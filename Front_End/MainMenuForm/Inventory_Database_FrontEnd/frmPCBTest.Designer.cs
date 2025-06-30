namespace Inventory_Database_FrontEnd
{
    partial class frmPCBTest
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
            userPanel = new Panel();
            recieveBtn = new Button();
            updateBtn = new Button();
            genDateSelect = new DateTimePicker();
            genDateLabel = new Label();
            genInfoLabel = new Label();
            genNumBox = new TextBox();
            genNumLabel = new Label();
            genBox = new ComboBox();
            genLabel = new Label();
            serialTxt = new TextBox();
            serialLabel = new Label();
            label1 = new Label();
            passCheck = new CheckBox();
            testDateSelect = new DateTimePicker();
            pcbLabel = new Label();
            reporteeName = new TextBox();
            nameLabel = new Label();
            pcbSelect = new ComboBox();
            panel1 = new Panel();
            refreshBtn = new Button();
            lensTestedNum = new Label();
            lensUntestedNum = new Label();
            lensTotalNum = new Label();
            pilotDCTestedNum = new Label();
            pilotDCUntestedNum = new Label();
            pilotDCTotalNum = new Label();
            pilotACTestedNum = new Label();
            pilotACUntestedNum = new Label();
            pilotACTotalNum = new Label();
            evalTestedNum = new Label();
            evalUntestedNum = new Label();
            evalTotalNum = new Label();
            bllTestedNum = new Label();
            bllUntestedNum = new Label();
            bllTotalNum = new Label();
            opticalTestedNum = new Label();
            opticalUntestedNum = new Label();
            opticalTotalNum = new Label();
            mainTestedNum = new Label();
            mainUntestedNum = new Label();
            mainTotalNum = new Label();
            driverTestedNum = new Label();
            driverUntestedNum = new Label();
            driverTotalNum = new Label();
            lensLabel = new Label();
            pilotDCLabel = new Label();
            pilotACLabel = new Label();
            bllEvalLabel = new Label();
            bllLabel = new Label();
            cblmdOpticalLabel = new Label();
            mcsTotalNum = new Label();
            stockTotalLabel = new Label();
            cblmdMainLabel = new Label();
            cblmdDriverLabel = new Label();
            mcsTestedNum = new Label();
            mcsUntestedNum = new Label();
            testedLabel = new Label();
            untestedLabel = new Label();
            mCSLabel = new Label();
            label2 = new Label();
            userPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // userPanel
            // 
            userPanel.Controls.Add(recieveBtn);
            userPanel.Controls.Add(updateBtn);
            userPanel.Controls.Add(genDateSelect);
            userPanel.Controls.Add(genDateLabel);
            userPanel.Controls.Add(genInfoLabel);
            userPanel.Controls.Add(genNumBox);
            userPanel.Controls.Add(genNumLabel);
            userPanel.Controls.Add(genBox);
            userPanel.Controls.Add(genLabel);
            userPanel.Controls.Add(serialTxt);
            userPanel.Controls.Add(serialLabel);
            userPanel.Controls.Add(label1);
            userPanel.Controls.Add(passCheck);
            userPanel.Controls.Add(testDateSelect);
            userPanel.Controls.Add(pcbLabel);
            userPanel.Controls.Add(reporteeName);
            userPanel.Controls.Add(nameLabel);
            userPanel.Controls.Add(pcbSelect);
            userPanel.Location = new Point(12, 12);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(479, 365);
            userPanel.TabIndex = 29;
            // 
            // recieveBtn
            // 
            recieveBtn.BackColor = Color.LightSalmon;
            recieveBtn.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recieveBtn.Location = new Point(195, 288);
            recieveBtn.Name = "recieveBtn";
            recieveBtn.Size = new Size(167, 42);
            recieveBtn.TabIndex = 22;
            recieveBtn.Text = "Retrieve Data";
            recieveBtn.UseVisualStyleBackColor = false;
            recieveBtn.Click += recieveBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.PaleGreen;
            updateBtn.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(195, 240);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(167, 42);
            updateBtn.TabIndex = 21;
            updateBtn.Text = "Submit Data";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // genDateSelect
            // 
            genDateSelect.CustomFormat = "MM/yyyy";
            genDateSelect.Format = DateTimePickerFormat.Custom;
            genDateSelect.Location = new Point(394, 156);
            genDateSelect.Name = "genDateSelect";
            genDateSelect.Size = new Size(81, 23);
            genDateSelect.TabIndex = 20;
            // 
            // genDateLabel
            // 
            genDateLabel.AutoSize = true;
            genDateLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genDateLabel.Location = new Point(394, 120);
            genDateLabel.Name = "genDateLabel";
            genDateLabel.Size = new Size(63, 25);
            genDateLabel.TabIndex = 19;
            genDateLabel.Text = "Date:";
            // 
            // genInfoLabel
            // 
            genInfoLabel.AutoSize = true;
            genInfoLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genInfoLabel.Location = new Point(233, 86);
            genInfoLabel.Name = "genInfoLabel";
            genInfoLabel.Size = new Size(99, 25);
            genInfoLabel.TabIndex = 18;
            genInfoLabel.Text = "Gen Info:";
            // 
            // genNumBox
            // 
            genNumBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genNumBox.Location = new Point(312, 156);
            genNumBox.Name = "genNumBox";
            genNumBox.Size = new Size(62, 23);
            genNumBox.TabIndex = 17;
            // 
            // genNumLabel
            // 
            genNumLabel.AutoSize = true;
            genNumLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genNumLabel.Location = new Point(312, 120);
            genNumLabel.Name = "genNumLabel";
            genNumLabel.Size = new Size(62, 25);
            genNumLabel.TabIndex = 16;
            genNumLabel.Text = "Num:";
            // 
            // genBox
            // 
            genBox.FormattingEnabled = true;
            genBox.Items.AddRange(new object[] { "GEN1", "GEN2" });
            genBox.Location = new Point(233, 156);
            genBox.Name = "genBox";
            genBox.Size = new Size(58, 23);
            genBox.TabIndex = 15;
            // 
            // genLabel
            // 
            genLabel.AutoSize = true;
            genLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genLabel.Location = new Point(233, 120);
            genLabel.Name = "genLabel";
            genLabel.Size = new Size(58, 25);
            genLabel.TabIndex = 14;
            genLabel.Text = "Gen:";
            // 
            // serialTxt
            // 
            serialTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serialTxt.Location = new Point(233, 36);
            serialTxt.Name = "serialTxt";
            serialTxt.Size = new Size(181, 29);
            serialTxt.TabIndex = 13;
            // 
            // serialLabel
            // 
            serialLabel.AutoSize = true;
            serialLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serialLabel.Location = new Point(233, 10);
            serialLabel.Name = "serialLabel";
            serialLabel.Size = new Size(154, 25);
            serialLabel.TabIndex = 12;
            serialLabel.Text = "Serial Number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 160);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 11;
            label1.Text = "Test Date:";
            // 
            // passCheck
            // 
            passCheck.AutoSize = true;
            passCheck.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passCheck.Location = new Point(12, 248);
            passCheck.Name = "passCheck";
            passCheck.Size = new Size(151, 29);
            passCheck.TabIndex = 10;
            passCheck.Text = "Passed Test";
            passCheck.UseVisualStyleBackColor = true;
            // 
            // testDateSelect
            // 
            testDateSelect.Location = new Point(7, 190);
            testDateSelect.Name = "testDateSelect";
            testDateSelect.Size = new Size(181, 23);
            testDateSelect.TabIndex = 8;
            // 
            // pcbLabel
            // 
            pcbLabel.AutoSize = true;
            pcbLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pcbLabel.Location = new Point(3, 10);
            pcbLabel.Name = "pcbLabel";
            pcbLabel.Size = new Size(127, 25);
            pcbLabel.TabIndex = 9;
            pcbLabel.Text = "PCB Select:";
            // 
            // reporteeName
            // 
            reporteeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reporteeName.Location = new Point(6, 116);
            reporteeName.Name = "reporteeName";
            reporteeName.Size = new Size(181, 29);
            reporteeName.TabIndex = 5;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(3, 86);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(192, 25);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name of Reportee:";
            // 
            // pcbSelect
            // 
            pcbSelect.FormattingEnabled = true;
            pcbSelect.Location = new Point(6, 42);
            pcbSelect.Name = "pcbSelect";
            pcbSelect.Size = new Size(181, 23);
            pcbSelect.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(refreshBtn);
            panel1.Controls.Add(lensTestedNum);
            panel1.Controls.Add(lensUntestedNum);
            panel1.Controls.Add(lensTotalNum);
            panel1.Controls.Add(pilotDCTestedNum);
            panel1.Controls.Add(pilotDCUntestedNum);
            panel1.Controls.Add(pilotDCTotalNum);
            panel1.Controls.Add(pilotACTestedNum);
            panel1.Controls.Add(pilotACUntestedNum);
            panel1.Controls.Add(pilotACTotalNum);
            panel1.Controls.Add(evalTestedNum);
            panel1.Controls.Add(evalUntestedNum);
            panel1.Controls.Add(evalTotalNum);
            panel1.Controls.Add(bllTestedNum);
            panel1.Controls.Add(bllUntestedNum);
            panel1.Controls.Add(bllTotalNum);
            panel1.Controls.Add(opticalTestedNum);
            panel1.Controls.Add(opticalUntestedNum);
            panel1.Controls.Add(opticalTotalNum);
            panel1.Controls.Add(mainTestedNum);
            panel1.Controls.Add(mainUntestedNum);
            panel1.Controls.Add(mainTotalNum);
            panel1.Controls.Add(driverTestedNum);
            panel1.Controls.Add(driverUntestedNum);
            panel1.Controls.Add(driverTotalNum);
            panel1.Controls.Add(lensLabel);
            panel1.Controls.Add(pilotDCLabel);
            panel1.Controls.Add(pilotACLabel);
            panel1.Controls.Add(bllEvalLabel);
            panel1.Controls.Add(bllLabel);
            panel1.Controls.Add(cblmdOpticalLabel);
            panel1.Controls.Add(mcsTotalNum);
            panel1.Controls.Add(stockTotalLabel);
            panel1.Controls.Add(cblmdMainLabel);
            panel1.Controls.Add(cblmdDriverLabel);
            panel1.Controls.Add(mcsTestedNum);
            panel1.Controls.Add(mcsUntestedNum);
            panel1.Controls.Add(testedLabel);
            panel1.Controls.Add(untestedLabel);
            panel1.Controls.Add(mCSLabel);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(511, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 503);
            panel1.TabIndex = 30;
            // 
            // refreshBtn
            // 
            refreshBtn.BackColor = SystemColors.Control;
            refreshBtn.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshBtn.Location = new Point(16, 448);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(167, 42);
            refreshBtn.TabIndex = 31;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // lensTestedNum
            // 
            lensTestedNum.AutoSize = true;
            lensTestedNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lensTestedNum.Location = new Point(410, 380);
            lensTestedNum.Name = "lensTestedNum";
            lensTestedNum.Size = new Size(56, 25);
            lensTestedNum.TabIndex = 61;
            lensTestedNum.Text = "Num";
            lensTestedNum.Visible = false;
            // 
            // lensUntestedNum
            // 
            lensUntestedNum.AutoSize = true;
            lensUntestedNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lensUntestedNum.Location = new Point(300, 380);
            lensUntestedNum.Name = "lensUntestedNum";
            lensUntestedNum.Size = new Size(56, 25);
            lensUntestedNum.TabIndex = 60;
            lensUntestedNum.Text = "Num";
            lensUntestedNum.Visible = false;
            // 
            // lensTotalNum
            // 
            lensTotalNum.AutoSize = true;
            lensTotalNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lensTotalNum.Location = new Point(185, 380);
            lensTotalNum.Name = "lensTotalNum";
            lensTotalNum.Size = new Size(56, 25);
            lensTotalNum.TabIndex = 59;
            lensTotalNum.Text = "Num";
            lensTotalNum.Visible = false;
            // 
            // pilotDCTestedNum
            // 
            pilotDCTestedNum.AutoSize = true;
            pilotDCTestedNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pilotDCTestedNum.Location = new Point(410, 340);
            pilotDCTestedNum.Name = "pilotDCTestedNum";
            pilotDCTestedNum.Size = new Size(56, 25);
            pilotDCTestedNum.TabIndex = 58;
            pilotDCTestedNum.Text = "Num";
            pilotDCTestedNum.Visible = false;
            // 
            // pilotDCUntestedNum
            // 
            pilotDCUntestedNum.AutoSize = true;
            pilotDCUntestedNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pilotDCUntestedNum.Location = new Point(300, 340);
            pilotDCUntestedNum.Name = "pilotDCUntestedNum";
            pilotDCUntestedNum.Size = new Size(56, 25);
            pilotDCUntestedNum.TabIndex = 57;
            pilotDCUntestedNum.Text = "Num";
            pilotDCUntestedNum.Visible = false;
            // 
            // pilotDCTotalNum
            // 
            pilotDCTotalNum.AutoSize = true;
            pilotDCTotalNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pilotDCTotalNum.Location = new Point(185, 340);
            pilotDCTotalNum.Name = "pilotDCTotalNum";
            pilotDCTotalNum.Size = new Size(56, 25);
            pilotDCTotalNum.TabIndex = 56;
            pilotDCTotalNum.Text = "Num";
            pilotDCTotalNum.Visible = false;
            // 
            // pilotACTestedNum
            // 
            pilotACTestedNum.AutoSize = true;
            pilotACTestedNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pilotACTestedNum.Location = new Point(410, 300);
            pilotACTestedNum.Name = "pilotACTestedNum";
            pilotACTestedNum.Size = new Size(56, 25);
            pilotACTestedNum.TabIndex = 55;
            pilotACTestedNum.Text = "Num";
            pilotACTestedNum.Visible = false;
            // 
            // pilotACUntestedNum
            // 
            pilotACUntestedNum.AutoSize = true;
            pilotACUntestedNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pilotACUntestedNum.Location = new Point(300, 297);
            pilotACUntestedNum.Name = "pilotACUntestedNum";
            pilotACUntestedNum.Size = new Size(56, 25);
            pilotACUntestedNum.TabIndex = 54;
            pilotACUntestedNum.Text = "Num";
            pilotACUntestedNum.Visible = false;
            // 
            // pilotACTotalNum
            // 
            pilotACTotalNum.AutoSize = true;
            pilotACTotalNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pilotACTotalNum.Location = new Point(185, 297);
            pilotACTotalNum.Name = "pilotACTotalNum";
            pilotACTotalNum.Size = new Size(56, 25);
            pilotACTotalNum.TabIndex = 53;
            pilotACTotalNum.Text = "Num";
            pilotACTotalNum.Visible = false;
            // 
            // evalTestedNum
            // 
            evalTestedNum.AutoSize = true;
            evalTestedNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            evalTestedNum.Location = new Point(410, 260);
            evalTestedNum.Name = "evalTestedNum";
            evalTestedNum.Size = new Size(56, 25);
            evalTestedNum.TabIndex = 52;
            evalTestedNum.Text = "Num";
            evalTestedNum.Visible = false;
            // 
            // evalUntestedNum
            // 
            evalUntestedNum.AutoSize = true;
            evalUntestedNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            evalUntestedNum.Location = new Point(300, 260);
            evalUntestedNum.Name = "evalUntestedNum";
            evalUntestedNum.Size = new Size(56, 25);
            evalUntestedNum.TabIndex = 51;
            evalUntestedNum.Text = "Num";
            evalUntestedNum.Visible = false;
            // 
            // evalTotalNum
            // 
            evalTotalNum.AutoSize = true;
            evalTotalNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            evalTotalNum.Location = new Point(185, 260);
            evalTotalNum.Name = "evalTotalNum";
            evalTotalNum.Size = new Size(56, 25);
            evalTotalNum.TabIndex = 50;
            evalTotalNum.Text = "Num";
            evalTotalNum.Visible = false;
            // 
            // bllTestedNum
            // 
            bllTestedNum.AutoSize = true;
            bllTestedNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bllTestedNum.Location = new Point(410, 220);
            bllTestedNum.Name = "bllTestedNum";
            bllTestedNum.Size = new Size(56, 25);
            bllTestedNum.TabIndex = 49;
            bllTestedNum.Text = "Num";
            bllTestedNum.Visible = false;
            // 
            // bllUntestedNum
            // 
            bllUntestedNum.AutoSize = true;
            bllUntestedNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bllUntestedNum.Location = new Point(300, 220);
            bllUntestedNum.Name = "bllUntestedNum";
            bllUntestedNum.Size = new Size(56, 25);
            bllUntestedNum.TabIndex = 48;
            bllUntestedNum.Text = "Num";
            bllUntestedNum.Visible = false;
            // 
            // bllTotalNum
            // 
            bllTotalNum.AutoSize = true;
            bllTotalNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bllTotalNum.Location = new Point(185, 220);
            bllTotalNum.Name = "bllTotalNum";
            bllTotalNum.Size = new Size(56, 25);
            bllTotalNum.TabIndex = 47;
            bllTotalNum.Text = "Num";
            bllTotalNum.Visible = false;
            // 
            // opticalTestedNum
            // 
            opticalTestedNum.AutoSize = true;
            opticalTestedNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            opticalTestedNum.Location = new Point(410, 180);
            opticalTestedNum.Name = "opticalTestedNum";
            opticalTestedNum.Size = new Size(56, 25);
            opticalTestedNum.TabIndex = 46;
            opticalTestedNum.Text = "Num";
            opticalTestedNum.Visible = false;
            // 
            // opticalUntestedNum
            // 
            opticalUntestedNum.AutoSize = true;
            opticalUntestedNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            opticalUntestedNum.Location = new Point(300, 180);
            opticalUntestedNum.Name = "opticalUntestedNum";
            opticalUntestedNum.Size = new Size(56, 25);
            opticalUntestedNum.TabIndex = 45;
            opticalUntestedNum.Text = "Num";
            opticalUntestedNum.Visible = false;
            // 
            // opticalTotalNum
            // 
            opticalTotalNum.AutoSize = true;
            opticalTotalNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            opticalTotalNum.Location = new Point(185, 180);
            opticalTotalNum.Name = "opticalTotalNum";
            opticalTotalNum.Size = new Size(56, 25);
            opticalTotalNum.TabIndex = 44;
            opticalTotalNum.Text = "Num";
            opticalTotalNum.Visible = false;
            // 
            // mainTestedNum
            // 
            mainTestedNum.AutoSize = true;
            mainTestedNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainTestedNum.Location = new Point(410, 140);
            mainTestedNum.Name = "mainTestedNum";
            mainTestedNum.Size = new Size(56, 25);
            mainTestedNum.TabIndex = 43;
            mainTestedNum.Text = "Num";
            mainTestedNum.Visible = false;
            // 
            // mainUntestedNum
            // 
            mainUntestedNum.AutoSize = true;
            mainUntestedNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainUntestedNum.Location = new Point(300, 140);
            mainUntestedNum.Name = "mainUntestedNum";
            mainUntestedNum.Size = new Size(56, 25);
            mainUntestedNum.TabIndex = 42;
            mainUntestedNum.Text = "Num";
            mainUntestedNum.Visible = false;
            // 
            // mainTotalNum
            // 
            mainTotalNum.AutoSize = true;
            mainTotalNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainTotalNum.Location = new Point(185, 140);
            mainTotalNum.Name = "mainTotalNum";
            mainTotalNum.Size = new Size(56, 25);
            mainTotalNum.TabIndex = 41;
            mainTotalNum.Text = "Num";
            mainTotalNum.Visible = false;
            // 
            // driverTestedNum
            // 
            driverTestedNum.AutoSize = true;
            driverTestedNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            driverTestedNum.Location = new Point(410, 100);
            driverTestedNum.Name = "driverTestedNum";
            driverTestedNum.Size = new Size(56, 25);
            driverTestedNum.TabIndex = 40;
            driverTestedNum.Text = "Num";
            driverTestedNum.Visible = false;
            // 
            // driverUntestedNum
            // 
            driverUntestedNum.AutoSize = true;
            driverUntestedNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            driverUntestedNum.Location = new Point(300, 100);
            driverUntestedNum.Name = "driverUntestedNum";
            driverUntestedNum.Size = new Size(56, 25);
            driverUntestedNum.TabIndex = 39;
            driverUntestedNum.Text = "Num";
            driverUntestedNum.Visible = false;
            // 
            // driverTotalNum
            // 
            driverTotalNum.AutoSize = true;
            driverTotalNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            driverTotalNum.Location = new Point(185, 100);
            driverTotalNum.Name = "driverTotalNum";
            driverTotalNum.Size = new Size(56, 25);
            driverTotalNum.TabIndex = 38;
            driverTotalNum.Text = "Num";
            driverTotalNum.Visible = false;
            // 
            // lensLabel
            // 
            lensLabel.AutoSize = true;
            lensLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lensLabel.Location = new Point(4, 380);
            lensLabel.Name = "lensLabel";
            lensLabel.Size = new Size(79, 25);
            lensLabel.TabIndex = 37;
            lensLabel.Text = "LensX:";
            // 
            // pilotDCLabel
            // 
            pilotDCLabel.AutoSize = true;
            pilotDCLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pilotDCLabel.Location = new Point(4, 340);
            pilotDCLabel.Name = "pilotDCLabel";
            pilotDCLabel.Size = new Size(114, 25);
            pilotDCLabel.TabIndex = 36;
            pilotDCLabel.Text = "Pilot 4 DC:";
            // 
            // pilotACLabel
            // 
            pilotACLabel.AutoSize = true;
            pilotACLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pilotACLabel.Location = new Point(4, 300);
            pilotACLabel.Name = "pilotACLabel";
            pilotACLabel.Size = new Size(113, 25);
            pilotACLabel.TabIndex = 35;
            pilotACLabel.Text = "Pilot 4 AC:";
            // 
            // bllEvalLabel
            // 
            bllEvalLabel.AutoSize = true;
            bllEvalLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bllEvalLabel.Location = new Point(4, 260);
            bllEvalLabel.Name = "bllEvalLabel";
            bllEvalLabel.Size = new Size(148, 25);
            bllEvalLabel.TabIndex = 34;
            bllEvalLabel.Text = "BLL Eval Unit:";
            // 
            // bllLabel
            // 
            bllLabel.AutoSize = true;
            bllLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bllLabel.Location = new Point(4, 220);
            bllLabel.Name = "bllLabel";
            bllLabel.Size = new Size(56, 25);
            bllLabel.TabIndex = 33;
            bllLabel.Text = "BLL:";
            // 
            // cblmdOpticalLabel
            // 
            cblmdOpticalLabel.AutoSize = true;
            cblmdOpticalLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cblmdOpticalLabel.Location = new Point(4, 180);
            cblmdOpticalLabel.Name = "cblmdOpticalLabel";
            cblmdOpticalLabel.Size = new Size(161, 25);
            cblmdOpticalLabel.TabIndex = 32;
            cblmdOpticalLabel.Text = "cBLMD Optical:";
            // 
            // mcsTotalNum
            // 
            mcsTotalNum.AutoSize = true;
            mcsTotalNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcsTotalNum.Location = new Point(185, 60);
            mcsTotalNum.Name = "mcsTotalNum";
            mcsTotalNum.Size = new Size(56, 25);
            mcsTotalNum.TabIndex = 31;
            mcsTotalNum.Text = "Num";
            mcsTotalNum.Visible = false;
            // 
            // stockTotalLabel
            // 
            stockTotalLabel.AutoSize = true;
            stockTotalLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stockTotalLabel.Location = new Point(155, 30);
            stockTotalLabel.Name = "stockTotalLabel";
            stockTotalLabel.Size = new Size(120, 25);
            stockTotalLabel.TabIndex = 30;
            stockTotalLabel.Text = "Stock Total";
            // 
            // cblmdMainLabel
            // 
            cblmdMainLabel.AutoSize = true;
            cblmdMainLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cblmdMainLabel.Location = new Point(4, 140);
            cblmdMainLabel.Name = "cblmdMainLabel";
            cblmdMainLabel.Size = new Size(141, 25);
            cblmdMainLabel.TabIndex = 29;
            cblmdMainLabel.Text = "cBLMD Main:";
            // 
            // cblmdDriverLabel
            // 
            cblmdDriverLabel.AutoSize = true;
            cblmdDriverLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cblmdDriverLabel.Location = new Point(4, 100);
            cblmdDriverLabel.Name = "cblmdDriverLabel";
            cblmdDriverLabel.Size = new Size(151, 25);
            cblmdDriverLabel.TabIndex = 28;
            cblmdDriverLabel.Text = "cBLMD Driver:";
            // 
            // mcsTestedNum
            // 
            mcsTestedNum.AutoSize = true;
            mcsTestedNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcsTestedNum.Location = new Point(410, 60);
            mcsTestedNum.Name = "mcsTestedNum";
            mcsTestedNum.Size = new Size(56, 25);
            mcsTestedNum.TabIndex = 27;
            mcsTestedNum.Text = "Num";
            mcsTestedNum.Visible = false;
            // 
            // mcsUntestedNum
            // 
            mcsUntestedNum.AutoSize = true;
            mcsUntestedNum.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcsUntestedNum.Location = new Point(300, 60);
            mcsUntestedNum.Name = "mcsUntestedNum";
            mcsUntestedNum.Size = new Size(56, 25);
            mcsUntestedNum.TabIndex = 26;
            mcsUntestedNum.Text = "Num";
            mcsUntestedNum.Visible = false;
            // 
            // testedLabel
            // 
            testedLabel.AutoSize = true;
            testedLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            testedLabel.Location = new Point(395, 30);
            testedLabel.Name = "testedLabel";
            testedLabel.Size = new Size(78, 25);
            testedLabel.TabIndex = 25;
            testedLabel.Text = "Tested";
            // 
            // untestedLabel
            // 
            untestedLabel.AutoSize = true;
            untestedLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            untestedLabel.Location = new Point(281, 30);
            untestedLabel.Name = "untestedLabel";
            untestedLabel.Size = new Size(98, 25);
            untestedLabel.TabIndex = 24;
            untestedLabel.Text = "Untested";
            // 
            // mCSLabel
            // 
            mCSLabel.AutoSize = true;
            mCSLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mCSLabel.Location = new Point(4, 60);
            mCSLabel.Name = "mCSLabel";
            mCSLabel.Size = new Size(118, 25);
            mCSLabel.TabIndex = 23;
            mCSLabel.Text = "SLD m-CS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 10);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 10;
            label2.Text = "Overview:";
            // 
            // frmPCBTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1031, 542);
            Controls.Add(panel1);
            Controls.Add(userPanel);
            Name = "frmPCBTest";
            Text = "frmPCBTest";
            Load += frmPCBTest_Load;
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel userPanel;
        private Label label1;
        private CheckBox passCheck;
        private DateTimePicker testDateSelect;
        private Label pcbLabel;
        private TextBox reporteeName;
        private Label nameLabel;
        private ComboBox pcbSelect;
        private Label genInfoLabel;
        private TextBox genNumBox;
        private Label genNumLabel;
        private ComboBox genBox;
        private Label genLabel;
        private TextBox serialTxt;
        private Label serialLabel;
        private DateTimePicker genDateSelect;
        private Label genDateLabel;
        private Button updateBtn;
        private Button recieveBtn;
        private Panel panel1;
        private Label cblmdMainLabel;
        private Label cblmdDriverLabel;
        private Label mcsTestedNum;
        private Label mcsUntestedNum;
        private Label testedLabel;
        private Label untestedLabel;
        private Label mCSLabel;
        private Label label2;
        private Label mcsTotalNum;
        private Label stockTotalLabel;
        private Label lensLabel;
        private Label pilotDCLabel;
        private Label pilotACLabel;
        private Label bllEvalLabel;
        private Label bllLabel;
        private Label cblmdOpticalLabel;
        private Label driverUntestedNum;
        private Label driverTotalNum;
        private Label lensTestedNum;
        private Label lensUntestedNum;
        private Label lensTotalNum;
        private Label pilotDCTestedNum;
        private Label pilotDCUntestedNum;
        private Label pilotDCTotalNum;
        private Label pilotACTestedNum;
        private Label pilotACUntestedNum;
        private Label pilotACTotalNum;
        private Label evalTestedNum;
        private Label evalUntestedNum;
        private Label evalTotalNum;
        private Label bllTestedNum;
        private Label bllUntestedNum;
        private Label bllTotalNum;
        private Label opticalTestedNum;
        private Label opticalUntestedNum;
        private Label opticalTotalNum;
        private Label mainTestedNum;
        private Label mainUntestedNum;
        private Label mainTotalNum;
        private Label driverTestedNum;
        private Button refreshBtn;
    }
}