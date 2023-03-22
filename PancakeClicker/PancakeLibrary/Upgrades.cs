using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PancakeLibrary
{
    public class Upgrades
    {
        public string Naam { get; set; }
        public int Prijs { get; set; }

        public Upgrades(string naam, int prijs) 
        {
            Naam = naam;
            Prijs = prijs;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
