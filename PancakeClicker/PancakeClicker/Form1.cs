using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PancakeLibrary;

namespace PancakeClicker
{
    public partial class Form1 : Form
    {
        PancakeManager PancakeManager = new PancakeManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // PancakeManager.Tick();
            labelMoney.Text = PancakeManager.Money.ToString();
        }

        private void buttonPancake_Click(object sender, EventArgs e)
        {
            PancakeManager.ButtonClick();
        }
    }
}
