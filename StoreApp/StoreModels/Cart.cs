using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModels
{
    public class Cart
    {
        public int Id { get; set; }

        public int CustomerID { get; set; }

        public Customer Customer { get; set; }
        public ICollection<CartProd> CartProducts { get; set; }

        public int LocationID { get; set; }

        public StoreLocation Location { get; set; }
    }
}