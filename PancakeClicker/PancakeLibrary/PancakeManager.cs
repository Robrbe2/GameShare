using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PancakeLibrary
{
    public class PancakeManager
    {
        public decimal Money;
        private UpgradeManager UpgradeManager;
        public AchievementsManager AchievementsManager; 
        public PancakeManager(UpgradeManager UM, decimal money = 0)
        {
            Money = money;
            OwnedBusinesses = new List<Business>();
            UpgradeManager = UM;
            AchievementsManager = new AchievementsManager(this);
            AchievementsManager.CheckForAchievements();
        }
        public List<Business> OwnedBusinesses { get; set; }
        public decimal Tick()
        {
            decimal moneyPerTick = MoneyPerTickCalc();
            AddMoney(moneyPerTick);
            return moneyPerTick;
        }
        public void AddMoney(decimal amount) 
        {
            Money += amount;
        }
        public void RemoveMoney(decimal amount)
        {
            Money -= amount;
        }
        public bool BuyBusinesses(int id, uint amount)
        {
            int index = GetIndex(id);
            if (index < 0)
                return false;
            Business ownedBusiness = OwnedBusinesses[index];

            decimal amountOwned = CostPriceForMany(ownedBusiness, amount);
            if (Money >= amountOwned)
            {
                RemoveMoney(amountOwned);
                OwnedBusinesses[index].Amount += amount;
                return true;
            }
            else
                return false;
        }

        public decimal CostPriceForMany(Business ownedBusiness, uint amount)
        {
            decimal price = CostPriceForOne(ownedBusiness); ;
            for (int i = 1; i < amount; i++)
            {
                price += (decimal)(ownedBusiness.InitialPrice * (decimal)Math.Pow(1.15, ownedBusiness.Amount+i));
            }
            return price;
        }

        public decimal CostPriceForOne(Business business)
        {
            decimal cost;
            int discountedPrice = 100;

            cost = (decimal)(business.InitialPrice * (decimal)Math.Pow(1.15, business.Amount));

            cost = cost * (decimal)(discountedPrice / 100);

            return cost;
        }

        public int GetIndex(int id)
        {
            return OwnedBusinesses.FindIndex(x => x.Id == id);
        }

        public void ButtonClick()
        {
            Money += UpgradeManager.ButtonClickAmount();
        }

        public void AddBusiness(Business business)
        {
            
            OwnedBusinesses.Add(business);
        }

        public bool BuyUpgrade(object OBJupgrade)
        {
            Upgrade upgrade = UpgradeManager.AvaibleUpgrades.FirstOrDefault(x => x.Name == OBJupgrade.ToString());
            if(UpgradeManager.AvaibleUpgrades.Contains(upgrade) && Money >= upgrade.Price)
            {
                UpgradeManager.BuyUpgrade(upgrade);
                RemoveMoney(upgrade.Price);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Money Per Tick Calculator
        /// </summary>
        /// <param name="business">the business that produces the money</param>
        /// <param name="upgradeLevel">The amount the upgrades gives extra if not specified it gives a value of 1</param>
        /// <returns>A decimal with the money per tick</returns>
        public decimal MPTCalc(Business business, Upgrade upgrade = null)
        {
            decimal moneyPerTick = 0;
            decimal moneyPerTickBusiness;
            moneyPerTickBusiness = business.InitialMoneyPerSecond / 10;
            if(upgrade != null)
                moneyPerTickBusiness *= upgrade.Multiplier;
            moneyPerTick += moneyPerTickBusiness * business.Amount;
            return moneyPerTick;
        }
        /// <summary>
        /// Calculates the amount of money that is generated every tick
        /// </summary>
        /// <returns></returns>
        public decimal MoneyPerTickCalc()
        {
            decimal moneyPerTick = 0;
            foreach (Business business in OwnedBusinesses)
            {
                if (UpgradeManager.boughtUpgrades.Find(x => x.Id == 1) != null)
                    if (UpgradeManager.boughtUpgrades.Find(x => x.Id == 2) != null && UpgradeManager.MeetsRequirement(2))
                        moneyPerTick += MPTCalc(business, UpgradeManager.boughtUpgrades.Find(x => x.Id == 2));
                    else
                        moneyPerTick += MPTCalc(business, UpgradeManager.boughtUpgrades.Find(x => x.Id == 1));
                else
                    moneyPerTick += MPTCalc(business);
            }
            return moneyPerTick;
        }
        public void IdleMoneyCalc(DateTime lastPlayed)
        {
            TimeSpan timeSinceLastPlayed = DateTime.Now - lastPlayed;
            decimal money = MoneyPerTickCalc() * (decimal)timeSinceLastPlayed.TotalSeconds;
            money *= 10;
            AddMoney(money);
        }

        public uint GetMaximum(Business ownedBusiness)
        {
            uint amount = 0;
            decimal price = CostPriceForOne(ownedBusiness);
            while (true)
            {
                price += (decimal)(ownedBusiness.InitialPrice * (decimal)Math.Pow(1.15, ownedBusiness.Amount + amount));
                if (price > Money)
                    break;

                amount++;
            }
            if (amount == 0 && CostPriceForOne(ownedBusiness) < Money)
                return 1;
            return amount;
        }
    }
}
