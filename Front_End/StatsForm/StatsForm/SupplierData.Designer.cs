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
            leadNum = new Label();
            leadLabel = new Label();
            deliverNum = new Label();
            deliveryLabel = new Label();
            button1 = new Button();
            supplierBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(leadNum);
            panel1.Controls.Add(leadLabel);
            panel1.Controls.Add(deliverNum);
            panel1.Controls.Add(deliveryLabel);
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
            // leadNum
            // 
            leadNum.AutoSize = true;
            leadNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leadNum.Location = new Point(121, 159);
            leadNum.Name = "leadNum";
            leadNum.Size = new Size(45, 21);
            leadNum.TabIndex = 7;
            leadNum.Text = "Num";
            leadNum.Visible = false;
            // 
            // leadLabel
            // 
            leadLabel.AutoSize = true;
            leadLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            leadLabel.Location = new Point(4, 159);
            leadLabel.Name = "leadLabel";
            leadLabel.Size = new Size(122, 21);
            leadLabel.TabIndex = 6;
            leadLabel.Text = "Avg Lead Time:";
            // 
            // deliverNum
            // 
            deliverNum.AutoSize = true;
            deliverNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliverNum.Location = new Point(121, 122);
            deliverNum.Name = "deliverNum";
            deliverNum.Size = new Size(45, 21);
            deliverNum.TabIndex = 5;
            deliverNum.Text = "Num";
            deliverNum.Visible = false;
            // 
            // deliveryLabel
            // 
            deliveryLabel.AutoSize = true;
            deliveryLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryLabel.Location = new Point(4, 122);
            deliveryLabel.Name = "deliveryLabel";
            deliveryLabel.Size = new Size(85, 21);
            deliveryLabel.TabIndex = 4;
            deliveryLabel.Text = "Deliveries:";
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
        private Label leadNum;
        private Label leadLabel;
        private Label deliverNum;
        private Label deliveryLabel;
    }
}
