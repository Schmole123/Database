using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Database_FrontEnd
{
    public partial class frmPCBTest : Form
    {
        public List<string> PCBTestList = new List<string> { "mCS", "cBLMD Horseshoe", "cBLMD Driver", "cBLMD Optical", "BLL", "BLL Eval", "Pilot 4 AC", "Pilot 4 DC", "LensX" };

        static string _connectionString;
        public bool numExists = false;
        public bool passed = false;

        OleDbConnection Con;
        OleDbCommand CMD;

        public frmPCBTest(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
        }

        private async void UpdateTable(string PCB, string reportee, string testDate, string serialNum, string gen)
        {

            try
            {
                if (passCheck.Checked == true) //set test pass tag state
                {
                    passed = true;
                }

                else
                {
                    passed = false;
                }

                //assign database path to connection variable
                Con = new OleDbConnection(_connectionString);


                //SQL command generation to SELECT "Serial Number" FROM "PCB Test Record" table WHERE "Serial Number" = "Serial Number"
                //[] brackets not always required for column names but better to include them to prevent clashing with Access definitions 
                CMD = new OleDbCommand("SELECT [Serial Number] FROM [PCB Test Record] WHERE [Serial Number] = '" + serialNum + "' ");

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
                    //SQL command generation to INSERT INTO PCB Test Record table(All columns of the table relevant to the unit) with VALUES(All data for each column relevant to the unit)
                    //[] brackets important for column names - values entered must be structured in the same order as columns are entered 
                    CMD = new OleDbCommand("INSERT INTO [PCB Test Record]([PCB],[Serial Number],[Date of Test],[Unit Pass],[Gen],[Reportee])" +
                        "VALUES('" + PCB + "','" + serialNum + "','" + testDate + "'," + passed + ",'" + gen + "','" + reportee + "')");

                    CMD.Connection = Con;
                    Con.Open();

                    CMD.ExecuteNonQuery(); //Executes SQL command to insert new data

                    Con.Close();
                    MessageBox.Show("Data submission successful");
                }

                else if (numExists == true) //updates existing row of data if the serial number already exists
                {
                    DialogResult overwrite = MessageBox.Show("Do you wish to overwrite existing data?", "Serial Number already exists", MessageBoxButtons.YesNo); //prompt user to confirm overwriting data
                    if (overwrite == DialogResult.No) //if user selects no, exit function
                    {
                        MessageBox.Show("Submission cancelled");
                        return;
                    }
                    else if (overwrite == DialogResult.Yes) //if user selects yes, continue with function
                    {
                        //SQL command generation to UPDATE PCB Test Record table(All columns of the table relevant to the unit) with VALUES(All data for each column relevant to the unit)
                        //[] brackets important for columns - values entered must be structured in the same order as columns are entered 
                        CMD = new OleDbCommand("UPDATE [PCB Test Record] " +
                                "SET [PCB] = '" + PCB + "', [Date of Test] = '" + testDate + "', [Unit Pass] = " + passed + ", [Gen] = '" + gen + "',[Reportee] = '" + reportee + "'" +
                                "WHERE [Serial Number] = '" + serialNum + "' ");

                        CMD.Connection = Con;
                        Con.Open();

                        CMD.ExecuteNonQuery();

                        Con.Close();
                        MessageBox.Show("Data submission successful");
                    }

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

        private void recieveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(serialTxt.Text)) //requires a serial number to execute function
                {
                    MessageBox.Show("Please enter a Serial Number"); //display if no serial number is entered
                    return;
                }

                Con = new OleDbConnection(_connectionString); //assign database path to connection variable

                //SQL command generation to SELECT all columns FROM "PCB Test Record" table WHERE "Serial Number" = "Serial Number"
                //[] brackets not always required for column names but better to include them to prevent clashing with Access definitions 
                CMD = new OleDbCommand("SELECT * FROM [PCB Test Record] WHERE [Serial Number] = '" + serialTxt.Text + "'");

                CMD.Connection = Con;
                Con.Open(); //open connection


                //Reads data from table based on previous SQL command - searching to find serial number in the relevant column 
                OleDbDataReader reader = CMD.ExecuteReader();


                while (reader.Read()) //will skip past if no valid serial number
                {
                    //if serial number exists- extracts values from indexed locations and assigns to relevant area in panel

                    //column indexes
                    //index 0 = ID
                    //index 1 = pcb type
                    //index 2 = serial number 
                    //etc

                    numExists = true;                                       //set flag that the serial number exists
                    pcbSelect.SelectedItem = reader[1].ToString(); //set PCB selection dropdown to the PCB type of the serial number
                    serialTxt.Text = reader[2].ToString();                //set PCB serial number text box to the serial number of the PCB
                    testDateSelect.Value = DateTime.Parse(reader[3].ToString()); //set test date to the date of the test
                    passCheck.Checked = Convert.ToBoolean(reader[4]); //set pass checkbox to the pass state of the PCB

                    string[] genSplit = reader[5].ToString().Split(' '); //split the gen string into an array to separate gen, number and date    

                    genBox.SelectedItem = genSplit[0]; //set generation dropdown to the gen of the PCB
                    genNumBox.Text = genSplit[1]; //set generation number text box to the gen number of the PCB
                    genDateSelect.Value = DateTime.ParseExact(genSplit[2], "MM/yyyy", null); //set gen date to the date of the generation
                    reporteeName.Text = reader[6].ToString(); //set reportee name text box to the name of the person who reported the PCB

                }

                if (numExists == false) //if the entered serial number is not found, prompt the enter of a valid number and clear all data fields
                {
                    MessageBox.Show($"No data for Serial Number: {serialTxt.Text}");
                    pcbSelect.SelectedItem = null;
                    reporteeName.Clear();
                    serialTxt.Clear();
                    passCheck.Checked = false;
                    genBox.SelectedItem = null;
                    genNumBox.Clear();
                    genDateSelect.Value = DateTime.Now; //reset generation date to current date
                }


                reader.Close(); //close reader
                Con.Close();    //close connection
                numExists = false;  //reset flag
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(pcbSelect.SelectedItem?.ToString()) || string.IsNullOrEmpty(serialTxt.Text) || string.IsNullOrEmpty(reporteeName.Text)
                   || string.IsNullOrEmpty(genBox.SelectedItem?.ToString()) || string.IsNullOrEmpty(genNumBox.Text))
                {
                    MessageBox.Show("Please fill in all fields before submitting.");
                    return;
                }

                else
                {
                    string PCB = pcbSelect.SelectedItem.ToString();
                    string serialNum = serialTxt.Text.Trim();
                    string reportee = reporteeName.Text.Trim();
                    string testDate = testDateSelect.Value.ToString("dd/MM/yyyy");
                    string gen = genBox.SelectedItem.ToString();
                    string genNum = genNumBox.Text.Trim();
                    string genDate = genDateSelect.Value.ToString("MM/yyyy");
                    string genConcat = gen + " " + genNum + " " + genDate;

                    UpdateTable(PCB, reportee, testDate, serialNum, genConcat);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
        }

        private void frmPCBTest_Load(object sender, EventArgs e)
        {
            foreach (string pcb in PCBTestList) //populate PCB selection dropdown with PCBTestList items
            {
                pcbSelect.Items.Add(pcb);
            }

            LoadStock();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadStock();
        }

        private void LoadStock()
        {
            string unit = string.Empty;
            foreach (var pcb in PCBTestList)
            {
                switch (pcb)
                {
                    case "mCS":
                        unit = "SLD-mCS PCB";
                        break;
                    case "cBLMD Horseshoe":
                        unit = "cBLMD Horseshoe PCB";
                        break;
                    case "cBLMD Driver":
                        unit = "cBLMD Driver PCB";
                        break;
                    case "cBLMD Optical":
                        unit = "cBLMD Optical PCB";
                        break;
                    case "BLL":
                        unit = "BLL Driver Board";
                        break;
                    case "BLL Eval":
                        unit = "BLL Eval Unit PCB";
                        break;
                    case "Pilot 4 AC":
                        unit = "Pilot 4 AC PCB";
                        break;
                    case "Pilot 4 DC":
                        unit = "Pilot 4 DC PCB";
                        break;
                    case "LensX":
                        unit = "LensX PCB";
                        break;
                }

                string query = $"SELECT [StockAmount] FROM [Components] WHERE [ComponentName] = '{unit}'";
                using (var conn = new OleDbConnection(_connectionString))
                using (var cmd = new OleDbCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            switch (pcb)
                            {
                                case "mCS":
                                    mcsTotalNum.Text = reader["StockAmount"].ToString();
                                    mcsTotalNum.Visible = true;
                                    break;
                                case "cBLMD Horseshoe":
                                    mainTotalNum.Text = reader["StockAmount"].ToString();
                                    mainTotalNum.Visible = true;
                                    break;
                                case "cBLMD Driver":
                                    driverTotalNum.Text = reader["StockAmount"].ToString();
                                    driverTotalNum.Visible = true;
                                    break;
                                case "cBLMD Optical":
                                    opticalTotalNum.Text = reader["StockAmount"].ToString();
                                    opticalTotalNum.Visible = true;
                                    break;
                                case "BLL":
                                    bllTotalNum.Text = reader["StockAmount"].ToString();
                                    bllTotalNum.Visible = true;
                                    break;
                                case "BLL Eval":
                                    evalTotalNum.Text = reader["StockAmount"].ToString();
                                    evalTotalNum.Visible = true;
                                    break;
                                case "Pilot 4 AC":
                                    pilotACTotalNum.Text = reader["StockAmount"].ToString();
                                    pilotACTotalNum.Visible = true;
                                    break;
                                case "Pilot 4 DC":
                                    pilotDCTotalNum.Text = reader["StockAmount"].ToString();
                                    pilotDCTotalNum.Visible = true;
                                    break;
                                case "LensX":
                                    lensTotalNum.Text = reader["StockAmount"].ToString();
                                    lensTotalNum.Visible = true;
                                    break;
                            }
                        }
                    }
                }
            }
        }
    }
}
