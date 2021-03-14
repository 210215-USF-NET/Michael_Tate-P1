using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModels
{
    public class OrderProducts
    {
        public int Id { get; set; }

        public int? OrderItemsQuantity { get; set; }

        public int OrderID { get; set; }

        public Order Order { get; set; }

        public int ProductID { get; set; }
    }
}