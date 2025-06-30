namespace Inventory_Database_FrontEnd
{
    partial class frmRedTag
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            updateBtn = new Button();
            pcbPanel = new Panel();
            pcbAInfo = new RichTextBox();
            label2 = new Label();
            pcbfail = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            PCBnum = new TextBox();
            sldPanel = new Panel();
            sldAInfoText = new RichTextBox();
            sldAInfoLabel = new Label();
            sldFailText = new RichTextBox();
            sldFailLabel = new Label();
            sldNumLabel = new Label();
            sldNum = new TextBox();
            recieveBtn = new Button();
            userPanel = new Panel();
            label1 = new Label();
            repairCheck = new CheckBox();
            dateSelect = new DateTimePicker();
            unitLabel = new Label();
            reporteeName = new TextBox();
            nameLabel = new Label();
            unitSelect = new ComboBox();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            yearBox = new ComboBox();
            label5 = new Label();
            refreshBtn = new Button();
            printBtn = new Button();
            fullUnitPanel = new Panel();
            unitIDBox = new TextBox();
            unitIDLabel = new Label();
            sldFailCheck = new CheckBox();
            fUnitSldNum = new TextBox();
            unitSLDNum = new Label();
            unitFailSelect = new ComboBox();
            fullUnitAInfo = new RichTextBox();
            label6 = new Label();
            fullUnitFailTxt = new RichTextBox();
            label7 = new Label();
            unitFailLabel = new Label();
            pcbPanel.SuspendLayout();
            sldPanel.SuspendLayout();
            userPanel.SuspendLayout();
            fullUnitPanel.SuspendLayout();
            SuspendLayout();
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.PaleGreen;
            updateBtn.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(650, 13);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(167, 42);
            updateBtn.TabIndex = 12;
            updateBtn.Text = "Submit Data";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // pcbPanel
            // 
            pcbPanel.Controls.Add(pcbAInfo);
            pcbPanel.Controls.Add(label2);
            pcbPanel.Controls.Add(pcbfail);
            pcbPanel.Controls.Add(label3);
            pcbPanel.Controls.Add(label4);
            pcbPanel.Controls.Add(PCBnum);
            pcbPanel.Location = new Point(235, 12);
            pcbPanel.Name = "pcbPanel";
            pcbPanel.Size = new Size(330, 315);
            pcbPanel.TabIndex = 26;
            pcbPanel.Visible = false;
            // 
            // pcbAInfo
            // 
            pcbAInfo.BorderStyle = BorderStyle.FixedSingle;
            pcbAInfo.Location = new Point(3, 193);
            pcbAInfo.Name = "pcbAInfo";
            pcbAInfo.Size = new Size(324, 75);
            pcbAInfo.TabIndex = 11;
            pcbAInfo.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 161);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 7;
            label2.Text = "Additional info";
            // 
            // pcbfail
            // 
            pcbfail.BorderStyle = BorderStyle.FixedSingle;
            pcbfail.Location = new Point(3, 100);
            pcbfail.Name = "pcbfail";
            pcbfail.Size = new Size(324, 57);
            pcbfail.TabIndex = 6;
            pcbfail.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(-2, 67);
            label3.Name = "label3";
            label3.Size = new Size(189, 25);
            label3.TabIndex = 5;
            label3.Text = "Reason for Failure";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(-1, 0);
            label4.Name = "label4";
            label4.Size = new Size(203, 25);
            label4.TabIndex = 3;
            label4.Text = "PCB Serial Number:";
            // 
            // PCBnum
            // 
            PCBnum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PCBnum.Location = new Point(3, 30);
            PCBnum.Name = "PCBnum";
            PCBnum.Size = new Size(196, 29);
            PCBnum.TabIndex = 1;
            // 
            // sldPanel
            // 
            sldPanel.Controls.Add(sldAInfoText);
            sldPanel.Controls.Add(sldAInfoLabel);
            sldPanel.Controls.Add(sldFailText);
            sldPanel.Controls.Add(sldFailLabel);
            sldPanel.Controls.Add(sldNumLabel);
            sldPanel.Controls.Add(sldNum);
            sldPanel.Location = new Point(840, 12);
            sldPanel.Name = "sldPanel";
            sldPanel.Size = new Size(330, 315);
            sldPanel.TabIndex = 27;
            sldPanel.Visible = false;
            // 
            // sldAInfoText
            // 
            sldAInfoText.BorderStyle = BorderStyle.FixedSingle;
            sldAInfoText.Location = new Point(5, 193);
            sldAInfoText.Name = "sldAInfoText";
            sldAInfoText.Size = new Size(324, 75);
            sldAInfoText.TabIndex = 11;
            sldAInfoText.Text = "";
            // 
            // sldAInfoLabel
            // 
            sldAInfoLabel.AutoSize = true;
            sldAInfoLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            sldAInfoLabel.Location = new Point(1, 163);
            sldAInfoLabel.Name = "sldAInfoLabel";
            sldAInfoLabel.Size = new Size(148, 25);
            sldAInfoLabel.TabIndex = 7;
            sldAInfoLabel.Text = "Additional info";
            // 
            // sldFailText
            // 
            sldFailText.BorderStyle = BorderStyle.FixedSingle;
            sldFailText.Location = new Point(4, 100);
            sldFailText.Name = "sldFailText";
            sldFailText.Size = new Size(323, 57);
            sldFailText.TabIndex = 6;
            sldFailText.Text = "";
            // 
            // sldFailLabel
            // 
            sldFailLabel.AutoSize = true;
            sldFailLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            sldFailLabel.Location = new Point(-1, 67);
            sldFailLabel.Name = "sldFailLabel";
            sldFailLabel.Size = new Size(189, 25);
            sldFailLabel.TabIndex = 5;
            sldFailLabel.Text = "Reason for Failure";
            // 
            // sldNumLabel
            // 
            sldNumLabel.AutoSize = true;
            sldNumLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sldNumLabel.Location = new Point(-1, 1);
            sldNumLabel.Name = "sldNumLabel";
            sldNumLabel.Size = new Size(201, 25);
            sldNumLabel.TabIndex = 3;
            sldNumLabel.Text = "SLD Serial Number:";
            // 
            // sldNum
            // 
            sldNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sldNum.Location = new Point(1, 32);
            sldNum.Name = "sldNum";
            sldNum.Size = new Size(194, 29);
            sldNum.TabIndex = 1;
            // 
            // recieveBtn
            // 
            recieveBtn.BackColor = Color.LightSalmon;
            recieveBtn.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recieveBtn.Location = new Point(650, 88);
            recieveBtn.Name = "recieveBtn";
            recieveBtn.Size = new Size(167, 42);
            recieveBtn.TabIndex = 12;
            recieveBtn.Text = "Retrieve Data";
            recieveBtn.UseVisualStyleBackColor = false;
            recieveBtn.Click += recieveBtn_Click;
            // 
            // userPanel
            // 
            userPanel.Controls.Add(label1);
            userPanel.Controls.Add(repairCheck);
            userPanel.Controls.Add(dateSelect);
            userPanel.Controls.Add(unitLabel);
            userPanel.Controls.Add(reporteeName);
            userPanel.Controls.Add(nameLabel);
            userPanel.Controls.Add(unitSelect);
            userPanel.Location = new Point(12, 12);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(193, 275);
            userPanel.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 150);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 11;
            label1.Text = "Date:";
            // 
            // repairCheck
            // 
            repairCheck.AutoSize = true;
            repairCheck.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            repairCheck.Location = new Point(9, 238);
            repairCheck.Name = "repairCheck";
            repairCheck.Size = new Size(118, 29);
            repairCheck.TabIndex = 10;
            repairCheck.Text = "Repaired";
            repairCheck.UseVisualStyleBackColor = true;
            // 
            // dateSelect
            // 
            dateSelect.Location = new Point(4, 180);
            dateSelect.Name = "dateSelect";
            dateSelect.Size = new Size(181, 23);
            dateSelect.TabIndex = 8;
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitLabel.Location = new Point(0, 0);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new Size(113, 25);
            unitLabel.TabIndex = 9;
            unitLabel.Text = "Unit select";
            // 
            // reporteeName
            // 
            reporteeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reporteeName.Location = new Point(3, 106);
            reporteeName.Name = "reporteeName";
            reporteeName.Size = new Size(181, 29);
            reporteeName.TabIndex = 5;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(0, 76);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(192, 25);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name of Reportee:";
            // 
            // unitSelect
            // 
            unitSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            unitSelect.FormattingEnabled = true;
            unitSelect.Items.AddRange(new object[] { "PCB", "SLD", "Full Unit" });
            unitSelect.Location = new Point(3, 32);
            unitSelect.Name = "unitSelect";
            unitSelect.Size = new Size(181, 23);
            unitSelect.TabIndex = 8;
            unitSelect.SelectedValueChanged += unitSelect_SelectedValueChanged;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(21, 332);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(857, 333);
            cartesianChart1.TabIndex = 29;
            // 
            // yearBox
            // 
            yearBox.DropDownStyle = ComboBoxStyle.DropDownList;
            yearBox.FormattingEnabled = true;
            yearBox.Location = new Point(659, 279);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(121, 23);
            yearBox.TabIndex = 30;
            yearBox.SelectedValueChanged += yearBox_SelectedValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(696, 250);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 31;
            label5.Text = "Year";
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new Point(678, 308);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(75, 23);
            refreshBtn.TabIndex = 32;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // printBtn
            // 
            printBtn.BackColor = Color.SkyBlue;
            printBtn.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            printBtn.Location = new Point(650, 166);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(167, 42);
            printBtn.TabIndex = 33;
            printBtn.Text = "Print";
            printBtn.UseVisualStyleBackColor = false;
            printBtn.Click += printBtn_Click;
            // 
            // fullUnitPanel
            // 
            fullUnitPanel.Controls.Add(unitIDBox);
            fullUnitPanel.Controls.Add(unitIDLabel);
            fullUnitPanel.Controls.Add(sldFailCheck);
            fullUnitPanel.Controls.Add(fUnitSldNum);
            fullUnitPanel.Controls.Add(unitSLDNum);
            fullUnitPanel.Controls.Add(unitFailSelect);
            fullUnitPanel.Controls.Add(fullUnitAInfo);
            fullUnitPanel.Controls.Add(label6);
            fullUnitPanel.Controls.Add(fullUnitFailTxt);
            fullUnitPanel.Controls.Add(label7);
            fullUnitPanel.Controls.Add(unitFailLabel);
            fullUnitPanel.Location = new Point(543, 337);
            fullUnitPanel.Name = "fullUnitPanel";
            fullUnitPanel.Size = new Size(330, 315);
            fullUnitPanel.TabIndex = 34;
            fullUnitPanel.Visible = false;
            // 
            // unitIDBox
            // 
            unitIDBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitIDBox.Location = new Point(204, 271);
            unitIDBox.Name = "unitIDBox";
            unitIDBox.Size = new Size(111, 29);
            unitIDBox.TabIndex = 15;
            // 
            // unitIDLabel
            // 
            unitIDLabel.AutoSize = true;
            unitIDLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitIDLabel.Location = new Point(116, 275);
            unitIDLabel.Name = "unitIDLabel";
            unitIDLabel.Size = new Size(82, 25);
            unitIDLabel.TabIndex = 14;
            unitIDLabel.Text = "Unit ID:";
            // 
            // sldFailCheck
            // 
            sldFailCheck.AutoSize = true;
            sldFailCheck.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sldFailCheck.Location = new Point(6, 274);
            sldFailCheck.Name = "sldFailCheck";
            sldFailCheck.Size = new Size(113, 29);
            sldFailCheck.TabIndex = 12;
            sldFailCheck.Text = "SLD Fail";
            sldFailCheck.UseVisualStyleBackColor = true;
            sldFailCheck.CheckStateChanged += sldFailCheck_CheckStateChanged;
            // 
            // fUnitSldNum
            // 
            fUnitSldNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fUnitSldNum.Location = new Point(130, 28);
            fUnitSldNum.Name = "fUnitSldNum";
            fUnitSldNum.Size = new Size(196, 29);
            fUnitSldNum.TabIndex = 12;
            fUnitSldNum.Visible = false;
            // 
            // unitSLDNum
            // 
            unitSLDNum.AutoSize = true;
            unitSLDNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitSLDNum.Location = new Point(135, 0);
            unitSLDNum.Name = "unitSLDNum";
            unitSLDNum.Size = new Size(154, 25);
            unitSLDNum.TabIndex = 13;
            unitSLDNum.Text = "Serial Number:";
            unitSLDNum.Visible = false;
            // 
            // unitFailSelect
            // 
            unitFailSelect.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitFailSelect.FormattingEnabled = true;
            unitFailSelect.Items.AddRange(new object[] { "SLD mCS", "cBLMD", "BLL", "Pilot 4", "LensX" });
            unitFailSelect.Location = new Point(3, 28);
            unitFailSelect.Name = "unitFailSelect";
            unitFailSelect.Size = new Size(121, 29);
            unitFailSelect.TabIndex = 12;
            // 
            // fullUnitAInfo
            // 
            fullUnitAInfo.BorderStyle = BorderStyle.FixedSingle;
            fullUnitAInfo.Location = new Point(3, 193);
            fullUnitAInfo.Name = "fullUnitAInfo";
            fullUnitAInfo.Size = new Size(324, 75);
            fullUnitAInfo.TabIndex = 11;
            fullUnitAInfo.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 161);
            label6.Name = "label6";
            label6.Size = new Size(148, 25);
            label6.TabIndex = 7;
            label6.Text = "Additional info";
            // 
            // fullUnitFailTxt
            // 
            fullUnitFailTxt.BorderStyle = BorderStyle.FixedSingle;
            fullUnitFailTxt.Location = new Point(3, 100);
            fullUnitFailTxt.Name = "fullUnitFailTxt";
            fullUnitFailTxt.Size = new Size(324, 57);
            fullUnitFailTxt.TabIndex = 6;
            fullUnitFailTxt.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(-2, 67);
            label7.Name = "label7";
            label7.Size = new Size(189, 25);
            label7.TabIndex = 5;
            label7.Text = "Reason for Failure";
            // 
            // unitFailLabel
            // 
            unitFailLabel.AutoSize = true;
            unitFailLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitFailLabel.Location = new Point(-1, 0);
            unitFailLabel.Name = "unitFailLabel";
            unitFailLabel.Size = new Size(121, 25);
            unitFailLabel.TabIndex = 3;
            unitFailLabel.Text = "Failed Unit:";
            // 
            // frmRedTag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(885, 682);
            Controls.Add(fullUnitPanel);
            Controls.Add(printBtn);
            Controls.Add(refreshBtn);
            Controls.Add(label5);
            Controls.Add(yearBox);
            Controls.Add(cartesianChart1);
            Controls.Add(updateBtn);
            Controls.Add(userPanel);
            Controls.Add(recieveBtn);
            Controls.Add(sldPanel);
            Controls.Add(pcbPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRedTag";
            Text = "frmRedTag";
            Load += frmRedTag_Load;
            pcbPanel.ResumeLayout(false);
            pcbPanel.PerformLayout();
            sldPanel.ResumeLayout(false);
            sldPanel.PerformLayout();
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            fullUnitPanel.ResumeLayout(false);
            fullUnitPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button updateBtn;
        private Panel pcbPanel;
        private RichTextBox pcbAInfo;
        private Label label2;
        private RichTextBox pcbfail;
        private Label label3;
        private Label label4;
        private TextBox PCBnum;
        private Panel sldPanel;
        private RichTextBox sldAInfoText;
        private Label sldAInfoLabel;
        private RichTextBox sldFailText;
        private Label sldFailLabel;
        private Label sldNumLabel;
        private TextBox sldNum;
        private Panel userPanel;
        private Label label1;
        private CheckBox repairCheck;
        private DateTimePicker dateSelect;
        private Label unitLabel;
        private TextBox reporteeName;
        private Label nameLabel;
        private ComboBox unitSelect;
        private Button recieveBtn;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private ComboBox yearBox;
        private Label label5;
        private Button refreshBtn;
        private Button printBtn;
        private Panel fullUnitPanel;
        private ComboBox unitFailSelect;
        private RichTextBox fullUnitAInfo;
        private Label label6;
        private RichTextBox fullUnitFailTxt;
        private Label label7;
        private Label unitFailLabel;
        private TextBox fUnitSldNum;
        private Label unitSLDNum;
        private CheckBox sldFailCheck;
        private TextBox unitIDBox;
        private Label unitIDLabel;
    }
}