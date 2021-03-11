namespace StoreModels
{
    /// <summary>
    /// This class should contain all the fields and properties that define a customer order.
    /// </summary>
    public class Order
    {
        public int Id { get; set; }
        public Customer CustID { get; set; }
        public StoreLocation LocID { get; set; }
        public Product ProID { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }

        public override string ToString() => $"Oreder Details: \n\t Store LocationID: {this.LocID} \n\t ProductID: {this.ProID} \n\t Quantity: {this.Quantity} \n\t Total: ${this.Total}";

        //TODO: add a property for the order items
    }
}