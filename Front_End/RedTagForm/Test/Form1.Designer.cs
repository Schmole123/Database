namespace Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            updateBtn = new Button();
            pcbNum = new TextBox();
            pcbPanel = new Panel();
            pcbAInfoText = new RichTextBox();
            pcbAInfoLabel = new Label();
            pcbFailText = new RichTextBox();
            pcbFailLabel = new Label();
            pcbNumLabel = new Label();
            sldPanel = new Panel();
            sldAInfoText = new RichTextBox();
            sldAInfoLabel = new Label();
            sldFailText = new RichTextBox();
            sldFailLabel = new Label();
            sldNumLabel = new Label();
            sldNum = new TextBox();
            dateSelect = new DateTimePicker();
            nameLabel = new Label();
            reporteeName = new TextBox();
            unitSelect = new ComboBox();
            unitLabel = new Label();
            userPanel = new Panel();
            label1 = new Label();
            repairCheck = new CheckBox();
            recieveBtn = new Button();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            yearLabel = new Label();
            yearBox = new ComboBox();
            refreshBtn = new Button();
            pcbPanel.SuspendLayout();
            sldPanel.SuspendLayout();
            userPanel.SuspendLayout();
            SuspendLayout();
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(563, 12);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(140, 42);
            updateBtn.TabIndex = 0;
            updateBtn.Text = "Submit";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_click;
            // 
            // pcbNum
            // 
            pcbNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pcbNum.Location = new Point(197, 16);
            pcbNum.Name = "pcbNum";
            pcbNum.Size = new Size(114, 29);
            pcbNum.TabIndex = 1;
            // 
            // pcbPanel
            // 
            pcbPanel.Controls.Add(pcbAInfoText);
            pcbPanel.Controls.Add(pcbAInfoLabel);
            pcbPanel.Controls.Add(pcbFailText);
            pcbPanel.Controls.Add(pcbFailLabel);
            pcbPanel.Controls.Add(pcbNumLabel);
            pcbPanel.Controls.Add(pcbNum);
            pcbPanel.Location = new Point(227, 2);
            pcbPanel.Name = "pcbPanel";
            pcbPanel.Size = new Size(330, 320);
            pcbPanel.TabIndex = 2;
            pcbPanel.Visible = false;
            // 
            // pcbAInfoText
            // 
            pcbAInfoText.BorderStyle = BorderStyle.FixedSingle;
            pcbAInfoText.Location = new Point(3, 191);
            pcbAInfoText.Name = "pcbAInfoText";
            pcbAInfoText.Size = new Size(324, 75);
            pcbAInfoText.TabIndex = 11;
            pcbAInfoText.Text = "";
            // 
            // pcbAInfoLabel
            // 
            pcbAInfoLabel.AutoSize = true;
            pcbAInfoLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pcbAInfoLabel.Location = new Point(3, 163);
            pcbAInfoLabel.Name = "pcbAInfoLabel";
            pcbAInfoLabel.Size = new Size(150, 30);
            pcbAInfoLabel.TabIndex = 7;
            pcbAInfoLabel.Text = "Additional info";
            // 
            // pcbFailText
            // 
            pcbFailText.BorderStyle = BorderStyle.FixedSingle;
            pcbFailText.Location = new Point(3, 84);
            pcbFailText.Name = "pcbFailText";
            pcbFailText.Size = new Size(324, 75);
            pcbFailText.TabIndex = 6;
            pcbFailText.Text = "";
            // 
            // pcbFailLabel
            // 
            pcbFailLabel.AutoSize = true;
            pcbFailLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pcbFailLabel.Location = new Point(3, 52);
            pcbFailLabel.Name = "pcbFailLabel";
            pcbFailLabel.Size = new Size(178, 30);
            pcbFailLabel.TabIndex = 5;
            pcbFailLabel.Text = "Reason for Failure";
            // 
            // pcbNumLabel
            // 
            pcbNumLabel.AutoSize = true;
            pcbNumLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pcbNumLabel.Location = new Point(3, 12);
            pcbNumLabel.Name = "pcbNumLabel";
            pcbNumLabel.Size = new Size(188, 30);
            pcbNumLabel.TabIndex = 3;
            pcbNumLabel.Text = "PCB Serial Number";
            // 
            // sldPanel
            // 
            sldPanel.Controls.Add(sldAInfoText);
            sldPanel.Controls.Add(sldAInfoLabel);
            sldPanel.Controls.Add(sldFailText);
            sldPanel.Controls.Add(sldFailLabel);
            sldPanel.Controls.Add(sldNumLabel);
            sldPanel.Controls.Add(sldNum);
            sldPanel.Location = new Point(742, 18);
            sldPanel.Name = "sldPanel";
            sldPanel.Size = new Size(330, 320);
            sldPanel.TabIndex = 11;
            sldPanel.Visible = false;
            // 
            // sldAInfoText
            // 
            sldAInfoText.BorderStyle = BorderStyle.FixedSingle;
            sldAInfoText.Location = new Point(3, 191);
            sldAInfoText.Name = "sldAInfoText";
            sldAInfoText.Size = new Size(324, 75);
            sldAInfoText.TabIndex = 11;
            sldAInfoText.Text = "";
            // 
            // sldAInfoLabel
            // 
            sldAInfoLabel.AutoSize = true;
            sldAInfoLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sldAInfoLabel.Location = new Point(3, 163);
            sldAInfoLabel.Name = "sldAInfoLabel";
            sldAInfoLabel.Size = new Size(150, 30);
            sldAInfoLabel.TabIndex = 7;
            sldAInfoLabel.Text = "Additional info";
            // 
            // sldFailText
            // 
            sldFailText.BorderStyle = BorderStyle.FixedSingle;
            sldFailText.Location = new Point(3, 84);
            sldFailText.Name = "sldFailText";
            sldFailText.Size = new Size(324, 75);
            sldFailText.TabIndex = 6;
            sldFailText.Text = "";
            // 
            // sldFailLabel
            // 
            sldFailLabel.AutoSize = true;
            sldFailLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sldFailLabel.Location = new Point(3, 52);
            sldFailLabel.Name = "sldFailLabel";
            sldFailLabel.Size = new Size(178, 30);
            sldFailLabel.TabIndex = 5;
            sldFailLabel.Text = "Reason for Failure";
            // 
            // sldNumLabel
            // 
            sldNumLabel.AutoSize = true;
            sldNumLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sldNumLabel.Location = new Point(3, 12);
            sldNumLabel.Name = "sldNumLabel";
            sldNumLabel.Size = new Size(187, 30);
            sldNumLabel.TabIndex = 3;
            sldNumLabel.Text = "SLD Serial Number";
            // 
            // sldNum
            // 
            sldNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sldNum.Location = new Point(196, 16);
            sldNum.Name = "sldNum";
            sldNum.Size = new Size(115, 29);
            sldNum.TabIndex = 1;
            // 
            // dateSelect
            // 
            dateSelect.Location = new Point(32, 194);
            dateSelect.Name = "dateSelect";
            dateSelect.Size = new Size(141, 23);
            dateSelect.TabIndex = 8;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(21, 76);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(183, 30);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name of Reportee";
            // 
            // reporteeName
            // 
            reporteeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reporteeName.Location = new Point(21, 109);
            reporteeName.Name = "reporteeName";
            reporteeName.Size = new Size(169, 29);
            reporteeName.TabIndex = 5;
            // 
            // unitSelect
            // 
            unitSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            unitSelect.FormattingEnabled = true;
            unitSelect.Items.AddRange(new object[] { "PCB", "SLD" });
            unitSelect.Location = new Point(32, 40);
            unitSelect.Name = "unitSelect";
            unitSelect.Size = new Size(141, 23);
            unitSelect.TabIndex = 8;
            unitSelect.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitLabel.Location = new Point(49, 7);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new Size(110, 30);
            unitLabel.TabIndex = 9;
            unitLabel.Text = "Unit select";
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
            userPanel.Location = new Point(5, 2);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(216, 320);
            userPanel.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 161);
            label1.Name = "label1";
            label1.Size = new Size(57, 30);
            label1.TabIndex = 11;
            label1.Text = "Date";
            // 
            // repairCheck
            // 
            repairCheck.AutoSize = true;
            repairCheck.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            repairCheck.Location = new Point(46, 254);
            repairCheck.Name = "repairCheck";
            repairCheck.Size = new Size(113, 34);
            repairCheck.TabIndex = 10;
            repairCheck.Text = "Repaired";
            repairCheck.UseVisualStyleBackColor = true;
            // 
            // recieveBtn
            // 
            recieveBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recieveBtn.Location = new Point(563, 84);
            recieveBtn.Name = "recieveBtn";
            recieveBtn.Size = new Size(140, 42);
            recieveBtn.TabIndex = 12;
            recieveBtn.Text = "Recieve";
            recieveBtn.UseVisualStyleBackColor = true;
            recieveBtn.Click += recieveBtn_Click;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(5, 328);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(722, 314);
            cartesianChart1.TabIndex = 13;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yearLabel.Location = new Point(605, 230);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(40, 21);
            yearLabel.TabIndex = 14;
            yearLabel.Text = "Year";
            // 
            // yearBox
            // 
            yearBox.DropDownStyle = ComboBoxStyle.DropDownList;
            yearBox.FormattingEnabled = true;
            yearBox.Location = new Point(573, 255);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(121, 23);
            yearBox.TabIndex = 18;
            yearBox.SelectedValueChanged += yearBox_SelectedValueChanged;
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new Point(593, 297);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(75, 23);
            refreshBtn.TabIndex = 19;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 656);
            Controls.Add(refreshBtn);
            Controls.Add(yearBox);
            Controls.Add(yearLabel);
            Controls.Add(cartesianChart1);
            Controls.Add(recieveBtn);
            Controls.Add(sldPanel);
            Controls.Add(updateBtn);
            Controls.Add(pcbPanel);
            Controls.Add(userPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Red Tagger";
            Load += Form1_Load;
            pcbPanel.ResumeLayout(false);
            pcbPanel.PerformLayout();
            sldPanel.ResumeLayout(false);
            sldPanel.PerformLayout();
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateBtn;
        private TextBox pcbNum;
        private Panel pcbPanel;
        private DateTimePicker dateSelect;
        private Label nameLabel;
        private TextBox reporteeName;
        private Label pcbNumLabel;
        private ComboBox unitSelect;
        private Label unitLabel;
        private Panel userPanel;
        private Label pcbFailLabel;
        private RichTextBox pcbFailText;
        private Panel sldPanel;
        private RichTextBox sldAInfoText;
        private Label sldAInfoLabel;
        private RichTextBox sldFailText;
        private Label sldFailLabel;
        private Label sldNumLabel;
        private TextBox sldNum;
        private RichTextBox pcbAInfoText;
        private Label pcbAInfoLabel;
        private Label label1;
        private CheckBox repairCheck;
        private Button recieveBtn;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Label yearLabel;
        private DateTimePicker yearPick;
        private ComboBox yearBox;
        private Button refreshBtn;
    }
}
