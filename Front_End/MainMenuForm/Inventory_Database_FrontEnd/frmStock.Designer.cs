namespace Inventory_Database_FrontEnd
{
    partial class frmStock
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAddtoStock = new Button();
            label6 = new Label();
            cmbComponent = new ComboBox();
            cmbLocation = new ComboBox();
            txtAmount = new TextBox();
            cmbSupplier = new ComboBox();
            txtSearchforComp = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 134);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 0;
            label1.Text = "Component";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(329, 134);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 1;
            label2.Text = "Amount in Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(262, 30);
            label3.Name = "label3";
            label3.Size = new Size(202, 25);
            label3.TabIndex = 2;
            label3.Text = "Search for Component";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 273);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 3;
            label4.Text = "Location";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(364, 273);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 4;
            label5.Text = "Supplier";
            // 
            // btnAddtoStock
            // 
            btnAddtoStock.Location = new Point(34, 417);
            btnAddtoStock.Name = "btnAddtoStock";
            btnAddtoStock.Size = new Size(132, 51);
            btnAddtoStock.TabIndex = 5;
            btnAddtoStock.Text = "Add to Stock";
            btnAddtoStock.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(229, 370);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 6;
            label6.Text = "Latest Update";
            // 
            // cmbComponent
            // 
            cmbComponent.FormattingEnabled = true;
            cmbComponent.Location = new Point(34, 162);
            cmbComponent.Name = "cmbComponent";
            cmbComponent.Size = new Size(215, 23);
            cmbComponent.TabIndex = 7;
            // 
            // cmbLocation
            // 
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(34, 301);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(215, 23);
            cmbLocation.TabIndex = 8;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(379, 162);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(46, 23);
            txtAmount.TabIndex = 9;
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(329, 301);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(149, 23);
            cmbSupplier.TabIndex = 10;
            // 
            // txtSearchforComp
            // 
            txtSearchforComp.Location = new Point(481, 33);
            txtSearchforComp.Name = "txtSearchforComp";
            txtSearchforComp.Size = new Size(291, 23);
            txtSearchforComp.TabIndex = 11;
            // 
            // frmStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(866, 498);
            Controls.Add(txtSearchforComp);
            Controls.Add(cmbSupplier);
            Controls.Add(txtAmount);
            Controls.Add(cmbLocation);
            Controls.Add(cmbComponent);
            Controls.Add(label6);
            Controls.Add(btnAddtoStock);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmStock";
            Text = "frmStock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAddtoStock;
        private Label label6;
        private ComboBox cmbComponent;
        private ComboBox cmbLocation;
        private TextBox txtAmount;
        private ComboBox cmbSupplier;
        private TextBox txtSearchforComp;
    }
}