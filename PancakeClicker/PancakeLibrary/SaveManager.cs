using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PancakeLibrary;

namespace PancakeLibrary
{
    public class SaveManager
    {
        public SaveManager() { }

        public UpgradeManager UpgradeManager;
        public PancakeManager PancakeManager;
        public bool Save()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Business bus in PancakeManager.OwnedBusinesses)
            {
                sb.AppendLine(bus.ToString());
            }
            foreach (Upgrades upgrades in UpgradeManager.AvaibleUpgrades) 
            { 
                sb.AppendLine(upgrades.ToString());
            }
            foreach (Upgrades upgrades in UpgradeManager.boughtUpgrades)
            {
                sb.AppendLine(upgrades.ToString());
            }
            File.WriteAllText("./Save.txt", sb.ToString());
            return File.Exists("./Save.txt");
        }

        public void Read()
        {
            if (File.Exists("./Save.txt"))
            {
                string[] SaveLines = File.ReadAllLines("./Save.txt");
                foreach (string line in SaveLines)
                {
                    if (line.StartsWith("| B |"))
                    {
                        string id = line.Substring(6,3).Trim();
                        if(id.Contains('|')) { id = id.Replace('|', ' ').Trim(); }
                        Business business = PancakeManager.OwnedBusinesses.Find(x => x.Id.ToString() == id);

                        string amount = line.Substring(line.Length - 4, 3).Trim();
                        amount = amount.Replace('|', ' ').Trim();
                        business.Amount = uint.Parse(amount);
                    }
                    else
                    {
                        if (line.StartsWith("| U |"))
                        {
                            string id = line.Substring(6, 3).Trim();
                            if (id.Contains('|')) { id = id.Replace('|', ' ').Trim(); }
                            try
                            {
                                Upgrades upgrade1 = UpgradeManager.AvaibleUpgrades.Find(x => x.Id.ToString() == id);
                            }
                            catch { }
                            try
                            {
                                Upgrades upgrade2 = UpgradeManager.AvaibleUpgrades.Find(x => x.Id.ToString() == id);
                            }
                            catch { }
                            string boolean = line.Substring(line.Length - 7, 5).Trim();
                            if(boolean == "true") { UpgradeManager.BuyUpgrade(upgrade); }
                        }

                    }
                }
            }
        }
    }
}
