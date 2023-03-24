using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PancakeLibrary
{
    public class Achievement
    {
        public Achievement(int id, string name, string description)
        {
            Name = name;
            Description = description;
        }
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
