using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarteiraDeFundosAPI.Models
{
    public class Stock
    {
        public long Id { get; set; }

        public string name { get; set; }

        public double price { get; set; }

        public string date { get; set; }

        public int quantity { get; set; }
    }
}
