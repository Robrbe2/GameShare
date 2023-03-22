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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonPancake
            // 
            this.buttonPancake.Location = new System.Drawing.Point(8, 8);
            this.buttonPancake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label1.Location = new System.Drawing.Point(100, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pancakes:";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(160, 22);
            this.labelMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(13, 13);
            this.labelMoney.TabIndex = 2;
            this.labelMoney.Text = "0";
            // 
            // labelClickerMoney
            // 
            this.labelClickerMoney.AutoSize = true;
            this.labelClickerMoney.Location = new System.Drawing.Point(100, 112);
            this.labelClickerMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClickerMoney.Name = "labelClickerMoney";
            this.labelClickerMoney.Size = new System.Drawing.Size(14, 13);
            this.labelClickerMoney.TabIndex = 3;
            this.labelClickerMoney.Text = "T";
            // 
            // buttonClicker
            // 
            this.buttonClicker.Location = new System.Drawing.Point(8, 112);
            this.buttonClicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClicker.Name = "buttonClicker";
            this.buttonClicker.Size = new System.Drawing.Size(88, 33);
            this.buttonClicker.TabIndex = 4;
            this.buttonClicker.Tag = "1";
            this.buttonClicker.Text = "Buy Clicker";
            this.toolTip1.SetToolTip(this.buttonClicker, "A basic pancake clicker");
            this.buttonClicker.UseVisualStyleBackColor = true;
            this.buttonClicker.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // buttonGrandma
            // 
            this.buttonGrandma.Location = new System.Drawing.Point(8, 149);
            this.buttonGrandma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGrandma.Name = "buttonGrandma";
            this.buttonGrandma.Size = new System.Drawing.Size(88, 33);
            this.buttonGrandma.TabIndex = 5;
            this.buttonGrandma.Tag = "2";
            this.buttonGrandma.Text = "Buy Grandma";
            this.buttonGrandma.UseVisualStyleBackColor = true;
            this.buttonGrandma.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelClickerAmount
            // 
            this.labelClickerAmount.AutoSize = true;
            this.labelClickerAmount.Location = new System.Drawing.Point(100, 132);
            this.labelClickerAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClickerAmount.Name = "labelClickerAmount";
            this.labelClickerAmount.Size = new System.Drawing.Size(14, 13);
            this.labelClickerAmount.TabIndex = 6;
            this.labelClickerAmount.Text = "T";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(385, 8);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 173);
            this.listBox1.TabIndex = 7;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelClickerAmount);
            this.Controls.Add(this.buttonGrandma);
            this.Controls.Add(this.buttonClicker);
            this.Controls.Add(this.labelClickerMoney);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPancake);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Pancake Clicker";
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

