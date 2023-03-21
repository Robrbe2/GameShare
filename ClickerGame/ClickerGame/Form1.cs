using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookieLibrary;

namespace ClickerGame
{
    public partial class Form1 : Form
    {
        CookieManager coockieManager = new CookieManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // coockieManager.Tick();
            labelMoney.Text = coockieManager.Money.ToString();
        }

        private void buttonCookie_Click(object sender, EventArgs e)
        {
            coockieManager.ButtonClick();
        }
    }
}
