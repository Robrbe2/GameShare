using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PancakeLibrary
{
    public class AchievementsManager
    {
        public List<Achievement> OwnedAchievements { get; set; }
        private PancakeManager LocalPancakeManager { get; set; }
        public AchievementsManager(PancakeManager localPancakeManager)
        {
            OwnedAchievements = new List<Achievement>();
            LocalPancakeManager = localPancakeManager;
        }
        public bool CheckForAchievements()
        {
            int amount = OwnedAchievements.Count;

            CheckMoney();


            if (amount < OwnedAchievements.Count)
                return true;
            else
                return false;
        }
        /// <summary>
        /// In de if statement word gecheckt of er genoeg geld is en je de achievement nog niet hebt
        /// </summary>
        /// 
        private void CheckMoney()
        {
            decimal money = LocalPancakeManager.Money;
            string[] achievementNames = new string[] {
                "Wooh my first pancake!",
                "Now da party starts",
                "So baked right now",
                "Affluent bakery",
                "Best bakery",
                "Cosmic bakery",
                "Galactic bakery",
                "Universal bakery"};
            decimal value = 1;
            for(int i = 0; i != achievementNames.Length; i++)
            {
                if (i != 0 && i % 2 == 0)
                    value *= 100;
                else if (i != 0 && (i+1) % 2 == 0)
                    value *= 1000;

            if (money >= value && OwnedAchievements.FindIndex(x => x.Id == i) < 0)
                OwnedAchievements.Add(new Achievement(i, achievementNames[i],$"Have {value} pancakes", true));
            }
        }
    }
}
