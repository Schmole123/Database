using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore;


namespace StatsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void prodBtn_Click(object sender, EventArgs e)
        {
            productionStatus1.Visible = true;
            supplierData1.Visible = false;
            this.Size = new Size(680, 500);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productionStatus1.Size = new Size(650, 500);

            supplierData1.Size = new Size(960, 500);
            supplierData1.Location = productionStatus1.Location;
        }

        private void supplyBtn_Click(object sender, EventArgs e)
        {
            supplierData1.Visible = true;
            productionStatus1.Visible = false;

            this.Size = new Size(1100, 500);
        }

    }
}
