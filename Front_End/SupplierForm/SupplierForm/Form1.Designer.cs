namespace SupplierForm
{
    partial class supplierForm
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
            panel1 = new Panel();
            deliveredCheck = new CheckBox();
            actualDateLabel = new Label();
            actualDate = new DateTimePicker();
            quantityBox = new NumericUpDown();
            quantityLabel = new Label();
            orderCodeTxt = new TextBox();
            orderCodeLabel = new Label();
            retrieveBtn = new Button();
            submitBtn = new Button();
            damageCheck = new CheckBox();
            componentList = new ListBox();
            componentBox = new ComboBox();
            componentLabel = new Label();
            estDate = new DateTimePicker();
            estDateLabel = new Label();
            orderDateLabel = new Label();
            orderDate = new DateTimePicker();
            supplierTxt = new TextBox();
            supplierLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(deliveredCheck);
            panel1.Controls.Add(actualDateLabel);
            panel1.Controls.Add(actualDate);
            panel1.Controls.Add(quantityBox);
            panel1.Controls.Add(quantityLabel);
            panel1.Controls.Add(orderCodeTxt);
            panel1.Controls.Add(orderCodeLabel);
            panel1.Controls.Add(retrieveBtn);
            panel1.Controls.Add(submitBtn);
            panel1.Controls.Add(damageCheck);
            panel1.Controls.Add(componentList);
            panel1.Controls.Add(componentBox);
            panel1.Controls.Add(componentLabel);
            panel1.Controls.Add(estDate);
            panel1.Controls.Add(estDateLabel);
            panel1.Controls.Add(orderDateLabel);
            panel1.Controls.Add(orderDate);
            panel1.Controls.Add(supplierTxt);
            panel1.Controls.Add(supplierLabel);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 450);
            panel1.TabIndex = 1;
            // 
            // deliveredCheck
            // 
            deliveredCheck.AutoSize = true;
            deliveredCheck.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveredCheck.Location = new Point(9, 309);
            deliveredCheck.Name = "deliveredCheck";
            deliveredCheck.RightToLeft = RightToLeft.Yes;
            deliveredCheck.Size = new Size(119, 34);
            deliveredCheck.TabIndex = 18;
            deliveredCheck.Text = "Delivered";
            deliveredCheck.UseVisualStyleBackColor = true;
            deliveredCheck.CheckStateChanged += deliveredCheck_CheckStateChanged;
            // 
            // actualDateLabel
            // 
            actualDateLabel.AutoSize = true;
            actualDateLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            actualDateLabel.Location = new Point(31, 406);
            actualDateLabel.Name = "actualDateLabel";
            actualDateLabel.Size = new Size(152, 30);
            actualDateLabel.TabIndex = 9;
            actualDateLabel.Text = "Actual Delivery";
            actualDateLabel.Visible = false;
            // 
            // actualDate
            // 
            actualDate.Location = new Point(220, 409);
            actualDate.Name = "actualDate";
            actualDate.Size = new Size(169, 23);
            actualDate.TabIndex = 11;
            actualDate.Visible = false;
            // 
            // quantityBox
            // 
            quantityBox.Location = new Point(198, 220);
            quantityBox.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            quantityBox.Name = "quantityBox";
            quantityBox.Size = new Size(67, 23);
            quantityBox.TabIndex = 17;
            quantityBox.ThousandsSeparator = true;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityLabel.Location = new Point(9, 212);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(86, 30);
            quantityLabel.TabIndex = 16;
            quantityLabel.Text = "Quanity";
            // 
            // orderCodeTxt
            // 
            orderCodeTxt.Location = new Point(197, 58);
            orderCodeTxt.Name = "orderCodeTxt";
            orderCodeTxt.Size = new Size(170, 23);
            orderCodeTxt.TabIndex = 15;
            // 
            // orderCodeLabel
            // 
            orderCodeLabel.AutoSize = true;
            orderCodeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderCodeLabel.Location = new Point(9, 52);
            orderCodeLabel.Name = "orderCodeLabel";
            orderCodeLabel.Size = new Size(120, 30);
            orderCodeLabel.TabIndex = 14;
            orderCodeLabel.Text = "Order Code";
            // 
            // retrieveBtn
            // 
            retrieveBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            retrieveBtn.Location = new Point(208, 354);
            retrieveBtn.Name = "retrieveBtn";
            retrieveBtn.Size = new Size(100, 40);
            retrieveBtn.TabIndex = 13;
            retrieveBtn.Text = "Retrieve";
            retrieveBtn.UseVisualStyleBackColor = true;
            retrieveBtn.Click += retrieveBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submitBtn.Location = new Point(83, 354);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(100, 40);
            submitBtn.TabIndex = 12;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // damageCheck
            // 
            damageCheck.AutoSize = true;
            damageCheck.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            damageCheck.Location = new Point(202, 309);
            damageCheck.Name = "damageCheck";
            damageCheck.RightToLeft = RightToLeft.Yes;
            damageCheck.Size = new Size(122, 34);
            damageCheck.TabIndex = 10;
            damageCheck.Text = "Damaged";
            damageCheck.UseVisualStyleBackColor = true;
            damageCheck.Visible = false;
            // 
            // componentList
            // 
            componentList.FormattingEnabled = true;
            componentList.ItemHeight = 15;
            componentList.Location = new Point(198, 136);
            componentList.Name = "componentList";
            componentList.Size = new Size(169, 79);
            componentList.TabIndex = 8;
            componentList.Visible = false;
            componentList.SelectedIndexChanged += componentList_SelectedIndexChanged;
            // 
            // componentBox
            // 
            componentBox.FormattingEnabled = true;
            componentBox.Items.AddRange(new object[] { "SLD-mCS", "cBLMD", "BLL", "DBUT Mount" });
            componentBox.Location = new Point(197, 113);
            componentBox.Name = "componentBox";
            componentBox.Size = new Size(170, 23);
            componentBox.TabIndex = 7;
            componentBox.TextChanged += componentBox_TextChanged;
            // 
            // componentLabel
            // 
            componentLabel.AutoSize = true;
            componentLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            componentLabel.Location = new Point(9, 104);
            componentLabel.Name = "componentLabel";
            componentLabel.Size = new Size(122, 30);
            componentLabel.TabIndex = 6;
            componentLabel.Text = "Component";
            // 
            // estDate
            // 
            estDate.Location = new Point(198, 277);
            estDate.Name = "estDate";
            estDate.Size = new Size(169, 23);
            estDate.TabIndex = 5;
            // 
            // estDateLabel
            // 
            estDateLabel.AutoSize = true;
            estDateLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            estDateLabel.Location = new Point(9, 272);
            estDateLabel.Name = "estDateLabel";
            estDateLabel.Size = new Size(184, 30);
            estDateLabel.TabIndex = 4;
            estDateLabel.Text = "Estimated Delivery";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderDateLabel.Location = new Point(9, 242);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new Size(116, 30);
            orderDateLabel.TabIndex = 3;
            orderDateLabel.Text = "Order Date";
            // 
            // orderDate
            // 
            orderDate.Location = new Point(198, 248);
            orderDate.Name = "orderDate";
            orderDate.Size = new Size(169, 23);
            orderDate.TabIndex = 2;
            // 
            // supplierTxt
            // 
            supplierTxt.Location = new Point(197, 15);
            supplierTxt.Name = "supplierTxt";
            supplierTxt.Size = new Size(170, 23);
            supplierTxt.TabIndex = 1;
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplierLabel.Location = new Point(9, 8);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new Size(88, 30);
            supplierLabel.TabIndex = 0;
            supplierLabel.Text = "Supplier";
            // 
            // supplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 454);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "supplierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supplier";
            Load += supplierForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DateTimePicker orderDate;
        private TextBox supplierTxt;
        private Label estDateLabel;
        private Label orderDateLabel;
        private ComboBox componentBox;
        private Label componentLabel;
        private DateTimePicker estDate;
        private Label supplierLabel;
        private ListBox componentList;
        private DateTimePicker actualDate;
        private CheckBox damageCheck;
        private Label actualDateLabel;
        private Button retrieveBtn;
        private Button submitBtn;
        private TextBox orderCodeTxt;
        private Label orderCodeLabel;
        private Label quantityLabel;
        private NumericUpDown quantityBox;
        private CheckBox deliveredCheck;
    }
}
