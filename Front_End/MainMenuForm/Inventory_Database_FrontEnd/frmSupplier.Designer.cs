namespace Inventory_Database_FrontEnd
{
    partial class frmSupplier
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
            supplierLabel = new Label();
            supplierTxt = new TextBox();
            orderDate = new DateTimePicker();
            orderDateLabel = new Label();
            estDateLabel = new Label();
            estDate = new DateTimePicker();
            componentLabel = new Label();
            componentBox = new ComboBox();
            componentList = new ListBox();
            damageCheck = new CheckBox();
            submitBtn = new Button();
            retrieveBtn = new Button();
            orderCodeLabel = new Label();
            orderCodeTxt = new TextBox();
            quantityLabel = new Label();
            quantityBox = new NumericUpDown();
            actualDate = new DateTimePicker();
            actualDateLabel = new Label();
            deliveredCheck = new CheckBox();
            compDelivNum = new Label();
            compLeadNum = new Label();
            compLeadLabel = new Label();
            compDelivLabel = new Label();
            compBox = new ComboBox();
            label3 = new Label();
            suppLeadNum = new Label();
            suppLeadLabel = new Label();
            suppDelivNum = new Label();
            suppDeliveryLabel = new Label();
            button1 = new Button();
            supplierBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            ((System.ComponentModel.ISupportInitialize)quantityBox).BeginInit();
            SuspendLayout();
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplierLabel.Location = new Point(36, 38);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new Size(97, 27);
            supplierLabel.TabIndex = 0;
            supplierLabel.Text = "Supplier:";
            // 
            // supplierTxt
            // 
            supplierTxt.Location = new Point(165, 42);
            supplierTxt.Name = "supplierTxt";
            supplierTxt.Size = new Size(170, 23);
            supplierTxt.TabIndex = 1;
            // 
            // orderDate
            // 
            orderDate.Location = new Point(165, 263);
            orderDate.Name = "orderDate";
            orderDate.Size = new Size(169, 23);
            orderDate.TabIndex = 2;
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderDateLabel.Location = new Point(23, 260);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new Size(121, 27);
            orderDateLabel.TabIndex = 3;
            orderDateLabel.Text = "Order Date:";
            // 
            // estDateLabel
            // 
            estDateLabel.AutoSize = true;
            estDateLabel.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            estDateLabel.Location = new Point(6, 315);
            estDateLabel.Name = "estDateLabel";
            estDateLabel.Size = new Size(137, 27);
            estDateLabel.TabIndex = 4;
            estDateLabel.Text = "Est. Delivery:";
            // 
            // estDate
            // 
            estDate.Location = new Point(165, 318);
            estDate.Name = "estDate";
            estDate.Size = new Size(169, 23);
            estDate.TabIndex = 5;
            // 
            // componentLabel
            // 
            componentLabel.AutoSize = true;
            componentLabel.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            componentLabel.Location = new Point(6, 149);
            componentLabel.Name = "componentLabel";
            componentLabel.Size = new Size(129, 27);
            componentLabel.TabIndex = 6;
            componentLabel.Text = "Component:";
            // 
            // componentBox
            // 
            componentBox.FormattingEnabled = true;
            componentBox.Items.AddRange(new object[] { "SLD-mCS", "cBLMD", "BLL", "DBUT Mount" });
            componentBox.Location = new Point(165, 155);
            componentBox.Name = "componentBox";
            componentBox.Size = new Size(170, 23);
            componentBox.TabIndex = 7;
            componentBox.TextChanged += componentBox_TextChanged;
            // 
            // componentList
            // 
            componentList.FormattingEnabled = true;
            componentList.ItemHeight = 15;
            componentList.Location = new Point(165, 178);
            componentList.Name = "componentList";
            componentList.Size = new Size(169, 79);
            componentList.TabIndex = 8;
            componentList.Visible = false;
            componentList.SelectedIndexChanged += componentList_SelectedIndexChanged;
            // 
            // damageCheck
            // 
            damageCheck.AutoSize = true;
            damageCheck.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            damageCheck.Location = new Point(213, 417);
            damageCheck.Name = "damageCheck";
            damageCheck.RightToLeft = RightToLeft.Yes;
            damageCheck.Size = new Size(122, 34);
            damageCheck.TabIndex = 10;
            damageCheck.Text = "Damaged";
            damageCheck.UseVisualStyleBackColor = true;
            damageCheck.Visible = false;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.PaleGreen;
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submitBtn.Location = new Point(32, 574);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(100, 40);
            submitBtn.TabIndex = 12;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // retrieveBtn
            // 
            retrieveBtn.BackColor = Color.LightSalmon;
            retrieveBtn.FlatStyle = FlatStyle.Flat;
            retrieveBtn.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            retrieveBtn.Location = new Point(233, 574);
            retrieveBtn.Name = "retrieveBtn";
            retrieveBtn.Size = new Size(100, 40);
            retrieveBtn.TabIndex = 13;
            retrieveBtn.Text = "Retrieve";
            retrieveBtn.UseVisualStyleBackColor = false;
            retrieveBtn.Click += retrieveBtn_Click;
            // 
            // orderCodeLabel
            // 
            orderCodeLabel.AutoSize = true;
            orderCodeLabel.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderCodeLabel.Location = new Point(6, 90);
            orderCodeLabel.Name = "orderCodeLabel";
            orderCodeLabel.Size = new Size(126, 27);
            orderCodeLabel.TabIndex = 14;
            orderCodeLabel.Text = "Order Code:";
            // 
            // orderCodeTxt
            // 
            orderCodeTxt.Location = new Point(165, 94);
            orderCodeTxt.Name = "orderCodeTxt";
            orderCodeTxt.Size = new Size(170, 23);
            orderCodeTxt.TabIndex = 15;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityLabel.Location = new Point(52, 367);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(92, 27);
            quantityLabel.TabIndex = 16;
            quantityLabel.Text = "Quanity:";
            // 
            // quantityBox
            // 
            quantityBox.Location = new Point(266, 371);
            quantityBox.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            quantityBox.Name = "quantityBox";
            quantityBox.Size = new Size(67, 23);
            quantityBox.TabIndex = 17;
            quantityBox.ThousandsSeparator = true;
            // 
            // actualDate
            // 
            actualDate.Location = new Point(165, 342);
            actualDate.Name = "actualDate";
            actualDate.Size = new Size(169, 23);
            actualDate.TabIndex = 11;
            actualDate.Visible = false;
            // 
            // actualDateLabel
            // 
            actualDateLabel.AutoSize = true;
            actualDateLabel.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            actualDateLabel.Location = new Point(8, 342);
            actualDateLabel.Name = "actualDateLabel";
            actualDateLabel.Size = new Size(136, 27);
            actualDateLabel.TabIndex = 9;
            actualDateLabel.Text = "Delivered on:";
            actualDateLabel.Visible = false;
            // 
            // deliveredCheck
            // 
            deliveredCheck.AutoSize = true;
            deliveredCheck.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveredCheck.Location = new Point(15, 417);
            deliveredCheck.Name = "deliveredCheck";
            deliveredCheck.RightToLeft = RightToLeft.Yes;
            deliveredCheck.Size = new Size(119, 34);
            deliveredCheck.TabIndex = 18;
            deliveredCheck.Text = "Delivered";
            deliveredCheck.UseVisualStyleBackColor = true;
            deliveredCheck.CheckStateChanged += deliveredCheck_CheckStateChanged;
            // 
            // compDelivNum
            // 
            compDelivNum.AutoSize = true;
            compDelivNum.Font = new Font("PT Root UI Light", 11.9999981F);
            compDelivNum.Location = new Point(898, 115);
            compDelivNum.Name = "compDelivNum";
            compDelivNum.Size = new Size(43, 20);
            compDelivNum.TabIndex = 13;
            compDelivNum.Text = "Num";
            compDelivNum.Visible = false;
            // 
            // compLeadNum
            // 
            compLeadNum.AutoSize = true;
            compLeadNum.Font = new Font("PT Root UI Light", 11.9999981F);
            compLeadNum.Location = new Point(898, 155);
            compLeadNum.Name = "compLeadNum";
            compLeadNum.Size = new Size(43, 20);
            compLeadNum.TabIndex = 12;
            compLeadNum.Text = "Num";
            compLeadNum.Visible = false;
            // 
            // compLeadLabel
            // 
            compLeadLabel.AutoSize = true;
            compLeadLabel.Font = new Font("PT Root UI Light", 11.9999981F);
            compLeadLabel.Location = new Point(723, 151);
            compLeadLabel.Name = "compLeadLabel";
            compLeadLabel.Size = new Size(119, 20);
            compLeadLabel.TabIndex = 11;
            compLeadLabel.Text = "Avg Lead Time:";
            // 
            // compDelivLabel
            // 
            compDelivLabel.AutoSize = true;
            compDelivLabel.Font = new Font("PT Root UI Light", 11.9999981F);
            compDelivLabel.Location = new Point(755, 115);
            compDelivLabel.Name = "compDelivLabel";
            compDelivLabel.Size = new Size(87, 20);
            compDelivLabel.TabIndex = 10;
            compDelivLabel.Text = "Deliveries:";
            // 
            // compBox
            // 
            compBox.FormattingEnabled = true;
            compBox.Location = new Point(843, 71);
            compBox.Name = "compBox";
            compBox.Size = new Size(138, 23);
            compBox.TabIndex = 9;
            compBox.SelectedIndexChanged += compBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(852, 38);
            label3.Name = "label3";
            label3.Size = new Size(129, 27);
            label3.TabIndex = 8;
            label3.Text = "Component:";
            // 
            // suppLeadNum
            // 
            suppLeadNum.AutoSize = true;
            suppLeadNum.Font = new Font("PT Root UI Light", 11.9999981F);
            suppLeadNum.Location = new Point(608, 151);
            suppLeadNum.Name = "suppLeadNum";
            suppLeadNum.Size = new Size(43, 20);
            suppLeadNum.TabIndex = 7;
            suppLeadNum.Text = "Num";
            suppLeadNum.Visible = false;
            // 
            // suppLeadLabel
            // 
            suppLeadLabel.AutoSize = true;
            suppLeadLabel.Font = new Font("PT Root UI Light", 11.9999981F);
            suppLeadLabel.Location = new Point(460, 151);
            suppLeadLabel.Name = "suppLeadLabel";
            suppLeadLabel.Size = new Size(119, 20);
            suppLeadLabel.TabIndex = 6;
            suppLeadLabel.Text = "Avg Lead Time:";
            // 
            // suppDelivNum
            // 
            suppDelivNum.AutoSize = true;
            suppDelivNum.Font = new Font("PT Root UI Light", 11.9999981F);
            suppDelivNum.Location = new Point(608, 115);
            suppDelivNum.Name = "suppDelivNum";
            suppDelivNum.Size = new Size(43, 20);
            suppDelivNum.TabIndex = 5;
            suppDelivNum.Text = "Num";
            suppDelivNum.Visible = false;
            // 
            // suppDeliveryLabel
            // 
            suppDeliveryLabel.AutoSize = true;
            suppDeliveryLabel.Font = new Font("PT Root UI Light", 11.9999981F);
            suppDeliveryLabel.Location = new Point(460, 115);
            suppDeliveryLabel.Name = "suppDeliveryLabel";
            suppDeliveryLabel.Size = new Size(87, 20);
            suppDeliveryLabel.TabIndex = 4;
            suppDeliveryLabel.Text = "Deliveries:";
            // 
            // button1
            // 
            button1.Location = new Point(948, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            // 
            // supplierBox
            // 
            supplierBox.FormattingEnabled = true;
            supplierBox.Location = new Point(460, 71);
            supplierBox.Name = "supplierBox";
            supplierBox.Size = new Size(138, 23);
            supplierBox.TabIndex = 2;
            supplierBox.SelectedIndexChanged += supplierBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PT Root UI Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(481, 42);
            label2.Name = "label2";
            label2.Size = new Size(97, 27);
            label2.TabIndex = 1;
            label2.Text = "Supplier:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(641, 4);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 0;
            label1.Text = "Lead Time Avg";
            // 
            // cartesianChart1
            // 
            cartesianChart1.BackColor = Color.AliceBlue;
            cartesianChart1.Location = new Point(393, 178);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(618, 463);
            cartesianChart1.TabIndex = 20;
            // 
            // frmSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1023, 707);
            Controls.Add(compDelivNum);
            Controls.Add(cartesianChart1);
            Controls.Add(compLeadNum);
            Controls.Add(compLeadLabel);
            Controls.Add(deliveredCheck);
            Controls.Add(compDelivLabel);
            Controls.Add(actualDateLabel);
            Controls.Add(compBox);
            Controls.Add(orderCodeLabel);
            Controls.Add(label3);
            Controls.Add(actualDate);
            Controls.Add(suppLeadNum);
            Controls.Add(supplierLabel);
            Controls.Add(suppLeadLabel);
            Controls.Add(quantityBox);
            Controls.Add(suppDelivNum);
            Controls.Add(supplierTxt);
            Controls.Add(suppDeliveryLabel);
            Controls.Add(quantityLabel);
            Controls.Add(button1);
            Controls.Add(orderDate);
            Controls.Add(supplierBox);
            Controls.Add(orderCodeTxt);
            Controls.Add(label2);
            Controls.Add(orderDateLabel);
            Controls.Add(label1);
            Controls.Add(estDateLabel);
            Controls.Add(retrieveBtn);
            Controls.Add(estDate);
            Controls.Add(submitBtn);
            Controls.Add(componentLabel);
            Controls.Add(damageCheck);
            Controls.Add(componentBox);
            Controls.Add(componentList);
            Name = "frmSupplier";
            Text = "frmSupplier";
            Load += frmSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)quantityBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label supplierLabel;
        private TextBox supplierTxt;
        private DateTimePicker orderDate;
        private Label orderDateLabel;
        private Label estDateLabel;
        private DateTimePicker estDate;
        private Label componentLabel;
        private ComboBox componentBox;
        private ListBox componentList;
        private CheckBox damageCheck;
        private Button submitBtn;
        private Button retrieveBtn;
        private Label orderCodeLabel;
        private TextBox orderCodeTxt;
        private Label quantityLabel;
        private NumericUpDown quantityBox;
        private DateTimePicker actualDate;
        private Label actualDateLabel;
        private CheckBox deliveredCheck;
        private Label compDelivNum;
        private Label compLeadNum;
        private Label compLeadLabel;
        private Label compDelivLabel;
        private ComboBox compBox;
        private Label label3;
        private Label suppLeadNum;
        private Label suppLeadLabel;
        private Label suppDelivNum;
        private Label suppDeliveryLabel;
        private Button button1;
        private ComboBox supplierBox;
        private Label label2;
        private Label label1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
    }
}