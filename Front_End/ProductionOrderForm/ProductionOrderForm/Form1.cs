using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;


namespace ProductionOrderForm
{
    public partial class productionOrderForm : Form
    {
        //connection string required to connect to file on server - requires program to run in .net8 & 64 bit to work
        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = \\SERVER-CORK\Shared\Staff Personal folders\Caolan\Database\Back_End\Inventory Managment_Data.accdb;";

        public bool orderExists = false;
        public int productID;
        public bool isolator = false;

        OleDbConnection con;
        OleDbCommand cmd;

        public productionOrderForm()
        {
            InitializeComponent();
        }

        //Insert new row of data or update existing row of data by order code
        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerTxt.Text != "" && orderTxt.Text != "" && statusBox.Text != "" && productBox.Text != "") //requires all data fields to be filled - "" is blank
                {
                    con = new OleDbConnection(connectionString);

                    //SQL command generation to SELECT "OrderCode" FROM "ProductionOrders" table WHERE "OrderCode" = "Order Code"
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
                            cmd = new OleDbCommand("INSERT INTO [ProductionOrders]([Customer],[OrderCode],[StartDate],[EstimatedEndDate],[Status],[ProductID],[Product],[Quantity],[Isolator])" +
                                "VALUES('" + customerTxt.Text + "', '" + orderTxt.Text + "', '" + startDate.Value.ToShortDateString() + "', '" + endDate.Value.ToShortDateString() + "', '" + statusBox.Text + "', '" + productID + "', '" + productBox.Text + "', '" + quantityNum.Value + "', " + isolator + ")");

                            cmd.Connection = con;
                            con.Open(); //open connection

                            cmd.ExecuteNonQuery(); //execute SQL command

                            con.Close(); //close connection

                            MessageBox.Show("Data submission successful"); //display message if no exception occurs
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    else if (orderExists == true) //updates existing row of data if the order code already exists
                    {
                        try
                        {
                            ProductID(); //calls function to assign product id based on product selection box

                            //SQL command generation to UPDATE "ProductionOrders" table(All columns of the table) with VALUES(All data for each column) relevant to order code
                            //[] brackets important for column names - values entered must be structured in the same order as columns are entered 
                            cmd = new OleDbCommand("UPDATE [ProductionOrders] " +
                                "SET[Customer] = '" + customerTxt.Text + "', [StartDate] = '" + startDate.Value.ToShortDateString() + "', [EstimatedEndDate] = '" + endDate.Value.ToShortDateString() + "', [Status] = '" + statusBox.Text + "', [ProductID] = '" + productID + "', [Product] = '" + productBox.Text + "', [Quantity] = '" + quantityNum.Value + "',[Isolator] = " + isolator + " " +
                                "WHERE [OrderCode] = '" + orderTxt.Text + "' ");

                            cmd.Connection = con;
                            con.Open();

                            cmd.ExecuteNonQuery();

                            con.Close();
                            MessageBox.Show("Data submission successful");
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Error writing data"); //misc error if exception has not already occured
                    }
                    con.Close();            //ensure connection is closed
                    orderExists = false;    //reset order code flag
                }

                else
                {
                    MessageBox.Show("Please fill all data fields");
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //sets product ID variable based on product selection box value
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

        //Retrieves data from the table by order code - displays data in relevant sections 
        private void retrieveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (orderTxt.Text != "") //requires an order code to execture function - "" is blank
                {
                    con = new OleDbConnection(connectionString); //assign database path to connection varible

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

                        orderExists = true;                                 //set flag that the order code exists

                        var start = DateTime.Parse(reader[2].ToString());   //convert start date string to DateTime for DateTime picker
                        var end = DateTime.Parse(reader[3].ToString());     //convert end date string to DateTime for DateTime picker

                        customerTxt.Text = reader[6].ToString();            //retrieve customer name- idk why its indexed at 6 but it is
                        startDate.Value = start;                            //set start date
                        endDate.Value = end;                                //set end date
                        statusBox.SelectedItem = reader[4].ToString();      //retrieve status 
                        productBox.SelectedItem = reader[7].ToString();     //retrieve selected product
                        if (reader[8].ToString() != "")
                        {
                            quantityNum.Value = Decimal.Parse(reader[8].ToString());
                        }
                        else
                        {
                            quantityNum.Value = 0;
                        }
                        
                    }

                    if (orderExists == false) //if the entered order code is not found, prompt the enter of a valid code and clear all data fields
                    {
                        MessageBox.Show($"No data for Order Code: {orderTxt.Text}");
                        customerTxt.Clear();
                        orderTxt.Clear();
                        statusBox.SelectedItem = "";
                        productBox.SelectedItem = "";
                        startDate.Value = DateTime.Now; 
                        endDate.Value = DateTime.Now;
                        quantityNum.Value = 0;
                    }

                    reader.Close();         //close reader
                    con.Close();            //close connection
                    orderExists = false;    //reset order flag
                }

                else
                {
                    MessageBox.Show("Please enter a valid Order Code"); //display if no order code is entered
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void productBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(productBox.Text == "BLL" || productBox.Text == "cBLMD")
            {
                isolator = true;
            }
            else
            {
                isolator = false;
            }
        }
    }
}
