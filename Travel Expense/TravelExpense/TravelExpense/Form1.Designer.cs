namespace TravelExpense
{
    partial class TravelExpense
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
            this.datesGroupBox = new System.Windows.Forms.GroupBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.endTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.startTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.returnMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.startMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.tripDataTabControl = new System.Windows.Forms.TabControl();
            this.domesticTabPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculateDomestic = new System.Windows.Forms.Button();
            this.txtPersonsAccompanying = new System.Windows.Forms.TextBox();
            this.txtKMAllowance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFullHalfDayAllowance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullDayAllowance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton0 = new System.Windows.Forms.RadioButton();
            this.lblDistance = new System.Windows.Forms.Label();
            this.distanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.abroadTabPage = new System.Windows.Forms.TabPage();
            this.btnCalculateAbroad = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.lblTotalData = new System.Windows.Forms.Label();
            this.lblKMData = new System.Windows.Forms.Label();
            this.lblDaysAllowanceData = new System.Windows.Forms.Label();
            this.lblMinutesData = new System.Windows.Forms.Label();
            this.lblHoursData = new System.Windows.Forms.Label();
            this.lblDaysData = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblKM = new System.Windows.Forms.Label();
            this.lblDaysAllowance = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lbldays = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datesGroupBox.SuspendLayout();
            this.tripDataTabControl.SuspendLayout();
            this.domesticTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).BeginInit();
            this.abroadTabPage.SuspendLayout();
            this.dataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datesGroupBox
            // 
            this.datesGroupBox.Controls.Add(this.lblEndTime);
            this.datesGroupBox.Controls.Add(this.endTimeMaskedTextBox);
            this.datesGroupBox.Controls.Add(this.lblStartTime);
            this.datesGroupBox.Controls.Add(this.lblEndDate);
            this.datesGroupBox.Controls.Add(this.lblStartDate);
            this.datesGroupBox.Controls.Add(this.startTimeMaskedTextBox);
            this.datesGroupBox.Controls.Add(this.returnMonthCalendar);
            this.datesGroupBox.Controls.Add(this.startMonthCalendar);
            this.datesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datesGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.datesGroupBox.Location = new System.Drawing.Point(9, 7);
            this.datesGroupBox.Name = "datesGroupBox";
            this.datesGroupBox.Size = new System.Drawing.Size(452, 246);
            this.datesGroupBox.TabIndex = 0;
            this.datesGroupBox.TabStop = false;
            this.datesGroupBox.Text = "Travel Dates";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEndTime.Location = new System.Drawing.Point(237, 208);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(60, 13);
            this.lblEndTime.TabIndex = 9;
            this.lblEndTime.Text = "End Time";
            // 
            // endTimeMaskedTextBox
            // 
            this.endTimeMaskedTextBox.Location = new System.Drawing.Point(308, 204);
            this.endTimeMaskedTextBox.Mask = "16:00";
            this.endTimeMaskedTextBox.Name = "endTimeMaskedTextBox";
            this.endTimeMaskedTextBox.Size = new System.Drawing.Size(61, 20);
            this.endTimeMaskedTextBox.TabIndex = 8;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStartTime.Location = new System.Drawing.Point(10, 211);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(65, 13);
            this.lblStartTime.TabIndex = 7;
            this.lblStartTime.Text = "Start Time";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEndDate.Location = new System.Drawing.Point(266, 23);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(60, 13);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStartDate.Location = new System.Drawing.Point(37, 22);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(65, 13);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Start Date";
            // 
            // startTimeMaskedTextBox
            // 
            this.startTimeMaskedTextBox.Location = new System.Drawing.Point(81, 207);
            this.startTimeMaskedTextBox.Mask = "08:00";
            this.startTimeMaskedTextBox.Name = "startTimeMaskedTextBox";
            this.startTimeMaskedTextBox.Size = new System.Drawing.Size(61, 20);
            this.startTimeMaskedTextBox.TabIndex = 2;
            // 
            // returnMonthCalendar
            // 
            this.returnMonthCalendar.Location = new System.Drawing.Point(239, 45);
            this.returnMonthCalendar.Name = "returnMonthCalendar";
            this.returnMonthCalendar.TabIndex = 1;
            // 
            // startMonthCalendar
            // 
            this.startMonthCalendar.Location = new System.Drawing.Point(13, 42);
            this.startMonthCalendar.Name = "startMonthCalendar";
            this.startMonthCalendar.TabIndex = 0;
            // 
            // tripDataTabControl
            // 
            this.tripDataTabControl.Controls.Add(this.domesticTabPage);
            this.tripDataTabControl.Controls.Add(this.abroadTabPage);
            this.tripDataTabControl.Location = new System.Drawing.Point(10, 267);
            this.tripDataTabControl.Name = "tripDataTabControl";
            this.tripDataTabControl.SelectedIndex = 0;
            this.tripDataTabControl.Size = new System.Drawing.Size(452, 240);
            this.tripDataTabControl.TabIndex = 1;
            // 
            // domesticTabPage
            // 
            this.domesticTabPage.Controls.Add(this.label4);
            this.domesticTabPage.Controls.Add(this.btnCalculateDomestic);
            this.domesticTabPage.Controls.Add(this.txtPersonsAccompanying);
            this.domesticTabPage.Controls.Add(this.txtKMAllowance);
            this.domesticTabPage.Controls.Add(this.label5);
            this.domesticTabPage.Controls.Add(this.txtFullHalfDayAllowance);
            this.domesticTabPage.Controls.Add(this.label3);
            this.domesticTabPage.Controls.Add(this.txtFullDayAllowance);
            this.domesticTabPage.Controls.Add(this.label2);
            this.domesticTabPage.Controls.Add(this.radioButton4);
            this.domesticTabPage.Controls.Add(this.radioButton3);
            this.domesticTabPage.Controls.Add(this.radioButton2);
            this.domesticTabPage.Controls.Add(this.radioButton1);
            this.domesticTabPage.Controls.Add(this.label1);
            this.domesticTabPage.Controls.Add(this.radioButton0);
            this.domesticTabPage.Controls.Add(this.lblDistance);
            this.domesticTabPage.Controls.Add(this.distanceNumericUpDown);
            this.domesticTabPage.Controls.Add(this.checkBox1);
            this.domesticTabPage.Location = new System.Drawing.Point(4, 22);
            this.domesticTabPage.Name = "domesticTabPage";
            this.domesticTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.domesticTabPage.Size = new System.Drawing.Size(444, 214);
            this.domesticTabPage.TabIndex = 0;
            this.domesticTabPage.Text = "Domestic Trip Data";
            this.domesticTabPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Persons Accompanying (£/pers/km) ";
            // 
            // btnCalculateDomestic
            // 
            this.btnCalculateDomestic.Location = new System.Drawing.Point(351, 177);
            this.btnCalculateDomestic.Name = "btnCalculateDomestic";
            this.btnCalculateDomestic.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateDomestic.TabIndex = 17;
            this.btnCalculateDomestic.Text = "&Calculate";
            this.btnCalculateDomestic.UseVisualStyleBackColor = true;
            // 
            // txtPersonsAccompanying
            // 
            this.txtPersonsAccompanying.Location = new System.Drawing.Point(362, 134);
            this.txtPersonsAccompanying.Name = "txtPersonsAccompanying";
            this.txtPersonsAccompanying.Size = new System.Drawing.Size(63, 20);
            this.txtPersonsAccompanying.TabIndex = 16;
            // 
            // txtKMAllowance
            // 
            this.txtKMAllowance.Location = new System.Drawing.Point(361, 100);
            this.txtKMAllowance.Name = "txtKMAllowance";
            this.txtKMAllowance.Size = new System.Drawing.Size(64, 20);
            this.txtKMAllowance.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Killometer Allowance (km/£)";
            // 
            // txtFullHalfDayAllowance
            // 
            this.txtFullHalfDayAllowance.Location = new System.Drawing.Point(361, 65);
            this.txtFullHalfDayAllowance.Name = "txtFullHalfDayAllowance";
            this.txtFullHalfDayAllowance.Size = new System.Drawing.Size(64, 20);
            this.txtFullHalfDayAllowance.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Half Daily Allowance (£)";
            // 
            // txtFullDayAllowance
            // 
            this.txtFullDayAllowance.Location = new System.Drawing.Point(362, 30);
            this.txtFullDayAllowance.Name = "txtFullDayAllowance";
            this.txtFullDayAllowance.Size = new System.Drawing.Size(63, 20);
            this.txtFullDayAllowance.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Full Daily Allowance (£)";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(77, 135);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(21, 135);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(130, 111);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(77, 111);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Persons accompanying in the car";
            // 
            // radioButton0
            // 
            this.radioButton0.AutoSize = true;
            this.radioButton0.Checked = true;
            this.radioButton0.Location = new System.Drawing.Point(21, 111);
            this.radioButton0.Name = "radioButton0";
            this.radioButton0.Size = new System.Drawing.Size(31, 17);
            this.radioButton0.TabIndex = 3;
            this.radioButton0.TabStop = true;
            this.radioButton0.Text = "0";
            this.radioButton0.UseVisualStyleBackColor = true;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(17, 51);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(119, 13);
            this.lblDistance.TabIndex = 2;
            this.lblDistance.Text = "Distance of the trip (km)";
            // 
            // distanceNumericUpDown
            // 
            this.distanceNumericUpDown.Location = new System.Drawing.Point(142, 49);
            this.distanceNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.distanceNumericUpDown.Name = "distanceNumericUpDown";
            this.distanceNumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.distanceNumericUpDown.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(20, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Trip was done with one\'s car";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // abroadTabPage
            // 
            this.abroadTabPage.Controls.Add(this.btnCalculateAbroad);
            this.abroadTabPage.Controls.Add(this.textBox1);
            this.abroadTabPage.Controls.Add(this.label6);
            this.abroadTabPage.Controls.Add(this.listBox1);
            this.abroadTabPage.Location = new System.Drawing.Point(4, 22);
            this.abroadTabPage.Name = "abroadTabPage";
            this.abroadTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.abroadTabPage.Size = new System.Drawing.Size(444, 214);
            this.abroadTabPage.TabIndex = 1;
            this.abroadTabPage.Text = "Abroad Trip Data";
            this.abroadTabPage.UseVisualStyleBackColor = true;
            // 
            // btnCalculateAbroad
            // 
            this.btnCalculateAbroad.Location = new System.Drawing.Point(313, 165);
            this.btnCalculateAbroad.Name = "btnCalculateAbroad";
            this.btnCalculateAbroad.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateAbroad.TabIndex = 3;
            this.btnCalculateAbroad.Text = "&Calculate";
            this.btnCalculateAbroad.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Daily Allowance (£)";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(126, 186);
            this.listBox1.TabIndex = 0;
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.lblTotalData);
            this.dataGroupBox.Controls.Add(this.lblKMData);
            this.dataGroupBox.Controls.Add(this.lblDaysAllowanceData);
            this.dataGroupBox.Controls.Add(this.lblMinutesData);
            this.dataGroupBox.Controls.Add(this.lblHoursData);
            this.dataGroupBox.Controls.Add(this.lblDaysData);
            this.dataGroupBox.Controls.Add(this.lblTotal);
            this.dataGroupBox.Controls.Add(this.lblKM);
            this.dataGroupBox.Controls.Add(this.lblDaysAllowance);
            this.dataGroupBox.Controls.Add(this.lblMinutes);
            this.dataGroupBox.Controls.Add(this.lblHours);
            this.dataGroupBox.Controls.Add(this.lbldays);
            this.dataGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGroupBox.Location = new System.Drawing.Point(10, 530);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(513, 82);
            this.dataGroupBox.TabIndex = 2;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Travel Data";
            // 
            // lblTotalData
            // 
            this.lblTotalData.AutoSize = true;
            this.lblTotalData.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalData.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTotalData.Location = new System.Drawing.Point(441, 48);
            this.lblTotalData.Name = "lblTotalData";
            this.lblTotalData.Size = new System.Drawing.Size(0, 16);
            this.lblTotalData.TabIndex = 11;
            // 
            // lblKMData
            // 
            this.lblKMData.AutoSize = true;
            this.lblKMData.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKMData.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblKMData.Location = new System.Drawing.Point(312, 48);
            this.lblKMData.Name = "lblKMData";
            this.lblKMData.Size = new System.Drawing.Size(0, 16);
            this.lblKMData.TabIndex = 10;
            // 
            // lblDaysAllowanceData
            // 
            this.lblDaysAllowanceData.AutoSize = true;
            this.lblDaysAllowanceData.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysAllowanceData.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDaysAllowanceData.Location = new System.Drawing.Point(186, 48);
            this.lblDaysAllowanceData.Name = "lblDaysAllowanceData";
            this.lblDaysAllowanceData.Size = new System.Drawing.Size(0, 16);
            this.lblDaysAllowanceData.TabIndex = 9;
            // 
            // lblMinutesData
            // 
            this.lblMinutesData.AutoSize = true;
            this.lblMinutesData.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutesData.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMinutesData.Location = new System.Drawing.Point(121, 48);
            this.lblMinutesData.Name = "lblMinutesData";
            this.lblMinutesData.Size = new System.Drawing.Size(0, 16);
            this.lblMinutesData.TabIndex = 8;
            // 
            // lblHoursData
            // 
            this.lblHoursData.AutoSize = true;
            this.lblHoursData.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursData.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHoursData.Location = new System.Drawing.Point(64, 48);
            this.lblHoursData.Name = "lblHoursData";
            this.lblHoursData.Size = new System.Drawing.Size(0, 16);
            this.lblHoursData.TabIndex = 7;
            // 
            // lblDaysData
            // 
            this.lblDaysData.AutoSize = true;
            this.lblDaysData.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysData.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDaysData.Location = new System.Drawing.Point(9, 48);
            this.lblDaysData.Name = "lblDaysData";
            this.lblDaysData.Size = new System.Drawing.Size(0, 16);
            this.lblDaysData.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(441, 21);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total";
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKM.Location = new System.Drawing.Point(310, 23);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(104, 16);
            this.lblKM.TabIndex = 4;
            this.lblKM.Text = "KM Allowance";
            // 
            // lblDaysAllowance
            // 
            this.lblDaysAllowance.AutoSize = true;
            this.lblDaysAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysAllowance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDaysAllowance.Location = new System.Drawing.Point(185, 23);
            this.lblDaysAllowance.Name = "lblDaysAllowance";
            this.lblDaysAllowance.Size = new System.Drawing.Size(119, 16);
            this.lblDaysAllowance.TabIndex = 3;
            this.lblDaysAllowance.Text = "Daily Allowance";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMinutes.Location = new System.Drawing.Point(121, 22);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(61, 16);
            this.lblMinutes.TabIndex = 2;
            this.lblMinutes.Text = "Minutes";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHours.Location = new System.Drawing.Point(63, 21);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(49, 16);
            this.lblHours.TabIndex = 1;
            this.lblHours.Text = "Hours";
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldays.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbldays.Location = new System.Drawing.Point(7, 20);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(44, 16);
            this.lbldays.TabIndex = 0;
            this.lbldays.Text = "Days";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(499, 466);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "&Read from File";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(474, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 57);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TravelExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 621);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.tripDataTabControl);
            this.Controls.Add(this.datesGroupBox);
            this.Name = "TravelExpense";
            this.Text = "Travel Expense Report";
            this.datesGroupBox.ResumeLayout(false);
            this.datesGroupBox.PerformLayout();
            this.tripDataTabControl.ResumeLayout(false);
            this.domesticTabPage.ResumeLayout(false);
            this.domesticTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).EndInit();
            this.abroadTabPage.ResumeLayout(false);
            this.abroadTabPage.PerformLayout();
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox datesGroupBox;
        private System.Windows.Forms.MonthCalendar returnMonthCalendar;
        private System.Windows.Forms.MonthCalendar startMonthCalendar;
        private System.Windows.Forms.MaskedTextBox startTimeMaskedTextBox;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.MaskedTextBox endTimeMaskedTextBox;
        private System.Windows.Forms.TabControl tripDataTabControl;
        private System.Windows.Forms.TabPage domesticTabPage;
        private System.Windows.Forms.TabPage abroadTabPage;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton0;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.NumericUpDown distanceNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnCalculateDomestic;
        private System.Windows.Forms.TextBox txtPersonsAccompanying;
        private System.Windows.Forms.TextBox txtKMAllowance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFullHalfDayAllowance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullDayAllowance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCalculateAbroad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label lblDaysAllowance;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblHoursData;
        private System.Windows.Forms.Label lblDaysData;
        private System.Windows.Forms.Label lblTotalData;
        private System.Windows.Forms.Label lblKMData;
        private System.Windows.Forms.Label lblDaysAllowanceData;
        private System.Windows.Forms.Label lblMinutesData;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

