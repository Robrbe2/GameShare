using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PancakeLibrary
{
    internal class UpgradeManager
    {
        public List<string> boughtUpgrades;

        /// <summary>
        /// Constructor of the upgrade manager
        /// </summary>
        /// <param name="upgrades">the upgrades that the user bought</param>
        public UpgradeManager(List<string> upgrades)
        {
            boughtUpgrades = upgrades;
        }

        public int ClickAmount()
        {
            int amount = 1;
            if(boughtUpgrades.Contains("Valuex5"))
                amount = 5;

            return amount;
        }
    }
}
