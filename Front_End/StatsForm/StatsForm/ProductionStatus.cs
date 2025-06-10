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

namespace StatsForm
{
    public partial class ProductionStatus : UserControl
    {
        public HashSet<string> customers = new HashSet<string>();
        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = \\SERVER-CORK\Shared\Staff Personal folders\Caolan\Database\Back_End\Inventory Managment_Data.accdb;";
        public List<string> status = new List<string> {"New","In Progress","Completed"};

        OleDbConnection con;
        OleDbCommand cmd;

        public ProductionStatus()
        {
            InitializeComponent();
            Init();
            Count();
        }

        private void Init()
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
                        case "In Progress":
                            progNum.Text = reader[0].ToString();
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
