using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inventory_Database_FrontEnd
{
    public partial class frmRedTag : Form
    {

        static string  _connectionString;

        public bool numExists = false;
        public bool repaired = false;

        OleDbConnection Con;

        OleDbDataAdapter DA;

        OleDbCommand CMD;

        DataSet DS;

        public frmRedTag(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
        }



        private void UpdateTable(string serialNum, string failText, string addInfo, string unit, string failCol)
        {
            try
            {
                if (repairCheck.Checked == true)
                {
                    repaired = true;
                }

                else
                {
                    repaired = false;
                }

                Con = new OleDbConnection(_connectionString);

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

        private void frmRedTag_Load(object sender, EventArgs e)
        {
            pcbPanel.Location = new Point(280, 8);
            sldPanel.Location = new Point(280, 8);
            this.Size = new Size(780, 365);
            unitSelect.SelectedItem = "PCB";
        }

        private void unitSelect_SelectedValueChanged(object sender, EventArgs e)
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (pcbPanel.Visible == true)
                {
                    if (PCBnum.Text != "" && reporteeName.Text != "" && pcbfail.Text != "")
                    {
                        UpdateTable(PCBnum.Text, pcbfail.Text, pcbAInfo.Text, "PCB Serial Number", "Reason for PCB Fail");
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
    }
}
    

