using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PancakeLibrary
{
    public class UpgradeManager
    {
        public List<Upgrades> upgrades;
        public List<Upgrades> AvaibleUpgrades;
        public List<Upgrades> boughtUpgrades;

        /// <summary>
        /// Constructor of the upgrade manager
        /// </summary>
        /// <param name="upgrades">the upgrades that the user bought</param>
        public UpgradeManager()
        {
            upgrades = new List<Upgrades>();
            boughtUpgrades = new List<Upgrades>();
            AvaibleUpgrades = new List<Upgrades>();
        }
        /// <summary>
        /// checks if the item meets the preset requirements
        /// </summary>
        /// <param name="id">the id of the item that needs to be checked</param>
        /// <returns></returns>
        public bool MeetsRequirement(int id)
        {
            bool meetsRequirement = false;
            Upgrades upgrade = upgrades.Find(x => x.Id == id);
            
            if(upgrade.Requirement != null)
            {
                if (null != boughtUpgrades.Find(x => x.Id == upgrade.Requirement))
                    meetsRequirement = true;
            }
            else
                meetsRequirement = true;

            return meetsRequirement;
        }
        public int ButtonClickAmount()
        {
            if (boughtUpgrades.Find(x => x.Id == 3) != null)
                return 4;
            else if (boughtUpgrades.Find(x => x.Id == 1) != null)
                return 2;
            else
                return 1;
        }

        public void AddUpgrade(Upgrades upgrade)
        {
            upgrades.Add(upgrade);
            AvaibleUpgrades.Add(upgrade);
        }

        public void BuyUpgrade(Upgrades upgrade)
        {
            upgrade.Gotten = true;
            boughtUpgrades.Add(upgrade);
            AvaibleUpgrades.Remove(upgrade);
        }

        public List<Upgrades> Sort()
        {
            AvaibleUpgrades = AvaibleUpgrades.OrderBy(x => x.Price).ToList();
            return AvaibleUpgrades;
        }
    }
}
