namespace StatsForm
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
            panel1 = new Panel();
            label1 = new Label();
            prodBtn = new Button();
            supplyBtn = new Button();
            productionStatus1 = new ProductionStatus();
            supplierData1 = new SupplierData();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(prodBtn);
            panel1.Controls.Add(supplyBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 461);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 5;
            label1.Text = "Stat Select";
            // 
            // prodBtn
            // 
            prodBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prodBtn.Location = new Point(7, 65);
            prodBtn.Name = "prodBtn";
            prodBtn.Size = new Size(130, 36);
            prodBtn.TabIndex = 2;
            prodBtn.Text = "Production";
            prodBtn.UseVisualStyleBackColor = true;
            prodBtn.Click += prodBtn_Click;
            // 
            // supplyBtn
            // 
            supplyBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplyBtn.Location = new Point(7, 107);
            supplyBtn.Name = "supplyBtn";
            supplyBtn.Size = new Size(130, 36);
            supplyBtn.TabIndex = 1;
            supplyBtn.Text = "Suppliers";
            supplyBtn.UseVisualStyleBackColor = true;
            supplyBtn.Click += supplyBtn_Click;
            // 
            // productionStatus1
            // 
            productionStatus1.Location = new Point(148, -3);
            productionStatus1.Name = "productionStatus1";
            productionStatus1.Size = new Size(386, 118);
            productionStatus1.TabIndex = 2;
            // 
            // supplierData1
            // 
            supplierData1.BackColor = SystemColors.Control;
            supplierData1.Location = new Point(148, 248);
            supplierData1.Name = "supplierData1";
            supplierData1.Size = new Size(428, 120);
            supplierData1.TabIndex = 4;
            supplierData1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(664, 461);
            Controls.Add(supplierData1);
            Controls.Add(productionStatus1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stats";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button supplyBtn;
        private Button prodBtn;
        private ProductionStatus productionStatus1;
        private SupplierData supplierData1;
        private Label label1;
    }
}
