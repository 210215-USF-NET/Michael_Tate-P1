namespace StoreModels
{
    //This class should contain all necessary fields to define a product.
    public class Product
    {
        public int Id { get; set; }
        public StoreLocation LocationID { get; set; }
        public Pie ProductName { get; set; }
        public decimal Price { get; set; }
        public int PieCount { get; set; }

        public override string ToString() => $"Inventory Details:\n\t StoreID: {this.LocationID}\n\t Product: {this.ProductName} \n\t Price: ${this.Price} \n\t Whole Pies: {this.PieCount}";

        //todo: add more properties to define a product (maybe a category?)
    }
}