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
        public PancakeManager()
        {
            Money = 0;
            OwnedBusinesses = new List<BusinessAmount>();
        }
        public List<BusinessAmount> OwnedBusinesses { get; set; }
        public void Tick()
        {
            decimal moneyPerTick = 0;
            decimal moneyPerTickBusiness;
            foreach (BusinessAmount businessAmount in OwnedBusinesses)
            {
                moneyPerTickBusiness = businessAmount.Business.InitialMoneyPerSecond / 10;
                moneyPerTick += moneyPerTickBusiness * businessAmount.Amount;
            }
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
            BusinessAmount ownedBusiness = OwnedBusinesses[index];

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

        public decimal CostPriceForMany(BusinessAmount ownedBusiness, int amount)
        {
            decimal price = 0;
            for (int i = 0; i < amount; i++)
            {
                price += CostPriceForOne(ownedBusiness);
            }
            return price;
        }

        public decimal CostPriceForOne(BusinessAmount businessAmount)
        {
            decimal cost;
            int discountedPrice = 100;

            cost = (decimal)(businessAmount.Business.InitialPrice * Math.Pow(1.15, businessAmount.Amount));

            return cost;
        }

        public int GetIndex(int id)
        {
            return OwnedBusinesses.FindIndex(x => x.Id == id);
        }

        public void ButtonClick()
        {
            Money += 1;
        }

        public void AddBusiness(Business business)
        {
            
            OwnedBusinesses.Add(new BusinessAmount(business));
        }
    }
}
