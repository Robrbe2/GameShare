namespace PancakeClicker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonPancake = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelClickerMoney = new System.Windows.Forms.Label();
            this.buttonClicker = new System.Windows.Forms.Button();
            this.buttonGrandma = new System.Windows.Forms.Button();
            this.labelClickerAmount = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonFarm = new System.Windows.Forms.Button();
            this.buttonMT = new System.Windows.Forms.Button();
            this.buttonTP = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderUpgrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.labelMoneyPerTick = new System.Windows.Forms.Label();
            this.labelGrandmaMoney = new System.Windows.Forms.Label();
            this.labelGrandmaAmount = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Save = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonStartOver = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelPSCAmount = new System.Windows.Forms.Label();
            this.buttonPSC = new System.Windows.Forms.Button();
            this.labelPSCMoney = new System.Windows.Forms.Label();
            this.labelACAmount = new System.Windows.Forms.Label();
            this.buttonAC = new System.Windows.Forms.Button();
            this.labelACMoney = new System.Windows.Forms.Label();
            this.labelTPAmount = new System.Windows.Forms.Label();
            this.labelTPMoney = new System.Windows.Forms.Label();
            this.labelPortalAmount = new System.Windows.Forms.Label();
            this.buttonPortal = new System.Windows.Forms.Button();
            this.labelPortalMoney = new System.Windows.Forms.Label();
            this.labelALAmount = new System.Windows.Forms.Label();
            this.buttonAL = new System.Windows.Forms.Button();
            this.labelALMoney = new System.Windows.Forms.Label();
            this.labelMTAmount = new System.Windows.Forms.Label();
            this.labelMTMoney = new System.Windows.Forms.Label();
            this.labelTempleAmount = new System.Windows.Forms.Label();
            this.buttonTemple = new System.Windows.Forms.Button();
            this.labelTempleMoney = new System.Windows.Forms.Label();
            this.labelFactoryAmount = new System.Windows.Forms.Label();
            this.buttonFactory = new System.Windows.Forms.Button();
            this.labelFactoryMoney = new System.Windows.Forms.Label();
            this.labelFarmAmount = new System.Windows.Forms.Label();
            this.labelFarmMoney = new System.Windows.Forms.Label();
            this.labelBakerAmount = new System.Windows.Forms.Label();
            this.buttonBaker = new System.Windows.Forms.Button();
            this.labelBakerMoney = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.buttonAdd1000000Money = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonPancake
            // 
            this.buttonPancake.Location = new System.Drawing.Point(11, 11);
            this.buttonPancake.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPancake.Name = "buttonPancake";
            this.buttonPancake.Size = new System.Drawing.Size(88, 81);
            this.buttonPancake.TabIndex = 0;
            this.buttonPancake.Tag = "";
            this.buttonPancake.Text = "Pancake";
            this.buttonPancake.UseVisualStyleBackColor = true;
            this.buttonPancake.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonPancake_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pancakes:";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(198, 14);
            this.labelMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(13, 13);
            this.labelMoney.TabIndex = 2;
            this.labelMoney.Text = "0";
            // 
            // labelClickerMoney
            // 
            this.labelClickerMoney.AutoSize = true;
            this.labelClickerMoney.Location = new System.Drawing.Point(169, 171);
            this.labelClickerMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClickerMoney.Name = "labelClickerMoney";
            this.labelClickerMoney.Size = new System.Drawing.Size(14, 13);
            this.labelClickerMoney.TabIndex = 3;
            this.labelClickerMoney.Text = "T";
            // 
            // buttonClicker
            // 
            this.buttonClicker.Location = new System.Drawing.Point(9, 171);
            this.buttonClicker.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClicker.Name = "buttonClicker";
            this.buttonClicker.Size = new System.Drawing.Size(150, 33);
            this.buttonClicker.TabIndex = 4;
            this.buttonClicker.Tag = "1";
            this.buttonClicker.Text = "Buy Clicker";
            this.toolTip1.SetToolTip(this.buttonClicker, "A basic pancake clicker");
            this.buttonClicker.UseVisualStyleBackColor = true;
            this.buttonClicker.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // buttonGrandma
            // 
            this.buttonGrandma.Location = new System.Drawing.Point(9, 208);
            this.buttonGrandma.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGrandma.Name = "buttonGrandma";
            this.buttonGrandma.Size = new System.Drawing.Size(150, 33);
            this.buttonGrandma.TabIndex = 5;
            this.buttonGrandma.Tag = "2";
            this.buttonGrandma.Text = "Buy Grandma";
            this.buttonGrandma.UseVisualStyleBackColor = true;
            this.buttonGrandma.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelClickerAmount
            // 
            this.labelClickerAmount.AutoSize = true;
            this.labelClickerAmount.Location = new System.Drawing.Point(169, 191);
            this.labelClickerAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClickerAmount.Name = "labelClickerAmount";
            this.labelClickerAmount.Size = new System.Drawing.Size(14, 13);
            this.labelClickerAmount.TabIndex = 6;
            this.labelClickerAmount.Text = "T";
            // 
            // buttonFarm
            // 
            this.buttonFarm.Location = new System.Drawing.Point(9, 282);
            this.buttonFarm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFarm.Name = "buttonFarm";
            this.buttonFarm.Size = new System.Drawing.Size(152, 33);
            this.buttonFarm.TabIndex = 18;
            this.buttonFarm.Tag = "4";
            this.buttonFarm.Text = "Buy Farm";
            this.toolTip1.SetToolTip(this.buttonFarm, "A basic pancake clicker");
            this.buttonFarm.UseVisualStyleBackColor = true;
            this.buttonFarm.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // buttonMT
            // 
            this.buttonMT.Location = new System.Drawing.Point(374, 171);
            this.buttonMT.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMT.Name = "buttonMT";
            this.buttonMT.Size = new System.Drawing.Size(150, 33);
            this.buttonMT.TabIndex = 27;
            this.buttonMT.Tag = "7";
            this.buttonMT.Text = "Buy Magic tower";
            this.toolTip1.SetToolTip(this.buttonMT, "A basic pancake clicker");
            this.buttonMT.UseVisualStyleBackColor = true;
            this.buttonMT.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // buttonTP
            // 
            this.buttonTP.Location = new System.Drawing.Point(374, 282);
            this.buttonTP.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTP.Name = "buttonTP";
            this.buttonTP.Size = new System.Drawing.Size(152, 33);
            this.buttonTP.TabIndex = 36;
            this.buttonTP.Tag = "10";
            this.buttonTP.Text = "Buy Time portal";
            this.toolTip1.SetToolTip(this.buttonTP, "A basic pancake clicker");
            this.buttonTP.UseVisualStyleBackColor = true;
            this.buttonTP.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUpgrade,
            this.columnHeaderPrice});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(399, 430);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // columnHeaderUpgrade
            // 
            this.columnHeaderUpgrade.Text = "Upgrade";
            this.columnHeaderUpgrade.Width = 195;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Money per second:";
            // 
            // labelMoneyPerTick
            // 
            this.labelMoneyPerTick.AutoSize = true;
            this.labelMoneyPerTick.Location = new System.Drawing.Point(198, 31);
            this.labelMoneyPerTick.Name = "labelMoneyPerTick";
            this.labelMoneyPerTick.Size = new System.Drawing.Size(13, 13);
            this.labelMoneyPerTick.TabIndex = 10;
            this.labelMoneyPerTick.Text = "0";
            // 
            // labelGrandmaMoney
            // 
            this.labelGrandmaMoney.AutoSize = true;
            this.labelGrandmaMoney.Location = new System.Drawing.Point(169, 208);
            this.labelGrandmaMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGrandmaMoney.Name = "labelGrandmaMoney";
            this.labelGrandmaMoney.Size = new System.Drawing.Size(14, 13);
            this.labelGrandmaMoney.TabIndex = 11;
            this.labelGrandmaMoney.Text = "T";
            // 
            // labelGrandmaAmount
            // 
            this.labelGrandmaAmount.AutoSize = true;
            this.labelGrandmaAmount.Location = new System.Drawing.Point(169, 228);
            this.labelGrandmaAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGrandmaAmount.Name = "labelGrandmaAmount";
            this.labelGrandmaAmount.Size = new System.Drawing.Size(14, 13);
            this.labelGrandmaAmount.TabIndex = 12;
            this.labelGrandmaAmount.Text = "T";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 300000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(3, 478);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 13;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonStartOver);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton5);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton4);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton3);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton2);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton1);
            this.splitContainer1.Panel1.Controls.Add(this.labelPSCAmount);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPSC);
            this.splitContainer1.Panel1.Controls.Add(this.labelPSCMoney);
            this.splitContainer1.Panel1.Controls.Add(this.labelACAmount);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAC);
            this.splitContainer1.Panel1.Controls.Add(this.labelACMoney);
            this.splitContainer1.Panel1.Controls.Add(this.buttonTP);
            this.splitContainer1.Panel1.Controls.Add(this.labelTPAmount);
            this.splitContainer1.Panel1.Controls.Add(this.labelTPMoney);
            this.splitContainer1.Panel1.Controls.Add(this.labelPortalAmount);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPortal);
            this.splitContainer1.Panel1.Controls.Add(this.labelPortalMoney);
            this.splitContainer1.Panel1.Controls.Add(this.labelALAmount);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAL);
            this.splitContainer1.Panel1.Controls.Add(this.labelALMoney);
            this.splitContainer1.Panel1.Controls.Add(this.buttonMT);
            this.splitContainer1.Panel1.Controls.Add(this.labelMTAmount);
            this.splitContainer1.Panel1.Controls.Add(this.labelMTMoney);
            this.splitContainer1.Panel1.Controls.Add(this.labelTempleAmount);
            this.splitContainer1.Panel1.Controls.Add(this.buttonTemple);
            this.splitContainer1.Panel1.Controls.Add(this.labelTempleMoney);
            this.splitContainer1.Panel1.Controls.Add(this.labelFactoryAmount);
            this.splitContainer1.Panel1.Controls.Add(this.buttonFactory);
            this.splitContainer1.Panel1.Controls.Add(this.labelFactoryMoney);
            this.splitContainer1.Panel1.Controls.Add(this.buttonFarm);
            this.splitContainer1.Panel1.Controls.Add(this.labelFarmAmount);
            this.splitContainer1.Panel1.Controls.Add(this.labelFarmMoney);
            this.splitContainer1.Panel1.Controls.Add(this.labelBakerAmount);
            this.splitContainer1.Panel1.Controls.Add(this.buttonBaker);
            this.splitContainer1.Panel1.Controls.Add(this.labelBakerMoney);
            this.splitContainer1.Panel1.Controls.Add(this.Save);
            this.splitContainer1.Panel1.Controls.Add(this.labelGrandmaAmount);
            this.splitContainer1.Panel1.Controls.Add(this.buttonGrandma);
            this.splitContainer1.Panel1.Controls.Add(this.labelGrandmaMoney);
            this.splitContainer1.Panel1.Controls.Add(this.buttonClicker);
            this.splitContainer1.Panel1.Controls.Add(this.labelClickerAmount);
            this.splitContainer1.Panel1.Controls.Add(this.labelMoneyPerTick);
            this.splitContainer1.Panel1.Controls.Add(this.labelClickerMoney);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPancake);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.labelMoney);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1133, 504);
            this.splitContainer1.SplitterDistance = 730;
            this.splitContainer1.TabIndex = 14;
            // 
            // buttonStartOver
            // 
            this.buttonStartOver.Location = new System.Drawing.Point(84, 478);
            this.buttonStartOver.Name = "buttonStartOver";
            this.buttonStartOver.Size = new System.Drawing.Size(75, 23);
            this.buttonStartOver.TabIndex = 49;
            this.buttonStartOver.Text = "Start Over";
            this.buttonStartOver.UseVisualStyleBackColor = true;
            this.buttonStartOver.Click += new System.EventHandler(this.buttonStartOver_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(259, 139);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(65, 17);
            this.radioButton5.TabIndex = 48;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Buy max";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(192, 139);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(64, 17);
            this.radioButton4.TabIndex = 47;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Buy 100";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(128, 139);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 17);
            this.radioButton3.TabIndex = 46;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Buy 10";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(70, 139);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 17);
            this.radioButton2.TabIndex = 45;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Buy 5";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 139);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 44;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Buy 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // labelPSCAmount
            // 
            this.labelPSCAmount.AutoSize = true;
            this.labelPSCAmount.Location = new System.Drawing.Point(534, 376);
            this.labelPSCAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPSCAmount.Name = "labelPSCAmount";
            this.labelPSCAmount.Size = new System.Drawing.Size(14, 13);
            this.labelPSCAmount.TabIndex = 43;
            this.labelPSCAmount.Text = "T";
            // 
            // buttonPSC
            // 
            this.buttonPSC.Location = new System.Drawing.Point(374, 356);
            this.buttonPSC.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPSC.Name = "buttonPSC";
            this.buttonPSC.Size = new System.Drawing.Size(152, 33);
            this.buttonPSC.TabIndex = 41;
            this.buttonPSC.Tag = "12";
            this.buttonPSC.Text = "Buy PanScript console";
            this.buttonPSC.UseVisualStyleBackColor = true;
            this.buttonPSC.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelPSCMoney
            // 
            this.labelPSCMoney.AutoSize = true;
            this.labelPSCMoney.Location = new System.Drawing.Point(534, 356);
            this.labelPSCMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPSCMoney.Name = "labelPSCMoney";
            this.labelPSCMoney.Size = new System.Drawing.Size(14, 13);
            this.labelPSCMoney.TabIndex = 42;
            this.labelPSCMoney.Text = "T";
            // 
            // labelACAmount
            // 
            this.labelACAmount.AutoSize = true;
            this.labelACAmount.Location = new System.Drawing.Point(534, 339);
            this.labelACAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelACAmount.Name = "labelACAmount";
            this.labelACAmount.Size = new System.Drawing.Size(14, 13);
            this.labelACAmount.TabIndex = 40;
            this.labelACAmount.Text = "T";
            // 
            // buttonAC
            // 
            this.buttonAC.Location = new System.Drawing.Point(374, 319);
            this.buttonAC.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAC.Name = "buttonAC";
            this.buttonAC.Size = new System.Drawing.Size(152, 33);
            this.buttonAC.TabIndex = 37;
            this.buttonAC.Tag = "11";
            this.buttonAC.Text = "Buy Antipancake condenser";
            this.buttonAC.UseVisualStyleBackColor = true;
            this.buttonAC.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelACMoney
            // 
            this.labelACMoney.AutoSize = true;
            this.labelACMoney.Location = new System.Drawing.Point(534, 319);
            this.labelACMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelACMoney.Name = "labelACMoney";
            this.labelACMoney.Size = new System.Drawing.Size(14, 13);
            this.labelACMoney.TabIndex = 39;
            this.labelACMoney.Text = "T";
            // 
            // labelTPAmount
            // 
            this.labelTPAmount.AutoSize = true;
            this.labelTPAmount.Location = new System.Drawing.Point(534, 302);
            this.labelTPAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTPAmount.Name = "labelTPAmount";
            this.labelTPAmount.Size = new System.Drawing.Size(14, 13);
            this.labelTPAmount.TabIndex = 38;
            this.labelTPAmount.Text = "T";
            // 
            // labelTPMoney
            // 
            this.labelTPMoney.AutoSize = true;
            this.labelTPMoney.Location = new System.Drawing.Point(534, 282);
            this.labelTPMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTPMoney.Name = "labelTPMoney";
            this.labelTPMoney.Size = new System.Drawing.Size(14, 13);
            this.labelTPMoney.TabIndex = 35;
            this.labelTPMoney.Text = "T";
            // 
            // labelPortalAmount
            // 
            this.labelPortalAmount.AutoSize = true;
            this.labelPortalAmount.Location = new System.Drawing.Point(534, 265);
            this.labelPortalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPortalAmount.Name = "labelPortalAmount";
            this.labelPortalAmount.Size = new System.Drawing.Size(14, 13);
            this.labelPortalAmount.TabIndex = 34;
            this.labelPortalAmount.Text = "T";
            // 
            // buttonPortal
            // 
            this.buttonPortal.Location = new System.Drawing.Point(374, 245);
            this.buttonPortal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPortal.Name = "buttonPortal";
            this.buttonPortal.Size = new System.Drawing.Size(152, 33);
            this.buttonPortal.TabIndex = 32;
            this.buttonPortal.Tag = "9";
            this.buttonPortal.Text = "Buy Portal";
            this.buttonPortal.UseVisualStyleBackColor = true;
            this.buttonPortal.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelPortalMoney
            // 
            this.labelPortalMoney.AutoSize = true;
            this.labelPortalMoney.Location = new System.Drawing.Point(534, 245);
            this.labelPortalMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPortalMoney.Name = "labelPortalMoney";
            this.labelPortalMoney.Size = new System.Drawing.Size(14, 13);
            this.labelPortalMoney.TabIndex = 33;
            this.labelPortalMoney.Text = "T";
            // 
            // labelALAmount
            // 
            this.labelALAmount.AutoSize = true;
            this.labelALAmount.Location = new System.Drawing.Point(534, 228);
            this.labelALAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelALAmount.Name = "labelALAmount";
            this.labelALAmount.Size = new System.Drawing.Size(14, 13);
            this.labelALAmount.TabIndex = 31;
            this.labelALAmount.Text = "T";
            // 
            // buttonAL
            // 
            this.buttonAL.Location = new System.Drawing.Point(374, 208);
            this.buttonAL.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAL.Name = "buttonAL";
            this.buttonAL.Size = new System.Drawing.Size(150, 33);
            this.buttonAL.TabIndex = 28;
            this.buttonAL.Tag = "8";
            this.buttonAL.Text = "Buy alchemy lab";
            this.buttonAL.UseVisualStyleBackColor = true;
            this.buttonAL.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelALMoney
            // 
            this.labelALMoney.AutoSize = true;
            this.labelALMoney.Location = new System.Drawing.Point(534, 208);
            this.labelALMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelALMoney.Name = "labelALMoney";
            this.labelALMoney.Size = new System.Drawing.Size(14, 13);
            this.labelALMoney.TabIndex = 30;
            this.labelALMoney.Text = "T";
            // 
            // labelMTAmount
            // 
            this.labelMTAmount.AutoSize = true;
            this.labelMTAmount.Location = new System.Drawing.Point(534, 191);
            this.labelMTAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMTAmount.Name = "labelMTAmount";
            this.labelMTAmount.Size = new System.Drawing.Size(14, 13);
            this.labelMTAmount.TabIndex = 29;
            this.labelMTAmount.Text = "T";
            // 
            // labelMTMoney
            // 
            this.labelMTMoney.AutoSize = true;
            this.labelMTMoney.Location = new System.Drawing.Point(534, 171);
            this.labelMTMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMTMoney.Name = "labelMTMoney";
            this.labelMTMoney.Size = new System.Drawing.Size(14, 13);
            this.labelMTMoney.TabIndex = 26;
            this.labelMTMoney.Text = "T";
            // 
            // labelTempleAmount
            // 
            this.labelTempleAmount.AutoSize = true;
            this.labelTempleAmount.Location = new System.Drawing.Point(169, 376);
            this.labelTempleAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTempleAmount.Name = "labelTempleAmount";
            this.labelTempleAmount.Size = new System.Drawing.Size(14, 13);
            this.labelTempleAmount.TabIndex = 25;
            this.labelTempleAmount.Text = "T";
            // 
            // buttonTemple
            // 
            this.buttonTemple.Location = new System.Drawing.Point(9, 356);
            this.buttonTemple.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTemple.Name = "buttonTemple";
            this.buttonTemple.Size = new System.Drawing.Size(152, 33);
            this.buttonTemple.TabIndex = 23;
            this.buttonTemple.Tag = "6";
            this.buttonTemple.Text = "Buy Temple";
            this.buttonTemple.UseVisualStyleBackColor = true;
            this.buttonTemple.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelTempleMoney
            // 
            this.labelTempleMoney.AutoSize = true;
            this.labelTempleMoney.Location = new System.Drawing.Point(169, 356);
            this.labelTempleMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTempleMoney.Name = "labelTempleMoney";
            this.labelTempleMoney.Size = new System.Drawing.Size(14, 13);
            this.labelTempleMoney.TabIndex = 24;
            this.labelTempleMoney.Text = "T";
            // 
            // labelFactoryAmount
            // 
            this.labelFactoryAmount.AutoSize = true;
            this.labelFactoryAmount.Location = new System.Drawing.Point(169, 339);
            this.labelFactoryAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFactoryAmount.Name = "labelFactoryAmount";
            this.labelFactoryAmount.Size = new System.Drawing.Size(14, 13);
            this.labelFactoryAmount.TabIndex = 22;
            this.labelFactoryAmount.Text = "T";
            // 
            // buttonFactory
            // 
            this.buttonFactory.Location = new System.Drawing.Point(9, 319);
            this.buttonFactory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFactory.Name = "buttonFactory";
            this.buttonFactory.Size = new System.Drawing.Size(152, 33);
            this.buttonFactory.TabIndex = 19;
            this.buttonFactory.Tag = "5";
            this.buttonFactory.Text = "Buy Factory";
            this.buttonFactory.UseVisualStyleBackColor = true;
            this.buttonFactory.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelFactoryMoney
            // 
            this.labelFactoryMoney.AutoSize = true;
            this.labelFactoryMoney.Location = new System.Drawing.Point(169, 319);
            this.labelFactoryMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFactoryMoney.Name = "labelFactoryMoney";
            this.labelFactoryMoney.Size = new System.Drawing.Size(14, 13);
            this.labelFactoryMoney.TabIndex = 21;
            this.labelFactoryMoney.Text = "T";
            // 
            // labelFarmAmount
            // 
            this.labelFarmAmount.AutoSize = true;
            this.labelFarmAmount.Location = new System.Drawing.Point(169, 302);
            this.labelFarmAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFarmAmount.Name = "labelFarmAmount";
            this.labelFarmAmount.Size = new System.Drawing.Size(14, 13);
            this.labelFarmAmount.TabIndex = 20;
            this.labelFarmAmount.Text = "T";
            // 
            // labelFarmMoney
            // 
            this.labelFarmMoney.AutoSize = true;
            this.labelFarmMoney.Location = new System.Drawing.Point(169, 282);
            this.labelFarmMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFarmMoney.Name = "labelFarmMoney";
            this.labelFarmMoney.Size = new System.Drawing.Size(14, 13);
            this.labelFarmMoney.TabIndex = 17;
            this.labelFarmMoney.Text = "T";
            // 
            // labelBakerAmount
            // 
            this.labelBakerAmount.AutoSize = true;
            this.labelBakerAmount.Location = new System.Drawing.Point(169, 265);
            this.labelBakerAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBakerAmount.Name = "labelBakerAmount";
            this.labelBakerAmount.Size = new System.Drawing.Size(14, 13);
            this.labelBakerAmount.TabIndex = 16;
            this.labelBakerAmount.Text = "T";
            // 
            // buttonBaker
            // 
            this.buttonBaker.Location = new System.Drawing.Point(9, 245);
            this.buttonBaker.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBaker.Name = "buttonBaker";
            this.buttonBaker.Size = new System.Drawing.Size(150, 33);
            this.buttonBaker.TabIndex = 14;
            this.buttonBaker.Tag = "3";
            this.buttonBaker.Text = "Buy Baker";
            this.buttonBaker.UseVisualStyleBackColor = true;
            this.buttonBaker.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelBakerMoney
            // 
            this.labelBakerMoney.AutoSize = true;
            this.labelBakerMoney.Location = new System.Drawing.Point(169, 245);
            this.labelBakerMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBakerMoney.Name = "labelBakerMoney";
            this.labelBakerMoney.Size = new System.Drawing.Size(14, 13);
            this.labelBakerMoney.TabIndex = 15;
            this.labelBakerMoney.Text = "T";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(399, 504);
            this.splitContainer2.SplitterDistance = 30;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.buttonAdd1000000Money);
            this.splitContainer3.Size = new System.Drawing.Size(399, 470);
            this.splitContainer3.SplitterDistance = 430;
            this.splitContainer3.TabIndex = 0;
            // 
            // buttonAdd1000000Money
            // 
            this.buttonAdd1000000Money.Location = new System.Drawing.Point(394, 31);
            this.buttonAdd1000000Money.Name = "buttonAdd1000000Money";
            this.buttonAdd1000000Money.Size = new System.Drawing.Size(1, 1);
            this.buttonAdd1000000Money.TabIndex = 0;
            this.buttonAdd1000000Money.UseVisualStyleBackColor = true;
            this.buttonAdd1000000Money.Click += new System.EventHandler(this.buttonAdd1000000Money_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 504);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Pancake Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonPancake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelClickerMoney;
        private System.Windows.Forms.Button buttonClicker;
        private System.Windows.Forms.Button buttonGrandma;
        private System.Windows.Forms.Label labelClickerAmount;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderUpgrade;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMoneyPerTick;
        private System.Windows.Forms.Label labelGrandmaMoney;
        private System.Windows.Forms.Label labelGrandmaAmount;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label labelBakerAmount;
        private System.Windows.Forms.Button buttonBaker;
        private System.Windows.Forms.Label labelBakerMoney;
        private System.Windows.Forms.Label labelPSCAmount;
        private System.Windows.Forms.Button buttonPSC;
        private System.Windows.Forms.Label labelPSCMoney;
        private System.Windows.Forms.Label labelACAmount;
        private System.Windows.Forms.Button buttonAC;
        private System.Windows.Forms.Label labelACMoney;
        private System.Windows.Forms.Button buttonTP;
        private System.Windows.Forms.Label labelTPAmount;
        private System.Windows.Forms.Label labelTPMoney;
        private System.Windows.Forms.Label labelPortalAmount;
        private System.Windows.Forms.Button buttonPortal;
        private System.Windows.Forms.Label labelPortalMoney;
        private System.Windows.Forms.Label labelALAmount;
        private System.Windows.Forms.Button buttonAL;
        private System.Windows.Forms.Label labelALMoney;
        private System.Windows.Forms.Button buttonMT;
        private System.Windows.Forms.Label labelMTAmount;
        private System.Windows.Forms.Label labelMTMoney;
        private System.Windows.Forms.Label labelTempleAmount;
        private System.Windows.Forms.Button buttonTemple;
        private System.Windows.Forms.Label labelTempleMoney;
        private System.Windows.Forms.Label labelFactoryAmount;
        private System.Windows.Forms.Button buttonFactory;
        private System.Windows.Forms.Label labelFactoryMoney;
        private System.Windows.Forms.Button buttonFarm;
        private System.Windows.Forms.Label labelFarmAmount;
        private System.Windows.Forms.Label labelFarmMoney;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button buttonStartOver;
        private System.Windows.Forms.Button buttonAdd1000000Money;
    }
}

