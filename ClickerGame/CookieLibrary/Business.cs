using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieLibrary
{
    public class Business
    {
        public Business(int id, string name, string description, int initialPrice, int initialMoneyPerTick)
        {
            Id = id;
            Name = name;
            Description = description;
            InitialPrice = initialPrice;
            InitialMoneyPerSecond = initialMoneyPerTick;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int InitialPrice { get; set; }
        public int InitialMoneyPerSecond { get; set; }
    }
}
