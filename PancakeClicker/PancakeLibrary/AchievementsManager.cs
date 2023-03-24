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

            int value = 1;
            for(int i = 0; i != achievementNames.Length; i++)
            {

            }
            if (money >= 1 && OwnedAchievements.FindIndex(x => x.id == 0) < 0)
                OwnedAchievements.Add(new Achievement(0, "Wooh my first pancake!","Have 1 pancake"));
            
            if (money >= 1000 && OwnedAchievements.FindIndex(x => x.id == 1) < 0)
                OwnedAchievements.Add(new Achievement(1, "Now da party starts", "Have 1000 pancakes"));
            
            if (money >= 100000 && OwnedAchievements.FindIndex(x => x.id == 1) < 0)
                OwnedAchievements.Add(new Achievement(1, "Now da party starts", "Have 100000 pancakes"));
            
            if (money >= 10000 && OwnedAchievements.FindIndex(x => x.id == 1) < 0)
                OwnedAchievements.Add(new Achievement(1, "Now da party starts", "Have 1000000 pancakes"));
            
            if (money >= 10000 && OwnedAchievements.FindIndex(x => x.id == 1) < 0)
                OwnedAchievements.Add(new Achievement(1, "Now da party starts", "Have 100000000 pancakes"));
            
            if (money >= 10000 && OwnedAchievements.FindIndex(x => x.id == 1) < 0)
                OwnedAchievements.Add(new Achievement(1, "Now da party starts", "Have 10000 pancakes"));
            
            if (money >= 10000 && OwnedAchievements.FindIndex(x => x.id == 1) < 0)
                OwnedAchievements.Add(new Achievement(1, "Now da party starts", "Have 10000 pancakes"));
            
            if (money >= 10000 && OwnedAchievements.FindIndex(x => x.id == 1) < 0)
                OwnedAchievements.Add(new Achievement(1, "Now da party starts", "Have 10000 pancakes"));
            
            if (money >= 10000 && OwnedAchievements.FindIndex(x => x.id == 1) < 0)
                OwnedAchievements.Add(new Achievement(1, "Now da party starts", "Have 10000 pancakes"));
        }
    }
}
