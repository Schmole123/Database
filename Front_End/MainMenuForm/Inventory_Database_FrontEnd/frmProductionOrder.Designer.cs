namespace Inventory_Database_FrontEnd
{
    partial class frmProductionOrder
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
            customerLabel = new Label();
            customerTxt = new TextBox();
            orderCodeLabel = new Label();
            retrieveBtn = new Button();
            submitBtn = new Button();
            productBox = new ComboBox();
            statusBox = new ComboBox();
            productLabel = new Label();
            statusLabel = new Label();
            endDate = new DateTimePicker();
            endLabel = new Label();
            startDate = new DateTimePicker();
            startLabel = new Label();
            orderTxt = new TextBox();
            pbPO = new PictureBox();
            panel2 = new Panel();
            trackBar1 = new TrackBar();
            label1 = new Label();
            textBox1 = new TextBox();
            progressPanel = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbPO).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.BackColor = Color.LightSlateGray;
            customerLabel.Font = new Font("PT Root UI Light", 15.7499981F);
            customerLabel.Location = new Point(21, 38);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(111, 27);
            customerLabel.TabIndex = 0;
            customerLabel.Text = "Customer:";
            // 
            // customerTxt
            // 
            customerTxt.Location = new Point(237, 38);
            customerTxt.Name = "customerTxt";
            customerTxt.Size = new Size(138, 23);
            customerTxt.TabIndex = 1;
            // 
            // orderCodeLabel
            // 
            orderCodeLabel.AutoSize = true;
            orderCodeLabel.BackColor = Color.LightSlateGray;
            orderCodeLabel.Font = new Font("PT Root UI Light", 15.7499981F);
            orderCodeLabel.Location = new Point(21, 76);
            orderCodeLabel.Name = "orderCodeLabel";
            orderCodeLabel.Size = new Size(126, 27);
            orderCodeLabel.TabIndex = 2;
            orderCodeLabel.Text = "Order Code:";
            // 
            // retrieveBtn
            // 
            retrieveBtn.BackColor = Color.LightSalmon;
            retrieveBtn.FlatStyle = FlatStyle.Flat;
            retrieveBtn.Font = new Font("PT Root UI Light", 15.7499981F);
            retrieveBtn.Location = new Point(254, 486);
            retrieveBtn.Name = "retrieveBtn";
            retrieveBtn.Size = new Size(119, 41);
            retrieveBtn.TabIndex = 13;
            retrieveBtn.Text = "Retrieve";
            retrieveBtn.UseVisualStyleBackColor = false;
            retrieveBtn.Click += retrieveBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.PaleGreen;
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.Font = new Font("PT Root UI Light", 15.7499981F);
            submitBtn.Location = new Point(28, 486);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(119, 41);
            submitBtn.TabIndex = 12;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // productBox
            // 
            productBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productBox.FormattingEnabled = true;
            productBox.Items.AddRange(new object[] { "SLD-mCS", "SLD-mCS Power Supply Unit", "cBLMD", "BLL", "BLL Evaluation Unit", "DBUT Mount" });
            productBox.Location = new Point(237, 242);
            productBox.Name = "productBox";
            productBox.Size = new Size(138, 23);
            productBox.TabIndex = 11;
            // 
            // statusBox
            // 
            statusBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusBox.FormattingEnabled = true;
            statusBox.Items.AddRange(new object[] { "New", "In Production", "QC", "Ready to Ship", "Completed" });
            statusBox.Location = new Point(237, 202);
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(138, 23);
            statusBox.TabIndex = 10;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.BackColor = Color.LightSlateGray;
            productLabel.Font = new Font("PT Root UI Light", 15.7499981F);
            productLabel.Location = new Point(22, 238);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(94, 27);
            productLabel.TabIndex = 9;
            productLabel.Text = "Product:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = Color.LightSlateGray;
            statusLabel.Font = new Font("PT Root UI Light", 15.7499981F);
            statusLabel.Location = new Point(22, 196);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(80, 27);
            statusLabel.TabIndex = 8;
            statusLabel.Text = "Status:";
            // 
            // endDate
            // 
            endDate.Location = new Point(237, 158);
            endDate.Name = "endDate";
            endDate.Size = new Size(138, 23);
            endDate.TabIndex = 7;
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.BackColor = Color.LightSlateGray;
            endLabel.Font = new Font("PT Root UI Light", 15.7499981F);
            endLabel.Location = new Point(22, 154);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(203, 27);
            endLabel.TabIndex = 6;
            endLabel.Text = "Estimated End Date:";
            // 
            // startDate
            // 
            startDate.Location = new Point(237, 118);
            startDate.Name = "startDate";
            startDate.Size = new Size(138, 23);
            startDate.TabIndex = 5;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.BackColor = Color.LightSlateGray;
            startLabel.Font = new Font("PT Root UI Light", 15.7499981F);
            startLabel.Location = new Point(22, 116);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(215, 27);
            startLabel.TabIndex = 4;
            startLabel.Text = "Estimated Start Date:";
            // 
            // orderTxt
            // 
            orderTxt.Location = new Point(237, 79);
            orderTxt.Name = "orderTxt";
            orderTxt.Size = new Size(138, 23);
            orderTxt.TabIndex = 3;
            // 
            // pbPO
            // 
            pbPO.Location = new Point(3, 3);
            pbPO.Name = "pbPO";
            pbPO.Size = new Size(395, 496);
            pbPO.TabIndex = 13;
            pbPO.TabStop = false;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(pbPO);
            panel2.Location = new Point(474, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(447, 539);
            panel2.TabIndex = 14;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(520, 547);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(306, 45);
            trackBar1.TabIndex = 15;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSlateGray;
            label1.Font = new Font("PT Root UI Light", 15.7499981F);
            label1.Location = new Point(21, 291);
            label1.Name = "label1";
            label1.Size = new Size(157, 27);
            label1.TabIndex = 16;
            label1.Text = "Additional Info:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 330);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 124);
            textBox1.TabIndex = 17;
            // 
            // progressPanel
            // 
            progressPanel.Location = new Point(0, 583);
            progressPanel.Name = "progressPanel";
            progressPanel.Size = new Size(978, 52);
            progressPanel.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSlateGray;
            panel1.Location = new Point(0, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 600);
            panel1.TabIndex = 19;
            // 
            // frmProductionOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(978, 671);
            Controls.Add(progressPanel);
            Controls.Add(trackBar1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(retrieveBtn);
            Controls.Add(submitBtn);
            Controls.Add(panel2);
            Controls.Add(productBox);
            Controls.Add(statusBox);
            Controls.Add(customerTxt);
            Controls.Add(productLabel);
            Controls.Add(orderCodeLabel);
            Controls.Add(statusLabel);
            Controls.Add(customerLabel);
            Controls.Add(endDate);
            Controls.Add(orderTxt);
            Controls.Add(endLabel);
            Controls.Add(startLabel);
            Controls.Add(startDate);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductionOrder";
            Text = "frmProductionOrder";
            Load += frmProductionOrder_Load;
            ((System.ComponentModel.ISupportInitialize)pbPO).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customerLabel;
        private TextBox customerTxt;
        private Label orderCodeLabel;
        private Button retrieveBtn;
        private Button submitBtn;
        private ComboBox productBox;
        private ComboBox statusBox;
        private Label productLabel;
        private Label statusLabel;
        private DateTimePicker endDate;
        private Label endLabel;
        private DateTimePicker startDate;
        private Label startLabel;
        private TextBox orderTxt;
        private PictureBox pbPO;
        private Panel panel2;
        private TrackBar trackBar1;
        private Label label1;
        private TextBox textBox1;
        private Panel progressPanel;
        private Panel panel1;
    }
}