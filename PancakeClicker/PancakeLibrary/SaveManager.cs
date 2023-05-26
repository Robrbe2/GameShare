using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PancakeLibrary
{
    public class SaveManager
    {
        public SaveManager(List<Business> businesses, List<Upgrades> upgrades) 
        {
            Businesses = businesses;
            Upgrades = upgrades;
        }
        protected List<Business> Businesses;
        protected List<Upgrades> Upgrades;
        public bool Save()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Business bus in Businesses)
            {
                sb.AppendLine(bus.ToString());
            }
            foreach (Upgrades upgrades in Upgrades) 
            { 
                sb.AppendLine(upgrades.ToString());
            }
            File.WriteAllText("~/Save.txt", sb.ToString());
            return true;
        }

        public bool Read()
        {
            return true;
        }
    }
}
