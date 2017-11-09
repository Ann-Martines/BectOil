namespace Задание6WinForms
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.grpbFilingStation = new System.Windows.Forms.GroupBox();
			this.numSum = new System.Windows.Forms.NumericUpDown();
			this.numliter = new System.Windows.Forms.NumericUpDown();
			this.cmbGasoline = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lbLiter = new System.Windows.Forms.Label();
			this.lbPriceStation = new System.Windows.Forms.Label();
			this.lbGasoline = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbSum = new System.Windows.Forms.RadioButton();
			this.rdbQuantity = new System.Windows.Forms.RadioButton();
			this.grpbPayStation = new System.Windows.Forms.GroupBox();
			this.lbPayStation = new System.Windows.Forms.Label();
			this.lbForPayStation = new System.Windows.Forms.Label();
			this.grpbCafe = new System.Windows.Forms.GroupBox();
			this.numQuantityCola = new System.Windows.Forms.NumericUpDown();
			this.numQuantityChips = new System.Windows.Forms.NumericUpDown();
			this.numQuantityHamburger = new System.Windows.Forms.NumericUpDown();
			this.numQuantityHotDog = new System.Windows.Forms.NumericUpDown();
			this.txtbPriceCola = new System.Windows.Forms.TextBox();
			this.txtbPriceChips = new System.Windows.Forms.TextBox();
			this.txtbPriceHamburger = new System.Windows.Forms.TextBox();
			this.txtbPriceHotDog = new System.Windows.Forms.TextBox();
			this.chkbCola = new System.Windows.Forms.CheckBox();
			this.chkbСhips = new System.Windows.Forms.CheckBox();
			this.chkbHamburger = new System.Windows.Forms.CheckBox();
			this.chkbHotDog = new System.Windows.Forms.CheckBox();
			this.lbQuantity = new System.Windows.Forms.Label();
			this.lbPriceCafe = new System.Windows.Forms.Label();
			this.grpbPayCafe = new System.Windows.Forms.GroupBox();
			this.lbPayCafe = new System.Windows.Forms.Label();
			this.lbForPayCafe = new System.Windows.Forms.Label();
			this.grpbAllPay = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lbPayAll = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.grpbFilingStation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numSum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numliter)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.grpbPayStation.SuspendLayout();
			this.grpbCafe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numQuantityCola)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numQuantityChips)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numQuantityHamburger)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numQuantityHotDog)).BeginInit();
			this.grpbPayCafe.SuspendLayout();
			this.grpbAllPay.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpbFilingStation
			// 
			this.grpbFilingStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.grpbFilingStation.BackColor = System.Drawing.Color.LightCyan;
			this.grpbFilingStation.Controls.Add(this.numSum);
			this.grpbFilingStation.Controls.Add(this.numliter);
			this.grpbFilingStation.Controls.Add(this.cmbGasoline);
			this.grpbFilingStation.Controls.Add(this.label1);
			this.grpbFilingStation.Controls.Add(this.txtPrice);
			this.grpbFilingStation.Controls.Add(this.label4);
			this.grpbFilingStation.Controls.Add(this.lbLiter);
			this.grpbFilingStation.Controls.Add(this.lbPriceStation);
			this.grpbFilingStation.Controls.Add(this.lbGasoline);
			this.grpbFilingStation.Controls.Add(this.groupBox1);
			this.grpbFilingStation.Controls.Add(this.grpbPayStation);
			this.grpbFilingStation.Location = new System.Drawing.Point(12, 12);
			this.grpbFilingStation.Name = "grpbFilingStation";
			this.grpbFilingStation.Size = new System.Drawing.Size(223, 254);
			this.grpbFilingStation.TabIndex = 0;
			this.grpbFilingStation.TabStop = false;
			this.grpbFilingStation.Text = "Filling station ";
			this.grpbFilingStation.Enter += new System.EventHandler(this.grpbFilingStation_Enter);
			// 
			// numSum
			// 
			this.numSum.Location = new System.Drawing.Point(124, 120);
			this.numSum.Name = "numSum";
			this.numSum.ReadOnly = true;
			this.numSum.Size = new System.Drawing.Size(52, 20);
			this.numSum.TabIndex = 13;
			// 
			// numliter
			// 
			this.numliter.Location = new System.Drawing.Point(124, 94);
			this.numliter.Name = "numliter";
			this.numliter.ReadOnly = true;
			this.numliter.Size = new System.Drawing.Size(52, 20);
			this.numliter.TabIndex = 3;
			// 
			// cmbGasoline
			// 
			this.cmbGasoline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGasoline.FormattingEnabled = true;
			this.cmbGasoline.Location = new System.Drawing.Point(74, 27);
			this.cmbGasoline.Name = "cmbGasoline";
			this.cmbGasoline.Size = new System.Drawing.Size(108, 21);
			this.cmbGasoline.TabIndex = 12;
			this.cmbGasoline.SelectedIndexChanged += new System.EventHandler(this.cmbGasoline_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(187, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "UAH";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(74, 50);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.ReadOnly = true;
			this.txtPrice.Size = new System.Drawing.Size(108, 20);
			this.txtPrice.TabIndex = 10;
			this.txtPrice.Text = "0,00";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(187, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "UAH";
			// 
			// lbLiter
			// 
			this.lbLiter.AutoSize = true;
			this.lbLiter.Location = new System.Drawing.Point(187, 99);
			this.lbLiter.Name = "lbLiter";
			this.lbLiter.Size = new System.Drawing.Size(23, 13);
			this.lbLiter.TabIndex = 5;
			this.lbLiter.Text = "liter";
			// 
			// lbPriceStation
			// 
			this.lbPriceStation.AutoSize = true;
			this.lbPriceStation.Location = new System.Drawing.Point(12, 53);
			this.lbPriceStation.Name = "lbPriceStation";
			this.lbPriceStation.Size = new System.Drawing.Size(34, 13);
			this.lbPriceStation.TabIndex = 4;
			this.lbPriceStation.Text = "Price:";
			// 
			// lbGasoline
			// 
			this.lbGasoline.AutoSize = true;
			this.lbGasoline.Location = new System.Drawing.Point(12, 30);
			this.lbGasoline.Name = "lbGasoline";
			this.lbGasoline.Size = new System.Drawing.Size(51, 13);
			this.lbGasoline.TabIndex = 3;
			this.lbGasoline.Text = "Gasoline:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbSum);
			this.groupBox1.Controls.Add(this.rdbQuantity);
			this.groupBox1.Location = new System.Drawing.Point(15, 87);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(93, 61);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// rdbSum
			// 
			this.rdbSum.AutoSize = true;
			this.rdbSum.Location = new System.Drawing.Point(6, 33);
			this.rdbSum.Name = "rdbSum";
			this.rdbSum.Size = new System.Drawing.Size(49, 17);
			this.rdbSum.TabIndex = 1;
			this.rdbSum.Text = "Sum ";
			this.rdbSum.UseVisualStyleBackColor = true;
			this.rdbSum.CheckedChanged += new System.EventHandler(this.rdbSum_CheckedChanged);
			// 
			// rdbQuantity
			// 
			this.rdbQuantity.AutoSize = true;
			this.rdbQuantity.Checked = true;
			this.rdbQuantity.Location = new System.Drawing.Point(6, 10);
			this.rdbQuantity.Name = "rdbQuantity";
			this.rdbQuantity.Size = new System.Drawing.Size(64, 17);
			this.rdbQuantity.TabIndex = 0;
			this.rdbQuantity.TabStop = true;
			this.rdbQuantity.Text = "Quantity";
			this.rdbQuantity.UseVisualStyleBackColor = true;
			this.rdbQuantity.CheckedChanged += new System.EventHandler(this.rdbQuantity_CheckedChanged);
			// 
			// grpbPayStation
			// 
			this.grpbPayStation.Controls.Add(this.lbPayStation);
			this.grpbPayStation.Controls.Add(this.lbForPayStation);
			this.grpbPayStation.Location = new System.Drawing.Point(15, 154);
			this.grpbPayStation.Name = "grpbPayStation";
			this.grpbPayStation.Size = new System.Drawing.Size(179, 77);
			this.grpbPayStation.TabIndex = 1;
			this.grpbPayStation.TabStop = false;
			this.grpbPayStation.Text = "For payment";
			// 
			// lbPayStation
			// 
			this.lbPayStation.AutoSize = true;
			this.lbPayStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbPayStation.Location = new System.Drawing.Point(60, 28);
			this.lbPayStation.Name = "lbPayStation";
			this.lbPayStation.Size = new System.Drawing.Size(71, 29);
			this.lbPayStation.TabIndex = 8;
			this.lbPayStation.Text = "00,00";
			// 
			// lbForPayStation
			// 
			this.lbForPayStation.AutoSize = true;
			this.lbForPayStation.Location = new System.Drawing.Point(137, 40);
			this.lbForPayStation.Name = "lbForPayStation";
			this.lbForPayStation.Size = new System.Drawing.Size(30, 13);
			this.lbForPayStation.TabIndex = 2;
			this.lbForPayStation.Text = "UAH";
			// 
			// grpbCafe
			// 
			this.grpbCafe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.grpbCafe.BackColor = System.Drawing.Color.LightCyan;
			this.grpbCafe.Controls.Add(this.numQuantityCola);
			this.grpbCafe.Controls.Add(this.numQuantityChips);
			this.grpbCafe.Controls.Add(this.numQuantityHamburger);
			this.grpbCafe.Controls.Add(this.numQuantityHotDog);
			this.grpbCafe.Controls.Add(this.txtbPriceCola);
			this.grpbCafe.Controls.Add(this.txtbPriceChips);
			this.grpbCafe.Controls.Add(this.txtbPriceHamburger);
			this.grpbCafe.Controls.Add(this.txtbPriceHotDog);
			this.grpbCafe.Controls.Add(this.chkbCola);
			this.grpbCafe.Controls.Add(this.chkbСhips);
			this.grpbCafe.Controls.Add(this.chkbHamburger);
			this.grpbCafe.Controls.Add(this.chkbHotDog);
			this.grpbCafe.Controls.Add(this.lbQuantity);
			this.grpbCafe.Controls.Add(this.lbPriceCafe);
			this.grpbCafe.Controls.Add(this.grpbPayCafe);
			this.grpbCafe.Location = new System.Drawing.Point(245, 12);
			this.grpbCafe.Name = "grpbCafe";
			this.grpbCafe.Size = new System.Drawing.Size(223, 254);
			this.grpbCafe.TabIndex = 1;
			this.grpbCafe.TabStop = false;
			this.grpbCafe.Text = "Mini-cafe";
			this.grpbCafe.Enter += new System.EventHandler(this.grpbCafe_Enter);
			// 
			// numQuantityCola
			// 
			this.numQuantityCola.Location = new System.Drawing.Point(169, 106);
			this.numQuantityCola.Name = "numQuantityCola";
			this.numQuantityCola.ReadOnly = true;
			this.numQuantityCola.Size = new System.Drawing.Size(48, 20);
			this.numQuantityCola.TabIndex = 18;
			this.numQuantityCola.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numQuantityChips
			// 
			this.numQuantityChips.Location = new System.Drawing.Point(169, 83);
			this.numQuantityChips.Name = "numQuantityChips";
			this.numQuantityChips.ReadOnly = true;
			this.numQuantityChips.Size = new System.Drawing.Size(48, 20);
			this.numQuantityChips.TabIndex = 17;
			this.numQuantityChips.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numQuantityHamburger
			// 
			this.numQuantityHamburger.Location = new System.Drawing.Point(169, 60);
			this.numQuantityHamburger.Name = "numQuantityHamburger";
			this.numQuantityHamburger.ReadOnly = true;
			this.numQuantityHamburger.Size = new System.Drawing.Size(48, 20);
			this.numQuantityHamburger.TabIndex = 16;
			this.numQuantityHamburger.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numQuantityHotDog
			// 
			this.numQuantityHotDog.Location = new System.Drawing.Point(169, 37);
			this.numQuantityHotDog.Name = "numQuantityHotDog";
			this.numQuantityHotDog.ReadOnly = true;
			this.numQuantityHotDog.Size = new System.Drawing.Size(48, 20);
			this.numQuantityHotDog.TabIndex = 15;
			this.numQuantityHotDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txtbPriceCola
			// 
			this.txtbPriceCola.Location = new System.Drawing.Point(108, 106);
			this.txtbPriceCola.Name = "txtbPriceCola";
			this.txtbPriceCola.ReadOnly = true;
			this.txtbPriceCola.Size = new System.Drawing.Size(48, 20);
			this.txtbPriceCola.TabIndex = 10;
			this.txtbPriceCola.Text = "8,60";
			// 
			// txtbPriceChips
			// 
			this.txtbPriceChips.Location = new System.Drawing.Point(108, 83);
			this.txtbPriceChips.Name = "txtbPriceChips";
			this.txtbPriceChips.ReadOnly = true;
			this.txtbPriceChips.Size = new System.Drawing.Size(48, 20);
			this.txtbPriceChips.TabIndex = 9;
			this.txtbPriceChips.Text = "9,45";
			// 
			// txtbPriceHamburger
			// 
			this.txtbPriceHamburger.Location = new System.Drawing.Point(108, 60);
			this.txtbPriceHamburger.Name = "txtbPriceHamburger";
			this.txtbPriceHamburger.ReadOnly = true;
			this.txtbPriceHamburger.Size = new System.Drawing.Size(48, 20);
			this.txtbPriceHamburger.TabIndex = 8;
			this.txtbPriceHamburger.Text = "14,50";
			// 
			// txtbPriceHotDog
			// 
			this.txtbPriceHotDog.Location = new System.Drawing.Point(108, 37);
			this.txtbPriceHotDog.Name = "txtbPriceHotDog";
			this.txtbPriceHotDog.ReadOnly = true;
			this.txtbPriceHotDog.Size = new System.Drawing.Size(48, 20);
			this.txtbPriceHotDog.TabIndex = 7;
			this.txtbPriceHotDog.Text = "12,00";
			// 
			// chkbCola
			// 
			this.chkbCola.AutoSize = true;
			this.chkbCola.Location = new System.Drawing.Point(16, 108);
			this.chkbCola.Name = "chkbCola";
			this.chkbCola.Size = new System.Drawing.Size(47, 17);
			this.chkbCola.TabIndex = 6;
			this.chkbCola.Text = "Cola";
			this.chkbCola.UseVisualStyleBackColor = true;
			this.chkbCola.CheckedChanged += new System.EventHandler(this.chkbCola_CheckedChanged);
			// 
			// chkbСhips
			// 
			this.chkbСhips.AutoSize = true;
			this.chkbСhips.Location = new System.Drawing.Point(16, 85);
			this.chkbСhips.Name = "chkbСhips";
			this.chkbСhips.Size = new System.Drawing.Size(52, 17);
			this.chkbСhips.TabIndex = 5;
			this.chkbСhips.Text = "Сhips";
			this.chkbСhips.UseVisualStyleBackColor = true;
			this.chkbСhips.CheckedChanged += new System.EventHandler(this.chkbСhips_CheckedChanged);
			// 
			// chkbHamburger
			// 
			this.chkbHamburger.AutoSize = true;
			this.chkbHamburger.Location = new System.Drawing.Point(16, 62);
			this.chkbHamburger.Name = "chkbHamburger";
			this.chkbHamburger.Size = new System.Drawing.Size(81, 17);
			this.chkbHamburger.TabIndex = 4;
			this.chkbHamburger.Text = "Hamburger ";
			this.chkbHamburger.UseVisualStyleBackColor = true;
			this.chkbHamburger.CheckedChanged += new System.EventHandler(this.chkbHamburger_CheckedChanged);
			// 
			// chkbHotDog
			// 
			this.chkbHotDog.AutoSize = true;
			this.chkbHotDog.Location = new System.Drawing.Point(16, 39);
			this.chkbHotDog.Name = "chkbHotDog";
			this.chkbHotDog.Size = new System.Drawing.Size(64, 17);
			this.chkbHotDog.TabIndex = 3;
			this.chkbHotDog.Text = "Hot dog";
			this.chkbHotDog.UseVisualStyleBackColor = true;
			this.chkbHotDog.CheckedChanged += new System.EventHandler(this.chkbHotDog_CheckedChanged);
			// 
			// lbQuantity
			// 
			this.lbQuantity.AutoSize = true;
			this.lbQuantity.Location = new System.Drawing.Point(171, 20);
			this.lbQuantity.Name = "lbQuantity";
			this.lbQuantity.Size = new System.Drawing.Size(49, 13);
			this.lbQuantity.TabIndex = 2;
			this.lbQuantity.Text = "Quantity:";
			// 
			// lbPriceCafe
			// 
			this.lbPriceCafe.AutoSize = true;
			this.lbPriceCafe.Location = new System.Drawing.Point(115, 21);
			this.lbPriceCafe.Name = "lbPriceCafe";
			this.lbPriceCafe.Size = new System.Drawing.Size(34, 13);
			this.lbPriceCafe.TabIndex = 0;
			this.lbPriceCafe.Text = "Price:";
			// 
			// grpbPayCafe
			// 
			this.grpbPayCafe.Controls.Add(this.lbPayCafe);
			this.grpbPayCafe.Controls.Add(this.lbForPayCafe);
			this.grpbPayCafe.Location = new System.Drawing.Point(16, 154);
			this.grpbPayCafe.Name = "grpbPayCafe";
			this.grpbPayCafe.Size = new System.Drawing.Size(186, 77);
			this.grpbPayCafe.TabIndex = 1;
			this.grpbPayCafe.TabStop = false;
			this.grpbPayCafe.Text = "For payment";
			// 
			// lbPayCafe
			// 
			this.lbPayCafe.AutoSize = true;
			this.lbPayCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbPayCafe.Location = new System.Drawing.Point(69, 28);
			this.lbPayCafe.Name = "lbPayCafe";
			this.lbPayCafe.Size = new System.Drawing.Size(71, 29);
			this.lbPayCafe.TabIndex = 3;
			this.lbPayCafe.Text = "00,00";
			// 
			// lbForPayCafe
			// 
			this.lbForPayCafe.AutoSize = true;
			this.lbForPayCafe.Location = new System.Drawing.Point(145, 40);
			this.lbForPayCafe.Name = "lbForPayCafe";
			this.lbForPayCafe.Size = new System.Drawing.Size(30, 13);
			this.lbForPayCafe.TabIndex = 0;
			this.lbForPayCafe.Text = "UAH";
			// 
			// grpbAllPay
			// 
			this.grpbAllPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.grpbAllPay.BackColor = System.Drawing.Color.LightCyan;
			this.grpbAllPay.Controls.Add(this.button1);
			this.grpbAllPay.Controls.Add(this.label2);
			this.grpbAllPay.Controls.Add(this.lbPayAll);
			this.grpbAllPay.Location = new System.Drawing.Point(12, 288);
			this.grpbAllPay.Name = "grpbAllPay";
			this.grpbAllPay.Size = new System.Drawing.Size(456, 100);
			this.grpbAllPay.TabIndex = 2;
			this.grpbAllPay.TabStop = false;
			this.grpbAllPay.Text = "All payment";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(80, 25);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 58);
			this.button1.TabIndex = 4;
			this.button1.Text = "Count  ";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(394, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "UAH";
			// 
			// lbPayAll
			// 
			this.lbPayAll.AutoSize = true;
			this.lbPayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbPayAll.Location = new System.Drawing.Point(300, 48);
			this.lbPayAll.Name = "lbPayAll";
			this.lbPayAll.Size = new System.Drawing.Size(71, 29);
			this.lbPayAll.TabIndex = 3;
			this.lbPayAll.Text = "00,00";
			// 
			// timer1
			// 
			this.timer1.Interval = 10000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(483, 400);
			this.Controls.Add(this.grpbAllPay);
			this.Controls.Add(this.grpbCafe);
			this.Controls.Add(this.grpbFilingStation);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "BestOil";
			this.grpbFilingStation.ResumeLayout(false);
			this.grpbFilingStation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numSum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numliter)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.grpbPayStation.ResumeLayout(false);
			this.grpbPayStation.PerformLayout();
			this.grpbCafe.ResumeLayout(false);
			this.grpbCafe.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numQuantityCola)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numQuantityChips)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numQuantityHamburger)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numQuantityHotDog)).EndInit();
			this.grpbPayCafe.ResumeLayout(false);
			this.grpbPayCafe.PerformLayout();
			this.grpbAllPay.ResumeLayout(false);
			this.grpbAllPay.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpbFilingStation;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbLiter;
		private System.Windows.Forms.Label lbPriceStation;
		private System.Windows.Forms.Label lbGasoline;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdbSum;
		private System.Windows.Forms.RadioButton rdbQuantity;
		private System.Windows.Forms.GroupBox grpbPayStation;
		private System.Windows.Forms.Label lbPayStation;
		private System.Windows.Forms.Label lbForPayStation;
		private System.Windows.Forms.GroupBox grpbCafe;
		private System.Windows.Forms.Label lbQuantity;
		private System.Windows.Forms.Label lbPriceCafe;
		private System.Windows.Forms.GroupBox grpbPayCafe;
		private System.Windows.Forms.Label lbPayCafe;
		private System.Windows.Forms.Label lbForPayCafe;
		private System.Windows.Forms.GroupBox grpbAllPay;
		private System.Windows.Forms.Label lbPayAll;
		private System.Windows.Forms.TextBox txtbPriceCola;
		private System.Windows.Forms.TextBox txtbPriceChips;
		private System.Windows.Forms.TextBox txtbPriceHamburger;
		private System.Windows.Forms.TextBox txtbPriceHotDog;
		private System.Windows.Forms.CheckBox chkbCola;
		private System.Windows.Forms.CheckBox chkbСhips;
		private System.Windows.Forms.CheckBox chkbHamburger;
		private System.Windows.Forms.CheckBox chkbHotDog;
		private System.Windows.Forms.ComboBox cmbGasoline;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.NumericUpDown numliter;
		private System.Windows.Forms.NumericUpDown numSum;
		private System.Windows.Forms.NumericUpDown numQuantityCola;
		private System.Windows.Forms.NumericUpDown numQuantityChips;
		private System.Windows.Forms.NumericUpDown numQuantityHamburger;
		private System.Windows.Forms.NumericUpDown numQuantityHotDog;
	}
}

