using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModels
{
    public class CartProd
    {
        public int Id { get; set; }

        public int CartID { get; set; }

        public Cart Cart { get; set; }

        public int ProductID { get; set; }

        public int? ProductCount { get; set; }
    }
}