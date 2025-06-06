using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Database_FrontEnd
{
    public partial class frmProductionOrder: Form
    {
        static string _connectionString;
        public frmProductionOrder(string ConnectionString)
        {
            InitializeComponent();
            _connectionString = ConnectionString;


        }
    }
}
