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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
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
            this.labelUnlockedAchievements = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startOverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.achievementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonPancake
            // 
            this.buttonPancake.Location = new System.Drawing.Point(14, 48);
            this.buttonPancake.Name = "buttonPancake";
            this.buttonPancake.Size = new System.Drawing.Size(132, 125);
            this.buttonPancake.TabIndex = 0;
            this.buttonPancake.Tag = "";
            this.buttonPancake.Text = "Pancake";
            this.buttonPancake.UseVisualStyleBackColor = true;
            this.buttonPancake.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonPancake_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pancakes:";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(295, 52);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(18, 20);
            this.labelMoney.TabIndex = 2;
            this.labelMoney.Text = "0";
            // 
            // labelClickerMoney
            // 
            this.labelClickerMoney.AutoSize = true;
            this.labelClickerMoney.Location = new System.Drawing.Point(254, 263);
            this.labelClickerMoney.Name = "labelClickerMoney";
            this.labelClickerMoney.Size = new System.Drawing.Size(18, 20);
            this.labelClickerMoney.TabIndex = 3;
            this.labelClickerMoney.Text = "T";
            // 
            // buttonClicker
            // 
            this.buttonClicker.Location = new System.Drawing.Point(14, 263);
            this.buttonClicker.Name = "buttonClicker";
            this.buttonClicker.Size = new System.Drawing.Size(225, 51);
            this.buttonClicker.TabIndex = 4;
            this.buttonClicker.Tag = "1";
            this.buttonClicker.Text = "Buy Clicker";
            this.toolTip1.SetToolTip(this.buttonClicker, "A basic pancake clicker");
            this.buttonClicker.UseVisualStyleBackColor = true;
            this.buttonClicker.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // buttonGrandma
            // 
            this.buttonGrandma.Location = new System.Drawing.Point(14, 320);
            this.buttonGrandma.Name = "buttonGrandma";
            this.buttonGrandma.Size = new System.Drawing.Size(225, 51);
            this.buttonGrandma.TabIndex = 5;
            this.buttonGrandma.Tag = "2";
            this.buttonGrandma.Text = "Buy Grandma";
            this.buttonGrandma.UseVisualStyleBackColor = true;
            this.buttonGrandma.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelClickerAmount
            // 
            this.labelClickerAmount.AutoSize = true;
            this.labelClickerAmount.Location = new System.Drawing.Point(254, 294);
            this.labelClickerAmount.Name = "labelClickerAmount";
            this.labelClickerAmount.Size = new System.Drawing.Size(18, 20);
            this.labelClickerAmount.TabIndex = 6;
            this.labelClickerAmount.Text = "T";
            // 
            // buttonFarm
            // 
            this.buttonFarm.Location = new System.Drawing.Point(14, 434);
            this.buttonFarm.Name = "buttonFarm";
            this.buttonFarm.Size = new System.Drawing.Size(228, 51);
            this.buttonFarm.TabIndex = 18;
            this.buttonFarm.Tag = "4";
            this.buttonFarm.Text = "Buy Farm";
            this.toolTip1.SetToolTip(this.buttonFarm, "A basic pancake clicker");
            this.buttonFarm.UseVisualStyleBackColor = true;
            this.buttonFarm.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // buttonMT
            // 
            this.buttonMT.Location = new System.Drawing.Point(561, 263);
            this.buttonMT.Name = "buttonMT";
            this.buttonMT.Size = new System.Drawing.Size(225, 51);
            this.buttonMT.TabIndex = 27;
            this.buttonMT.Tag = "7";
            this.buttonMT.Text = "Buy Magic tower";
            this.toolTip1.SetToolTip(this.buttonMT, "A basic pancake clicker");
            this.buttonMT.UseVisualStyleBackColor = true;
            this.buttonMT.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // buttonTP
            // 
            this.buttonTP.Location = new System.Drawing.Point(561, 434);
            this.buttonTP.Name = "buttonTP";
            this.buttonTP.Size = new System.Drawing.Size(228, 51);
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
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(599, 661);
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
            this.label2.Location = new System.Drawing.Point(152, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Money per second:";
            // 
            // labelMoneyPerTick
            // 
            this.labelMoneyPerTick.AutoSize = true;
            this.labelMoneyPerTick.Location = new System.Drawing.Point(295, 78);
            this.labelMoneyPerTick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoneyPerTick.Name = "labelMoneyPerTick";
            this.labelMoneyPerTick.Size = new System.Drawing.Size(18, 20);
            this.labelMoneyPerTick.TabIndex = 10;
            this.labelMoneyPerTick.Text = "0";
            // 
            // labelGrandmaMoney
            // 
            this.labelGrandmaMoney.AutoSize = true;
            this.labelGrandmaMoney.Location = new System.Drawing.Point(254, 320);
            this.labelGrandmaMoney.Name = "labelGrandmaMoney";
            this.labelGrandmaMoney.Size = new System.Drawing.Size(18, 20);
            this.labelGrandmaMoney.TabIndex = 11;
            this.labelGrandmaMoney.Text = "T";
            // 
            // labelGrandmaAmount
            // 
            this.labelGrandmaAmount.AutoSize = true;
            this.labelGrandmaAmount.Location = new System.Drawing.Point(254, 351);
            this.labelGrandmaAmount.Name = "labelGrandmaAmount";
            this.labelGrandmaAmount.Size = new System.Drawing.Size(18, 20);
            this.labelGrandmaAmount.TabIndex = 12;
            this.labelGrandmaAmount.Text = "T";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 300000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelUnlockedAchievements);
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
            this.splitContainer1.Size = new System.Drawing.Size(1700, 775);
            this.splitContainer1.SplitterDistance = 1095;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 14;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(388, 214);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(94, 24);
            this.radioButton5.TabIndex = 48;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Buy max";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(288, 214);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(92, 24);
            this.radioButton4.TabIndex = 47;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Buy 100";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(192, 214);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(83, 24);
            this.radioButton3.TabIndex = 46;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Buy 10";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(105, 214);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 24);
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
            this.radioButton1.Location = new System.Drawing.Point(18, 214);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 24);
            this.radioButton1.TabIndex = 44;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Buy 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // labelPSCAmount
            // 
            this.labelPSCAmount.AutoSize = true;
            this.labelPSCAmount.Location = new System.Drawing.Point(801, 578);
            this.labelPSCAmount.Name = "labelPSCAmount";
            this.labelPSCAmount.Size = new System.Drawing.Size(18, 20);
            this.labelPSCAmount.TabIndex = 43;
            this.labelPSCAmount.Text = "T";
            // 
            // buttonPSC
            // 
            this.buttonPSC.Location = new System.Drawing.Point(561, 548);
            this.buttonPSC.Name = "buttonPSC";
            this.buttonPSC.Size = new System.Drawing.Size(228, 51);
            this.buttonPSC.TabIndex = 41;
            this.buttonPSC.Tag = "12";
            this.buttonPSC.Text = "Buy PanScript console";
            this.buttonPSC.UseVisualStyleBackColor = true;
            this.buttonPSC.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelPSCMoney
            // 
            this.labelPSCMoney.AutoSize = true;
            this.labelPSCMoney.Location = new System.Drawing.Point(801, 548);
            this.labelPSCMoney.Name = "labelPSCMoney";
            this.labelPSCMoney.Size = new System.Drawing.Size(18, 20);
            this.labelPSCMoney.TabIndex = 42;
            this.labelPSCMoney.Text = "T";
            // 
            // labelACAmount
            // 
            this.labelACAmount.AutoSize = true;
            this.labelACAmount.Location = new System.Drawing.Point(801, 522);
            this.labelACAmount.Name = "labelACAmount";
            this.labelACAmount.Size = new System.Drawing.Size(18, 20);
            this.labelACAmount.TabIndex = 40;
            this.labelACAmount.Text = "T";
            // 
            // buttonAC
            // 
            this.buttonAC.Location = new System.Drawing.Point(561, 491);
            this.buttonAC.Name = "buttonAC";
            this.buttonAC.Size = new System.Drawing.Size(228, 51);
            this.buttonAC.TabIndex = 37;
            this.buttonAC.Tag = "11";
            this.buttonAC.Text = "Buy Antipancake condenser";
            this.buttonAC.UseVisualStyleBackColor = true;
            this.buttonAC.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelACMoney
            // 
            this.labelACMoney.AutoSize = true;
            this.labelACMoney.Location = new System.Drawing.Point(801, 491);
            this.labelACMoney.Name = "labelACMoney";
            this.labelACMoney.Size = new System.Drawing.Size(18, 20);
            this.labelACMoney.TabIndex = 39;
            this.labelACMoney.Text = "T";
            // 
            // labelTPAmount
            // 
            this.labelTPAmount.AutoSize = true;
            this.labelTPAmount.Location = new System.Drawing.Point(801, 465);
            this.labelTPAmount.Name = "labelTPAmount";
            this.labelTPAmount.Size = new System.Drawing.Size(18, 20);
            this.labelTPAmount.TabIndex = 38;
            this.labelTPAmount.Text = "T";
            // 
            // labelTPMoney
            // 
            this.labelTPMoney.AutoSize = true;
            this.labelTPMoney.Location = new System.Drawing.Point(801, 434);
            this.labelTPMoney.Name = "labelTPMoney";
            this.labelTPMoney.Size = new System.Drawing.Size(18, 20);
            this.labelTPMoney.TabIndex = 35;
            this.labelTPMoney.Text = "T";
            // 
            // labelPortalAmount
            // 
            this.labelPortalAmount.AutoSize = true;
            this.labelPortalAmount.Location = new System.Drawing.Point(801, 408);
            this.labelPortalAmount.Name = "labelPortalAmount";
            this.labelPortalAmount.Size = new System.Drawing.Size(18, 20);
            this.labelPortalAmount.TabIndex = 34;
            this.labelPortalAmount.Text = "T";
            // 
            // buttonPortal
            // 
            this.buttonPortal.Location = new System.Drawing.Point(561, 377);
            this.buttonPortal.Name = "buttonPortal";
            this.buttonPortal.Size = new System.Drawing.Size(228, 51);
            this.buttonPortal.TabIndex = 32;
            this.buttonPortal.Tag = "9";
            this.buttonPortal.Text = "Buy Portal";
            this.buttonPortal.UseVisualStyleBackColor = true;
            this.buttonPortal.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelPortalMoney
            // 
            this.labelPortalMoney.AutoSize = true;
            this.labelPortalMoney.Location = new System.Drawing.Point(801, 377);
            this.labelPortalMoney.Name = "labelPortalMoney";
            this.labelPortalMoney.Size = new System.Drawing.Size(18, 20);
            this.labelPortalMoney.TabIndex = 33;
            this.labelPortalMoney.Text = "T";
            // 
            // labelALAmount
            // 
            this.labelALAmount.AutoSize = true;
            this.labelALAmount.Location = new System.Drawing.Point(801, 351);
            this.labelALAmount.Name = "labelALAmount";
            this.labelALAmount.Size = new System.Drawing.Size(18, 20);
            this.labelALAmount.TabIndex = 31;
            this.labelALAmount.Text = "T";
            // 
            // buttonAL
            // 
            this.buttonAL.Location = new System.Drawing.Point(561, 320);
            this.buttonAL.Name = "buttonAL";
            this.buttonAL.Size = new System.Drawing.Size(225, 51);
            this.buttonAL.TabIndex = 28;
            this.buttonAL.Tag = "8";
            this.buttonAL.Text = "Buy alchemy lab";
            this.buttonAL.UseVisualStyleBackColor = true;
            this.buttonAL.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelALMoney
            // 
            this.labelALMoney.AutoSize = true;
            this.labelALMoney.Location = new System.Drawing.Point(801, 320);
            this.labelALMoney.Name = "labelALMoney";
            this.labelALMoney.Size = new System.Drawing.Size(18, 20);
            this.labelALMoney.TabIndex = 30;
            this.labelALMoney.Text = "T";
            // 
            // labelMTAmount
            // 
            this.labelMTAmount.AutoSize = true;
            this.labelMTAmount.Location = new System.Drawing.Point(801, 294);
            this.labelMTAmount.Name = "labelMTAmount";
            this.labelMTAmount.Size = new System.Drawing.Size(18, 20);
            this.labelMTAmount.TabIndex = 29;
            this.labelMTAmount.Text = "T";
            // 
            // labelMTMoney
            // 
            this.labelMTMoney.AutoSize = true;
            this.labelMTMoney.Location = new System.Drawing.Point(801, 263);
            this.labelMTMoney.Name = "labelMTMoney";
            this.labelMTMoney.Size = new System.Drawing.Size(18, 20);
            this.labelMTMoney.TabIndex = 26;
            this.labelMTMoney.Text = "T";
            // 
            // labelTempleAmount
            // 
            this.labelTempleAmount.AutoSize = true;
            this.labelTempleAmount.Location = new System.Drawing.Point(254, 578);
            this.labelTempleAmount.Name = "labelTempleAmount";
            this.labelTempleAmount.Size = new System.Drawing.Size(18, 20);
            this.labelTempleAmount.TabIndex = 25;
            this.labelTempleAmount.Text = "T";
            // 
            // buttonTemple
            // 
            this.buttonTemple.Location = new System.Drawing.Point(14, 548);
            this.buttonTemple.Name = "buttonTemple";
            this.buttonTemple.Size = new System.Drawing.Size(228, 51);
            this.buttonTemple.TabIndex = 23;
            this.buttonTemple.Tag = "6";
            this.buttonTemple.Text = "Buy Temple";
            this.buttonTemple.UseVisualStyleBackColor = true;
            this.buttonTemple.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelTempleMoney
            // 
            this.labelTempleMoney.AutoSize = true;
            this.labelTempleMoney.Location = new System.Drawing.Point(254, 548);
            this.labelTempleMoney.Name = "labelTempleMoney";
            this.labelTempleMoney.Size = new System.Drawing.Size(18, 20);
            this.labelTempleMoney.TabIndex = 24;
            this.labelTempleMoney.Text = "T";
            // 
            // labelFactoryAmount
            // 
            this.labelFactoryAmount.AutoSize = true;
            this.labelFactoryAmount.Location = new System.Drawing.Point(254, 522);
            this.labelFactoryAmount.Name = "labelFactoryAmount";
            this.labelFactoryAmount.Size = new System.Drawing.Size(18, 20);
            this.labelFactoryAmount.TabIndex = 22;
            this.labelFactoryAmount.Text = "T";
            // 
            // buttonFactory
            // 
            this.buttonFactory.Location = new System.Drawing.Point(14, 491);
            this.buttonFactory.Name = "buttonFactory";
            this.buttonFactory.Size = new System.Drawing.Size(228, 51);
            this.buttonFactory.TabIndex = 19;
            this.buttonFactory.Tag = "5";
            this.buttonFactory.Text = "Buy Factory";
            this.buttonFactory.UseVisualStyleBackColor = true;
            this.buttonFactory.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelFactoryMoney
            // 
            this.labelFactoryMoney.AutoSize = true;
            this.labelFactoryMoney.Location = new System.Drawing.Point(254, 491);
            this.labelFactoryMoney.Name = "labelFactoryMoney";
            this.labelFactoryMoney.Size = new System.Drawing.Size(18, 20);
            this.labelFactoryMoney.TabIndex = 21;
            this.labelFactoryMoney.Text = "T";
            // 
            // labelFarmAmount
            // 
            this.labelFarmAmount.AutoSize = true;
            this.labelFarmAmount.Location = new System.Drawing.Point(254, 465);
            this.labelFarmAmount.Name = "labelFarmAmount";
            this.labelFarmAmount.Size = new System.Drawing.Size(18, 20);
            this.labelFarmAmount.TabIndex = 20;
            this.labelFarmAmount.Text = "T";
            // 
            // labelFarmMoney
            // 
            this.labelFarmMoney.AutoSize = true;
            this.labelFarmMoney.Location = new System.Drawing.Point(254, 434);
            this.labelFarmMoney.Name = "labelFarmMoney";
            this.labelFarmMoney.Size = new System.Drawing.Size(18, 20);
            this.labelFarmMoney.TabIndex = 17;
            this.labelFarmMoney.Text = "T";
            // 
            // labelBakerAmount
            // 
            this.labelBakerAmount.AutoSize = true;
            this.labelBakerAmount.Location = new System.Drawing.Point(254, 408);
            this.labelBakerAmount.Name = "labelBakerAmount";
            this.labelBakerAmount.Size = new System.Drawing.Size(18, 20);
            this.labelBakerAmount.TabIndex = 16;
            this.labelBakerAmount.Text = "T";
            // 
            // buttonBaker
            // 
            this.buttonBaker.Location = new System.Drawing.Point(14, 377);
            this.buttonBaker.Name = "buttonBaker";
            this.buttonBaker.Size = new System.Drawing.Size(225, 51);
            this.buttonBaker.TabIndex = 14;
            this.buttonBaker.Tag = "3";
            this.buttonBaker.Text = "Buy Baker";
            this.buttonBaker.UseVisualStyleBackColor = true;
            this.buttonBaker.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelBakerMoney
            // 
            this.labelBakerMoney.AutoSize = true;
            this.labelBakerMoney.Location = new System.Drawing.Point(254, 377);
            this.labelBakerMoney.Name = "labelBakerMoney";
            this.labelBakerMoney.Size = new System.Drawing.Size(18, 20);
            this.labelBakerMoney.TabIndex = 15;
            this.labelBakerMoney.Text = "T";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(599, 775);
            this.splitContainer2.SplitterDistance = 46;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.splitContainer3.Size = new System.Drawing.Size(599, 723);
            this.splitContainer3.SplitterDistance = 661;
            this.splitContainer3.SplitterWidth = 6;
            this.splitContainer3.TabIndex = 0;
            // 
            // buttonAdd1000000Money
            // 
            this.buttonAdd1000000Money.Location = new System.Drawing.Point(591, 48);
            this.buttonAdd1000000Money.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd1000000Money.Name = "buttonAdd1000000Money";
            this.buttonAdd1000000Money.Size = new System.Drawing.Size(2, 2);
            this.buttonAdd1000000Money.TabIndex = 0;
            this.buttonAdd1000000Money.UseVisualStyleBackColor = true;
            this.buttonAdd1000000Money.Click += new System.EventHandler(this.buttonAdd1000000Money_Click);
            // 
            // labelUnlockedAchievements
            // 
            this.labelUnlockedAchievements.AutoSize = true;
            this.labelUnlockedAchievements.BackColor = System.Drawing.Color.White;
            this.labelUnlockedAchievements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUnlockedAchievements.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelUnlockedAchievements.Location = new System.Drawing.Point(384, 52);
            this.labelUnlockedAchievements.Name = "labelUnlockedAchievements";
            this.labelUnlockedAchievements.Size = new System.Drawing.Size(407, 39);
            this.labelUnlockedAchievements.TabIndex = 0;
            this.labelUnlockedAchievements.Text = "UnlockedAchievementsTag";
            this.labelUnlockedAchievements.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.startOverToolStripMenuItem,
            this.achievementsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1700, 33);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // startOverToolStripMenuItem
            // 
            this.startOverToolStripMenuItem.Name = "startOverToolStripMenuItem";
            this.startOverToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.startOverToolStripMenuItem.Text = "Start over";
            // 
            // achievementsToolStripMenuItem
            // 
            this.achievementsToolStripMenuItem.Name = "achievementsToolStripMenuItem";
            this.achievementsToolStripMenuItem.Size = new System.Drawing.Size(138, 29);
            this.achievementsToolStripMenuItem.Text = "Achievements";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 775);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button buttonAdd1000000Money;
        private System.Windows.Forms.Label labelUnlockedAchievements;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startOverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem achievementsToolStripMenuItem;
    }
}

