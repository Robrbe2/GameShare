using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PancakeClicker.Properties;
using PancakeLibrary;

namespace PancakeClicker
{
    public partial class Form1 : Form
    {
        PancakeManager pancakeManager = new PancakeManager();
        UpgradeManager upgradeManager = new UpgradeManager();
        public Form1()
        {
            InitializeComponent();
            LoadBusinesses();
            LoadUpgrades();
        }

        private void LoadBusinesses()
        {
            Business business = new Business(1, "Pancake Clicker", "A basic pancake clicker", 15, (decimal)0.1);
            pancakeManager.AddBusiness(business);
        }

        private void LoadUpgrades()
        {
            Upgrades upgrade = new Upgrades("Valuex2", 250);
            upgradeManager.AddUpgrade(upgrade);
            listBox1.Items.Add(upgrade.ToString());
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pancakeManager.Tick();
            labelMoney.Text = pancakeManager.Money.ToString("0.00");
            labelClickerMoney.Text = ((int)pancakeManager.CostPriceForOne(pancakeManager.OwnedBusinesses[0])).ToString();
            labelClickerAmount.Text = pancakeManager.OwnedBusinesses[0].Amount.ToString();
        }

        private void buttonPancake_Click(object sender, MouseEventArgs e)
        {
            pancakeManager.ButtonClick();

        }

        private void buyBusiness_Click(object sender, EventArgs e)
        {
            if (sender == null)
                return;

            Button buyButton = (Button)sender;
            pancakeManager.BuyBusinesses(int.Parse((string)buyButton.Tag), 1) ;
        }

        private void listBox1_MouseClick(object sender, EventArgs e)
        {
            if (pancakeManager.BuyUpgrade(listBox1.SelectedItem))
                listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
