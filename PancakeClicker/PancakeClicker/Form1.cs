using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        bool save = true;

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
            upgradeManager.AddUpgrade(new Upgrade(1, "Valuex2", 100, 2));
            upgradeManager.AddUpgrade(new Upgrade(2, "Valuex4", 500, 4, 1));
            upgradeManager.AddUpgrade(new Upgrade(3, "Forwards from grandma", 1000, 2));
            upgradeManager.AddUpgrade(new Upgrade(4, "Steel plated rolling pins", 5000, 4, 3));
            upgradeManager.AddUpgrade(new Upgrade(5, "Lubricated dentures", 50000, 8, 4));

            //TODO: Insert more upgrades :(

            foreach (var item in upgradeManager.Sort())
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
            #region LabelUpdates
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
            if (AmountCalc() == uint.MaxValue)
            {
                labelClickerMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[0], pancakeManager.GetMaximum(pancakeManager.OwnedBusinesses[0])).ToString("0.00");
                labelGrandmaMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[1], pancakeManager.GetMaximum(pancakeManager.OwnedBusinesses[1])).ToString("0.00");
                labelBakerMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[2], pancakeManager.GetMaximum(pancakeManager.OwnedBusinesses[2])).ToString("0.00");
                labelFarmMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[3], pancakeManager.GetMaximum(pancakeManager.OwnedBusinesses[3])).ToString("0.00");
                labelFactoryMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[4], pancakeManager.GetMaximum(pancakeManager.OwnedBusinesses[4])).ToString("0.00");
                labelTempleMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[5], pancakeManager.GetMaximum(pancakeManager.OwnedBusinesses[5])).ToString("0.00");
                labelMTMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[6], pancakeManager.GetMaximum(pancakeManager.OwnedBusinesses[6])).ToString("0.00");
                labelALMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[7], pancakeManager.GetMaximum(pancakeManager.OwnedBusinesses[7])).ToString("0.00");
                labelPortalMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[8], pancakeManager.GetMaximum(pancakeManager.OwnedBusinesses[8])).ToString("0.00");
                labelTPMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[9], pancakeManager.GetMaximum(pancakeManager.OwnedBusinesses[9])).ToString("0.00");
                labelACMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[10], pancakeManager.GetMaximum(pancakeManager.OwnedBusinesses[10])).ToString("0.00");
                labelPSCMoney.Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[11], pancakeManager.GetMaximum(pancakeManager.OwnedBusinesses[11])).ToString("0.00");

            }
            else if (AmountCalc() == 1)
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
            #endregion

            BoldButtons();
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

            if (AmountCalc() == uint.MaxValue)
            {
                Business business = pancakeManager.OwnedBusinesses.Find(x => x.Id == uint.Parse(buyButton.Tag.ToString()));
                pancakeManager.BuyBusinesses(int.Parse(buyButton.Tag.ToString()), pancakeManager.GetMaximum(business));
            }
            else
                pancakeManager.BuyBusinesses(int.Parse(buyButton.Tag.ToString()), AmountCalc());
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pancakeManager.BuyUpgrade(listView1.SelectedItems[0].Text))
            {
                listView1.Items.Clear();
                foreach (var item in upgradeManager.Sort())
                {
                    listView1.Items.Add(item.Name).SubItems.Add(item.Price.ToString());
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveManager.PancakeManager = pancakeManager;
            saveManager.UpgradeManager = upgradeManager;
            if (save)
            {
                SaveSettings(pancakeManager.Money);
                saveManager.Save();
            }
            else
            {
                SaveSettings(0);
                saveManager.StartOver();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SaveSettings(pancakeManager.Money);
            saveManager.PancakeManager = pancakeManager;
            saveManager.UpgradeManager = upgradeManager;
            saveManager.Save();
        }

        private void SaveSettings(decimal money)
        {
            Settings.Default.LastPlayed = DateTime.Now;
            Settings.Default.Money = money;
            Settings.Default.Save();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveSettings(pancakeManager.Money);
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
            else if (radioButton5.Checked)
                amount = uint.MaxValue;

            return amount;
        }

        private void BoldButtons()
        {
            #region ButtonsBold

            if (pancakeManager.Money >= decimal.Parse(labelClickerMoney.Text))
                buttonClicker.Font = new Font(buttonClicker.Font, FontStyle.Bold);
            else
                buttonClicker.Font = new Font(buttonClicker.Font, FontStyle.Regular);

            //

            if (pancakeManager.Money >= decimal.Parse(labelGrandmaMoney.Text))
                buttonGrandma.Font = new Font(buttonGrandma.Font, FontStyle.Bold);
            else
                buttonGrandma.Font = new Font(buttonGrandma.Font, FontStyle.Regular);

            //

            if (pancakeManager.Money >= decimal.Parse(labelBakerMoney.Text))
                buttonBaker.Font = new Font(buttonBaker.Font, FontStyle.Bold);
            else
                buttonBaker.Font = new Font(buttonBaker.Font, FontStyle.Regular);

            //

            if (pancakeManager.Money >= decimal.Parse(labelFarmMoney.Text))
                buttonFarm.Font = new Font(buttonFarm.Font, FontStyle.Bold);
            else
                buttonFarm.Font = new Font(buttonFarm.Font, FontStyle.Regular);

            //

            if (pancakeManager.Money >= decimal.Parse(labelFactoryMoney.Text))
                buttonFactory.Font = new Font(buttonFactory.Font, FontStyle.Bold);
            else
                buttonFactory.Font = new Font(buttonFactory.Font, FontStyle.Regular);

            //

            if (pancakeManager.Money >= decimal.Parse(labelTempleMoney.Text))
                buttonTemple.Font = new Font(buttonTemple.Font, FontStyle.Bold);
            else
                buttonTemple.Font = new Font(buttonTemple.Font, FontStyle.Regular);

            //

            if (pancakeManager.Money >= decimal.Parse(labelMTMoney.Text))
                buttonMT.Font = new Font(buttonMT.Font, FontStyle.Bold);
            else
                buttonMT.Font = new Font(buttonMT.Font, FontStyle.Regular);

            //

            if (pancakeManager.Money >= decimal.Parse(labelALMoney.Text))
                buttonAL.Font = new Font(buttonAL.Font, FontStyle.Bold);
            else
                buttonAL.Font = new Font(buttonAL.Font, FontStyle.Regular);

            //

            if (pancakeManager.Money >= decimal.Parse(labelPortalMoney.Text))
                buttonPortal.Font = new Font(buttonPortal.Font, FontStyle.Bold);
            else
                buttonPortal.Font = new Font(buttonPortal.Font, FontStyle.Regular);

            //

            if (pancakeManager.Money >= decimal.Parse(labelTPMoney.Text))
                buttonTP.Font = new Font(buttonTP.Font, FontStyle.Bold);
            else
                buttonTP.Font = new Font(buttonTP.Font, FontStyle.Regular);

            //

            if (pancakeManager.Money >= decimal.Parse(labelACMoney.Text))
                buttonAC.Font = new Font(buttonAC.Font, FontStyle.Bold);
            else
                buttonAC.Font = new Font(buttonAC.Font, FontStyle.Regular);

            //

            if (pancakeManager.Money >= decimal.Parse(labelPSCMoney.Text))
                buttonPSC.Font = new Font(buttonPSC.Font, FontStyle.Bold);
            else
                buttonPSC.Font = new Font(buttonPSC.Font, FontStyle.Regular);

            #endregion
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            BoldButtons();
        }

        private void buttonStartOver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that u want to start over?", "Start over", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                save = false;
                if (MessageBox.Show("Are you really sure that u want to start over?", "Start over", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    this.Close();
                else
                    save = true;
            }
            else
                MessageBox.Show("Start over reverted", "Start over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAdd1000000Money_Click(object sender, EventArgs e)
        {
            pancakeManager.Money += 1000000;
        }
    }
}
