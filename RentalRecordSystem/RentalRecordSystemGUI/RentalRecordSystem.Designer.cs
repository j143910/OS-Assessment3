namespace RentalRecordSystemGUI
{
    partial class RentalRecordSystem
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxAddVehicleManufacturer = new System.Windows.Forms.TextBox();
            this.txtBoxAddVehicleModel = new System.Windows.Forms.TextBox();
            this.dtpAddVehicleMakeYear = new System.Windows.Forms.DateTimePicker();
            this.txtBoxAddVehicleRegistrationNo = new System.Windows.Forms.TextBox();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbAddJourneyVehicle = new System.Windows.Forms.ComboBox();
            this.nudAddJourneyDistanceTravelled = new System.Windows.Forms.NumericUpDown();
            this.cmbAddFuelPurchaseVehicle = new System.Windows.Forms.ComboBox();
            this.nudAddFuelPurchaseQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudAddFuelPurchaseCost = new System.Windows.Forms.NumericUpDown();
            this.cmbAddPerKmRentalVehicle = new System.Windows.Forms.ComboBox();
            this.nudAddPerKmRentalKmTravelled = new System.Windows.Forms.NumericUpDown();
            this.cmbAddPerDayRentalVehicle = new System.Windows.Forms.ComboBox();
            this.nudAddPerDayRentalDaysRented = new System.Windows.Forms.NumericUpDown();
            this.cmbAddServiceVehicle = new System.Windows.Forms.ComboBox();
            this.btnAddJourney = new System.Windows.Forms.Button();
            this.btnAddFuelPurchase = new System.Windows.Forms.Button();
            this.btnAddPerKmRental = new System.Windows.Forms.Button();
            this.btnAddPerDayRental = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBoxViewVehicleRecord = new System.Windows.Forms.TextBox();
            this.cmbViewVehicleRecords = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnViewRecordsRefresh = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddJourneyDistanceTravelled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddFuelPurchaseQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddFuelPurchaseCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddPerKmRentalKmTravelled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddPerDayRentalDaysRented)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Controls.Add(this.groupBox5);
            this.flowLayoutPanel1.Controls.Add(this.groupBox6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(328, 377);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddVehicle);
            this.groupBox1.Controls.Add(this.txtBoxAddVehicleRegistrationNo);
            this.groupBox1.Controls.Add(this.dtpAddVehicleMakeYear);
            this.groupBox1.Controls.Add(this.txtBoxAddVehicleModel);
            this.groupBox1.Controls.Add(this.txtBoxAddVehicleManufacturer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Vehicle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MakeYear";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Registration No";
            // 
            // txtBoxAddVehicleManufacturer
            // 
            this.txtBoxAddVehicleManufacturer.Location = new System.Drawing.Point(92, 19);
            this.txtBoxAddVehicleManufacturer.Name = "txtBoxAddVehicleManufacturer";
            this.txtBoxAddVehicleManufacturer.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAddVehicleManufacturer.TabIndex = 4;
            // 
            // txtBoxAddVehicleModel
            // 
            this.txtBoxAddVehicleModel.Location = new System.Drawing.Point(92, 45);
            this.txtBoxAddVehicleModel.Name = "txtBoxAddVehicleModel";
            this.txtBoxAddVehicleModel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAddVehicleModel.TabIndex = 5;
            // 
            // dtpAddVehicleMakeYear
            // 
            this.dtpAddVehicleMakeYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAddVehicleMakeYear.Location = new System.Drawing.Point(92, 71);
            this.dtpAddVehicleMakeYear.Name = "dtpAddVehicleMakeYear";
            this.dtpAddVehicleMakeYear.ShowUpDown = true;
            this.dtpAddVehicleMakeYear.Size = new System.Drawing.Size(57, 20);
            this.dtpAddVehicleMakeYear.TabIndex = 6;
            // 
            // txtBoxAddVehicleRegistrationNo
            // 
            this.txtBoxAddVehicleRegistrationNo.Location = new System.Drawing.Point(92, 97);
            this.txtBoxAddVehicleRegistrationNo.Name = "txtBoxAddVehicleRegistrationNo";
            this.txtBoxAddVehicleRegistrationNo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAddVehicleRegistrationNo.TabIndex = 7;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(209, 94);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnAddVehicle.TabIndex = 8;
            this.btnAddVehicle.Text = "Submit";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddJourney);
            this.groupBox2.Controls.Add(this.nudAddJourneyDistanceTravelled);
            this.groupBox2.Controls.Add(this.cmbAddJourneyVehicle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(3, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Journey";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddFuelPurchase);
            this.groupBox3.Controls.Add(this.nudAddFuelPurchaseCost);
            this.groupBox3.Controls.Add(this.nudAddFuelPurchaseQuantity);
            this.groupBox3.Controls.Add(this.cmbAddFuelPurchaseVehicle);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(3, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Fuel Purchase";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddPerKmRental);
            this.groupBox4.Controls.Add(this.nudAddPerKmRentalKmTravelled);
            this.groupBox4.Controls.Add(this.cmbAddPerKmRentalVehicle);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(3, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(304, 77);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Per Km Rental";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAddPerDayRental);
            this.groupBox5.Controls.Add(this.nudAddPerDayRentalDaysRented);
            this.groupBox5.Controls.Add(this.cmbAddPerDayRentalVehicle);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(3, 408);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 76);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add Per Day Rental";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAddService);
            this.groupBox6.Controls.Add(this.cmbAddServiceVehicle);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Location = new System.Drawing.Point(3, 490);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(304, 53);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Add Service";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vehicle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Distance Travelled Km";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vehicle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Fuel Cost Per L";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Fuel Quantity Purchased L";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Vehicle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Km Travelled";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Vehicle";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Days Rented";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Vehicle";
            // 
            // cmbAddJourneyVehicle
            // 
            this.cmbAddJourneyVehicle.FormattingEnabled = true;
            this.cmbAddJourneyVehicle.Location = new System.Drawing.Point(54, 19);
            this.cmbAddJourneyVehicle.Name = "cmbAddJourneyVehicle";
            this.cmbAddJourneyVehicle.Size = new System.Drawing.Size(121, 21);
            this.cmbAddJourneyVehicle.TabIndex = 2;
            // 
            // nudAddJourneyDistanceTravelled
            // 
            this.nudAddJourneyDistanceTravelled.DecimalPlaces = 2;
            this.nudAddJourneyDistanceTravelled.Location = new System.Drawing.Point(126, 46);
            this.nudAddJourneyDistanceTravelled.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudAddJourneyDistanceTravelled.Name = "nudAddJourneyDistanceTravelled";
            this.nudAddJourneyDistanceTravelled.Size = new System.Drawing.Size(67, 20);
            this.nudAddJourneyDistanceTravelled.TabIndex = 3;
            this.nudAddJourneyDistanceTravelled.ThousandsSeparator = true;
            // 
            // cmbAddFuelPurchaseVehicle
            // 
            this.cmbAddFuelPurchaseVehicle.FormattingEnabled = true;
            this.cmbAddFuelPurchaseVehicle.Location = new System.Drawing.Point(54, 19);
            this.cmbAddFuelPurchaseVehicle.Name = "cmbAddFuelPurchaseVehicle";
            this.cmbAddFuelPurchaseVehicle.Size = new System.Drawing.Size(121, 21);
            this.cmbAddFuelPurchaseVehicle.TabIndex = 3;
            // 
            // nudAddFuelPurchaseQuantity
            // 
            this.nudAddFuelPurchaseQuantity.DecimalPlaces = 1;
            this.nudAddFuelPurchaseQuantity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudAddFuelPurchaseQuantity.Location = new System.Drawing.Point(144, 44);
            this.nudAddFuelPurchaseQuantity.Name = "nudAddFuelPurchaseQuantity";
            this.nudAddFuelPurchaseQuantity.Size = new System.Drawing.Size(57, 20);
            this.nudAddFuelPurchaseQuantity.TabIndex = 4;
            // 
            // nudAddFuelPurchaseCost
            // 
            this.nudAddFuelPurchaseCost.DecimalPlaces = 2;
            this.nudAddFuelPurchaseCost.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudAddFuelPurchaseCost.Location = new System.Drawing.Point(144, 70);
            this.nudAddFuelPurchaseCost.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAddFuelPurchaseCost.Name = "nudAddFuelPurchaseCost";
            this.nudAddFuelPurchaseCost.Size = new System.Drawing.Size(57, 20);
            this.nudAddFuelPurchaseCost.TabIndex = 5;
            // 
            // cmbAddPerKmRentalVehicle
            // 
            this.cmbAddPerKmRentalVehicle.FormattingEnabled = true;
            this.cmbAddPerKmRentalVehicle.Location = new System.Drawing.Point(53, 19);
            this.cmbAddPerKmRentalVehicle.Name = "cmbAddPerKmRentalVehicle";
            this.cmbAddPerKmRentalVehicle.Size = new System.Drawing.Size(121, 21);
            this.cmbAddPerKmRentalVehicle.TabIndex = 2;
            // 
            // nudAddPerKmRentalKmTravelled
            // 
            this.nudAddPerKmRentalKmTravelled.DecimalPlaces = 2;
            this.nudAddPerKmRentalKmTravelled.Location = new System.Drawing.Point(81, 46);
            this.nudAddPerKmRentalKmTravelled.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudAddPerKmRentalKmTravelled.Name = "nudAddPerKmRentalKmTravelled";
            this.nudAddPerKmRentalKmTravelled.Size = new System.Drawing.Size(65, 20);
            this.nudAddPerKmRentalKmTravelled.TabIndex = 3;
            // 
            // cmbAddPerDayRentalVehicle
            // 
            this.cmbAddPerDayRentalVehicle.FormattingEnabled = true;
            this.cmbAddPerDayRentalVehicle.Location = new System.Drawing.Point(53, 19);
            this.cmbAddPerDayRentalVehicle.Name = "cmbAddPerDayRentalVehicle";
            this.cmbAddPerDayRentalVehicle.Size = new System.Drawing.Size(121, 21);
            this.cmbAddPerDayRentalVehicle.TabIndex = 2;
            // 
            // nudAddPerDayRentalDaysRented
            // 
            this.nudAddPerDayRentalDaysRented.Location = new System.Drawing.Point(81, 46);
            this.nudAddPerDayRentalDaysRented.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAddPerDayRentalDaysRented.Name = "nudAddPerDayRentalDaysRented";
            this.nudAddPerDayRentalDaysRented.Size = new System.Drawing.Size(44, 20);
            this.nudAddPerDayRentalDaysRented.TabIndex = 3;
            // 
            // cmbAddServiceVehicle
            // 
            this.cmbAddServiceVehicle.FormattingEnabled = true;
            this.cmbAddServiceVehicle.Location = new System.Drawing.Point(57, 19);
            this.cmbAddServiceVehicle.Name = "cmbAddServiceVehicle";
            this.cmbAddServiceVehicle.Size = new System.Drawing.Size(121, 21);
            this.cmbAddServiceVehicle.TabIndex = 1;
            // 
            // btnAddJourney
            // 
            this.btnAddJourney.Location = new System.Drawing.Point(209, 43);
            this.btnAddJourney.Name = "btnAddJourney";
            this.btnAddJourney.Size = new System.Drawing.Size(75, 23);
            this.btnAddJourney.TabIndex = 4;
            this.btnAddJourney.Text = "Submit";
            this.btnAddJourney.UseVisualStyleBackColor = true;
            this.btnAddJourney.Click += new System.EventHandler(this.btnAddJourney_Click);
            // 
            // btnAddFuelPurchase
            // 
            this.btnAddFuelPurchase.Location = new System.Drawing.Point(209, 67);
            this.btnAddFuelPurchase.Name = "btnAddFuelPurchase";
            this.btnAddFuelPurchase.Size = new System.Drawing.Size(75, 23);
            this.btnAddFuelPurchase.TabIndex = 6;
            this.btnAddFuelPurchase.Text = "Submit";
            this.btnAddFuelPurchase.UseVisualStyleBackColor = true;
            this.btnAddFuelPurchase.Click += new System.EventHandler(this.btnAddFuelPurchase_Click);
            // 
            // btnAddPerKmRental
            // 
            this.btnAddPerKmRental.Location = new System.Drawing.Point(209, 43);
            this.btnAddPerKmRental.Name = "btnAddPerKmRental";
            this.btnAddPerKmRental.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerKmRental.TabIndex = 4;
            this.btnAddPerKmRental.Text = "Submit";
            this.btnAddPerKmRental.UseVisualStyleBackColor = true;
            this.btnAddPerKmRental.Click += new System.EventHandler(this.btnAddPerKmRental_Click);
            // 
            // btnAddPerDayRental
            // 
            this.btnAddPerDayRental.Location = new System.Drawing.Point(209, 43);
            this.btnAddPerDayRental.Name = "btnAddPerDayRental";
            this.btnAddPerDayRental.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerDayRental.TabIndex = 4;
            this.btnAddPerDayRental.Text = "Submit";
            this.btnAddPerDayRental.UseVisualStyleBackColor = true;
            this.btnAddPerDayRental.Click += new System.EventHandler(this.btnAddPerDayRental_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(209, 19);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(75, 23);
            this.btnAddService.TabIndex = 2;
            this.btnAddService.Text = "Submit";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(342, 409);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(334, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Records";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnViewRecordsRefresh);
            this.tabPage2.Controls.Add(this.txtBoxViewVehicleRecord);
            this.tabPage2.Controls.Add(this.cmbViewVehicleRecords);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(334, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Records";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtBoxViewVehicleRecord
            // 
            this.txtBoxViewVehicleRecord.Location = new System.Drawing.Point(5, 33);
            this.txtBoxViewVehicleRecord.Multiline = true;
            this.txtBoxViewVehicleRecord.Name = "txtBoxViewVehicleRecord";
            this.txtBoxViewVehicleRecord.Size = new System.Drawing.Size(321, 182);
            this.txtBoxViewVehicleRecord.TabIndex = 2;
            // 
            // cmbViewVehicleRecords
            // 
            this.cmbViewVehicleRecords.FormattingEnabled = true;
            this.cmbViewVehicleRecords.Location = new System.Drawing.Point(56, 6);
            this.cmbViewVehicleRecords.Name = "cmbViewVehicleRecords";
            this.cmbViewVehicleRecords.Size = new System.Drawing.Size(121, 21);
            this.cmbViewVehicleRecords.TabIndex = 1;
            this.cmbViewVehicleRecords.SelectedIndexChanged += new System.EventHandler(this.cmbViewVehicleRecords_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Vehicle";
            // 
            // btnViewRecordsRefresh
            // 
            this.btnViewRecordsRefresh.Location = new System.Drawing.Point(8, 221);
            this.btnViewRecordsRefresh.Name = "btnViewRecordsRefresh";
            this.btnViewRecordsRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnViewRecordsRefresh.TabIndex = 3;
            this.btnViewRecordsRefresh.Text = "Refresh";
            this.btnViewRecordsRefresh.UseVisualStyleBackColor = true;
            this.btnViewRecordsRefresh.Click += new System.EventHandler(this.btnViewRecordsRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 409);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(358, 618);
            this.MinimumSize = new System.Drawing.Size(358, 311);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddJourneyDistanceTravelled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddFuelPurchaseQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddFuelPurchaseCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddPerKmRentalKmTravelled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddPerDayRentalDaysRented)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAddVehicleMakeYear;
        private System.Windows.Forms.TextBox txtBoxAddVehicleModel;
        private System.Windows.Forms.TextBox txtBoxAddVehicleManufacturer;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.TextBox txtBoxAddVehicleRegistrationNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAddJourney;
        private System.Windows.Forms.NumericUpDown nudAddJourneyDistanceTravelled;
        private System.Windows.Forms.ComboBox cmbAddJourneyVehicle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddFuelPurchase;
        private System.Windows.Forms.NumericUpDown nudAddFuelPurchaseCost;
        private System.Windows.Forms.NumericUpDown nudAddFuelPurchaseQuantity;
        private System.Windows.Forms.ComboBox cmbAddFuelPurchaseVehicle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddPerKmRental;
        private System.Windows.Forms.NumericUpDown nudAddPerKmRentalKmTravelled;
        private System.Windows.Forms.ComboBox cmbAddPerKmRentalVehicle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddPerDayRental;
        private System.Windows.Forms.NumericUpDown nudAddPerDayRentalDaysRented;
        private System.Windows.Forms.ComboBox cmbAddPerDayRentalVehicle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.ComboBox cmbAddServiceVehicle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtBoxViewVehicleRecord;
        private System.Windows.Forms.ComboBox cmbViewVehicleRecords;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnViewRecordsRefresh;
    }
}

