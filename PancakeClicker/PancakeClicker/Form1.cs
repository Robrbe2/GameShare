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
            pancakeManager.AchievementsManager.CheckForAchievements();
            #region LabelUpdates
            labelMoneyPerTick.Text = (pancakeManager.Tick()*10).ToString();
            labelMoney.Text = pancakeManager.Money.ToString("0.00");

            List<Label> labels = new List<Label>()
            {
                labelClickerAmount,
                labelGrandmaAmount,
                labelBakerAmount,
                labelFarmAmount,
                labelFactoryAmount,
                labelTempleAmount,
                labelMTAmount,
                labelALAmount,
                labelPortalAmount,
                labelTPAmount,
                labelACAmount,
                labelPSCAmount,
            };
            for (int i = 0; i < labels.Count; i++)
            {
                labels[i].Text = pancakeManager.OwnedBusinesses[i].Name;
            }
            List<Label> moneyLabelList = new List<Label>()
            {
                labelClickerMoney,
                labelGrandmaMoney,
                labelBakerMoney,
                labelFarmMoney,
                labelFactoryMoney,
                labelTempleMoney,
                labelMTMoney,
                labelALMoney,
                labelPortalMoney,
                labelTPMoney,
                labelACMoney,
                labelPSCMoney,
            };
            switch (AmountCalc())
            {
                case uint.MaxValue:
                    for (int i = 0; i < moneyLabelList.Count; i++)
                    {
                        moneyLabelList[i].Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[i], pancakeManager.GetMaximum(pancakeManager.OwnedBusinesses[i])).ToString("0.00");
                    }
                    break;
                case 1:
                    for (int i = 0; i < moneyLabelList.Count; i++)
                    {
                        moneyLabelList[i].Text = pancakeManager.CostPriceForOne(pancakeManager.OwnedBusinesses[i]).ToString("0.00");
                    }
                    break;
                default:
                    for (int i = 0; i < moneyLabelList.Count; i++)
                    {
                        moneyLabelList[i].Text = pancakeManager.CostPriceForMany(pancakeManager.OwnedBusinesses[i], AmountCalc()).ToString("0.00");
                    }
                    break;
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
        
            Dictionary<Label, Button> dicLabelButton = new Dictionary<Label, Button>()
            {

                { labelClickerMoney,    buttonClicker },
                { labelGrandmaMoney,    buttonGrandma },
                { labelBakerMoney,      buttonBaker },
                { labelFarmMoney,       buttonFarm },
                { labelFactoryMoney,    buttonFactory },
                { labelTempleMoney,     buttonTemple },
                { labelMTMoney,         buttonMT },
                { labelALMoney,         buttonAL },
                { labelPortalMoney,     buttonPortal },
                { labelTPMoney,         buttonTP },
                { labelACMoney,         buttonAC },
                { labelPSCMoney,        buttonPSC },
            };
            foreach (var item in dicLabelButton)
            {
                if (pancakeManager.Money >= decimal.Parse(item.Key.Text))
                    item.Value.Font = new Font(item.Value.Font, FontStyle.Bold);
                else
                    item.Value.Font = new Font(item.Value.Font, FontStyle.Regular);
            }
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

        private void achievementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
