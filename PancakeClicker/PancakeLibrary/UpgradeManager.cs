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
            upgrades = new List<Upgrades>();
            boughtUpgrades = new List<Upgrades>();
        }

        public int ButtonClickAmount()
        {
            if (boughtUpgrades.Find(x => x.Naam == "Valuex2") != null)
                return 2;
            else
                return 1;
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

        public List<Upgrades> Sort()
        {
            upgrades = upgrades.OrderBy(x => x.Prijs).ToList<Upgrades>();
            return upgrades;
        }
    }
}
