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

namespace Inventory_Database_FrontEnd
{
    public partial class frmProductionOrder : Form
    {
        static string _connectionString;
        public bool orderExists = false;
        public int productID;

        OleDbConnection con;
        OleDbCommand cmd;


        public frmProductionOrder(string ConnectionString)
        {
            InitializeComponent();
            _connectionString = ConnectionString;
            var POnum = 0;

        }

        private void InitializeProgressBar(string currentStep)
        {
            progressPanel.Controls.Clear();

            string[] steps = { "New", "In Production", "QC", "Ready to Ship","Complete" };
            int stepWidth = progressPanel.Width / steps.Length;

            for (int i = 0; i < steps.Length; i++)
            {
                Label stepLabel = new Label();
                stepLabel.Text = steps[i];
                stepLabel.TextAlign = ContentAlignment.MiddleCenter;
                stepLabel.BorderStyle = BorderStyle.FixedSingle;
                stepLabel.Width = stepWidth - 10;
                stepLabel.Height = 40;
                stepLabel.Left = i * stepWidth + 5;
                stepLabel.Top = 5;

                // Highlight current step
                if (steps[i] == currentStep)
                {
                    stepLabel.BackColor = Color.LightGreen;
                    stepLabel.Font = new Font(stepLabel.Font, FontStyle.Bold);
                }
                else
                {
                    stepLabel.BackColor = Color.LightGray;
                }

                progressPanel.Controls.Add(stepLabel);
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerTxt.Text != "" && orderTxt.Text != "" && statusBox.Text != "" && productBox.Text != "") //requires all data fields to be filled - "" is blank
                {
                    con = new OleDbConnection(_connectionString);

                    //SQL command generation to SELECT "OrderCode" FRO "ProductionOrders" table WHERE "OrderCode" = "Order Code"
                    //[] brackets not always required for column names but better to include them to prevent clashing with Access definitions 
                    cmd = new OleDbCommand("SELECT [OrderCode] FROM [ProductionOrders] WHERE [OrderCode] = '" + orderTxt.Text + "' ");

                    cmd.Connection = con; //assign connection path
                    con.Open(); //open connection

                    //Reads data from table based on previous SQL command - searching to find the order code in the OrderCode column
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read()) //will skip over if no order code is found
                    {
                        if (reader[0].ToString() == orderTxt.Text)
                        {
                            orderExists = true; //set flag true if order code exists
                        }
                    }

                    reader.Close(); //close reader
                    con.Close(); //close connection

                    if (orderExists == false) //if no order code already exists, new row of data is added to the table
                    {
                        try
                        {
                            ProductID();    //calls function to assign product id based on product selection box

                            //SQL command generation to INSERT INTO "ProductionOrders" table(All columns of the table) with VALUES(All data for each column) relevant to order code
                            //[] brackets important for column names - values entered must be structured in the same order as columns are entered 
                            cmd = new OleDbCommand("INSERT INTO [ProductionOrders]([Customer],[OrderCode],[StartDate],[EstimatedEndDate],[Status],[ProductID],[Product])" +
                                "VALUES('" + customerTxt.Text + "', '" + orderTxt.Text + "', '" + startDate.Value.ToShortDateString() + "', '" + endDate.Value.ToShortDateString() + "', '" + statusBox.Text + "', '" + productID + "', '" + productBox.Text + "')");

                            cmd.Connection = con;
                            con.Open(); //open connection

                            cmd.ExecuteNonQuery(); //execute SQL command

                            con.Close(); //close connection

                            InitializeProgressBar(statusBox.Text);

                            MessageBox.Show("Data submission successful"); //display message if no exception occurs
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void retrieveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderTxt.Text != "") //requires an order code to exexecute function - "" is blank
                {
                    con = new OleDbConnection(_connectionString); //assign database path to connection varible

                    //SQL command generation to SELECT all columns FROM "ProductionOrders" table WHERE "OrderCode" = "Order code"
                    //[] brackets not always required for column names but better to include them to prevent clashing with Access definitions 
                    cmd = new OleDbCommand("SELECT * FROM [ProductionOrders] WHERE [OrderCode] = '" + orderTxt.Text + "'");

                    cmd.Connection = con;
                    con.Open(); //open connection

                    //Reads data from table based on previous SQL command - searching to find order code in the relevant column
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read()) //will skip past if no valid serial number
                    {

                        //if order code exists- extracts values from indexed locations and assigns to relevant area in panel

                        //index 0 = order id,
                        //index 1 = order code
                        //etc

                        orderExists = true;                             //set flag that the order code exists

                        var start = DateTime.Parse(reader[2].ToString());   //convert start date string to DateTime for DateTime picker
                        var end = DateTime.Parse(reader[3].ToString());     //convert end date string to DateTime for DateTime picker

                        customerTxt.Text = reader[6].ToString();           //retrieve customer name- idk why its indexed at 6 but it is
                        startDate.Value = start;                           //set start date
                        endDate.Value = end;                               //set end date
                        statusBox.SelectedItem = reader[4].ToString();     //retrieve status 
                        InitializeProgressBar(statusBox.SelectedItem.ToString());
                        productBox.SelectedItem = reader[7].ToString();    //retrieve selected product
                    }

                    if (orderExists == false) //if the entered order code is not found, prompt the enter of a valid code and clear all data fields
                    {
                        MessageBox.Show($"No data for Order Code: {orderTxt.Text}");
                        customerTxt.Clear();
                        orderTxt.Clear();
                        statusBox.SelectedItem = "";
                        productBox.SelectedItem = "";
                    }

                    reader.Close();          //close reader
                    con.Close();             //close connection
                    orderExists = false;     //reset order flag

                    var imagePath = $@"C:\Users\Caolan\Desktop\SuperlumProductionDatabase\Database\Back_End\ProductionOrders\{orderTxt.Text}.bmp";

                   
                    if (File.Exists(imagePath)) // Check if the image file exists
                    {
                        // --- CHANGE START ---
                        // Instead of ImageLocation, load the image directly into the Image property
                        // and then assign it to org.Image.
                        try
                        {
                            Image originalImage = Image.FromFile(imagePath);
                            Image resizedImage = ResizeImageToFit(originalImage, pbPO.Width, pbPO.Height);

                            pbPO.Image = resizedImage;
                            org.Image = (Image)resizedImage.Clone(); // Still clone if you use it elsewhere
                            pbPO.SizeMode = PictureBoxSizeMode.Normal;


                            // Update PictureBox size to match original image size initially
                            pbPO.Width = pbPO.Image.Width;
                            pbPO.Height = pbPO.Image.Height;

                            if (pbPO.Image != null)
                            {
                                org.Image = (Image)pbPO.Image.Clone(); // Clone for safety/independence
                                trackBar1.Enabled = true; // Enable trackbar here
                                trackBar1.Value = 1; // Reset zoom to default (1x)
                            }
                            else
                            {
                                MessageBox.Show($"Image for Order Code: not found or could not be loaded from {imagePath}", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                pbPO.Image = null;
                                trackBar1.Enabled = false;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading image from {imagePath}: {ex.Message}", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            pbPO.Image = null;
                            trackBar1.Enabled = false;
                        }
                    }
                    else
                    {
                        pbPO.Image = null;
                        MessageBox.Show($"Image for Order Code: not found at {imagePath}", "Image Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        trackBar1.Enabled = false;
                    }
                }
            }
            catch (Exception ex) // Catch any other errors from the database logic
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Image ResizeImageToFit(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            using (var g = Graphics.FromImage(newImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }

        private void ProductID()
        {
            switch (productBox.Text)
            {
                case "SLD-mCS":
                    productID = 1;
                    break;
                case "SLD-mCS Power Supply Unit":
                    productID = 2;
                    break;
                case "cBLMD":
                    productID = 3;
                    break;
                case "BLL":
                    productID = 4;
                    break;
                case "BLL Evaluation Unit":
                    productID = 5;
                    break;
                case "DBUT Mount":
                    productID = 6;
                    break;
            }
        }
        PictureBox org;
        private void frmProductionOrder_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);

            // TrackBar setup
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 6;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 1;
            trackBar1.UseWaitCursor = false;

       

            // Initialize org PictureBox, but its Image will be null initially
            org = new PictureBox();

            // Ensure pbPO is blank initially
            pbPO.Image = null;

        }

        private void FindPO()
        {

        }

        Image ZoomPic(Image img, Size size)
        {

            if (img == null)
            {
                return null;
            }

            
            int newWidth = Convert.ToInt32(img.Width * size.Width);
            int newHeight = Convert.ToInt32(img.Height * size.Height);

       

            Bitmap bm = new Bitmap(img, newWidth, newHeight);
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Only attempt to zoom if an original image exists
            if (org != null && org.Image != null && trackBar1.Value != 0)
            {
                pbPO.Image = null; // Clear the previous image
                pbPO.Image = ZoomPic(org.Image, new Size(trackBar1.Value, trackBar1.Value));
            }
            else if (org == null || org.Image == null)
            {
            
                MessageBox.Show("No image loaded to zoom. Please receive an order first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                trackBar1.Value = 1; // Reset trackbar to default or disable it again
                trackBar1.Enabled = false; // Disable it to prevent further attempts
            }
        }
    }
}
