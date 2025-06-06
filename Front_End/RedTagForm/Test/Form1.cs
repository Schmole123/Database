using System.Data;
using System.Data.OleDb;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Test
{
    public partial class Form1 : Form
    {
        //connection string required to connect to file on server - requires program to run in .net8 & 64 bit to work
        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = \\SERVER-CORK\Shared\Staff Personal folders\Caolan\Database\Back_End\Inventory Managment_Data.accdb;";

        public bool numExists = false;
        public bool repaired = false; 

        OleDbConnection Con;

        OleDbCommand CMD;

        public Form1()

        {
            InitializeComponent();

        }




        //Insert new row of data or update existing row of data by serial number 
        private void updateBtn_click(object sender, EventArgs e)
        {
            try
            {
                
                if (pcbPanel.Visible == true) //pcb unit selected
                {
                    if (pcbNum.Text != "" && reporteeName.Text != "" && pcbFailText.Text != "") //requires minimum of serial number, reportee name and reason for failure to submit - "" is blank
                    {
                        UpdateTable(pcbNum.Text, pcbFailText.Text, pcbAInfoText.Text, "PCB Serial Number", "Reason for PCB Fail"); //table update function call for pcb, passing data from form
                        MessageBox.Show("Data submission successful");
                    }

                    else
                    {
                        MessageBox.Show("Please fill in all data fields");
                    }
                }

                else if (sldPanel.Visible == true) //sld unit selected
                {
                    if (sldNum.Text != "" && reporteeName.Text != "" && sldFailText.Text != "") //requires minimum of serial number, reportee name and reason for failure to submit - "" is blank
                    {
                        UpdateTable(sldNum.Text, sldFailText.Text, sldAInfoText.Text, "SLD Serial Number", "Reason for SLD Fail"); //table update function call for sld, passing data from form
                        MessageBox.Show("Data submission successful");
                    }

                    else
                    {
                        MessageBox.Show("Please fill in all data fields");
                    }
                }

                else
                {
                    MessageBox.Show("Please select unit type"); // no unit selected from combobox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Changes visibility of pcb or sld panels based on combobox selection - defaults to pcb panel
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (unitSelect.Text == "PCB")
            {
                pcbPanel.Visible = true;
                sldPanel.Visible = false;
                repairCheck.Checked = false;
            }

            if (unitSelect.Text == "SLD")
            {
                pcbPanel.Visible = false;
                sldPanel.Visible = true;
                repairCheck.Checked = false;
            }

            else if (unitSelect.Text != "PCB" && unitSelect.Text != "SLD")
            {
                pcbPanel.Visible = false;
                sldPanel.Visible = false;
                repairCheck.Checked = false;
                MessageBox.Show("Please select a unit type");
            }
        }

        //Overlays pcb and sld panels and resizes form to set size on launch - default selection of pcb panel
        private void Form1_Load(object sender, EventArgs e)
        {
            pcbPanel.Location = new Point(227, 2);
            sldPanel.Location = new Point(227, 2); //overlaying pcb and sld panels to same coords
            this.Size = new Size(780, 365); //set form dimensions
            unitSelect.SelectedItem = "PCB"; //set combobox default value
        }

        //Table update function - pulls data from selected unit and either inserts new data row for new serial number, or updates existing row for exisiting serial numbers
        private void UpdateTable(string serialNum, string failText, string addInfo, string unit, string failCol)
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
                Con = new OleDbConnection(connectionString);


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
                }

                else if (numExists == true) //updates existing row of data if the serial number already exists
                {
                    //SQL command generation to UPDATE RedTagTracking table(All columns of the table relevant to PCB/SLD units) with VALUES(All data for each column relevant to PCB/SLD units)
                    //[] brackets important for columns - values entered must be structured in the same order as columns are entered 
                    CMD = new OleDbCommand("UPDATE RedTagTracking " +
                        "SET [Name of Reportee] = '" + reporteeName.Text + "', [Date of Report] = '" + dateSelect.Value.ToShortDateString() + "', [" + failCol + "] = '" + failText + "', [Additional Information] = '" + addInfo + "', [Repaired] = " + repaired + " " +
                        "WHERE [" + unit + "] = '" + serialNum + "' ");

                    CMD.Connection = Con;
                    Con.Open();

                    CMD.ExecuteNonQuery();

                    Con.Close();
                }

                else
                {
                    MessageBox.Show("Error writing data"); //misc error if somehow the above fails without an exception
                }

                Con.Close(); //ensure connection is closed
                numExists = false; //reset serial number check flag to default
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Retrieves data from the table by serial number - displays data in relevant sections 
        private void recieveBtn_Click(object sender, EventArgs e)
        {

            if (pcbPanel.Visible == true) //pcb unit selected
            {
                try
                {

                    if (pcbNum.Text != "") //requires a serial number to execute function - "" is blank
                    {
                        
                        Con = new OleDbConnection(connectionString); //assign database path to connection variable

                        //SQL command generation to SELECT all columns FROM "RedTagTracking" table WHERE "PCB Serial Number" = "Serial Number"
                        //[] brackets not always required for column names but better to include them to prevent clashing with Access definitions 
                        CMD = new OleDbCommand("SELECT * FROM [RedTagTracking] WHERE [PCB Serial Number] = '" + pcbNum.Text + "'");

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
                                    pcbFailText.Text = reader[6].ToString();                //retrieve PCB failure info
                                    pcbAInfoText.Text = reader[7].ToString();               //retrieve Additional Info
                                    repairCheck.Checked = bool.Parse(reader[8].ToString()); //retrieve repaired check box state
                            }

                        if (numExists == false) //if the entered serial number is not found, prompt the enter of a valid number and clear all data fields
                        {
                            MessageBox.Show($"No data for Serial Number: {pcbNum.Text}");
                            pcbFailText.Clear();
                            pcbAInfoText.Clear();
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

            if(sldPanel.Visible == true) //same as previous pcb function just replaced with sld values and data fields
            {
                try
                {

                    if (sldNum.Text != "")
                    {
                        Con = new OleDbConnection(connectionString);

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
