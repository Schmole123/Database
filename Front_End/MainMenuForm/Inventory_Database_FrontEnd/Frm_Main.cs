using System.Data;
using System.Data.OleDb;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Inventory_Database_FrontEnd;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Database_FrontEnd
{
    public partial class Inventory_Database : Form
    {

        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = \\SERVER-CORK\Shared\Staff Personal folders\Caolan\Database\Back_End\Inventory Managment_Data.accdb;";
        //string connectionString = @"Server=desktop-nnart1b\productiondb;Database=tempdb;Trusted_Connection=True;";

        public bool numExists = false;
        public bool repaired = false;

        public static Panel MainPanel;

        public Inventory_Database()
        {
            InitializeComponent();
            MainPanel = pnlStats;
            MainPanel.Visible = true;

            pnlRedTag.Visible = false;
            pnlStock.Visible = false;
            ListPrinters();
            string defaultPrinter = /*cmbPrinterSel.SelectedItem?.ToString() ?? */"TSC TE200";

        }


        private void btnRedTag_Click(object sender, EventArgs e)
        {
            try
            {
                ShowPanel(pnlRedTag);
                ParentContainer.Controls.Clear();
                frmRedTag frm = new frmRedTag(connectionString, cmbPrinterSel.SelectedItem.ToString());
                frm.Dock = DockStyle.Fill;
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                ParentContainer.Controls.Add(frm);
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
                ParentContainer.Controls.Clear();
                frmStock frm = new frmStock(connectionString);
                frm.Dock = DockStyle.Fill;
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                ParentContainer.Controls.Add(frm);
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
            pnlProductionOrder.Visible = false;
            pnlSupplier.Visible = false;
            pnlWelcome.Visible = false;
            pnlPCBTest.Visible = false;

            panelToShow.Refresh();


            // Show the selected one
            panelToShow.BringToFront();
            panelToShow.Visible = true;
        }

        private void btnProductionOrder_Click(object sender, EventArgs e)
        {
            try
            {
                ShowPanel(pnlProductionOrder);
                ParentContainer.Controls.Clear();
                frmProductionOrder frm = new frmProductionOrder(connectionString);
                frm.Dock = DockStyle.Fill;
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                ParentContainer.Controls.Add(frm);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Production Order menu: " + ex.Message);
            }
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                ShowPanel(pnlSupplier);
                ParentContainer.Controls.Clear();
                frmSupplier frm = new frmSupplier(connectionString);
                frm.Dock = DockStyle.Fill;
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                ParentContainer.Controls.Add(frm);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Production Order menu: " + ex.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                ShowPanel(pnlStats);
                ParentContainer.Controls.Clear();
                frmStats frm = new frmStats();
                frm.Dock = DockStyle.Fill;
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                ParentContainer.Controls.Add(frm);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Stats menu: " + ex.Message);
            }
        }
        private void Inventory_Database_Load(object sender, EventArgs e)
        {
            hh.Text = DateTime.Now.Hour.ToString("00");
            mm.Text = DateTime.Now.Minute.ToString("00");
            ss.Text = DateTime.Now.Second.ToString("00");
            timerSecond.Start();
            MainPanel.Show();
        }

        private void timerSecond_Tick(object sender, EventArgs e)
        {
            hh.Text = DateTime.Now.Hour.ToString("00");
            mm.Text = DateTime.Now.Minute.ToString("00");
            ss.Text = DateTime.Now.Second.ToString("00");
        }

        private void ListPrinters()
        {
            cmbPrinterSel.Items.AddRange(PrinterSettings.InstalledPrinters.Cast<string>().ToArray());
            if (cmbPrinterSel.Items.Count > 0)
            {
                cmbPrinterSel.SelectedIndex = 1;
            }
        }

        private void btnPCBTest_Click(object sender, EventArgs e)
        {
            try
            {
                ShowPanel(pnlPCBTest);
                ParentContainer.Controls.Clear();
                frmPCBTest frm = new frmPCBTest(connectionString);
                frm.Dock = DockStyle.Fill;
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                ParentContainer.Controls.Add(frm);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading PCB Test menu: " + ex.Message);
            }
        }

        private void cmbPrinterSel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
