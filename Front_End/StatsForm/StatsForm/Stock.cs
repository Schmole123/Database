using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatsForm
{
    public partial class Stock : UserControl
    {

        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = \\SERVER-CORK\Shared\Staff Personal folders\Caolan\Database\Back_End\Inventory Managment_Data.accdb;";
        public List<string> products = new List<string>();
        public Dictionary<int,List<string>> product_IDs = new Dictionary<int,List<string>>();

        public List<string> sldmCS_ID = new List<string>();
        public List<string> cBLMD_ID = new List<string>();
        public List<string> bll_ID = new List<string>();

        OleDbConnection con;
        OleDbCommand cmd;

        public Stock()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            con = new OleDbConnection(connectionString);

            cmd = new OleDbCommand("SELECT [ProductName] FROM [Products]");

            cmd.Connection = con;
            con.Open();

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader[0].ToString() != "")
                {
                    products.Add(reader[0].ToString());
                }
            }

            foreach (var v in products)
            {
                prodBox.Items.Add(v);
            }

            reader.Close();
            con.Close();
        }

        private void ChartInit()
        {

            switch (prodBox.Text)
            {
                case "SLD-mCS":
                    con = new OleDbConnection(connectionString);

                    cmd = new OleDbCommand("SELECT [ComponentID] FROM [BOM] WHERE [ProductID] = '1'");

                    cmd.Connection = con;
                    con.Open();

                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        sldmCS_ID.Add(reader[0].ToString());
                    }
                    reader.Close();
                    con.Close();

                    product_IDs.Add(1, sldmCS_ID);
                    break;
                case "cBLMD":
                    con = new OleDbConnection(connectionString);

                    cmd = new OleDbCommand("SELECT [ComponentID] FROM [BOM] WHERE [ProductID] = '3'");

                    cmd.Connection = con;
                    con.Open();

                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cBLMD_ID.Add(reader[0].ToString());
                    }
                    reader.Close();
                    con.Close();

                    product_IDs.Add(3, cBLMD_ID);
                    break;
                case "BLL Evaluation Unit":
                    con = new OleDbConnection(connectionString);

                    cmd = new OleDbCommand("SELECT [ComponentID] FROM [BOM] WHERE [ProductID] = '4'");

                    cmd.Connection = con;
                    con.Open();

                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        bll_ID.Add(reader[0].ToString());
                    }
                    reader.Close();
                    con.Close();

                    product_IDs.Add(4, bll_ID);
                    break;
                    
            }
        }

        private void prodBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChartInit();
        }
    }
}
