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
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderUpgrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.labelMoneyPerTick = new System.Windows.Forms.Label();
            this.labelGrandmaMoney = new System.Windows.Forms.Label();
            this.labelGrandmaAmount = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Save = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelPSCAmount = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.labelPSCMoney = new System.Windows.Forms.Label();
            this.labelACAmount = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.labelACMoney = new System.Windows.Forms.Label();
            this.labelTPAmount = new System.Windows.Forms.Label();
            this.labelTPMoney = new System.Windows.Forms.Label();
            this.labelPortalAmount = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.labelPortalMoney = new System.Windows.Forms.Label();
            this.labelALAmount = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.labelALMoney = new System.Windows.Forms.Label();
            this.labelMTAmount = new System.Windows.Forms.Label();
            this.labelMTMoney = new System.Windows.Forms.Label();
            this.labelTempleAmount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelTempleMoney = new System.Windows.Forms.Label();
            this.labelFactoryAmount = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.labelFactoryMoney = new System.Windows.Forms.Label();
            this.labelFarmAmount = new System.Windows.Forms.Label();
            this.labelFarmMoney = new System.Windows.Forms.Label();
            this.labelBakerAmount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelBakerMoney = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
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
            this.labelClickerMoney.Location = new System.Drawing.Point(171, 133);
            this.labelClickerMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClickerMoney.Name = "labelClickerMoney";
            this.labelClickerMoney.Size = new System.Drawing.Size(14, 13);
            this.labelClickerMoney.TabIndex = 3;
            this.labelClickerMoney.Text = "T";
            // 
            // buttonClicker
            // 
            this.buttonClicker.Location = new System.Drawing.Point(11, 133);
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
            this.buttonGrandma.Location = new System.Drawing.Point(11, 170);
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
            this.labelClickerAmount.Location = new System.Drawing.Point(171, 153);
            this.labelClickerAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClickerAmount.Name = "labelClickerAmount";
            this.labelClickerAmount.Size = new System.Drawing.Size(14, 13);
            this.labelClickerAmount.TabIndex = 6;
            this.labelClickerAmount.Text = "T";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 244);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 33);
            this.button4.TabIndex = 18;
            this.button4.Tag = "4";
            this.button4.Text = "Buy Farm";
            this.toolTip1.SetToolTip(this.button4, "A basic pancake clicker");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(325, 133);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 33);
            this.button7.TabIndex = 27;
            this.button7.Tag = "7";
            this.button7.Text = "Buy Magic tower";
            this.toolTip1.SetToolTip(this.button7, "A basic pancake clicker");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(325, 244);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(152, 33);
            this.button10.TabIndex = 36;
            this.button10.Tag = "10";
            this.button10.Text = "Buy Time portal";
            this.toolTip1.SetToolTip(this.button10, "A basic pancake clicker");
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUpgrade,
            this.columnHeaderPrijs});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(419, 353);
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
            // columnHeaderPrijs
            // 
            this.columnHeaderPrijs.Text = "Prijs";
            this.columnHeaderPrijs.Width = 200;
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
            this.labelGrandmaMoney.Location = new System.Drawing.Point(171, 170);
            this.labelGrandmaMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGrandmaMoney.Name = "labelGrandmaMoney";
            this.labelGrandmaMoney.Size = new System.Drawing.Size(14, 13);
            this.labelGrandmaMoney.TabIndex = 11;
            this.labelGrandmaMoney.Text = "T";
            // 
            // labelGrandmaAmount
            // 
            this.labelGrandmaAmount.AutoSize = true;
            this.labelGrandmaAmount.Location = new System.Drawing.Point(171, 190);
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
            this.Save.Location = new System.Drawing.Point(11, 370);
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
            this.splitContainer1.Panel1.Controls.Add(this.radioButton4);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton3);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton2);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton1);
            this.splitContainer1.Panel1.Controls.Add(this.labelPSCAmount);
            this.splitContainer1.Panel1.Controls.Add(this.button8);
            this.splitContainer1.Panel1.Controls.Add(this.labelPSCMoney);
            this.splitContainer1.Panel1.Controls.Add(this.labelACAmount);
            this.splitContainer1.Panel1.Controls.Add(this.button9);
            this.splitContainer1.Panel1.Controls.Add(this.labelACMoney);
            this.splitContainer1.Panel1.Controls.Add(this.button10);
            this.splitContainer1.Panel1.Controls.Add(this.labelTPAmount);
            this.splitContainer1.Panel1.Controls.Add(this.labelTPMoney);
            this.splitContainer1.Panel1.Controls.Add(this.labelPortalAmount);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.labelPortalMoney);
            this.splitContainer1.Panel1.Controls.Add(this.labelALAmount);
            this.splitContainer1.Panel1.Controls.Add(this.button6);
            this.splitContainer1.Panel1.Controls.Add(this.labelALMoney);
            this.splitContainer1.Panel1.Controls.Add(this.button7);
            this.splitContainer1.Panel1.Controls.Add(this.labelMTAmount);
            this.splitContainer1.Panel1.Controls.Add(this.labelMTMoney);
            this.splitContainer1.Panel1.Controls.Add(this.labelTempleAmount);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.labelTempleMoney);
            this.splitContainer1.Panel1.Controls.Add(this.labelFactoryAmount);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.labelFactoryMoney);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.labelFarmAmount);
            this.splitContainer1.Panel1.Controls.Add(this.labelFarmMoney);
            this.splitContainer1.Panel1.Controls.Add(this.labelBakerAmount);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
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
            this.splitContainer1.Size = new System.Drawing.Size(1067, 412);
            this.splitContainer1.SplitterDistance = 644;
            this.splitContainer1.TabIndex = 14;
            // 
            // labelPSCAmount
            // 
            this.labelPSCAmount.AutoSize = true;
            this.labelPSCAmount.Location = new System.Drawing.Point(485, 338);
            this.labelPSCAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPSCAmount.Name = "labelPSCAmount";
            this.labelPSCAmount.Size = new System.Drawing.Size(14, 13);
            this.labelPSCAmount.TabIndex = 43;
            this.labelPSCAmount.Text = "T";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(325, 318);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(152, 33);
            this.button8.TabIndex = 41;
            this.button8.Tag = "12";
            this.button8.Text = "Buy PanScript console";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelPSCMoney
            // 
            this.labelPSCMoney.AutoSize = true;
            this.labelPSCMoney.Location = new System.Drawing.Point(485, 318);
            this.labelPSCMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPSCMoney.Name = "labelPSCMoney";
            this.labelPSCMoney.Size = new System.Drawing.Size(14, 13);
            this.labelPSCMoney.TabIndex = 42;
            this.labelPSCMoney.Text = "T";
            // 
            // labelACAmount
            // 
            this.labelACAmount.AutoSize = true;
            this.labelACAmount.Location = new System.Drawing.Point(485, 301);
            this.labelACAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelACAmount.Name = "labelACAmount";
            this.labelACAmount.Size = new System.Drawing.Size(14, 13);
            this.labelACAmount.TabIndex = 40;
            this.labelACAmount.Text = "T";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(325, 281);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(152, 33);
            this.button9.TabIndex = 37;
            this.button9.Tag = "11";
            this.button9.Text = "Buy Antipancake condenser";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelACMoney
            // 
            this.labelACMoney.AutoSize = true;
            this.labelACMoney.Location = new System.Drawing.Point(485, 281);
            this.labelACMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelACMoney.Name = "labelACMoney";
            this.labelACMoney.Size = new System.Drawing.Size(14, 13);
            this.labelACMoney.TabIndex = 39;
            this.labelACMoney.Text = "T";
            // 
            // labelTPAmount
            // 
            this.labelTPAmount.AutoSize = true;
            this.labelTPAmount.Location = new System.Drawing.Point(485, 264);
            this.labelTPAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTPAmount.Name = "labelTPAmount";
            this.labelTPAmount.Size = new System.Drawing.Size(14, 13);
            this.labelTPAmount.TabIndex = 38;
            this.labelTPAmount.Text = "T";
            // 
            // labelTPMoney
            // 
            this.labelTPMoney.AutoSize = true;
            this.labelTPMoney.Location = new System.Drawing.Point(485, 244);
            this.labelTPMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTPMoney.Name = "labelTPMoney";
            this.labelTPMoney.Size = new System.Drawing.Size(14, 13);
            this.labelTPMoney.TabIndex = 35;
            this.labelTPMoney.Text = "T";
            // 
            // labelPortalAmount
            // 
            this.labelPortalAmount.AutoSize = true;
            this.labelPortalAmount.Location = new System.Drawing.Point(485, 227);
            this.labelPortalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPortalAmount.Name = "labelPortalAmount";
            this.labelPortalAmount.Size = new System.Drawing.Size(14, 13);
            this.labelPortalAmount.TabIndex = 34;
            this.labelPortalAmount.Text = "T";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(325, 207);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 33);
            this.button5.TabIndex = 32;
            this.button5.Tag = "9";
            this.button5.Text = "Buy Portal";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelPortalMoney
            // 
            this.labelPortalMoney.AutoSize = true;
            this.labelPortalMoney.Location = new System.Drawing.Point(485, 207);
            this.labelPortalMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPortalMoney.Name = "labelPortalMoney";
            this.labelPortalMoney.Size = new System.Drawing.Size(14, 13);
            this.labelPortalMoney.TabIndex = 33;
            this.labelPortalMoney.Text = "T";
            // 
            // labelALAmount
            // 
            this.labelALAmount.AutoSize = true;
            this.labelALAmount.Location = new System.Drawing.Point(485, 190);
            this.labelALAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelALAmount.Name = "labelALAmount";
            this.labelALAmount.Size = new System.Drawing.Size(14, 13);
            this.labelALAmount.TabIndex = 31;
            this.labelALAmount.Text = "T";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(325, 170);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 33);
            this.button6.TabIndex = 28;
            this.button6.Tag = "8";
            this.button6.Text = "Buy alchemy lab";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelALMoney
            // 
            this.labelALMoney.AutoSize = true;
            this.labelALMoney.Location = new System.Drawing.Point(485, 170);
            this.labelALMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelALMoney.Name = "labelALMoney";
            this.labelALMoney.Size = new System.Drawing.Size(14, 13);
            this.labelALMoney.TabIndex = 30;
            this.labelALMoney.Text = "T";
            // 
            // labelMTAmount
            // 
            this.labelMTAmount.AutoSize = true;
            this.labelMTAmount.Location = new System.Drawing.Point(485, 153);
            this.labelMTAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMTAmount.Name = "labelMTAmount";
            this.labelMTAmount.Size = new System.Drawing.Size(14, 13);
            this.labelMTAmount.TabIndex = 29;
            this.labelMTAmount.Text = "T";
            // 
            // labelMTMoney
            // 
            this.labelMTMoney.AutoSize = true;
            this.labelMTMoney.Location = new System.Drawing.Point(485, 133);
            this.labelMTMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMTMoney.Name = "labelMTMoney";
            this.labelMTMoney.Size = new System.Drawing.Size(14, 13);
            this.labelMTMoney.TabIndex = 26;
            this.labelMTMoney.Text = "T";
            // 
            // labelTempleAmount
            // 
            this.labelTempleAmount.AutoSize = true;
            this.labelTempleAmount.Location = new System.Drawing.Point(171, 338);
            this.labelTempleAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTempleAmount.Name = "labelTempleAmount";
            this.labelTempleAmount.Size = new System.Drawing.Size(14, 13);
            this.labelTempleAmount.TabIndex = 25;
            this.labelTempleAmount.Text = "T";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 318);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 33);
            this.button2.TabIndex = 23;
            this.button2.Tag = "6";
            this.button2.Text = "Buy Temple";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelTempleMoney
            // 
            this.labelTempleMoney.AutoSize = true;
            this.labelTempleMoney.Location = new System.Drawing.Point(171, 318);
            this.labelTempleMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTempleMoney.Name = "labelTempleMoney";
            this.labelTempleMoney.Size = new System.Drawing.Size(14, 13);
            this.labelTempleMoney.TabIndex = 24;
            this.labelTempleMoney.Text = "T";
            // 
            // labelFactoryAmount
            // 
            this.labelFactoryAmount.AutoSize = true;
            this.labelFactoryAmount.Location = new System.Drawing.Point(171, 301);
            this.labelFactoryAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFactoryAmount.Name = "labelFactoryAmount";
            this.labelFactoryAmount.Size = new System.Drawing.Size(14, 13);
            this.labelFactoryAmount.TabIndex = 22;
            this.labelFactoryAmount.Text = "T";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 281);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 33);
            this.button3.TabIndex = 19;
            this.button3.Tag = "5";
            this.button3.Text = "Buy Factory";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelFactoryMoney
            // 
            this.labelFactoryMoney.AutoSize = true;
            this.labelFactoryMoney.Location = new System.Drawing.Point(171, 281);
            this.labelFactoryMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFactoryMoney.Name = "labelFactoryMoney";
            this.labelFactoryMoney.Size = new System.Drawing.Size(14, 13);
            this.labelFactoryMoney.TabIndex = 21;
            this.labelFactoryMoney.Text = "T";
            // 
            // labelFarmAmount
            // 
            this.labelFarmAmount.AutoSize = true;
            this.labelFarmAmount.Location = new System.Drawing.Point(171, 264);
            this.labelFarmAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFarmAmount.Name = "labelFarmAmount";
            this.labelFarmAmount.Size = new System.Drawing.Size(14, 13);
            this.labelFarmAmount.TabIndex = 20;
            this.labelFarmAmount.Text = "T";
            // 
            // labelFarmMoney
            // 
            this.labelFarmMoney.AutoSize = true;
            this.labelFarmMoney.Location = new System.Drawing.Point(171, 244);
            this.labelFarmMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFarmMoney.Name = "labelFarmMoney";
            this.labelFarmMoney.Size = new System.Drawing.Size(14, 13);
            this.labelFarmMoney.TabIndex = 17;
            this.labelFarmMoney.Text = "T";
            // 
            // labelBakerAmount
            // 
            this.labelBakerAmount.AutoSize = true;
            this.labelBakerAmount.Location = new System.Drawing.Point(171, 227);
            this.labelBakerAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBakerAmount.Name = "labelBakerAmount";
            this.labelBakerAmount.Size = new System.Drawing.Size(14, 13);
            this.labelBakerAmount.TabIndex = 16;
            this.labelBakerAmount.Text = "T";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 207);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 33);
            this.button1.TabIndex = 14;
            this.button1.Tag = "3";
            this.button1.Text = "Buy Baker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelBakerMoney
            // 
            this.labelBakerMoney.AutoSize = true;
            this.labelBakerMoney.Location = new System.Drawing.Point(171, 207);
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
            this.splitContainer2.Size = new System.Drawing.Size(419, 412);
            this.splitContainer2.SplitterDistance = 25;
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
            this.splitContainer3.Size = new System.Drawing.Size(419, 383);
            this.splitContainer3.SplitterDistance = 353;
            this.splitContainer3.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 101);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 44;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Buy 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(72, 101);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 17);
            this.radioButton2.TabIndex = 45;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Buy 5";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(130, 101);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 17);
            this.radioButton3.TabIndex = 46;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Buy 10";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(194, 101);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(64, 17);
            this.radioButton4.TabIndex = 47;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Buy 100";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 412);
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
        private System.Windows.Forms.ColumnHeader columnHeaderPrijs;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelBakerMoney;
        private System.Windows.Forms.Label labelPSCAmount;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label labelPSCMoney;
        private System.Windows.Forms.Label labelACAmount;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label labelACMoney;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label labelTPAmount;
        private System.Windows.Forms.Label labelTPMoney;
        private System.Windows.Forms.Label labelPortalAmount;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelPortalMoney;
        private System.Windows.Forms.Label labelALAmount;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label labelALMoney;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label labelMTAmount;
        private System.Windows.Forms.Label labelMTMoney;
        private System.Windows.Forms.Label labelTempleAmount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelTempleMoney;
        private System.Windows.Forms.Label labelFactoryAmount;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelFactoryMoney;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelFarmAmount;
        private System.Windows.Forms.Label labelFarmMoney;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

