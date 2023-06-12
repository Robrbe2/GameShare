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
        /// <summary>
        /// List of upgrades that the user hasn't bought
        /// </summary>
        public List<Upgrade> AvaibleUpgrades;
        /// <summary>
        /// List of upgrades that the user has bought
        /// </summary>
        public List<Upgrade> boughtUpgrades;

        /// <summary>
        /// Constructor of the upgrade manager
        /// </summary>
        /// <param name="upgrades">the upgrades that the user bought</param>
        public UpgradeManager()
        {
            boughtUpgrades = new List<Upgrade>();
            AvaibleUpgrades = new List<Upgrade>();
        }
        /// <summary>
        /// checks if the item meets the preset requirements
        /// </summary>
        /// <param name="id">the id of the item that needs to be checked</param>
        /// <returns></returns>
        public bool MeetsRequirement(int id)
        {
            bool meetsRequirement = false;
            Upgrade upgrade = AvaibleUpgrades.Find(x => x.Id == id);
            
            if(upgrade != null && upgrade.Requirement != null)
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

        public void AddUpgrade(Upgrade upgrade)
        {
            AvaibleUpgrades.Add(upgrade);
        }

        public void BuyUpgrade(Upgrade upgrade)
        {
            upgrade.Gotten = true;
            boughtUpgrades.Add(upgrade);
            AvaibleUpgrades.Remove(upgrade);
        }

        public List<Upgrade> Sort()
        {
            AvaibleUpgrades = AvaibleUpgrades.OrderBy(x => x.Price).ToList();
            return AvaibleUpgrades;
        }
    }
}
