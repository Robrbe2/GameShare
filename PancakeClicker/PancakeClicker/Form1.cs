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
        PancakeManager pancakeManager = new PancakeManager();
        public Form1()
        {
            InitializeComponent();
            LoadBusinesses();
            labelTesting.Text = pancakeManager.OwnedBusinesses[0].Name.ToString();
        }

        private void LoadBusinesses()
        {
            Business business = new Business(1, "Pancake Clicker", "A basic pancake clicker", 15, (decimal)0.1);
            pancakeManager.AddBusiness(business);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // PancakeManager.Tick();
            labelMoney.Text = pancakeManager.Money.ToString();
        }

        private void buttonPancake_Click(object sender, EventArgs e)
        {
            pancakeManager.ButtonClick();
        }
    }
}
