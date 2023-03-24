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

        private void CheckMoney()
        {
            decimal money = LocalPancakeManager.Money;
            if (money >= 10000 && OwnedAchievements.FindIndex(x => x.id == 1) > 0)
                OwnedAchievements.Add(new Achievement(0, "Wooh my first pancake!","Have 10000 pancakes"));
            
            if (money >= 10000 && OwnedAchievements.FindIndex(x => x.id == 1) > 0)
                OwnedAchievements.Add(new Achievement(1, "Now da party starts", "Have 10000 pancakes"));
            
            if (money >= 10000 && OwnedAchievements.FindIndex(x => x.id == 1) > 0)
                OwnedAchievements.Add(new Achievement(1, "Now da party starts", "Have 10000 pancakes"));
            
            if (money >= 10000 && OwnedAchievements.FindIndex(x => x.id == 1) > 0)
                OwnedAchievements.Add(new Achievement(1, "Now da party starts", "Have 10000 pancakes"));
            
            if (money >= 10000 && OwnedAchievements.FindIndex(x => x.id == 1) > 0)
                OwnedAchievements.Add(new Achievement(1, "Now da party starts", "Have 10000 pancakes"));
            
            if (money >= 10000 && OwnedAchievements.FindIndex(x => x.id == 1) > 0)
                OwnedAchievements.Add(new Achievement(1, "Now da party starts", "Have 10000 pancakes"));
            
            if (money >= 10000 && OwnedAchievements.FindIndex(x => x.id == 1) > 0)
                OwnedAchievements.Add(new Achievement(1, "Now da party starts", "Have 10000 pancakes"));
            
            if (money >= 10000 && OwnedAchievements.FindIndex(x => x.id == 1) > 0)
                OwnedAchievements.Add(new Achievement(1, "Now da party starts", "Have 10000 pancakes"));
            
            if (money >= 10000 && OwnedAchievements.FindIndex(x => x.id == 1) > 0)
                OwnedAchievements.Add(new Achievement(1, "Now da party starts", "Have 10000 pancakes"));
        }
    }
}
