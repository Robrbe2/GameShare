using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PancakeLibrary
{
    public class Achievement
    {

        public Achievement(int id, string name, string description, string type)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
        }
        public Achievement(int id, string name, string description, string type, bool gotten)
        {
            Id = id;
            Name = name;
            Description = description;
            Gotten = gotten;
            Type = type;
        }
        public Achievement(int id, string name, string description, string type, bool gotten, DateTime dateGotten)
        {
            Id = id;
            Name = name;
            Description = description;
            Gotten = gotten;
            DateGotten = dateGotten;
            Type = type;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool Gotten { get; set; }
        public DateTime DateGotten { get; set; }

        public override string ToString()
        {
            //Standard saving pattern
            return $"| A | {Id} | {Name} | {Description} | {Gotten} | {Type} | {DateGotten} |";
        }
    }
}
