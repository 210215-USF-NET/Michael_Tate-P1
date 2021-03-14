using System;

namespace StoreModels
{
    /// <summary>
    /// This class should contain all the fields and properties that define a customer order.
    /// </summary>
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int LocationID { get; set; }
        public StoreLocation Location { get; set; }

        public decimal Total { get; set; }
    }
}