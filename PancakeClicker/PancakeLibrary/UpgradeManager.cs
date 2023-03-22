using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PancakeLibrary
{
    public class UpgradeManager
    {
        public List<Upgrades> upgrades;
        public List<Upgrades> boughtUpgrades;

        /// <summary>
        /// Constructor of the upgrade manager
        /// </summary>
        /// <param name="upgrades">the upgrades that the user bought</param>
        public UpgradeManager()
        {
            boughtUpgrades = new List<Upgrades>();
            upgrades = new List<Upgrades>();
        }

        public int ClickAmount()
        {
            int amount = 1;
            if (boughtUpgrades.Contains(new Upgrades("Valuex5", 250)))
                amount = 2;

            return amount;
        }

        public void AddUpgrade(Upgrades upgrade)
        {
            upgrades.Add(upgrade);
        }

        public void BuyUpgrade(Upgrades upgrade)
        {
            boughtUpgrades.Add(upgrade);
            upgrades.Remove(upgrade);
        }
    }
}
