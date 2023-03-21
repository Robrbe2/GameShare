using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PancakeLibrary
{
    public class BusinessAmount
    {
        public BusinessAmount(Business business)
        {
            Business = business;
            Id = Business.Id;
            Amount = 0;
        }
        public int Id { get; set; }
        public Business Business { get; set; }
        public uint Amount { get; set; }
    }
}
