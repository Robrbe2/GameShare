using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PancakeLibrary
{
    public class Upgrades
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public decimal Multiplier { get; set; }
        public int? Requirement { get; set; }
        public bool Gotten { get; set; }

        public Upgrades(int id, string naam, int prijs, decimal multipier, int? requiredment = null, bool gotten = false) 
        {
            Id = id;
            Name = naam;
            Price = prijs;
            Multiplier = multipier;
            Requirement = requiredment;
            Gotten = gotten;
        }

        public override string ToString()
        {
            //Standard saving pattern
            return $"| U | {Id} | {Name} | {Price} | {Multiplier} | {Requirement} | {Gotten} |";
        }
    }
}
