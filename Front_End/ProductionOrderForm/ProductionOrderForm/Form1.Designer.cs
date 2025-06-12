namespace ProductionOrderForm
{
    partial class productionOrderForm
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
            customerLabel = new Label();
            customerTxt = new TextBox();
            orderCodeLabel = new Label();
            panel1 = new Panel();
            quantityNum = new NumericUpDown();
            quantityLabel = new Label();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNum).BeginInit();
            SuspendLayout();
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerLabel.Location = new Point(11, 8);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(102, 30);
            customerLabel.TabIndex = 0;
            customerLabel.Text = "Customer";
            // 
            // customerTxt
            // 
            customerTxt.Location = new Point(219, 12);
            customerTxt.Name = "customerTxt";
            customerTxt.Size = new Size(138, 23);
            customerTxt.TabIndex = 1;
            // 
            // orderCodeLabel
            // 
            orderCodeLabel.AutoSize = true;
            orderCodeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderCodeLabel.Location = new Point(11, 38);
            orderCodeLabel.Name = "orderCodeLabel";
            orderCodeLabel.Size = new Size(120, 30);
            orderCodeLabel.TabIndex = 2;
            orderCodeLabel.Text = "Order Code";
            // 
            // panel1
            // 
            panel1.Controls.Add(quantityNum);
            panel1.Controls.Add(quantityLabel);
            panel1.Controls.Add(retrieveBtn);
            panel1.Controls.Add(submitBtn);
            panel1.Controls.Add(productBox);
            panel1.Controls.Add(statusBox);
            panel1.Controls.Add(productLabel);
            panel1.Controls.Add(statusLabel);
            panel1.Controls.Add(endDate);
            panel1.Controls.Add(endLabel);
            panel1.Controls.Add(startDate);
            panel1.Controls.Add(startLabel);
            panel1.Controls.Add(orderTxt);
            panel1.Controls.Add(customerLabel);
            panel1.Controls.Add(customerTxt);
            panel1.Controls.Add(orderCodeLabel);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 280);
            panel1.TabIndex = 3;
            // 
            // quantityNum
            // 
            quantityNum.Location = new Point(246, 198);
            quantityNum.Name = "quantityNum";
            quantityNum.Size = new Size(81, 23);
            quantityNum.TabIndex = 15;
            quantityNum.TextAlign = HorizontalAlignment.Center;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityLabel.Location = new Point(11, 188);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(93, 30);
            quantityLabel.TabIndex = 14;
            quantityLabel.Text = "Quantity";
            // 
            // retrieveBtn
            // 
            retrieveBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            retrieveBtn.Location = new Point(186, 231);
            retrieveBtn.Name = "retrieveBtn";
            retrieveBtn.Size = new Size(119, 41);
            retrieveBtn.TabIndex = 13;
            retrieveBtn.Text = "Retrieve";
            retrieveBtn.UseVisualStyleBackColor = true;
            retrieveBtn.Click += retrieveBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submitBtn.Location = new Point(46, 231);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(119, 41);
            submitBtn.TabIndex = 12;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // productBox
            // 
            productBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productBox.FormattingEnabled = true;
            productBox.Items.AddRange(new object[] { "SLD-mCS", "SLD-mCS Power Supply Unit", "cBLMD", "BLL", "BLL Evaluation Unit", "DBUT Mount" });
            productBox.Location = new Point(219, 162);
            productBox.Name = "productBox";
            productBox.Size = new Size(138, 23);
            productBox.TabIndex = 11;
            productBox.SelectedIndexChanged += productBox_SelectedIndexChanged;
            // 
            // statusBox
            // 
            statusBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusBox.FormattingEnabled = true;
            statusBox.Items.AddRange(new object[] { "New", "In progress", "Completed" });
            statusBox.Location = new Point(219, 132);
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(138, 23);
            statusBox.TabIndex = 10;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productLabel.Location = new Point(11, 158);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(85, 30);
            productLabel.TabIndex = 9;
            productLabel.Text = "Product";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabel.Location = new Point(11, 128);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(69, 30);
            statusLabel.TabIndex = 8;
            statusLabel.Text = "Status";
            // 
            // endDate
            // 
            endDate.Location = new Point(219, 101);
            endDate.Name = "endDate";
            endDate.Size = new Size(138, 23);
            endDate.TabIndex = 7;
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endLabel.Location = new Point(11, 98);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(195, 30);
            endLabel.TabIndex = 6;
            endLabel.Text = "Estimated End Date";
            // 
            // startDate
            // 
            startDate.Location = new Point(219, 70);
            startDate.Name = "startDate";
            startDate.Size = new Size(138, 23);
            startDate.TabIndex = 5;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startLabel.Location = new Point(11, 68);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(202, 30);
            startLabel.TabIndex = 4;
            startLabel.Text = "Estimated Start Date";
            // 
            // orderTxt
            // 
            orderTxt.Location = new Point(219, 41);
            orderTxt.Name = "orderTxt";
            orderTxt.Size = new Size(138, 23);
            orderTxt.TabIndex = 3;
            // 
            // productionOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 288);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "productionOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Production Order";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label customerLabel;
        private TextBox customerTxt;
        private Label orderCodeLabel;
        private Panel panel1;
        private Label endLabel;
        private DateTimePicker startDate;
        private Label startLabel;
        private TextBox orderTxt;
        private ComboBox productBox;
        private ComboBox statusBox;
        private Label productLabel;
        private Label statusLabel;
        private DateTimePicker endDate;
        private Button submitBtn;
        private Button retrieveBtn;
        private NumericUpDown quantityNum;
        private Label quantityLabel;
    }
}
