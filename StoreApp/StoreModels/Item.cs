using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModels
{
    public class Item
    {
        public int Itemid { get; set; }
        public int Categoryid { get; set; }
        public String ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal ItemPrice { get; set; }
    }
}