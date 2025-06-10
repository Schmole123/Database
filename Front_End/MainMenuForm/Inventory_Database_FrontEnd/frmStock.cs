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
using Inventory_Database_FrontEnd.Dialogs;

namespace Inventory_Database_FrontEnd
{
    public partial class frmStock : Form
    {
        static string _connectionString;

        public bool numExists = false;
        public bool repaired = false;
        private DataTable componentsTable;

        OleDbConnection Con;

        OleDbDataAdapter DA;

        OleDbCommand CMD;

        DataSet DS;

        public frmStock(string connectionString)
        {
            InitializeComponent();
            this.cmbComponent.SelectedIndexChanged += new System.EventHandler(this.cmbComponent_SelectedIndexChanged);
            _connectionString = connectionString;
            LoadComponents();
        }

        private void cmbComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (cmbComponent.SelectedIndex < 0 || componentsTable == null)
                    return;

                DataRowView drv = cmbComponent.SelectedItem as DataRowView;
                if (drv != null)
                {
                    txtAmount.Text = drv["StockAmount"].ToString();
                    cmbLocation.Text = drv["Location"].ToString();
                    cmbSupplier.Text = drv["Supplier"].ToString();
                    txtProductCode.Text = drv["ProductNumber"].ToString();
                    if (drv["LastUpdate"] != DBNull.Value)
                    {
                        txtLastUpdate.Text = Convert.ToDateTime(drv["LastUpdate"]).ToShortDateString();
                    }
                    else
                    {
                        txtLastUpdate.Text = "No Update Available";
                    }

                }
            }

        }


        private void LoadComponents()
        {
            using (OleDbConnection con = new OleDbConnection(_connectionString))
            {
                string query = "SELECT ComponentID, ComponentName, StockAmount, Location, Supplier, LastUpdate, ProductNumber FROM Components";
                OleDbDataAdapter da = new OleDbDataAdapter(query, con);
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                da.Fill(dt);


                cmbComponent.DataSource = dt;
                cmbComponent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbComponent.AutoCompleteSource = AutoCompleteSource.ListItems;
                cmbComponent.DisplayMember = "ComponentName";
                cmbComponent.ValueMember = "ComponentID";

                cmbLocation.Items.AddRange(new string[] {
                "SLD-mCS-A-1", "SLD-mCS-A-2", "SLD-mCS-A-3", "SLD-mCS-A-4",
                "SLD-mCS-B-1", "SLD-mCS-B-2", "SLD-mCS-B-3", "SLD-mCS-B-4",
                "SLD-mCS-C-1", "SLD-mCS-C-2", "SLD-mCS-C-3", "SLD-mCS-C-4",
                "SLD-mCS-D-1", "SLD-mCS-D-2", "SLD-mCS-D-3", "SLD-mCS-D-4",
                "cBLMD-A-1", "cBLMD-A-2", "cBLMD-A-3", "cBLMD-A-4",
                "cBLMD-B-1", "cBLMD-B-2", "cBLMD-B-3", "cBLMD-B-4",
                "cBLMD-C-1", "cBLMD-C-2", "cBLMD-C-3", "cBLMD-C-4",
                "cBLMD-D-1", "cBLMD-D-2", "cBLMD-D-3", "cBLMD-D-4",
                "BLL-A-1", "BLL-A-2", "BLL-A-3", "BLL-A-4",
                "Pilot-A-1", "Pilot-A-2", "Pilot-A-3", "Pilot-A-4"
                });

                cmbSupplier.Items.AddRange(new string[] { "Farnell", "Mouser", "Digikey", "RS", "Genesis" });


                // Store the whole table for later use
                componentsTable = dt;
            }
        }

        private void btnAddtoStock_Click(object sender, EventArgs e)
        {
            if (cmbComponent.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a component.");
                return;
            }

            int componentId = Convert.ToInt32(cmbComponent.SelectedValue);
            string location = cmbLocation.Text;
            string supplier = cmbSupplier.Text;
            var Updated = DateTime.Now;
        

            using (OleDbConnection con = new OleDbConnection(_connectionString))
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();

                List<string> setClauses = new List<string>();
                List<object> parameters = new List<object>();

                if (!string.IsNullOrEmpty(location))
                {
                    setClauses.Add("Location = ?");
                    parameters.Add(location);
                }

                if (!string.IsNullOrEmpty(supplier))
                {
                    setClauses.Add("Supplier = ?");
                    parameters.Add(supplier);
                }


                
                    setClauses.Add("LastUpdate = ?");
                parameters.Add(Updated.ToString("yyyy-MM-dd HH:mm:ss"));
              



                if (setClauses.Count == 0)
                {
                    MessageBox.Show("Nothing to update.");
                    return;
                }

                string setClause = string.Join(", ", setClauses);
                cmd.CommandText = $"UPDATE Components SET {setClause} WHERE ComponentID = ?";
                parameters.Add(componentId); // final WHERE clause parameter

                // Add parameters in order
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue("?", param);
                }

                int result = cmd.ExecuteNonQuery();
                System.Threading.Thread.Sleep(1000); // 100 ms delay
                int previouslySelected = componentId; // Save selected component
                LoadComponents();
                cmbComponent.SelectedValue = previouslySelected;
                if (result > 0)

                    MessageBox.Show("Successfully Submitted");

                else
                    MessageBox.Show("Component not found or no update made.");
            }
        }






        private void lblAddNewComp_Click(object sender, EventArgs e)
        {
            NewComponent popup = new NewComponent();
            {
                if(popup.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }




    }
}

