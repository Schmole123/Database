using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;


namespace ProductionOrderForm
{
    public partial class productionOrderForm : Form
    {
        string connectionString =
        @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = \\SERVER-CORK\Shared\Staff Personal folders\Caolan\Database\Back_End\Inventory Managment_Data.accdb;";

        public bool orderExists = false;
        public int productID;

        OleDbConnection con;
        OleDbCommand cmd;

        public productionOrderForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerTxt.Text != "" && orderTxt.Text != "" && statusBox.Text != "" && productBox.Text != "")
                {
                    con = new OleDbConnection(connectionString);

                    cmd = new OleDbCommand("SELECT [OrderCode] FROM [ProductionOrders] WHERE [OrderCode] = '" + orderTxt.Text + "' ");
                    cmd.Connection = con;
                    con.Open();

                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader[0].ToString() == orderTxt.Text)
                        {
                            orderExists = true;
                        }
                    }

                    reader.Close();
                    con.Close();

                    if (orderExists == false)
                    {
                        try
                        {
                            ProductID();

                            cmd = new OleDbCommand("INSERT INTO [ProductionOrders]([Customer],[OrderCode],[StartDate],[EstimatedEndDate],[Status],[ProductID],[Product])" +
                                "VALUES('" + customerTxt.Text + "', '" + orderTxt.Text + "', '" + startDate.Value.ToShortDateString() + "', '" + endDate.Value.ToShortDateString() + "', '" + statusBox.Text + "', '" + productID + "', '" + productBox.Text + "')");
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

                    else if (orderExists == true)
                    {
                        try
                        {
                            ProductID();

                            cmd = new OleDbCommand("UPDATE [ProductionOrders] " +
                                "SET[Customer] = '" + customerTxt.Text + "', [StartDate] = '" + startDate.Value.ToShortDateString() + "', [EstimatedEndDate] = '" + endDate.Value.ToShortDateString() + "', [Status] = '" + statusBox.Text + "', [ProductID] = '" + productID + "', [Product] = '" + productBox.Text + "'" +
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
                        MessageBox.Show("Error writing data");
                    }
                    con.Close();
                    orderExists = false;
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

        private void retrieveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (orderTxt.Text != "")
                {
                    con = new OleDbConnection(connectionString);

                    cmd = new OleDbCommand("SELECT * FROM [ProductionOrders] WHERE [OrderCode] = '" + orderTxt.Text + "'");
                    cmd.Connection = con;
                    con.Open();

                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //index 0 = order id, index 1 = order code etc

                        var start = DateTime.Parse(reader[2].ToString());
                        var end = DateTime.Parse(reader[3].ToString());

                        customerTxt.Text = reader[6].ToString(); //idk why its indexed at 6 but it is
                        startDate.Value = start;
                        endDate.Value = end;
                        statusBox.SelectedItem = reader[4].ToString();
                        productBox.SelectedItem = reader[7].ToString();
                    }

                    reader.Close();
                    con.Close();
                }

                else
                {
                    MessageBox.Show("Please enter a valid Order Code");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }
    }
}
