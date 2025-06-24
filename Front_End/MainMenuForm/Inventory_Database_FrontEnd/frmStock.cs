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
        string currentRack = "SLD-mCS";
        Dictionary<string, Dictionary<string, (int currentUnits, int maxCapacity)>> allRacks;
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

           
            allRacks = new Dictionary<string, Dictionary<string, (int, int)>>();

            allRacks["SLD-mCS"] = new Dictionary<string, (int, int)>
    {
 
    };

            this.cmbComponent.SelectedIndexChanged += new System.EventHandler(this.cmbComponent_SelectedIndexChanged);
            _connectionString = connectionString;

            UpdateRackDataFromDatabase(); 
            LoadComponents();

            panelRackView.Paint += PanelRackView_Paint;
            panelRackView.Invalidate(); 
        }


        private Dictionary<string, int> LoadStockFromDatabase()
        {
            var stock = new Dictionary<string, int>();

            
            string query = "SELECT Location, StockAmount FROM Components";

            using (var conn = new OleDbConnection(_connectionString))
            using (var cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["Location"].ToString();
                        int amount = Convert.ToInt32(reader["StockAmount"]);

                        stock[name] = amount;
                    }
                }
            }

            return stock;
        }

        private void UpdateRackDataFromDatabase()
        {
            var stockFromDb = LoadStockFromDatabase();

            foreach (var rackGroup in allRacks)
            {
                foreach (var rack in rackGroup.Value.Keys.ToList())
                {
                    int dbStock = stockFromDb.ContainsKey(rack) ? stockFromDb[rack] : 0;
                    int maxCapacity = rackGroup.Value[rack].Item2;

                    rackGroup.Value[rack] = (dbStock, maxCapacity);
                }
            }

            panelRackView.Invalidate(); // Refresh the visual panel
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

        private void PanelRackView_Paint(object sender, PaintEventArgs e)
        {
            if (!allRacks.ContainsKey(currentRack)) return;

            var rackData = allRacks[currentRack];
            var g = e.Graphics;
            g.Clear(Color.AliceBlue);

            int rows = 4, cols = 4;
            int slotWidth = 150, slotHeight = 100, padding = 20;

            Font font = new Font("Segoe UI", 9);
            Brush textBrush = Brushes.Black;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    int x = padding + c * (slotWidth + padding);
                    int y = padding + r * (slotHeight + padding);

                    string subsectionName = $"{currentRack}-{(char)('A' + r)}-{c + 1}";

                    if (!rackData.ContainsKey(subsectionName)) continue;

                    var data = rackData[subsectionName];
                    int current = data.currentUnits;
                    int max = data.maxCapacity;

                    Color fillColor = current <150 ? Color.LightGreen :
                                      current >= max ? Color.IndianRed :
                                      Color.Gold;

                    using (Brush fillBrush = new SolidBrush(fillColor))
                        g.FillRectangle(fillBrush, x, y, slotWidth, slotHeight);

                    g.DrawRectangle(Pens.Black, x, y, slotWidth, slotHeight);

                    g.DrawString(subsectionName, font, textBrush, x + 5, y + 5);
                    g.DrawString($"{max - current} slots free", font, textBrush, x + 5, y + 25);
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
                if (popup.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            allRacks = new Dictionary<string, Dictionary<string, (int, int)>>();

            allRacks["SLD-mCS"] = new Dictionary<string, (int, int)>
            {
                
            { "SLD-mCS-A-1", (0, 450) },
            { "SLD-mCS-A-2", (0, 450) },
            { "SLD-mCS-A-3", (0, 450) },
            { "SLD-mCS-A-4", (0, 450) },
            { "SLD-mCS-B-1", (0, 450) },
            { "SLD-mCS-B-2", (0, 450) },
            { "SLD-mCS-B-3", (0, 450) },
            { "SLD-mCS-B-4", (0, 450) },
            { "SLD-mCS-C-1", (0, 450) },
            { "SLD-mCS-C-2", (0, 450) },
            { "SLD-mCS-C-3", (0, 450) },
            { "SLD-mCS-C-4", (0, 450) },
            { "SLD-mCS-D-1", (0, 450) },
            { "SLD-mCS-D-2", (0, 450) },
            { "SLD-mCS-D-3", (0, 450) },
            { "SLD-mCS-D-4", (0, 450) },
        }; 
        

            allRacks["cBLMD"] = new Dictionary<string, (int, int)>
            {
                { "cBLMD-A-1", (0, 450) },
                { "cBLMD-A-2", (0, 450) },
                { "cBLMD-A-3", (0, 450) },
                { "cBLMD-A-4", (0, 450) },
                { "cBLMD-B-1", (0, 450) },
                { "cBLMD-B-2", (0, 450) },
                { "cBLMD-B-3", (0, 450) },
                { "cBLMD-B-4", (0, 450) },
                { "cBLMD-C-1", (0, 450) },
                { "cBLMD-C-2", (0, 450) },
                { "cBLMD-C-3", (0, 450) },
                { "cBLMD-C-4", (0, 450) },
                { "cBLMD-D-1", (0, 450) },
                { "cBLMD-D-2", (0, 450) },
                { "cBLMD-D-3", (0, 450) },
                { "cBLMD-D-4", (0, 450) },
            };

            allRacks["BLL"] = new Dictionary<string, (int, int)>
            {
                { "BLL-A-1", (0, 450) },
                { "BLL-A-2", (0, 450) },
                { "BLL-A-3", (0, 450) },
                { "BLL-A-4", (0, 450) },
                { "BLL-B-1", (0, 450) },
                { "BLL-B-2", (0, 450) },
                { "BLL-B-3", (0, 450) },
                { "BLL-B-4", (0, 450) },
                { "BLL-C-1", (0, 450) },
                { "BLL-C-2", (0, 450) },
                { "BLL-C-3", (0, 450) },
                { "BLL-C-4", (0, 450) },
                { "BLL-D-1", (0, 450) },
                { "BLL-D-2", (0, 450) },
                { "BLL-D-3", (0, 450) },
                { "BLL-D-4", (0, 450) },
            };

            UpdateRackDataFromDatabase();

            cmbRackSelector.Items.AddRange(allRacks.Keys.ToArray());
            cmbRackSelector.SelectedItem = currentRack;

            cmbRackSelector.SelectedIndexChanged += (s, ev) =>
            {
                currentRack = cmbRackSelector.SelectedItem.ToString();
                panelRackView.Invalidate(); // Redraw
            };

            panelRackView.Paint += PanelRackView_Paint;
        }
    }
}


