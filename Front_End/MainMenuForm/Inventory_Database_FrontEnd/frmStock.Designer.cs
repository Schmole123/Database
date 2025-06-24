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
            label4 = new Label();
            label5 = new Label();
            btnAddtoStock = new Button();
            label6 = new Label();
            cmbComponent = new ComboBox();
            cmbLocation = new ComboBox();
            txtAmount = new TextBox();
            cmbSupplier = new ComboBox();
            txtLastUpdate = new TextBox();
            lblProductCode = new Label();
            txtProductCode = new TextBox();
            lblAddNewComp = new Label();
            panelRackView = new Panel();
            cmbRackSelector = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PT Root UI Light", 14.25F);
            label1.Location = new Point(13, 29);
            label1.Name = "label1";
            label1.Size = new Size(116, 24);
            label1.TabIndex = 0;
            label1.Text = "Component:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PT Root UI Light", 14.25F);
            label2.Location = new Point(10, 345);
            label2.Name = "label2";
            label2.Size = new Size(160, 24);
            label2.TabIndex = 1;
            label2.Text = "Amount in Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("PT Root UI Light", 14.25F);
            label4.Location = new Point(12, 118);
            label4.Name = "label4";
            label4.Size = new Size(89, 24);
            label4.TabIndex = 3;
            label4.Text = "Location:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PT Root UI Light", 14.25F);
            label5.Location = new Point(10, 272);
            label5.Name = "label5";
            label5.Size = new Size(89, 24);
            label5.TabIndex = 4;
            label5.Text = "Supplier:";
            // 
            // btnAddtoStock
            // 
            btnAddtoStock.BackColor = Color.MediumSeaGreen;
            btnAddtoStock.Font = new Font("PT Root UI Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddtoStock.Location = new Point(9, 429);
            btnAddtoStock.Name = "btnAddtoStock";
            btnAddtoStock.Size = new Size(162, 62);
            btnAddtoStock.TabIndex = 5;
            btnAddtoStock.Text = "Add to Stock";
            btnAddtoStock.UseVisualStyleBackColor = false;
            btnAddtoStock.Click += btnAddtoStock_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 528);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 6;
            label6.Text = "Last Update:";
            // 
            // cmbComponent
            // 
            cmbComponent.FormattingEnabled = true;
            cmbComponent.Location = new Point(15, 57);
            cmbComponent.Name = "cmbComponent";
            cmbComponent.Size = new Size(215, 23);
            cmbComponent.TabIndex = 7;
            cmbComponent.SelectedIndexChanged += cmbComponent_SelectedIndexChanged;
            // 
            // cmbLocation
            // 
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(12, 146);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(215, 23);
            cmbLocation.TabIndex = 8;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(12, 388);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(46, 23);
            txtAmount.TabIndex = 9;
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(12, 300);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(149, 23);
            cmbSupplier.TabIndex = 10;
            // 
            // txtLastUpdate
            // 
            txtLastUpdate.Location = new Point(12, 546);
            txtLastUpdate.Name = "txtLastUpdate";
            txtLastUpdate.Size = new Size(215, 23);
            txtLastUpdate.TabIndex = 12;
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Font = new Font("PT Root UI Light", 14.25F);
            lblProductCode.Location = new Point(12, 197);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(132, 24);
            lblProductCode.TabIndex = 13;
            lblProductCode.Text = "Product Code:";
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(12, 225);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(215, 23);
            txtProductCode.TabIndex = 14;
            // 
            // lblAddNewComp
            // 
            lblAddNewComp.AutoSize = true;
            lblAddNewComp.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAddNewComp.ForeColor = Color.Teal;
            lblAddNewComp.Location = new Point(69, 87);
            lblAddNewComp.Name = "lblAddNewComp";
            lblAddNewComp.Size = new Size(91, 13);
            lblAddNewComp.TabIndex = 15;
            lblAddNewComp.Text = "New Component?";
            lblAddNewComp.Click += lblAddNewComp_Click;
            // 
            // panelRackView
            // 
            panelRackView.BackColor = Color.Transparent;
            panelRackView.Location = new Point(273, 13);
            panelRackView.Name = "panelRackView";
            panelRackView.Size = new Size(710, 489);
            panelRackView.TabIndex = 16;
            // 
            // cmbRackSelector
            // 
            cmbRackSelector.FormattingEnabled = true;
            cmbRackSelector.Items.AddRange(new object[] { "SLD-mCS", "cBLMD", "BLL", "Other" });
            cmbRackSelector.Location = new Point(575, 534);
            cmbRackSelector.Name = "cmbRackSelector";
            cmbRackSelector.Size = new Size(121, 23);
            cmbRackSelector.TabIndex = 17;
            // 
            // frmStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1001, 581);
            Controls.Add(cmbRackSelector);
            Controls.Add(panelRackView);
            Controls.Add(lblAddNewComp);
            Controls.Add(txtProductCode);
            Controls.Add(lblProductCode);
            Controls.Add(txtLastUpdate);
            Controls.Add(cmbSupplier);
            Controls.Add(txtAmount);
            Controls.Add(cmbLocation);
            Controls.Add(cmbComponent);
            Controls.Add(label6);
            Controls.Add(btnAddtoStock);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStock";
            Text = "frmStock";
            Load += frmStock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button btnAddtoStock;
        private Label label6;
        private ComboBox cmbComponent;
        private ComboBox cmbLocation;
        private TextBox txtAmount;
        private ComboBox cmbSupplier;
        private TextBox txtLastUpdate;
        private Label lblProductCode;
        private TextBox txtProductCode;
        private Label lblAddNewComp;
        private Panel panelRackView;
        private ComboBox cmbRackSelector;
    }
}