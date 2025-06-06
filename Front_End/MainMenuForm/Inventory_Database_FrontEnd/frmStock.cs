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
            //Validate a component has been selected
            if (cmbComponent.SelectedValue == null)
            {
                MessageBox.Show("Please select a component first.", "No Component Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Validate correct Storage Location is selected
            if (string.IsNullOrWhiteSpace(cmbLocation.Text))
            {
                MessageBox.Show("Please select a storage location.", "No Location Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int componentID = Convert.ToInt32(cmbComponent.SelectedValue);
            string selectedLocation = cmbLocation.Text.Replace("'", "''");
            string selectedSupplier = cmbSupplier.Text.Replace("'", "''");
            string currentDateTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");

            string query = $@"UPDATE Components SET StockAmount = StockAmount + ?,
            [Location] = ?,
            [Supplier] = ?,
            [LastUpdate] = ?
            WHERE ComponentID = ?";

            try
            {
                using (OleDbConnection con = new OleDbConnection(_connectionString))
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("?", selectedSupplier);
                    
                    

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Stock updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear fields
                txtAmount.Clear();
                cmbLocation.SelectedIndex = -1;
                cmbSupplier.SelectedIndex = -1;

                // Reload details for selected component
                cmbComponent_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

