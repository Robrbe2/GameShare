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
        SaveManager saveManager;
        public Form1()
        {
            InitializeComponent();
            upgradeManager = new UpgradeManager();
            pancakeManager = new PancakeManager(upgradeManager, Settings.Default.Money);
            saveManager = new SaveManager();
            LoadBusinesses();
            LoadUpgrades();
            LoadData();
            if(Settings.Default.LastPlayed == null || Settings.Default.LastPlayed == DateTime.MinValue)
                Settings.Default.LastPlayed = DateTime.Now;
            pancakeManager.IdleMoneyCalc(Settings.Default.LastPlayed);
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
                "PanScript console",
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
            upgradeManager.AddUpgrade(new Upgrades(1, "Valuex2", 100, 2));
            upgradeManager.AddUpgrade(new Upgrades(2, "Forwards from grandma", 1000, 2));
            upgradeManager.AddUpgrade(new Upgrades(3, "Valuex4", 500, 4, 1));
            upgradeManager.AddUpgrade(new Upgrades(4, "Steel plated rolling pins", 5000, 4, 2));
            upgradeManager.AddUpgrade(new Upgrades(5, "Lubricated dentures", 50000, 8, 4));

            foreach (var item in upgradeManager.AvaibleUpgrades)
            {
                if(!item.Gotten)
                {
                    listView1.Items.Add(item.Name).SubItems.Add(item.Price.ToString());
                }
            }
        }
        
        private void LoadData()
        {
            saveManager.PancakeManager = pancakeManager;
            saveManager.UpgradeManager = upgradeManager;
            saveManager.Read();
            listView1.Items.Clear();
            foreach (var item in upgradeManager.AvaibleUpgrades)
            {
                listView1.Items.Add(item.Name).SubItems.Add(item.Price.ToString());
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            labelMoneyPerTick.Text = (pancakeManager.Tick()*10).ToString();
            labelMoney.Text = pancakeManager.Money.ToString("0.00");
            labelClickerAmount.Text = pancakeManager.OwnedBusinesses[0].Amount.ToString();
            labelGrandmaAmount.Text = pancakeManager.OwnedBusinesses[1].Amount.ToString();
            labelBakerAmount.Text = pancakeManager.OwnedBusinesses[2].Amount.ToString();
            labelFarmAmount.Text = pancakeManager.OwnedBusinesses[3].Amount.ToString();
            labelFactoryAmount.Text = pancakeManager.OwnedBusinesses[4].Amount.ToString();
            labelTempleAmount.Text = pancakeManager.OwnedBusinesses[5].Amount.ToString();
            labelMTAmount.Text = pancakeManager.OwnedBusinesses[6].Amount.ToString();
            labelALAmount.Text = pancakeManager.OwnedBusinesses[7].Amount.ToString();
            labelPortalAmount.Text = pancakeManager.OwnedBusinesses[8].Amount.ToString();
            labelTPAmount.Text = pancakeManager.OwnedBusinesses[9].Amount.ToString();
            labelACAmount.Text = pancakeManager.OwnedBusinesses[10].Amount.ToString();
            labelPSCAmount.Text = pancakeManager.OwnedBusinesses[11].Amount.ToString();

            if(AmountCalc() == 1)
            {
                labelClickerMoney.Text = pancakeManager.CostPriceForOne(pancakeManager.OwnedBusinesses[0]).ToString("0.00");
                labelGrandmaMoney.Text = pancakeManager.CostPriceForOne(pancakeManager.OwnedBusinesses[1]).ToString("0.00");
                labelBakerMoney.Text = pancakeManager.CostPriceForOne(pancakeManager.OwnedBusinesses[2]).ToString("0.00");
                labelFarmMoney.Text = pancakeManager.CostPriceForOne(pancakeManager.OwnedBusinesses[3]).ToString("0.00");
                labelFactoryMoney.Text = pancakeManager.CostPriceForOne(pancakeManager.OwnedBusinesses[4]).ToString("0.00");
                labelTempleMoney.Text = pancakeManager.CostPriceForOne(pancakeManager.OwnedBusinesses[5]).ToString("0.00");
                labelMTMoney.Text = pancakeManager.CostPriceForOne(pancakeManager.OwnedBusinesses[6]).ToString("0.00");
                labelALMoney.Text = pancakeManager.CostPriceForOne(pancakeManager.OwnedBusinesses[7]).ToString("0.00");
                labelPortalMoney.Text = pancakeManager.CostPriceForOne(pancakeManager.OwnedBusinesses[8]).ToString("0.00");
                labelTPMoney.Text = pancakeManager.CostPriceForOne(pancakeManager.OwnedBusinesses[9]).ToString("0.00");
                labelACMoney.Text = pancakeManager.CostPriceForOne(pancakeManager.OwnedBusinesses[10]).ToString("0.00");
                labelPSCMoney.Text = pancakeManager.CostPriceForOne(pancakeManager.OwnedBusinesses[11]).ToString("0.00");
            }
            else
            {
                labelClickerMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[0], AmountCalc()).ToString("0.00");
                labelGrandmaMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[1], AmountCalc()).ToString("0.00");
                labelBakerMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[2], AmountCalc()).ToString("0.00");
                labelFarmMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[3], AmountCalc()).ToString("0.00");
                labelFactoryMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[4], AmountCalc()).ToString("0.00");
                labelTempleMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[5], AmountCalc()).ToString("0.00");
                labelMTMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[6], AmountCalc()).ToString("0.00");
                labelALMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[7], AmountCalc()).ToString("0.00");
                labelPortalMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[8], AmountCalc()).ToString("0.00");
                labelTPMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[9], AmountCalc()).ToString("0.00");
                labelACMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[10], AmountCalc()).ToString("0.00");
                labelPSCMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[11], AmountCalc()).ToString("0.00");
            }
            
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
            pancakeManager.BuyBusinesses(int.Parse((string)buyButton.Tag), AmountCalc());
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pancakeManager.BuyUpgrade(listView1.SelectedItems[0].Text))
            {
                listView1.Items.Clear();
                foreach (var item in upgradeManager.AvaibleUpgrades)
                {
                    listView1.Items.Add(item.Name).SubItems.Add(item.Price.ToString());
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            saveManager.PancakeManager = pancakeManager;
            saveManager.UpgradeManager = upgradeManager;
            saveManager.Save();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SaveSettings();
            saveManager.PancakeManager = pancakeManager;
            saveManager.UpgradeManager = upgradeManager;
            saveManager.Save();
        }

        protected void SaveSettings()
        {
            Settings.Default.LastPlayed = DateTime.Now;
            Settings.Default.Money = pancakeManager.Money;
            Settings.Default.Save();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveManager.PancakeManager = pancakeManager;
            saveManager.UpgradeManager = upgradeManager;
            saveManager.Save();
        }

        private uint AmountCalc()
        {
            uint amount = 1;

            if (radioButton2.Checked)
                amount = 5;
            else if (radioButton3.Checked)
                amount = 10;
            else if (radioButton4.Checked)
                amount = 100;

            return amount;
        }
    }
}
