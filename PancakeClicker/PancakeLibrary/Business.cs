using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PancakeLibrary
{
    public class Business
    {
        public Business(int id, string name, string description, decimal initialPrice, decimal initialMoneyPerSecond, uint amount = 0)
        {
            Id = id;
            Name = name;
            Description = description;
            InitialPrice = initialPrice;
            InitialMoneyPerSecond = initialMoneyPerSecond;
            Amount = amount;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal InitialPrice { get; set; }
        public decimal InitialMoneyPerSecond { get; set; }
        public uint Amount { get; set; }

        public override string ToString()
        {
            //Standard saving pattern
            return $"| B | {Id} | {Name} | {Description} | {InitialPrice} | {InitialMoneyPerSecond} | {Amount} |";
        }
    }
}
