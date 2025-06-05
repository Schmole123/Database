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

        }


        private void btnRedTag_Click(object sender, EventArgs e)
        {
            pnlRedTag.Visible = true;
            frmRedTag frmRedTag = new frmRedTag(connectionString);
            frmRedTag.Dock = DockStyle.Fill;
            frmRedTag.TopLevel = false;
            pnlRedTag.Controls.Clear();
            pnlRedTag.Controls.Add(frmRedTag);
            
            frmRedTag.Show();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pnlRedTag.Controls.Clear();
            pnlRedTag.Visible = false;
          
        }
    }
}
