namespace StatsForm
{
    partial class Stock
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
            button1 = new Button();
            prodBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(prodBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 450);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(107, 424);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // prodBox
            // 
            prodBox.FormattingEnabled = true;
            prodBox.Location = new Point(17, 70);
            prodBox.Name = "prodBox";
            prodBox.Size = new Size(121, 23);
            prodBox.TabIndex = 2;
            prodBox.SelectedIndexChanged += prodBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 37);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 1;
            label2.Text = "Product:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 5);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 0;
            label1.Text = "Stock Levels";
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(190, 5);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(630, 435);
            cartesianChart1.TabIndex = 1;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cartesianChart1);
            Controls.Add(panel1);
            Name = "Stock";
            Size = new Size(870, 450);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox prodBox;
        private Label label2;
        private Label label1;
        private Button button1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
    }
}
