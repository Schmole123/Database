namespace Inventory_Database_FrontEnd.Dialogs
{
    partial class NewComponent
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
            txtCreateCompName = new TextBox();
            label2 = new Label();
            txtCreateCompCode = new TextBox();
            label3 = new Label();
            txtCompAddInfo = new TextBox();
            btnCreateNewComp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 24);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Component Name";
            // 
            // txtCreateCompName
            // 
            txtCreateCompName.Location = new Point(33, 42);
            txtCreateCompName.Name = "txtCreateCompName";
            txtCreateCompName.Size = new Size(178, 23);
            txtCreateCompName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 84);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Product Code";
            // 
            // txtCreateCompCode
            // 
            txtCreateCompCode.Location = new Point(33, 102);
            txtCreateCompCode.Name = "txtCreateCompCode";
            txtCreateCompCode.Size = new Size(178, 23);
            txtCreateCompCode.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 146);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 4;
            label3.Text = "Additional Info";
            // 
            // txtCompAddInfo
            // 
            txtCompAddInfo.Location = new Point(33, 164);
            txtCompAddInfo.Name = "txtCompAddInfo";
            txtCompAddInfo.Size = new Size(178, 23);
            txtCompAddInfo.TabIndex = 5;
            // 
            // btnCreateNewComp
            // 
            btnCreateNewComp.BackColor = Color.PaleGreen;
            btnCreateNewComp.ForeColor = SystemColors.ActiveCaptionText;
            btnCreateNewComp.Location = new Point(34, 223);
            btnCreateNewComp.Name = "btnCreateNewComp";
            btnCreateNewComp.Size = new Size(171, 45);
            btnCreateNewComp.TabIndex = 6;
            btnCreateNewComp.Text = "Create New Component";
            btnCreateNewComp.UseVisualStyleBackColor = false;
            // 
            // NewComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 291);
            Controls.Add(btnCreateNewComp);
            Controls.Add(txtCompAddInfo);
            Controls.Add(label3);
            Controls.Add(txtCreateCompCode);
            Controls.Add(label2);
            Controls.Add(txtCreateCompName);
            Controls.Add(label1);
            Name = "NewComponent";
            Text = "NewComponent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCreateCompName;
        private Label label2;
        private TextBox txtCreateCompCode;
        private Label label3;
        private TextBox txtCompAddInfo;
        private Button btnCreateNewComp;
    }
}