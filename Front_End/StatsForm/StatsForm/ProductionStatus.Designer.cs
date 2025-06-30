namespace StatsForm
{
    partial class ProductionStatus
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
            compNum = new Label();
            progNum = new Label();
            newNum = new Label();
            customerNum = new Label();
            customerUnit = new Label();
            customerBox = new ComboBox();
            customerLabel = new Label();
            customerHeader = new Label();
            unitNoHeader = new Label();
            compUnit = new Label();
            progUnit = new Label();
            newUnit = new Label();
            overviewHeader = new Label();
            panel2 = new Panel();
            productTxt = new Label();
            customerDetailTxt = new Label();
            statusTxt = new Label();
            endDate = new DateTimePicker();
            startDate = new DateTimePicker();
            endDetail = new Label();
            startDetail = new Label();
            statusDetail = new Label();
            prodDetail = new Label();
            customerDetail = new Label();
            orderBox = new ComboBox();
            orderCode = new Label();
            detailHeader = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(compNum);
            panel1.Controls.Add(progNum);
            panel1.Controls.Add(newNum);
            panel1.Controls.Add(customerNum);
            panel1.Controls.Add(customerUnit);
            panel1.Controls.Add(customerBox);
            panel1.Controls.Add(customerLabel);
            panel1.Controls.Add(customerHeader);
            panel1.Controls.Add(unitNoHeader);
            panel1.Controls.Add(compUnit);
            panel1.Controls.Add(progUnit);
            panel1.Controls.Add(newUnit);
            panel1.Controls.Add(overviewHeader);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 175);
            panel1.TabIndex = 0;
            // 
            // compNum
            // 
            compNum.AutoSize = true;
            compNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            compNum.Location = new Point(100, 131);
            compNum.Name = "compNum";
            compNum.Size = new Size(34, 21);
            compNum.TabIndex = 12;
            compNum.Text = "No.";
            // 
            // progNum
            // 
            progNum.AutoSize = true;
            progNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            progNum.Location = new Point(100, 110);
            progNum.Name = "progNum";
            progNum.Size = new Size(34, 21);
            progNum.TabIndex = 11;
            progNum.Text = "No.";
            // 
            // newNum
            // 
            newNum.AutoSize = true;
            newNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newNum.Location = new Point(100, 89);
            newNum.Name = "newNum";
            newNum.Size = new Size(34, 21);
            newNum.TabIndex = 10;
            newNum.Text = "No.";
            // 
            // customerNum
            // 
            customerNum.AutoSize = true;
            customerNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerNum.Location = new Point(219, 131);
            customerNum.Name = "customerNum";
            customerNum.Size = new Size(34, 21);
            customerNum.TabIndex = 9;
            customerNum.Text = "No.";
            customerNum.Visible = false;
            // 
            // customerUnit
            // 
            customerUnit.AutoSize = true;
            customerUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerUnit.Location = new Point(162, 131);
            customerUnit.Name = "customerUnit";
            customerUnit.Size = new Size(49, 21);
            customerUnit.TabIndex = 8;
            customerUnit.Text = "Units:";
            // 
            // customerBox
            // 
            customerBox.DropDownStyle = ComboBoxStyle.DropDownList;
            customerBox.FormattingEnabled = true;
            customerBox.Location = new Point(265, 91);
            customerBox.Name = "customerBox";
            customerBox.Size = new Size(81, 23);
            customerBox.TabIndex = 7;
            customerBox.SelectedIndexChanged += customerBox_SelectedIndexChanged;
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerLabel.Location = new Point(162, 89);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(81, 21);
            customerLabel.TabIndex = 6;
            customerLabel.Text = "Customer:";
            // 
            // customerHeader
            // 
            customerHeader.AutoSize = true;
            customerHeader.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            customerHeader.Location = new Point(160, 59);
            customerHeader.Name = "customerHeader";
            customerHeader.Size = new Size(224, 30);
            customerHeader.TabIndex = 5;
            customerHeader.Text = "No. of Customer units";
            // 
            // unitNoHeader
            // 
            unitNoHeader.AutoSize = true;
            unitNoHeader.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            unitNoHeader.Location = new Point(3, 59);
            unitNoHeader.Name = "unitNoHeader";
            unitNoHeader.Size = new Size(128, 30);
            unitNoHeader.TabIndex = 4;
            unitNoHeader.Text = "No. of Units";
            // 
            // compUnit
            // 
            compUnit.AutoSize = true;
            compUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            compUnit.Location = new Point(3, 131);
            compUnit.Name = "compUnit";
            compUnit.Size = new Size(89, 21);
            compUnit.TabIndex = 3;
            compUnit.Text = "Completed:";
            // 
            // progUnit
            // 
            progUnit.AutoSize = true;
            progUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            progUnit.Location = new Point(3, 110);
            progUnit.Name = "progUnit";
            progUnit.Size = new Size(91, 21);
            progUnit.TabIndex = 2;
            progUnit.Text = "In progress:";
            // 
            // newUnit
            // 
            newUnit.AutoSize = true;
            newUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUnit.Location = new Point(3, 89);
            newUnit.Name = "newUnit";
            newUnit.Size = new Size(45, 21);
            newUnit.TabIndex = 1;
            newUnit.Text = "New:";
            // 
            // overviewHeader
            // 
            overviewHeader.AutoSize = true;
            overviewHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            overviewHeader.Location = new Point(3, 9);
            overviewHeader.Name = "overviewHeader";
            overviewHeader.Size = new Size(121, 32);
            overviewHeader.TabIndex = 0;
            overviewHeader.Text = "Overview";
            // 
            // panel2
            // 
            panel2.Controls.Add(productTxt);
            panel2.Controls.Add(customerDetailTxt);
            panel2.Controls.Add(statusTxt);
            panel2.Controls.Add(endDate);
            panel2.Controls.Add(startDate);
            panel2.Controls.Add(endDetail);
            panel2.Controls.Add(startDetail);
            panel2.Controls.Add(statusDetail);
            panel2.Controls.Add(prodDetail);
            panel2.Controls.Add(customerDetail);
            panel2.Controls.Add(orderBox);
            panel2.Controls.Add(orderCode);
            panel2.Controls.Add(detailHeader);
            panel2.Location = new Point(3, 184);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 263);
            panel2.TabIndex = 1;
            // 
            // productTxt
            // 
            productTxt.AutoSize = true;
            productTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productTxt.Location = new Point(160, 137);
            productTxt.Name = "productTxt";
            productTxt.Size = new Size(64, 21);
            productTxt.TabIndex = 19;
            productTxt.Text = "Product";
            productTxt.Visible = false;
            // 
            // customerDetailTxt
            // 
            customerDetailTxt.AutoSize = true;
            customerDetailTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerDetailTxt.Location = new Point(160, 107);
            customerDetailTxt.Name = "customerDetailTxt";
            customerDetailTxt.Size = new Size(134, 21);
            customerDetailTxt.TabIndex = 18;
            customerDetailTxt.Text = "customerDetailTxt";
            customerDetailTxt.Visible = false;
            // 
            // statusTxt
            // 
            statusTxt.AutoSize = true;
            statusTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusTxt.Location = new Point(160, 167);
            statusTxt.Name = "statusTxt";
            statusTxt.Size = new Size(82, 21);
            statusTxt.TabIndex = 16;
            statusTxt.Text = "Status Text";
            statusTxt.Visible = false;
            // 
            // endDate
            // 
            endDate.Enabled = false;
            endDate.Location = new Point(161, 227);
            endDate.Name = "endDate";
            endDate.Size = new Size(125, 23);
            endDate.TabIndex = 15;
            // 
            // startDate
            // 
            startDate.Enabled = false;
            startDate.Location = new Point(161, 196);
            startDate.Name = "startDate";
            startDate.Size = new Size(125, 23);
            startDate.TabIndex = 14;
            // 
            // endDetail
            // 
            endDetail.AutoSize = true;
            endDetail.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            endDetail.Location = new Point(6, 220);
            endDetail.Name = "endDetail";
            endDetail.Size = new Size(105, 30);
            endDetail.TabIndex = 13;
            endDetail.Text = "End Date:";
            // 
            // startDetail
            // 
            startDetail.AutoSize = true;
            startDetail.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startDetail.Location = new Point(6, 190);
            startDetail.Name = "startDetail";
            startDetail.Size = new Size(115, 30);
            startDetail.TabIndex = 12;
            startDetail.Text = "Start Date:";
            // 
            // statusDetail
            // 
            statusDetail.AutoSize = true;
            statusDetail.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusDetail.Location = new Point(6, 160);
            statusDetail.Name = "statusDetail";
            statusDetail.Size = new Size(76, 30);
            statusDetail.TabIndex = 11;
            statusDetail.Text = "Status:";
            // 
            // prodDetail
            // 
            prodDetail.AutoSize = true;
            prodDetail.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prodDetail.Location = new Point(6, 130);
            prodDetail.Name = "prodDetail";
            prodDetail.Size = new Size(94, 30);
            prodDetail.TabIndex = 10;
            prodDetail.Text = "Product:";
            // 
            // customerDetail
            // 
            customerDetail.AutoSize = true;
            customerDetail.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerDetail.Location = new Point(6, 100);
            customerDetail.Name = "customerDetail";
            customerDetail.Size = new Size(112, 30);
            customerDetail.TabIndex = 9;
            customerDetail.Text = "Customer:";
            // 
            // orderBox
            // 
            orderBox.DropDownStyle = ComboBoxStyle.DropDownList;
            orderBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderBox.FormattingEnabled = true;
            orderBox.Location = new Point(161, 46);
            orderBox.Name = "orderBox";
            orderBox.Size = new Size(125, 23);
            orderBox.TabIndex = 8;
            orderBox.SelectedValueChanged += orderBox_SelectedValueChanged;
            // 
            // orderCode
            // 
            orderCode.AutoSize = true;
            orderCode.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderCode.Location = new Point(6, 41);
            orderCode.Name = "orderCode";
            orderCode.Size = new Size(125, 30);
            orderCode.TabIndex = 2;
            orderCode.Text = "Order Code";
            // 
            // detailHeader
            // 
            detailHeader.AutoSize = true;
            detailHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            detailHeader.Location = new Point(3, 9);
            detailHeader.Name = "detailHeader";
            detailHeader.Size = new Size(92, 32);
            detailHeader.TabIndex = 1;
            detailHeader.Text = "Details";
            // 
            // ProductionStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ProductionStatus";
            Size = new Size(397, 450);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label newUnit;
        private Label overviewHeader;
        private Label customerHeader;
        private Label unitNoHeader;
        private Label compUnit;
        private Label progUnit;
        private ComboBox customerBox;
        private Label customerLabel;
        private Panel panel2;
        private Label detailHeader;
        private Label orderCode;
        private DateTimePicker startDate;
        private Label endDetail;
        private Label startDetail;
        private Label statusDetail;
        private Label prodDetail;
        private Label customerDetail;
        private ComboBox orderBox;
        private Label customerDetailTxt;
        private Label statusTxt;
        private DateTimePicker endDate;
        private Label customerUnit;
        private Label customerNum;
        private Label compNum;
        private Label progNum;
        private Label newNum;
        private Label productTxt;
    }
}
