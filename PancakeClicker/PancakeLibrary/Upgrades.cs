using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PancakeLibrary
{
    public class Upgrades
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public int Prijs { get; set; }
        public int? Requirement { get; set; }

        public Upgrades(int id, string naam, int prijs, int? requiredment = null) 
        {
            Id = id;
            Naam = naam;
            Prijs = prijs;
            Requirement = requiredment;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
