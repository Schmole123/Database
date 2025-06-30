using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System.Data.OleDb;

namespace StatsForm
{
    public partial class SupplierData : UserControl
    {
        public HashSet<string> suppliers = new HashSet<string> { "All" };
        public HashSet<string> _components = new HashSet<string> ();
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
        public SupplierData()
        {
            InitializeComponent();
            Init();
            ChartInit();
        }

        private void Init()
        {
            if (selectedData == "Supplier")
            {
                lastItem = supplierBox.Text;
                supplierBox.Items.Clear();
                suppliers.Clear();
                suppliers.Add("All");
            }

            else if (selectedData == "Component")
            {
                lastItem = compBox.Text;
                compBox.Items.Clear();
                _components.Clear();
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
                    MinStep = 1
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
                    MinLimit = 0,
                }
            };

            cartesianChart1.LegendPosition = LegendPosition.Top;
            cartesianChart1.LegendTextSize = 15;
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
    }

}
