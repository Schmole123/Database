using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.Painting.Effects;
using SkiaSharp;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace Inventory_Database_FrontEnd
{
    public partial class frmStats : Form
    {
        public HashSet<string> suppliers = new HashSet<string> { "All" };
        public List<string> status = new List<string> { "New", "In Production", "QC", "Ready to Ship", "Completed" };
        public HashSet<string> customers = new HashSet<string>();
        public HashSet<string> _components = new HashSet<string>();
        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = \\SERVER-CORK\Shared\Staff Personal folders\Caolan\Database\Back_End\Inventory Managment_Data.accdb;";

        public List<DateTime> orderDates = new List<DateTime>();
        public List<DateTime> actualDates = new List<DateTime>();
        public List<TimeSpan> timeDiffs = new List<TimeSpan>();
        public List<double> leadTimes = new List<double>();

        public List<ISeries> seriesCollection = new List<ISeries>();

        public bool dataValid = false;
        public string lastItem;
        public string selectedData;

        OleDbConnection con;
        OleDbCommand cmd;

        public frmStats()
        {
            InitializeComponent();
            Init();
            ProdInit();
            ChartInit();
            Count();
        }


        private void Init()
        {
            if (selectedData == "Supplier")
            {
                lastItem = supplierBox.Text;
                supplierBox.Items.Clear();
                suppliers.Clear();
            }

            con = new OleDbConnection(connectionString);

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

            cartesianChart1.LegendPosition = LegendPosition.Top;
            cartesianChart1.LegendTextSize = 15;
        }

        private void UpdateAvg(string dataset, double avg)
        {
            switch (selectedData)
            {
                case "Supplier":
                    suppLeadNum.Text = $"{avg.ToString()} Days";
                    suppDelivNum.Text = orderDates.Count.ToString();

                    con = new OleDbConnection(connectionString);
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
            if (supplierBox.Text != "All")
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

            else
            {
                List<double> leadTimes = new List<double>();
                foreach (var v in times)
                {
                    leadTimes.Add(v.TotalDays);
                }

                seriesCollection.Add(new LineSeries<double>
                {
                    Name = dataset,
                    Values = leadTimes,
                    Fill = null
                });

                cartesianChart1.Series = seriesCollection;
            }

        }

        private void RetrieveData(string dataset)
        {
            con = new OleDbConnection(connectionString);
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

        private void supplierBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedData = "Supplier";
            compBox.Text = "";

            if (supplierBox.Text == "All")
            {
                seriesCollection.Clear();

                foreach (var v in suppliers)
                {
                    if (v != "All")
                    {
                        AvgCalc(v);
                    }
                }

                suppDelivNum.Visible = false;
                suppLeadNum.Visible = false;
                compDelivNum.Visible = false;
                compLeadNum.Visible = false;
            }

            else
            {
                seriesCollection.Clear();
                try
                {
                    AvgCalc(supplierBox.Text);
                    suppLeadNum.Visible = true;
                    suppDelivNum.Visible = true;
                    compDelivNum.Visible = false;
                    compLeadNum.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedData == "Supplier")
            {

                try
                {
                    Init();

                    if (supplierBox.Text == "All")
                    {
                        seriesCollection.Clear();

                        foreach (var v in suppliers)
                        {
                            if (v != "All")
                            {
                                AvgCalc(v);
                            }
                        }

                        suppDelivNum.Visible = false;
                        suppLeadNum.Visible = false;
                    }

                    else if (supplierBox.Text != "")
                    {
                        seriesCollection.Clear();
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (selectedData == "Component")
            {
                try
                {
                    Init();

                    if (compBox.Text == "All")
                    {
                        seriesCollection.Clear();

                        foreach (var v in _components)
                        {
                            if (v != "All")
                            {
                                AvgCalc(v);
                            }
                        }

                        compDelivNum.Visible = false;
                        compLeadNum.Visible = false;
                    }

                    else if (compBox.Text != "")
                    {
                        seriesCollection.Clear();
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                MessageBox.Show("No supplier/component selected");
            }
        }

        private void compBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedData = "Component";
            supplierBox.Text = "";

            if (compBox.Text == "All")
            {
                seriesCollection.Clear();

                foreach (var v in _components)
                {
                    if (v != "All")
                    {
                        AvgCalc(v);
                    }
                }

                compDelivNum.Visible = false;
                compLeadNum.Visible = false;
                suppDelivNum.Visible = false;
                suppLeadNum.Visible = false;
            }

            else
            {
                seriesCollection.Clear();
                try
                {
                    AvgCalc(compBox.Text);
                    compLeadNum.Visible = true;
                    compDelivNum.Visible = true;
                    suppDelivNum.Visible = false;
                    suppLeadNum.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////// Production Statistics ////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////

        private void ProdInit()
        {

            con = new OleDbConnection(connectionString);

            cmd = new OleDbCommand("SELECT [Customer] FROM [ProductionOrders]");

            cmd.Connection = con;
            con.Open();

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader[0].ToString() != "")
                {
                    customers.Add(reader[0].ToString());
                }
            }

            foreach (var v in customers)
            {
                customerBox.Items.Add(v);
            }

            reader.Close();
            con.Close();
        }

        private void Count()
        {
            foreach (var stat in status)
            {
                con = new OleDbConnection(connectionString);

                cmd = new OleDbCommand("SELECT COUNT([Status]) FROM [ProductionOrders] WHERE [Status] = '" + stat + "' ");

                cmd.Connection = con;
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    switch (stat)
                    {
                        case "New":
                            newNum.Text = reader[0].ToString();
                            break;
                        case "In Production":
                            prodNum.Text = reader[0].ToString();
                            break;
                        case "QC":
                            qcNum.Text = reader[0].ToString();
                            break;
                        case "Ready to Ship":
                            shipNum.Text = reader[0].ToString();
                            break;
                        case "Completed":
                            compNum.Text = reader[0].ToString();
                            break;
                    }
                }

                reader.Close();
                con.Close();
                
            }
        }

        private void customerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderBox.Items != null)
            {
                orderBox.Items.Clear();
                orderBox.Text = "";
            }

            customerDetailTxt.Text = customerBox.Text;
            customerDetailTxt.Visible = true;
            customerNum.Visible = true;

            con = new OleDbConnection(connectionString);

            cmd = new OleDbCommand("SELECT [OrderCode] FROM [ProductionOrders] WHERE [Customer] = '" + customerBox.Text + "' ");

            cmd.Connection = con;
            con.Open();

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                orderBox.Items.Add(reader[0].ToString());
            }

            reader.Close();
            con.Close();

            cmd = new OleDbCommand("SELECT COUNT([Customer]) FROM [ProductionOrders] WHERE [Customer] = '" + customerBox.Text + "'");
            cmd.Connection = con;
            con.Open();

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                customerNum.Text = reader[0].ToString();
            }

            reader.Close();
            con.Close();
        }

        private void orderBox_SelectedValueChanged(object sender, EventArgs e)
        {
            con = new OleDbConnection(connectionString);

            cmd = new OleDbCommand("SELECT [StartDate],[EstimatedEndDate],[Status],[Product] FROM [ProductionOrders] WHERE [OrderCode] = '" + orderBox.Text + "' ");

            cmd.Connection = con;
            con.Open();

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                startDate.Value = DateTime.Parse(reader[0].ToString());
                endDate.Value = DateTime.Parse(reader[1].ToString());
                statusTxt.Text = reader[2].ToString();
                productTxt.Text = reader[3].ToString();
            }

            reader.Close();
            con.Close();
            productTxt.Visible = true;
            statusTxt.Visible = true;
        }
    }
}

