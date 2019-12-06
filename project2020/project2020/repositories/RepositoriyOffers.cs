using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project2020.Models
{
    public class Offers
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int duratoin { get; set; }
        public Workers workers { get; set; }
    }
}
