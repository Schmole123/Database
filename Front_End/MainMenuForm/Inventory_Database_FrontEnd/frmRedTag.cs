using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.Painting.Effects;
using LiveChartsCore.SkiaSharpView.WinForms;
using QRCoder;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inventory_Database_FrontEnd
{
    public partial class frmRedTag : Form
    {

        static string _connectionString;
        string _defaultPrinter;


        public bool numExists = false;
        public bool repaired = false;

        public List<string> months = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        public ObservableCollection<int> tagCount = new ObservableCollection<int>();
        public HashSet<int> years = new HashSet<int>();
        public List<int> sortedYears = new List<int>();

        public ObservableCollection<ISeries> seriesCollection = new ObservableCollection<ISeries>();

        OleDbConnection Con;

        OleDbDataAdapter DA;

        OleDbCommand CMD;

        DataSet DS;

        public frmRedTag(string connectionString, string Printer)
        {
            InitializeComponent();
            _connectionString = connectionString;
            _defaultPrinter = Printer;
            ChartInit();
            yearInit();

        }



        private async void UpdateTable(string serialNum, string failText, string addInfo, string unit, string failCol)
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

                    var serialToPrint = serialNum;
                    if (serialToPrint != "")
                    {
                        string zpl = $"^XA^FO290,50 ^A@ 20,20,E:ArialBD.TTL ^FD Red Tag ^FS^BY5,2,20^FO400,0^BQN,2,3,M,7^FDQA,#{serialToPrint}^FS^XZ";
                        PrinterHelper.SendStringToPrinter(_defaultPrinter, zpl);
                        DateTime date = dateSelect.Value;
                        zpl = $"^XA^FO290,50 ^A@ 30,30,E:ArialBD.TTL ^FD {date.Day}/{date.Month}/{date.Year} ^FS^XZ";
                        await Task.Delay(1000); //wait for the first label to print before sending the second one
                        PrinterHelper.SendStringToPrinter(_defaultPrinter, zpl);
                    }


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
                        //SQL command generation to UPDATE RedTagTracking table(All columns of the table relevant to PCB/SLD units) with VALUES(All data for each column relevant to PCB/SLD units)
                        //[] brackets important for columns - values entered must be structured in the same order as columns are entered 
                        CMD = new OleDbCommand("UPDATE RedTagTracking " +
                                "SET [Name of Reportee] = '" + reporteeName.Text + "', [Date of Report] = '" + dateSelect.Value.ToShortDateString() + "', [" + failCol + "] = '" + failText + "', [Additional Information] = '" + addInfo + "', [Repaired] = " + repaired + " " +
                                "WHERE [" + unit + "] = '" + serialNum + "' ");

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
                if (pcbPanel.Visible == true) //pcb unit selected
                {

                    if (PCBnum.Text != "" && reporteeName.Text != "" && pcbfail.Text != "") //requires minimum of serial number, reportee name and reason for failure to submit - "" is blank
                    {
                        UpdateTable(PCBnum.Text, pcbfail.Text, pcbAInfo.Text, "PCB Serial Number", "Reason for PCB Fail"); //table update function call for pcb, passing data from form

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
        private void ChartInit()
        {
            cartesianChart1.XAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Months",
                    NamePaint = new SolidColorPaint(SKColors.Black),
                    Labels = months,
                    LabelsPaint = new SolidColorPaint(SKColors.Black),
                    TextSize = 20,
                    ForceStepToMin = true,
                    MinStep = 1,
                    TicksAtCenter = true,
                    SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray){StrokeThickness = 2}
                }
            };

            cartesianChart1.YAxes = new Axis[]
            {
                new Axis
                {
                    Name = "No. of Tags",
                    NamePaint = new SolidColorPaint(SKColors.Black),

                    LabelsPaint = new SolidColorPaint(SKColors.Black),
                    TextSize = 20,
                    MinLimit = 0,
                    MinStep = 1,
                    TicksAtCenter = true,
                    SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray)
                    {
                        StrokeThickness = 2,
                        PathEffect = new DashEffect(new float[]{3,3 })
                    }

                }
            };
        }

        private void UpdateChart()
        {
            var existingSeries = cartesianChart1.Series.FirstOrDefault(s => s.Name == yearBox.Text);

            if (existingSeries == null)
            {
                seriesCollection.Clear();
                seriesCollection.Add(new ColumnSeries<int>
                {
                    Name = yearBox.Text,
                    Values = tagCount,
                    Fill = new SolidColorPaint(SKColors.Red)

                });
            }

            else if (existingSeries != null)
            {
                var series = cartesianChart1.Series.FirstOrDefault(s => s.Name == yearBox.Text);
                series.Values = tagCount;
            }

            cartesianChart1.Series = seriesCollection;
        }

        private void yearInit()
        {
            Con = new OleDbConnection(_connectionString);

            CMD = new OleDbCommand("SELECT [Date of Report] FROM [RedTagTracking]");

            CMD.Connection = Con;
            Con.Open();

            OleDbDataReader reader = CMD.ExecuteReader();

            while (reader.Read())
            {
                if (reader[0].ToString() != "")
                {
                    years.Add(DateTime.Parse(reader[0].ToString()).Year);
                }
            }

            reader.Close();
            Con.Close();

            foreach (var year in years)
            {
                sortedYears.Add(year);
            }
            sortedYears.Sort(); //sort the years in ascending order

            foreach (var year in sortedYears)
            {
                yearBox.Items.Add(year);
            }

            sortedYears.Clear(); //clear the sorted years list for next use

        }
        private void yearBox_SelectedValueChanged(object sender, EventArgs e)
        {
            tagCount.Clear();

            for (int month = 1; month <= 12; month++)
            {
                var year = yearBox.Text;

                string monthYear = string.Empty;

                if (month >= 10)
                {
                    monthYear = $"%{month}/{year}";
                }
                else
                {
                    monthYear = $"%0{month}/{year}";
                }

                Con = new OleDbConnection(_connectionString);

                CMD = new OleDbCommand("SELECT COUNT([Date of Report]) FROM [RedTagTracking] WHERE [Date of Report] LIKE '" + monthYear + "'");

                CMD.Connection = Con;
                Con.Open();

                OleDbDataReader reader = CMD.ExecuteReader();

                while (reader.Read())
                {
                    tagCount.Add(int.Parse(reader[0].ToString()));
                }

                reader.Close();
                Con.Close();
            }

            UpdateChart();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            string lastYear = yearBox.Text;
            yearBox.Items.Clear();
            yearInit();
            yearBox.Text = lastYear;
        }

        private async void printBtn_Click(object sender, EventArgs e)
        {
            if(PCBnum.Text == "" && sldNum.Text == "") //check if both serial number textboxes are empty
            {
                MessageBox.Show("Please enter a Serial Number to print labels for");
                return;
            }

            DialogResult printConfirm = DialogResult.No; //initialize dialog result
            string serialToPrint = null; //initialize serial number to print
            if (pcbPanel.Visible == true)
            {
                serialToPrint = PCBnum.Text; //set serial number to print from PCB number textbox
                printConfirm = MessageBox.Show($"Do you wish to print new labels for #{serialToPrint}?", "Print Confirmation", MessageBoxButtons.YesNo);
            }

            else
            {
                serialToPrint = sldNum.Text; //set serial number to print from SLD number textbox
                printConfirm = MessageBox.Show($"Do you wish to print new labels for #{serialToPrint}?", "Print Confirmation", MessageBoxButtons.YesNo);
            }

            if (printConfirm == DialogResult.Yes)
            {
                string zpl = $"^XA^FO290,50 ^A@ 20,20,E:ArialBD.TTL ^FD Red Tag ^FS^BY5,2,20^FO400,0^BQN,2,3,M,7^FDQA,#{serialToPrint}^FS^XZ";
                PrinterHelper.SendStringToPrinter(_defaultPrinter, zpl);
                DateTime date = dateSelect.Value;
                zpl = $"^XA^FO290,50 ^A@ 30,30,E:ArialBD.TTL ^FD {date.Day}/{date.Month}/{date.Year} ^FS^XZ";
                await Task.Delay(1000); //wait for the first label to print before sending the second one
                PrinterHelper.SendStringToPrinter(_defaultPrinter, zpl);
            }

            else if (printConfirm == DialogResult.No)
            {
                MessageBox.Show("Print cancelled");
            }
            else
            {
                MessageBox.Show("Error printing label");
            }
        }
    }
}

    

