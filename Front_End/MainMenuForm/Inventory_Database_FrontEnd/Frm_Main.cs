using System.Data;
using System.Data.OleDb;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Inventory_Database_FrontEnd;


namespace Inventory_Database_FrontEnd
{
    public partial class Inventory_Database : Form
    {

        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = \\SERVER-CORK\Shared\Staff Personal folders\Caolan\Database\Back_End\Inventory Managment_Data.accdb;";

        public bool numExists = false;
        public bool repaired = false;

        public static Panel MainPanel;

        public Inventory_Database()
        {
            InitializeComponent();
            MainPanel = panel3;
            pnlRedTag.Visible = false;
            pnlStock.Visible = false;

        }


        private void btnRedTag_Click(object sender, EventArgs e)
        {
            try
            {
                ShowPanel(pnlRedTag);
                pnlRedTag.Controls.Clear();
                frmRedTag frm = new frmRedTag(connectionString);
                frm.Dock = DockStyle.Fill;
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                pnlRedTag.Controls.Add(frm);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Red Tag menu: " + ex.Message);
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pnlRedTag.Controls.Clear();
            pnlRedTag.Visible = false;

        }

        private void btnStockMenu_Click(object sender, EventArgs e)
        {
            try
            {
                ShowPanel(pnlStock);
                pnlStock.Controls.Clear();
                frmStock frm = new frmStock(connectionString);
                frm.Dock = DockStyle.Fill;
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                pnlStock.Controls.Add(frm);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock menu: " + ex.Message);
            }
        }
        private void ShowPanel(Panel panelToShow)
        {
            // Hide all panels
            pnlStock.Visible = false;
            pnlRedTag.Visible = false;
            // Add more if you have others

            // Show the selected one
            panelToShow.BringToFront();
            panelToShow.Visible = true;
        }

        private void btnProductionOrder_Click(object sender, EventArgs e)
        {
            try
            {
                ShowPanel(pnlProductionOrder);
                pnlProductionOrder.Controls.Clear();
                frmProductionOrder frm = new frmProductionOrder(connectionString);
                frm.Dock = DockStyle.Fill;
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                pnlProductionOrder.Controls.Add(frm);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Production Order menu: " + ex.Message);
            }
        }
    }
}
