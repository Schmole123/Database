using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.Painting.Effects;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatsForm
{
    public partial class SupplierData : UserControl
    {
        public HashSet<string> suppliers = new HashSet<string>();
        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = \\SERVER-CORK\Shared\Staff Personal folders\Caolan\Database\Back_End\Inventory Managment_Data.accdb;";

        public List<DateTime> orderDates = new List<DateTime>();
        public List<DateTime> actualDates = new List<DateTime>();
        public List<TimeSpan> timeDiffs = new List<TimeSpan>();
        public List<double> leadTimes = new List<double>();



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

            con = new OleDbConnection(connectionString);

            cmd = new OleDbCommand("SELECT [Supplier] FROM [Supplier Data]");

            cmd.Connection = con;
            con.Open();

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader[0].ToString() != "")
                {
                    suppliers.Add(reader[0].ToString());
                }
            }

            foreach (var v in suppliers)
            {
                supplierBox.Items.Add(v);
            }

            reader.Close();
            con.Close();
        }

        private void AvgCalc(string supplier)
        {
            RetrieveData(supplier);

            int i = 0;

            foreach (var v in orderDates)
            {
                timeDiffs.Add(actualDates[i].Subtract(v));
                i++;
            }

            var average = new TimeSpan(Convert.ToInt64(timeDiffs.Average(x => x.Ticks)));
            var realAvg = Double.Round(average.TotalDays);

            UpdateAvg(supplier, realAvg);
            UpdateChart(timeDiffs, supplier);

            orderDates.Clear();
            actualDates.Clear();
            timeDiffs.Clear();
        }

        private void RetrieveData(string supplier)
        {
            con = new OleDbConnection(connectionString);
            cmd = new OleDbCommand("SELECT [Order Date],[Actual Delivery] FROM [Supplier Data] WHERE [Supplier] = '" + supplier + "'");

            cmd.Connection = con;
            con.Open();

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader[0].ToString() != "" && reader[1].ToString() != "")
                {
                    orderDates.Add(DateTime.Parse(reader[0].ToString()));
                    actualDates.Add(DateTime.Parse(reader[1].ToString()));
                }
            }

            reader.Close();
            con.Close();
        }

        private void UpdateAvg(string supplier, double avg)
        {
            leadNum.Text = $"{avg.ToString()} Days";
            deliverNum.Text = orderDates.Count.ToString();

            con = new OleDbConnection(connectionString);
            cmd = new OleDbCommand("UPDATE [Supplier Data] SET [Average Lead Time] = " + avg + " WHERE [Supplier] = '" + supplier + "'");
            cmd.Connection = con;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void UpdateChart(List<TimeSpan> times, string supplier)
        {
            leadTimes.Clear();
            foreach (var v in times)
            {
                leadTimes.Add(v.TotalDays);
            }

            var existingSeries = cartesianChart1.Series.FirstOrDefault(s => s.Name == supplier);

            if (existingSeries == null)
            {
                cartesianChart1.Series = new ISeries[]
                {
                    new LineSeries<double>
                    {
                        Name = supplier,
                        Values = leadTimes,
                    }
                };
            }

            else if (existingSeries != null)
            {
                var series = cartesianChart1.Series.FirstOrDefault(s => s.Name == supplier);

                series.Values = leadTimes;

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

        private void supplierBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                AvgCalc(supplierBox.Text);
                leadNum.Visible = true;
                deliverNum.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AvgCalc(supplierBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
