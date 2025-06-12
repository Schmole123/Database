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
            pcbPanel.SuspendLayout();
            sldPanel.SuspendLayout();
            userPanel.SuspendLayout();
            SuspendLayout();
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.PaleGreen;
            updateBtn.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(650, 64);
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
            label2.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 161);
            label2.Name = "label2";
            label2.Size = new Size(150, 27);
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
            label3.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(-2, 67);
            label3.Name = "label3";
            label3.Size = new Size(181, 27);
            label3.TabIndex = 5;
            label3.Text = "Reason for Failure";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(-1, 0);
            label4.Name = "label4";
            label4.Size = new Size(198, 27);
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
            sldPanel.Location = new Point(33, 355);
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
            sldAInfoLabel.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            sldAInfoLabel.Location = new Point(1, 163);
            sldAInfoLabel.Name = "sldAInfoLabel";
            sldAInfoLabel.Size = new Size(150, 27);
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
            sldFailLabel.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            sldFailLabel.Location = new Point(-1, 67);
            sldFailLabel.Name = "sldFailLabel";
            sldFailLabel.Size = new Size(181, 27);
            sldFailLabel.TabIndex = 5;
            sldFailLabel.Text = "Reason for Failure";
            // 
            // sldNumLabel
            // 
            sldNumLabel.AutoSize = true;
            sldNumLabel.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sldNumLabel.Location = new Point(-1, 1);
            sldNumLabel.Name = "sldNumLabel";
            sldNumLabel.Size = new Size(196, 27);
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
            recieveBtn.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recieveBtn.Location = new Point(650, 165);
            recieveBtn.Name = "recieveBtn";
            recieveBtn.Size = new Size(167, 42);
            recieveBtn.TabIndex = 12;
            recieveBtn.Text = "Receive Data";
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
            label1.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 150);
            label1.Name = "label1";
            label1.Size = new Size(62, 27);
            label1.TabIndex = 11;
            label1.Text = "Date:";
            // 
            // repairCheck
            // 
            repairCheck.AutoSize = true;
            repairCheck.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            repairCheck.Location = new Point(9, 238);
            repairCheck.Name = "repairCheck";
            repairCheck.Size = new Size(114, 31);
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
            unitLabel.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitLabel.Location = new Point(0, 0);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new Size(113, 27);
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
            nameLabel.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(0, 76);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(188, 27);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name of Reportee:";
            // 
            // unitSelect
            // 
            unitSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            unitSelect.FormattingEnabled = true;
            unitSelect.Items.AddRange(new object[] { "PCB", "SLD" });
            unitSelect.Location = new Point(3, 32);
            unitSelect.Name = "unitSelect";
            unitSelect.Size = new Size(181, 23);
            unitSelect.TabIndex = 8;
            unitSelect.SelectedValueChanged += unitSelect_SelectedValueChanged;
            // 
            // frmRedTag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(885, 682);
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
            ResumeLayout(false);
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
    }
}