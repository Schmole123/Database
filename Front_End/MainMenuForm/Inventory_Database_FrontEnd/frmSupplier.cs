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
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using SkiaSharp;
using LiveChartsCore;

namespace Inventory_Database_FrontEnd
{
    public partial class frmSupplier : Form
    {
        public List<string> collection = new List<string>();
        static string _connectionString;

        public bool orderExists = false;
        public bool damaged = false;

        public HashSet<string> suppliers = new HashSet<string>();
        public HashSet<string> _components = new HashSet<string>();


        public List<DateTime> orderDates = new List<DateTime>();
        public List<DateTime> actualDates = new List<DateTime>();
        public List<TimeSpan> timeDiffs = new List<TimeSpan>();
        public List<double> leadTimes = new List<double>();

        public bool dataValid = false;
        public string lastItem;
        public string selectedData;



        OleDbConnection con;
        OleDbCommand cmd;
        public frmSupplier(string connectionString)
        {
            _connectionString = connectionString;
            InitializeComponent();
            Init();
            StatInit();
            ChartInit();


        }



        //selects all component names from the component table and enters them into the component selection combobox
        private void Init()
        {
            con = new OleDbConnection(_connectionString);

            cmd = new OleDbCommand("SELECT [ComponentName] FROM [Components]");

            cmd.Connection = con;
            con.Open();

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                componentBox.Items.Add(reader[0].ToString());
            }

            reader.Close();
            con.Close();


            foreach (var v in componentBox.Items)
            {
                collection.Add(v.ToString());
            }
        }

        private void StatInit()
        {
            if (selectedData == "Supplier")
            {
                lastItem = supplierBox.Text;
                supplierBox.Items.Clear();
                suppliers.Clear();
            }

            else if (selectedData == "Component")
            {
                lastItem = compBox.Text;
                compBox.Items.Clear();
                _components.Clear();
            }
            con = new OleDbConnection(_connectionString);

            cmd = new OleDbCommand("SELECT [Supplier],[Component] FROM [Supplier Data]");

            cmd.Connection = con;
            con.Open();

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader[0].ToString() != "" && reader[1].ToString() != "")
                {
                    suppliers.Add(reader[0].ToString());
                    _components.Add(reader[1].ToString());
                }
            }

            reader.Close();
            con.Close();

            foreach (var v in suppliers)
            {
                if (supplierBox.Items.Contains(v) != true)
                {
                    supplierBox.Items.Add(v);
                }
            }

            foreach (var v in _components)
            {
                if (compBox.Items.Contains(v) != true)
                {
                    compBox.Items.Add(v);
                }
            }

            if (selectedData == "Supplier")
            {
                supplierBox.SelectedItem = lastItem;
            }

            else if (selectedData == "Component")
            {
                compBox.SelectedItem = lastItem;
            }
        }


        private void ChartInit()
        {
            cartesianChart1.XAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Delivery No.",
                    NamePaint = new SolidColorPaint(SKColors.Black),
                    LabelsPaint = new SolidColorPaint(SKColors.Black),
                    TextSize = 20,
                    MinStep = 1,
                }
            };

            cartesianChart1.YAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Lead Time (Days)",
                    NamePaint = new SolidColorPaint(SKColors.Black),

                    LabelsPaint = new SolidColorPaint(SKColors.Black),
                    TextSize = 20,
                    MinLimit = 0
                }
            };
        }

        private void UpdateAvg(string dataset, double avg)
        {
            switch (selectedData)
            {
                case "Supplier":
                    suppLeadNum.Text = $"{avg.ToString()} Days";
                    suppDelivNum.Text = orderDates.Count.ToString();

                    con = new OleDbConnection(_connectionString);
                    cmd = new OleDbCommand("UPDATE [Supplier Data] SET [Average Lead Time] = " + avg + " WHERE [Supplier] = '" + dataset + "'");
                    cmd.Connection = con;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    break;
                case "Component":
                    compLeadNum.Text = $"{avg.ToString()} Days";
                    compDelivNum.Text = orderDates.Count.ToString();
                    break;
            }
        }

        private void UpdateChart(List<TimeSpan> times, string dataset)
        {
            leadTimes.Clear();
            foreach (var v in times)
            {
                leadTimes.Add(v.TotalDays);
            }

            var existingSeries = cartesianChart1.Series.FirstOrDefault(s => s.Name == dataset);

            if (existingSeries == null)
            {
                cartesianChart1.Series = new ISeries[]
                {
                    new LineSeries<double>
                    {
                        Name = dataset,
                        Values = leadTimes,
                    }
                };
            }

            else if (existingSeries != null)
            {
                var series = cartesianChart1.Series.FirstOrDefault(s => s.Name == dataset);

                series.Values = leadTimes;

            }

        }

        private void RetrieveData(string dataset)
        {
            con = new OleDbConnection(_connectionString);
            switch (selectedData)
            {
                case "Supplier":
                    cmd = new OleDbCommand("SELECT [Order Date],[Actual Delivery] FROM [Supplier Data] WHERE [Supplier] = '" + dataset + "'");
                    break;
                case "Component":
                    cmd = new OleDbCommand("SELECT [Order Date],[Actual Delivery] FROM [Supplier Data] WHERE [Component] = '" + dataset + "'");
                    break;
            }

            cmd.Connection = con;
            con.Open();

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader[0].ToString() != "" && reader[1].ToString() != "")
                {
                    dataValid = true;
                    orderDates.Add(DateTime.Parse(reader[0].ToString()));
                    actualDates.Add(DateTime.Parse(reader[1].ToString()));
                }
            }

            reader.Close();
            con.Close();

        }

        private void AvgCalc(string dataset)
        {
            dataValid = false;
            RetrieveData(dataset);

            if (dataValid == true)
            {
                int i = 0;

                foreach (var v in orderDates)
                {
                    timeDiffs.Add(actualDates[i].Subtract(v));
                    i++;
                }

                var average = new TimeSpan(Convert.ToInt64(timeDiffs.Average(x => x.Ticks)));
                var realAvg = Double.Round(average.TotalDays);

                UpdateAvg(dataset, realAvg);
                UpdateChart(timeDiffs, dataset);

                orderDates.Clear();
                actualDates.Clear();
                timeDiffs.Clear();
            }

            else
            {
                MessageBox.Show("Missing data to calculate lead time");
            }
        }

        private void componentBox_TextChanged(object sender, EventArgs e)
        {
            string textToSearch = componentBox.Text.ToLower();
            componentList.Visible = false;
            if (String.IsNullOrEmpty(textToSearch))
                return;

            string[] result = (from i in collection where i.ToLower().Contains(textToSearch) select i).ToArray();

            if (result.Length == 0)
                return;

            componentList.Items.Clear();
            componentList.Items.AddRange(result);
            componentList.Visible = true;

            if (componentBox.SelectedItem != null)
            {
                componentList.Visible = false;
            }
        }

        private void componentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            componentBox.SelectedItem = componentList.SelectedItem;
            componentList.Visible = false;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (supplierTxt.Text != "" && orderCodeTxt.Text != "" && componentBox.SelectedItem != null && quantityBox.Value > 0) //requires minimum of supplier name, order code, component name and quantity of component
                {
                    if (damageCheck.Checked == true) //checks the damage tag and sets a bool flag
                    {
                        damaged = true;
                    }
                    else
                    {
                        damaged = false;
                    }

                    con = new OleDbConnection(_connectionString);

                    //SQL command generation to SELECT "Order Code" FROM "Supplier Data" table WHERE "Order Code" row value = "Order Code" input value
                    //[] brackets not always required for column names but better to include them to prevent clashing with Access definitions
                    cmd = new OleDbCommand("SELECT [Order Code] FROM [Supplier Data] WHERE [Order Code] = '" + orderCodeTxt.Text + "'");

                    cmd.Connection = con;   //assign connection path
                    con.Open();             //open connection

                    //Reads data from table based on previous SQL command - searching to find the order code in the Order Code column
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read()) //will skip over if no order code is found
                    {
                        if (reader[0].ToString() == orderCodeTxt.Text)
                        {
                            orderExists = true;
                        }
                    }

                    reader.Close(); //close reader
                    con.Close();    //close connection

                    if (orderExists == false)   //if no order code already exists, insert new row of data to table
                    {
                        if (deliveredCheck.Checked == false) //if the product has not been delivered yet, fill in everything but actual delivery date
                        {
                            try
                            {
                                cmd = new OleDbCommand("INSERT INTO [Supplier Data]([Supplier], [Order Code], [Component], [Order Date], [Estimated Delivery], [Damaged],[Quantity])" +
                                    "VALUES('" + supplierTxt.Text + "', '" + orderCodeTxt.Text + "', '" + componentBox.Text + "', '" + orderDate.Value.ToShortDateString() + "', '" + estDate.Value.ToShortDateString() + "'," + damaged + ", '" + quantityBox.Value + "')");

                                cmd.Connection = con;
                                con.Open();             //open connection

                                cmd.ExecuteNonQuery();  //execute command

                                con.Close();            //close connection

                                MessageBox.Show("Data submission successful");  //display message if no exception occurs
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }

                        else if (deliveredCheck.Checked == true)    //if the product has not been delivered yet, fill in everything but estimated delivery date
                        {
                            try
                            {
                                cmd = new OleDbCommand("INSERT INTO [Supplier Data]([Supplier], [Order Code], [Component], [Order Date], [Actual Delivery], [Damaged],[Quantity])" +
                                    "VALUES('" + supplierTxt.Text + "', '" + orderCodeTxt.Text + "', '" + componentBox.Text + "', '" + orderDate.Value.ToShortDateString() + "','" + actualDate.Value.ToShortDateString() + "'," + damaged + ", '" + quantityBox.Value + "')");

                                cmd.Connection = con;
                                con.Open();

                                cmd.ExecuteNonQuery();

                                con.Close();

                                MessageBox.Show("Data submission successful");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }

                    else if (orderExists == true)   //updates existing row of data if the order code already exists
                    {
                        if (deliveredCheck.Checked == false)
                        {
                            try
                            {
                                //SQL command generation to UPDATE "Supplier Data" table(All columns of the table except actual date) with VALUES(Data for each column) relevant to order code
                                //[] brackets important for column names - values entered must be structured in the same order as columns are entered 
                                cmd = new OleDbCommand("UPDATE [Supplier Data] " +
                                    "SET [Supplier] = '" + supplierTxt.Text + "', [Component] = '" + componentBox.Text + "', [Order Date] = '" + orderDate.Value.ToShortDateString() + "', " +
                                    "[Estimated Delivery] = '" + estDate.Value.ToShortDateString() + "',[Damaged] = " + damaged + ", [Quantity] = '" + quantityBox.Value + "'" +
                                    "WHERE [Order Code] = '" + orderCodeTxt.Text + "'");


                                cmd.Connection = con;
                                con.Open();

                                cmd.ExecuteNonQuery();

                                con.Close();

                                MessageBox.Show("Data submission successful");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }

                        else if (deliveredCheck.Checked == true)
                        {
                            try
                            {
                                //SQL command generation to UPDATE "Supplier Data" table(All columns of the table except estimated date) with VALUES(Data for each column) relevant to order code
                                //[] brackets important for column names - values entered must be structured in the same order as columns are entered 
                                cmd = new OleDbCommand("UPDATE [Supplier Data] " +
                                     "SET [Supplier] = '" + supplierTxt.Text + "', [Component] = '" + componentBox.Text + "', [Order Date] = '" + orderDate.Value.ToShortDateString() + "', " +
                                     "[Actual Delivery] = '" + actualDate.Value.ToShortDateString() + "',[Damaged] = " + damaged + ", [Quantity] = '" + quantityBox.Value + "'" +
                                     "WHERE [Order Code] = '" + orderCodeTxt.Text + "'");

                                cmd.Connection = con;
                                con.Open();

                                cmd.ExecuteNonQuery();

                                con.Close();

                                MessageBox.Show("Data submission successful");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }

                    orderExists = false;
                }

                else
                {
                    MessageBox.Show("Please fill all data fields");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            this.Size = new Size(435, 450);                     //set main form size
            actualDateLabel.Location = estDateLabel.Location;   //set actual date label to estimated date label location
            actualDate.Location = estDate.Location;
        }

        private void deliveredCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (deliveredCheck.Checked == false)
            {
                estDate.Visible = true;
                estDateLabel.Visible = true;

                damageCheck.Visible = false;

                actualDate.Visible = false;
                actualDateLabel.Visible = false;
            }

            else if (deliveredCheck.Checked == true)
            {
                estDate.Visible = false;
                estDateLabel.Visible = false;

                damageCheck.Visible = true;

                actualDate.Visible = true;
                actualDateLabel.Visible = true;
            }
        }

        private void retrieveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (orderCodeTxt.Text != "") //requires an order code to execture function - "" is blank
                {
                    con = new OleDbConnection(_connectionString); //assign database path to connection varible

                    //SQL command generation to SELECT all columns FROM "ProductionOrders" table WHERE "OrderCode" = "Order code"
                    //[] brackets not always required for column names but better to include them to prevent clashing with Access definitions 
                    cmd = new OleDbCommand("SELECT * FROM [Supplier Data] WHERE [Order Code] = '" + orderCodeTxt.Text + "'");

                    cmd.Connection = con;
                    con.Open(); //open connection

                    //Reads data from table based on previous SQL command - searching to find order code in the relevant column
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read()) //will skip past if no valid serial number
                    {

                        //if order code exists- extracts values from indexed locations and assigns to relevant area in panel

                        //index 0 = order id,
                        //index 1 = order code
                        //etc

                        orderExists = true;                                         //set flag that the order code exists

                        var ordDate = DateTime.Parse(reader[4].ToString());         //convert order date string to DateTime for DateTime picker
                        if (reader[5].ToString() != "")
                        {
                            var estmDate = DateTime.Parse(reader[5].ToString());        //convert estimated shipping date string to DateTime for DateTime picker
                            estDate.Value = estmDate;                                   //set estimated date
                        }

                        if (reader[6].ToString() != "")
                        {
                            var actDate = DateTime.Parse(reader[6].ToString());     //convert actual arrival date string to DateTIme for DateTime picker
                            actualDate.Value = actDate;                             //set actual date
                        }

                        supplierTxt.Text = reader[1].ToString();                    //retrieve supplier name
                        componentBox.SelectedItem = reader[3].ToString();           //set selected component from component list
                        orderDate.Value = ordDate;                                  //set order date

                        quantityBox.Value = Decimal.Parse(reader[9].ToString());    //retrieve quantity of ordered components
                        damageCheck.Checked = bool.Parse(reader[8].ToString());     //retrieve damage status
                    }

                    if (orderExists == false) //if the entered order code is not found, prompt the enter of a valid code and clear all data fields
                    {
                        MessageBox.Show($"No data for Order Code: {orderCodeTxt.Text}");
                        supplierTxt.Clear();
                        orderCodeTxt.Clear();
                        componentBox.SelectedItem = null;
                        quantityBox.Value = 0;
                        orderDate.Value = DateTime.Now;
                        estDate.Value = DateTime.Now;
                        actualDate.Value = DateTime.Now;
                        deliveredCheck.Checked = false;
                        damageCheck.Checked = false;
                    }

                    reader.Close();         //close reader
                    con.Close();            //close connection
                    orderExists = false;    //reset order flag
                }

                else
                {
                    MessageBox.Show("Please enter a valid Order Code"); //display if no order code is entered
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void supplierBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedData = "Supplier";

            try
            {
                AvgCalc(supplierBox.Text);
                suppLeadNum.Visible = true;
                suppDelivNum.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void compBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedData = "Component";

            try
            {
                AvgCalc(compBox.Text);
                compLeadNum.Visible = true;
                compDelivNum.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}













