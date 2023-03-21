namespace ClickerGame
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
            this.buttonCookie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonCookie
            // 
            this.buttonCookie.Location = new System.Drawing.Point(12, 12);
            this.buttonCookie.Name = "buttonCookie";
            this.buttonCookie.Size = new System.Drawing.Size(133, 125);
            this.buttonCookie.TabIndex = 0;
            this.buttonCookie.Tag = "";
            this.buttonCookie.Text = "Cookie";
            this.buttonCookie.UseVisualStyleBackColor = true;
            this.buttonCookie.Click += new System.EventHandler(this.buttonCookie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Money:";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(217, 34);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(18, 20);
            this.labelMoney.TabIndex = 2;
            this.labelMoney.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCookie);
            this.Name = "Form1";
            this.Text = "Cookie Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonCookie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMoney;
    }
}

