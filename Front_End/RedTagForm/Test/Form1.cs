using System.Data;
using System.Data.OleDb;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Test
{
    public partial class Form1 : Form
    {
        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = \\SERVER-CORK\Shared\Staff Personal folders\Caolan\Database\Back_End\Inventory Managment_Data.accdb;";

        public bool numExists = false;
        public bool repaired = false;

        OleDbConnection Con;

        OleDbDataAdapter DA;

        OleDbCommand CMD;

        DataSet DS;



        public Form1()

        {
            InitializeComponent();

        }





        private void updateBtn_click(object sender, EventArgs e)
        {
            try
            {
                if (pcbPanel.Visible == true)
                {
                    if (pcbNum.Text != "" && reporteeName.Text != "" && pcbFailText.Text != "")
                    {
                        UpdateTable(pcbNum.Text, pcbFailText.Text, pcbAInfoText.Text, "PCB Serial Number", "Reason for PCB Fail");
                        MessageBox.Show("Data submission successful");
                    }

                    else
                    {
                        MessageBox.Show("Please fill in all data fields");
                    }
                }

                else if (sldPanel.Visible == true)
                {
                    if (sldNum.Text != "" && reporteeName.Text != "" && sldFailText.Text != "")
                    {
                        UpdateTable(sldNum.Text, sldFailText.Text, sldAInfoText.Text, "SLD Serial Number", "Reason for SLD Fail");
                        MessageBox.Show("Data submission successful");
                    }

                    else
                    {
                        MessageBox.Show("Please fill in all data fields");
                    }
                }

                else
                {
                    MessageBox.Show("Please select unit type");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (unitSelect.Text == "PCB")
            {
                pcbPanel.Visible = true;
                sldPanel.Visible = false;
            }

            if (unitSelect.Text == "SLD")
            {
                pcbPanel.Visible = false;
                sldPanel.Visible = true;
            }

            else if (unitSelect.Text != "PCB" && unitSelect.Text != "SLD")
            {
                pcbPanel.Visible = false;
                sldPanel.Visible = false;
                MessageBox.Show("Please select a unit type");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcbPanel.Location = new Point(227, 2);
            sldPanel.Location = new Point(227, 2);
            this.Size = new Size(780, 365);
            unitSelect.SelectedItem = "PCB";
        }

        private void UpdateTable(string serialNum, string failText, string addInfo, string unit, string failCol)
        {
            try
            {
                if(repairCheck.Checked == true)
                {
                   repaired = true;
                }

                else
                {
                    repaired = false;
                }

                Con = new OleDbConnection(connectionString);

                CMD = new OleDbCommand("SELECT [" + unit + "] FROM RedTagTracking WHERE [" + unit + "] = '" + serialNum + "' ");
                CMD.Connection = Con;
                Con.Open();

                OleDbDataReader reader = CMD.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0].ToString() == serialNum)
                    {
                        numExists = true;
                    }
                }

                reader.Close();
                Con.Close();

                if (numExists == false)
                {
                    CMD = new OleDbCommand("INSERT INTO RedTagTracking([" + unit + "],[Name of Reportee],[Date of Report],[" + failCol + "],[Additional Information], [Repaired])" +
                        "VALUES('" + serialNum + "','" + reporteeName.Text + "','" + dateSelect.Value.ToShortDateString() + "','" + failText + "','" + addInfo + "', " + repaired + " );");
                    CMD.Connection = Con;
                    Con.Open();
                    CMD.ExecuteNonQuery();
                    Con.Close();
                }
                else if (numExists == true)
                {
                    CMD = new OleDbCommand("UPDATE RedTagTracking " +
                        "SET [Name of Reportee] = '" + reporteeName.Text + "', [Date of Report] = '" + dateSelect.Value.ToShortDateString() + "', [" + failCol + "] = '" + failText + "', [Additional Information] = '" + addInfo + "', [Repaired] = " + repaired + " " +
                        "WHERE [" + unit + "] = '" + serialNum + "' ");
                    CMD.Connection = Con;
                    Con.Open();
                    CMD.ExecuteNonQuery();
                    Con.Close();
                }

                else
                {
                    MessageBox.Show("Error writing data");
                }

                Con.Close();
                numExists = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
