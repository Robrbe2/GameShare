﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PancakeLibrary
{
    public class Achievement
    {
        public Achievement(int id, string name, string description, bool gotten)
        {
            Id = id;
            Name = name;
            Description = description;
            Gotten = gotten;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Gotten { get; set; }

        public override string ToString()
        {
            //Standard saving pattern
            return $"| A | {Id} | {Name} | {Description} | {Gotten} |";
        }
    }
}
