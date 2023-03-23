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
        UpgradeManager upgradeManager;
        PancakeManager pancakeManager;
        public Form1()
        {
            InitializeComponent();
            upgradeManager = new UpgradeManager();
            pancakeManager = new PancakeManager(upgradeManager);
            LoadBusinesses();
            LoadUpgrades();
        }

        private void LoadBusinesses()
        {
            List<Business> businesses = new List<Business>() { new Business(
                1,
                "Pancake Clicker",
                "A basic pancake clicker",
                15,
                0.1M), new Business(
                2,
                "Grandma",
                "",
                100,
                5), new Business(
                3,
                "Baker",
                "",
                1000,
                50), new Business(
                4,
                "Farm",
                "",
                10000,
                300), new Business(
                5,
                "Factory",
                "",
                161000,
                1000), new Business(
                6,
                "Temple",
                "",
                3800000,
                20000),new Business(
                7,
                "Magic tower",
                "",
                86500000,
                100000), new Business(
                8,
                "Alchemy lab",
                "",
                947000000,
                560000), new Business(
                9,
                "Portal",
                "",
                9132000000,
                9600000), new Business(
                10,
                "Time portal",
                "",
                91231000000,
                10000000), new Business(
                11,
                "Antipancake condenser",
                "",
                313920000000,
                560000000), new Business(
                12,
                "PanScript Console",
                "",
                9391032010000,
                640000000)
            };

            foreach (Business item in businesses)
            {
                pancakeManager.AddBusiness(item);
            }
        }

        private void LoadUpgrades()
        {
            Upgrades upgrade = new Upgrades("Valuex2", 250);
            upgradeManager.AddUpgrade(upgrade);
            upgrade = new Upgrades("StrongerGrandma", 100);
            upgradeManager.AddUpgrade(upgrade);

            upgradeManager.Sort();
            foreach (var item in upgradeManager.upgrades)
            {
                listView1.Items.Add(item.Naam).SubItems.Add(item.Prijs.ToString());
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelMoneyPerTick.Text = pancakeManager.Tick().ToString();
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

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pancakeManager.BuyUpgrade(listView1.SelectedItems[0].Text))
            {
                listView1.Items.Clear();
                foreach (var item in upgradeManager.upgrades)
                {
                    listView1.Items.Add(item.Naam).SubItems.Add(item.Prijs.ToString());
                }
            }
        }
    }
}
