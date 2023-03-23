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
        public PancakeManager(UpgradeManager UM)
        {
            Money = 250;
            OwnedBusinesses = new List<Business>();
            UpgradeManager = UM;
        }
        public List<Business> OwnedBusinesses { get; set; }
        public void Tick()
        {
            decimal moneyPerTick = 0;
            decimal moneyPerTickBusiness;
            foreach (Business business in OwnedBusinesses)
            {
                moneyPerTickBusiness = business.InitialMoneyPerSecond / 10;
                moneyPerTick += moneyPerTickBusiness * business.Amount;
            }
            AddMoney(moneyPerTick);
        }
        public void AddMoney(decimal amount) 
        {
            Money += amount;
        }
        public void RemoveMoney(decimal amount)
        {
            Money -= amount;
        }
        public bool BuyBusinesses(int id, int amount)
        {
            int index = GetIndex(id);
            if (index < 0)
                return false;
            Business ownedBusiness = OwnedBusinesses[index];

            decimal amountOwned = CostPriceForMany(ownedBusiness, amount);
            if (Money >= amountOwned)
            {
                RemoveMoney(amountOwned);
                OwnedBusinesses[index].Amount += (uint)amount;
                return true;
            }
            else
                return false;
        }

        public decimal CostPriceForMany(Business ownedBusiness, int amount)
        {
            decimal price = 0;
            for (int i = 0; i < amount; i++)
            {
                price += CostPriceForOne(ownedBusiness);
            }
            return price;
        }

        public decimal CostPriceForOne(Business business)
        {
            decimal cost;
            int discountedPrice = 100;

            cost = (decimal)(business.InitialPrice * Math.Pow(1.15, business.Amount));

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

        public void BusinessClick()
        {
            Money += UpgradeManager.BusinessClickAmount();
        }

        public void AddBusiness(Business business)
        {
            
            OwnedBusinesses.Add(business);
        }

        public bool BuyUpgrade(object OBJupgrade)
       {
            Upgrades upgrade = UpgradeManager.upgrades.FirstOrDefault(x => x.Naam == OBJupgrade);
            if(UpgradeManager.upgrades.Contains(upgrade) && Money >= upgrade.Prijs)
            {
                UpgradeManager.BuyUpgrade(upgrade);
                RemoveMoney(upgrade.Prijs);
                return true;
            }
            else
                return false;
        }
    }
}
