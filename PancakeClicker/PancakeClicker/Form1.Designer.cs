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
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonPancake
            // 
            this.buttonPancake.Location = new System.Drawing.Point(11, 10);
            this.buttonPancake.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPancake.Name = "buttonPancake";
            this.buttonPancake.Size = new System.Drawing.Size(118, 100);
            this.buttonPancake.TabIndex = 0;
            this.buttonPancake.Tag = "";
            this.buttonPancake.Text = "Pancake";
            this.buttonPancake.UseVisualStyleBackColor = true;
            this.buttonPancake.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonPancake_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pancakes:";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(213, 27);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(14, 16);
            this.labelMoney.TabIndex = 2;
            this.labelMoney.Text = "0";
            // 
            // labelClickerMoney
            // 
            this.labelClickerMoney.AutoSize = true;
            this.labelClickerMoney.Location = new System.Drawing.Point(134, 138);
            this.labelClickerMoney.Name = "labelClickerMoney";
            this.labelClickerMoney.Size = new System.Drawing.Size(16, 16);
            this.labelClickerMoney.TabIndex = 3;
            this.labelClickerMoney.Text = "T";
            // 
            // buttonClicker
            // 
            this.buttonClicker.Location = new System.Drawing.Point(11, 138);
            this.buttonClicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClicker.Name = "buttonClicker";
            this.buttonClicker.Size = new System.Drawing.Size(118, 41);
            this.buttonClicker.TabIndex = 4;
            this.buttonClicker.Tag = "1";
            this.buttonClicker.Text = "Buy Clicker";
            this.buttonClicker.UseVisualStyleBackColor = true;
            this.buttonClicker.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // buttonGrandma
            // 
            this.buttonGrandma.Location = new System.Drawing.Point(11, 183);
            this.buttonGrandma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGrandma.Name = "buttonGrandma";
            this.buttonGrandma.Size = new System.Drawing.Size(118, 41);
            this.buttonGrandma.TabIndex = 5;
            this.buttonGrandma.Tag = "2";
            this.buttonGrandma.Text = "Buy Grandma";
            this.buttonGrandma.UseVisualStyleBackColor = true;
            this.buttonGrandma.Click += new System.EventHandler(this.buyBusiness_Click);
            // 
            // labelClickerAmount
            // 
            this.labelClickerAmount.AutoSize = true;
            this.labelClickerAmount.Location = new System.Drawing.Point(134, 162);
            this.labelClickerAmount.Name = "labelClickerAmount";
            this.labelClickerAmount.Size = new System.Drawing.Size(16, 16);
            this.labelClickerAmount.TabIndex = 6;
            this.labelClickerAmount.Text = "T";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(513, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 212);
            this.listBox1.TabIndex = 7;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelClickerAmount);
            this.Controls.Add(this.buttonGrandma);
            this.Controls.Add(this.buttonClicker);
            this.Controls.Add(this.labelClickerMoney);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPancake);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}

