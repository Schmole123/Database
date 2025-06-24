using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Runtime.InteropServices.JavaScript.JSType;
using QRCoder;
using System.Drawing.Printing;
using System.Reflection;
using static System.Resources.ResXFileRef;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

namespace Inventory_Database_FrontEnd
{
    public partial class frmRedTag : Form
    {

        static string _connectionString;
         static string _defaultPrinter;


        public bool numExists = false;
        public bool repaired = false;

        OleDbConnection Con;

        OleDbDataAdapter DA;

        OleDbCommand CMD;

        DataSet DS;

        public frmRedTag(string connectionString, string Printer)
        {
            InitializeComponent();
            _connectionString = connectionString;
            _defaultPrinter = Printer;
            

        }



        private bool UpdateTable(string serialNum, string failText, string addInfo, string unit, string failCol)
        {
            try
            {
                if (repairCheck.Checked == true) //set repaired tag state
                {
                    repaired = true;
                }

                else
                {
                    repaired = false;
                }

                //assign database path to connection variable
                Con = new OleDbConnection(_connectionString);


                //SQL command generation to SELECT "PCB/SLD Serial Number" FROM "RedTagTracking" table WHERE "PCB/SLD Serial Number" = "Serial Number"
                //[] brackets not always required for column names but better to include them to prevent clashing with Access definitions 
                CMD = new OleDbCommand("SELECT [" + unit + "] FROM RedTagTracking WHERE [" + unit + "] = '" + serialNum + "' ");

                CMD.Connection = Con; //assigning connection path
                Con.Open(); //opening connection

                //Reads data from table based on previous SQL command - searching to find serial number in the relevant column
                OleDbDataReader reader = CMD.ExecuteReader();

                while (reader.Read()) //will skip over if no serial number is found
                {
                    if (reader[0].ToString() == serialNum) //in this instance the serial number is always at index 0
                    {
                        numExists = true; //marks the serial number is existing if found
                    }
                }

                reader.Close(); //close reader
                Con.Close();    //close connection

                if (numExists == false) //inserts new row of data if the serial number does not already exist
                {
                    //SQL command generation to INSERT INTO RedTagTracking table(All columns of the table relevant to PCB/SLD units) with VALUES(All data for each column relevant to PCB/SLD units)
                    //[] brackets important for column names - values entered must be structured in the same order as columns are entered 
                    CMD = new OleDbCommand("INSERT INTO RedTagTracking([" + unit + "],[Name of Reportee],[Date of Report],[" + failCol + "],[Additional Information], [Repaired])" +
                        "VALUES('" + serialNum + "','" + reporteeName.Text + "','" + dateSelect.Value.ToShortDateString() + "','" + failText + "','" + addInfo + "', " + repaired + " );");

                    CMD.Connection = Con;
                    Con.Open();

                    CMD.ExecuteNonQuery(); //Executes SQL command to insert new data

                    Con.Close();
                    return true;
                }

                else if (numExists == true)
                {
                    DialogResult result = MessageBox.Show(
                        "This serial number already exists in the database.\n\nDo you want to overwrite the existing data?",
                        "Duplicate Serial Number",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question

                    );

                    if (result == DialogResult.Yes)
                    {
                        // User chose to update the existing row
                        string updateQuery = "UPDATE RedTagTracking " +
                            "SET [Name of Reportee] = ?, [Date of Report] = ?, [" + failCol + "] = ?, [Additional Information] = ?, [Repaired] = ? " +
                            "WHERE [" + unit + "] = ?";

                        CMD = new OleDbCommand(updateQuery, Con);

                        // Use parameters for safety
                        CMD.Parameters.AddWithValue("@reporteeName", reporteeName.Text);
                        CMD.Parameters.AddWithValue("@date", dateSelect.Value.ToShortDateString());
                        CMD.Parameters.AddWithValue("@failText", failText);
                        CMD.Parameters.AddWithValue("@addInfo", addInfo);
                        CMD.Parameters.AddWithValue("@repaired", repaired);
                        CMD.Parameters.AddWithValue("@serialNum", serialNum);

                        Con.Open();
                        CMD.ExecuteNonQuery();
                        Con.Close();


                        return true;
                    }
                    else // No or Cancel
                    {
                        MessageBox.Show("Operation cancelled. No changes were made.");
                        return false;
                    }
                }
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }


        private void frmRedTag_Load(object sender, EventArgs e)
        {
            pcbPanel.Location = new Point(235, 12);
            sldPanel.Location = new Point(235, 12);
            this.Size = new Size(780, 365);
            unitSelect.SelectedItem = "PCB";
        }

        private void unitSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            if (unitSelect.Text == "PCB")
            {
                pcbPanel.Visible = true;
                sldPanel.Visible = false;
            }

            if (unitSelect.Text == "SLD")
            {
                pcbPanel.Visible = false;
                sldPanel.Visible = true;
            }

            else if (unitSelect.Text != "PCB" && unitSelect.Text != "SLD")
            {
                pcbPanel.Visible = false;
                sldPanel.Visible = false;
                MessageBox.Show("Please select a unit type");
            }
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string serialToPrint = null;

                if (pcbPanel.Visible == true) // pcb unit selected
                {
                    if (PCBnum.Text != "" && reporteeName.Text != "" && pcbfail.Text != "")
                    {
                        bool updated = UpdateTable(PCBnum.Text, pcbfail.Text, pcbAInfo.Text, "PCB Serial Number", "Reason for PCB Fail");
                        if (!updated) return;  // stop here if update was cancelled
                        serialToPrint = PCBnum.Text;

                        ImageToZplConverter converter = new ImageToZplConverter();
                        Bitmap qrCodeImage = converter.GenerateQrCodeBitmap(serialToPrint);
                        string zpl = await converter.ConvertImageToZplAsync(qrCodeImage);

                        if (zpl != null)
                        {
                            zpl = System.Text.RegularExpressions.Regex.Replace(zpl, @"\^FO\d+,\d+", "^FO440,0");
                            string extraZpl = $@"^CFJ0,26\n^FO325,20^FDRedTag^FS\n^CFJ0,17\n^FO310,10^FD^FS\n";
                            zpl = zpl.StartsWith("^XA") ? "^XA\n" + extraZpl + zpl.Substring(3) : "^XA\n" + extraZpl + zpl;

                            PrinterHelper.SendStringToPrinter(_defaultPrinter, zpl);
                            MessageBox.Show("Data submission successful");
                            qrCodeImage.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Failed to generate ZPL");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all data fields");
                    }
                }
                else if (sldPanel.Visible == true) // sld unit selected
                {
                    if (sldNum.Text != "" && reporteeName.Text != "" && sldFailText.Text != "")
                    {
                        bool updated = UpdateTable(sldNum.Text, sldFailText.Text, sldAInfoText.Text, "SLD Serial Number", "Reason for SLD Fail");
                        if (!updated) return;  // stop here if update was cancelled
                        serialToPrint = sldNum.Text;
                        MessageBox.Show("Data submission successful");
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all data fields");
                    }
                }
                else
                {
                    MessageBox.Show("Please select unit type");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }





        private void recieveBtn_Click(object sender, EventArgs e)
        {
            if (pcbPanel.Visible == true) //pcb unit selected
            {
                try
                {

                    if (PCBnum.Text != "") //requires a serial number to execute function - "" is blank
                    {

                        Con = new OleDbConnection(_connectionString); //assign database path to connection variable

                        //SQL command generation to SELECT all columns FROM "RedTagTracking" table WHERE "PCB Serial Number" = "Serial Number"
                        //[] brackets not always required for column names but better to include them to prevent clashing with Access definitions 
                        CMD = new OleDbCommand("SELECT * FROM [RedTagTracking] WHERE [PCB Serial Number] = '" + PCBnum.Text + "'");

                        CMD.Connection = Con;
                        Con.Open(); //open connection


                        //Reads data from table based on previous SQL command - searching to find serial number in the relevant column 
                        OleDbDataReader reader = CMD.ExecuteReader();


                        while (reader.Read()) //will skip past if no valid serial number
                        {
                            //if serial number exists- extracts values from indexed locations and assigns to relevant area in panel

                            //column indexes
                            //index 0 = ID
                            //index 1 = pcb serial
                            //index 2 = sld serial 
                            //etc

                            numExists = true;                                       //set flag that the serial number exists
                            var date = DateTime.Parse(reader[4].ToString());        //convert date string to DateTime for DateTime picker in form
                            reporteeName.Text = reader[3].ToString();               //retrieve name of reportee
                            dateSelect.Value = date;                                //set date
                            pcbfail.Text = reader[6].ToString();                //retrieve PCB failure info
                            pcbAInfo.Text = reader[7].ToString();               //retrieve Additional Info
                            repairCheck.Checked = bool.Parse(reader[8].ToString()); //retrieve repaired check box state
                        }

                        if (numExists == false) //if the entered serial number is not found, prompt the enter of a valid number and clear all data fields
                        {
                            MessageBox.Show($"No data for Serial Number: {PCBnum.Text}");
                            pcbfail.Clear();
                            pcbAInfo.Clear();
                            reporteeName.Clear();
                            repairCheck.Checked = false;
                        }


                        reader.Close(); //close reader
                        Con.Close();    //close connection
                        numExists = false;  //reset flag
                    }

                    else
                    {
                        MessageBox.Show("Please enter a Serial Number"); //display if no serial number is entered
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            if (sldPanel.Visible == true) //same as previous pcb function just replaced with sld values and data fields
            {
                try
                {

                    if (sldNum.Text != "")
                    {
                        Con = new OleDbConnection(_connectionString);

                        CMD = new OleDbCommand("SELECT * FROM [RedTagTracking] WHERE [SLD Serial Number] = '" + sldNum.Text + "'");
                        CMD.Connection = Con;
                        Con.Open();

                        OleDbDataReader reader = CMD.ExecuteReader();

                        while (reader.Read())
                        {
                            //index 0 = ID
                            //index 1 = pcb serial
                            //index 2 = sld serial 
                            //etc


                            numExists = true;
                            var date = DateTime.Parse(reader[4].ToString());
                            reporteeName.Text = reader[3].ToString();
                            dateSelect.Value = date;
                            sldFailText.Text = reader[5].ToString();
                            sldAInfoText.Text = reader[7].ToString();
                            repairCheck.Checked = bool.Parse(reader[8].ToString());
                        }


                        if (numExists == false)
                        {
                            MessageBox.Show($"No data for Serial Number: {sldNum.Text}");
                            sldFailText.Clear();
                            sldAInfoText.Clear();
                            reporteeName.Clear();
                            repairCheck.Checked = false;
                        }

                        reader.Close();
                        Con.Close();
                        numExists = false;
                    }

                    else
                    {
                        MessageBox.Show("Please enter a valid Serial Number");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        
    }
  }
}
    

