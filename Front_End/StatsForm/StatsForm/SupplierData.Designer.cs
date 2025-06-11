namespace StatsForm
{
    partial class SupplierData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            suppLeadNum = new Label();
            suppLeadLabel = new Label();
            suppDelivNum = new Label();
            suppDeliveryLabel = new Label();
            button1 = new Button();
            supplierBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label3 = new Label();
            compBox = new ComboBox();
            compDelivLabel = new Label();
            compLeadLabel = new Label();
            compLeadNum = new Label();
            compDelivNum = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(compDelivNum);
            panel1.Controls.Add(compLeadNum);
            panel1.Controls.Add(compLeadLabel);
            panel1.Controls.Add(compDelivLabel);
            panel1.Controls.Add(compBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(suppLeadNum);
            panel1.Controls.Add(suppLeadLabel);
            panel1.Controls.Add(suppDelivNum);
            panel1.Controls.Add(suppDeliveryLabel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(supplierBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 500);
            panel1.TabIndex = 0;
            // 
            // suppLeadNum
            // 
            suppLeadNum.AutoSize = true;
            suppLeadNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            suppLeadNum.Location = new Point(121, 159);
            suppLeadNum.Name = "suppLeadNum";
            suppLeadNum.Size = new Size(45, 21);
            suppLeadNum.TabIndex = 7;
            suppLeadNum.Text = "Num";
            suppLeadNum.Visible = false;
            // 
            // suppLeadLabel
            // 
            suppLeadLabel.AutoSize = true;
            suppLeadLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suppLeadLabel.Location = new Point(4, 159);
            suppLeadLabel.Name = "suppLeadLabel";
            suppLeadLabel.Size = new Size(122, 21);
            suppLeadLabel.TabIndex = 6;
            suppLeadLabel.Text = "Avg Lead Time:";
            // 
            // suppDelivNum
            // 
            suppDelivNum.AutoSize = true;
            suppDelivNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            suppDelivNum.Location = new Point(121, 122);
            suppDelivNum.Name = "suppDelivNum";
            suppDelivNum.Size = new Size(45, 21);
            suppDelivNum.TabIndex = 5;
            suppDelivNum.Text = "Num";
            suppDelivNum.Visible = false;
            // 
            // suppDeliveryLabel
            // 
            suppDeliveryLabel.AutoSize = true;
            suppDeliveryLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suppDeliveryLabel.Location = new Point(4, 122);
            suppDeliveryLabel.Name = "suppDeliveryLabel";
            suppDeliveryLabel.Size = new Size(85, 21);
            suppDeliveryLabel.TabIndex = 4;
            suppDeliveryLabel.Text = "Deliveries:";
            // 
            // button1
            // 
            button1.Location = new Point(108, 426);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // supplierBox
            // 
            supplierBox.FormattingEnabled = true;
            supplierBox.Location = new Point(22, 76);
            supplierBox.Name = "supplierBox";
            supplierBox.Size = new Size(121, 23);
            supplierBox.TabIndex = 2;
            supplierBox.SelectedIndexChanged += supplierBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 43);
            label2.Name = "label2";
            label2.Size = new Size(91, 30);
            label2.TabIndex = 1;
            label2.Text = "Supplier";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 0;
            label1.Text = "Lead Time Avg";
            // 
            // cartesianChart1
            // 
            cartesianChart1.BackColor = Color.SeaShell;
            cartesianChart1.Location = new Point(190, 0);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(752, 475);
            cartesianChart1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 199);
            label3.Name = "label3";
            label3.Size = new Size(127, 30);
            label3.TabIndex = 8;
            label3.Text = "Component";
            // 
            // compBox
            // 
            compBox.FormattingEnabled = true;
            compBox.Location = new Point(22, 232);
            compBox.Name = "compBox";
            compBox.Size = new Size(121, 23);
            compBox.TabIndex = 9;
            compBox.SelectedIndexChanged += compBox_SelectedIndexChanged;
            // 
            // compDelivLabel
            // 
            compDelivLabel.AutoSize = true;
            compDelivLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            compDelivLabel.Location = new Point(4, 277);
            compDelivLabel.Name = "compDelivLabel";
            compDelivLabel.Size = new Size(85, 21);
            compDelivLabel.TabIndex = 10;
            compDelivLabel.Text = "Deliveries:";
            // 
            // compLeadLabel
            // 
            compLeadLabel.AutoSize = true;
            compLeadLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            compLeadLabel.Location = new Point(4, 317);
            compLeadLabel.Name = "compLeadLabel";
            compLeadLabel.Size = new Size(122, 21);
            compLeadLabel.TabIndex = 11;
            compLeadLabel.Text = "Avg Lead Time:";
            // 
            // compLeadNum
            // 
            compLeadNum.AutoSize = true;
            compLeadNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            compLeadNum.Location = new Point(121, 317);
            compLeadNum.Name = "compLeadNum";
            compLeadNum.Size = new Size(45, 21);
            compLeadNum.TabIndex = 12;
            compLeadNum.Text = "Num";
            compLeadNum.Visible = false;
            // 
            // compDelivNum
            // 
            compDelivNum.AutoSize = true;
            compDelivNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            compDelivNum.Location = new Point(121, 277);
            compDelivNum.Name = "compDelivNum";
            compDelivNum.Size = new Size(45, 21);
            compDelivNum.TabIndex = 13;
            compDelivNum.Text = "Num";
            compDelivNum.Visible = false;
            // 
            // SupplierData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(cartesianChart1);
            Controls.Add(panel1);
            Name = "SupplierData";
            Size = new Size(960, 500);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private ComboBox supplierBox;
        private Label label2;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Label suppLeadNum;
        private Label suppLeadLabel;
        private Label suppDelivNum;
        private Label suppDeliveryLabel;
        private Label compDelivNum;
        private Label compLeadNum;
        private Label compLeadLabel;
        private Label compDelivLabel;
        private ComboBox compBox;
        private Label label3;
    }
}
