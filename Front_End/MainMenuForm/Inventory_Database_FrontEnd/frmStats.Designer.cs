namespace Inventory_Database_FrontEnd
{
    partial class frmStats
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
            panel1 = new Panel();
            panel2 = new Panel();
            shipNum = new Label();
            shipUnit = new Label();
            qcNum = new Label();
            qcUnit = new Label();
            compNum = new Label();
            prodNum = new Label();
            newNum = new Label();
            customerNum = new Label();
            customerUnit = new Label();
            customerBox = new ComboBox();
            customerLabel = new Label();
            customerHeader = new Label();
            unitNoHeader = new Label();
            compUnit = new Label();
            prodUnit = new Label();
            newUnit = new Label();
            overviewHeader = new Label();
            panel3 = new Panel();
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
            panel3.SuspendLayout();
            SuspendLayout();
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
            // compBox
            // 
            compBox.FormattingEnabled = true;
            compBox.Location = new Point(22, 232);
            compBox.Name = "compBox";
            compBox.Size = new Size(121, 23);
            compBox.TabIndex = 9;
            compBox.SelectedIndexChanged += compBox_SelectedIndexChanged;
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
            button1.Location = new Point(120, 364);
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
            cartesianChart1.BackColor = Color.AliceBlue;
            cartesianChart1.Location = new Point(201, -1);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(826, 400);
            cartesianChart1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
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
            panel1.Size = new Size(207, 672);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(shipNum);
            panel2.Controls.Add(shipUnit);
            panel2.Controls.Add(qcNum);
            panel2.Controls.Add(qcUnit);
            panel2.Controls.Add(compNum);
            panel2.Controls.Add(prodNum);
            panel2.Controls.Add(newNum);
            panel2.Controls.Add(customerNum);
            panel2.Controls.Add(customerUnit);
            panel2.Controls.Add(customerBox);
            panel2.Controls.Add(customerLabel);
            panel2.Controls.Add(customerHeader);
            panel2.Controls.Add(unitNoHeader);
            panel2.Controls.Add(compUnit);
            panel2.Controls.Add(prodUnit);
            panel2.Controls.Add(newUnit);
            panel2.Controls.Add(overviewHeader);
            panel2.Location = new Point(200, 393);
            panel2.Name = "panel2";
            panel2.Size = new Size(409, 288);
            panel2.TabIndex = 4;
            // 
            // shipNum
            // 
            shipNum.AutoSize = true;
            shipNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shipNum.Location = new Point(114, 153);
            shipNum.Name = "shipNum";
            shipNum.Size = new Size(34, 21);
            shipNum.TabIndex = 16;
            shipNum.Text = "No.";
            // 
            // shipUnit
            // 
            shipUnit.AutoSize = true;
            shipUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shipUnit.Location = new Point(3, 153);
            shipUnit.Name = "shipUnit";
            shipUnit.Size = new Size(109, 21);
            shipUnit.TabIndex = 15;
            shipUnit.Text = "Ready to Ship:";
            // 
            // qcNum
            // 
            qcNum.AutoSize = true;
            qcNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qcNum.Location = new Point(114, 132);
            qcNum.Name = "qcNum";
            qcNum.Size = new Size(34, 21);
            qcNum.TabIndex = 14;
            qcNum.Text = "No.";
            // 
            // qcUnit
            // 
            qcUnit.AutoSize = true;
            qcUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qcUnit.Location = new Point(5, 132);
            qcUnit.Name = "qcUnit";
            qcUnit.Size = new Size(35, 21);
            qcUnit.TabIndex = 13;
            qcUnit.Text = "QC:";
            // 
            // compNum
            // 
            compNum.AutoSize = true;
            compNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            compNum.Location = new Point(114, 174);
            compNum.Name = "compNum";
            compNum.Size = new Size(34, 21);
            compNum.TabIndex = 12;
            compNum.Text = "No.";
            // 
            // prodNum
            // 
            prodNum.AutoSize = true;
            prodNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prodNum.Location = new Point(114, 110);
            prodNum.Name = "prodNum";
            prodNum.Size = new Size(34, 21);
            prodNum.TabIndex = 11;
            prodNum.Text = "No.";
            // 
            // newNum
            // 
            newNum.AutoSize = true;
            newNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newNum.Location = new Point(114, 89);
            newNum.Name = "newNum";
            newNum.Size = new Size(34, 21);
            newNum.TabIndex = 10;
            newNum.Text = "No.";
            // 
            // customerNum
            // 
            customerNum.AutoSize = true;
            customerNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerNum.Location = new Point(228, 131);
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
            customerUnit.Location = new Point(171, 131);
            customerUnit.Name = "customerUnit";
            customerUnit.Size = new Size(49, 21);
            customerUnit.TabIndex = 8;
            customerUnit.Text = "Units:";
            // 
            // customerBox
            // 
            customerBox.DropDownStyle = ComboBoxStyle.DropDownList;
            customerBox.FormattingEnabled = true;
            customerBox.Location = new Point(274, 91);
            customerBox.Name = "customerBox";
            customerBox.Size = new Size(81, 23);
            customerBox.TabIndex = 7;
            customerBox.SelectedIndexChanged += customerBox_SelectedIndexChanged;
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerLabel.Location = new Point(171, 89);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(81, 21);
            customerLabel.TabIndex = 6;
            customerLabel.Text = "Customer:";
            // 
            // customerHeader
            // 
            customerHeader.AutoSize = true;
            customerHeader.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            customerHeader.Location = new Point(169, 59);
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
            compUnit.Location = new Point(3, 174);
            compUnit.Name = "compUnit";
            compUnit.Size = new Size(89, 21);
            compUnit.TabIndex = 3;
            compUnit.Text = "Completed:";
            // 
            // prodUnit
            // 
            prodUnit.AutoSize = true;
            prodUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prodUnit.Location = new Point(3, 110);
            prodUnit.Name = "prodUnit";
            prodUnit.Size = new Size(106, 21);
            prodUnit.TabIndex = 2;
            prodUnit.Text = "In Production:";
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
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Controls.Add(productTxt);
            panel3.Controls.Add(customerDetailTxt);
            panel3.Controls.Add(statusTxt);
            panel3.Controls.Add(endDate);
            panel3.Controls.Add(startDate);
            panel3.Controls.Add(endDetail);
            panel3.Controls.Add(startDetail);
            panel3.Controls.Add(statusDetail);
            panel3.Controls.Add(prodDetail);
            panel3.Controls.Add(customerDetail);
            panel3.Controls.Add(orderBox);
            panel3.Controls.Add(orderCode);
            panel3.Controls.Add(detailHeader);
            panel3.Location = new Point(609, 393);
            panel3.Name = "panel3";
            panel3.Size = new Size(430, 288);
            panel3.TabIndex = 5;
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
            // frmStats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1030, 672);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(cartesianChart1);
            Controls.Add(panel1);
            Name = "frmStats";
            Text = "frmStats";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

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
        private Panel panel1;
        private Panel panel2;
        private Label compNum;
        private Label prodNum;
        private Label newNum;
        private Label customerNum;
        private Label customerUnit;
        private ComboBox customerBox;
        private Label customerLabel;
        private Label customerHeader;
        private Label unitNoHeader;
        private Label compUnit;
        private Label prodUnit;
        private Label newUnit;
        private Label overviewHeader;
        private Panel panel3;
        private Label productTxt;
        private Label customerDetailTxt;
        private Label statusTxt;
        private DateTimePicker endDate;
        private DateTimePicker startDate;
        private Label endDetail;
        private Label startDetail;
        private Label statusDetail;
        private Label prodDetail;
        private Label customerDetail;
        private ComboBox orderBox;
        private Label orderCode;
        private Label detailHeader;
        private Label shipNum;
        private Label shipUnit;
        private Label qcNum;
        private Label qcUnit;
    }
}