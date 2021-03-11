using System;

namespace StoreModels
{
    /// <summary>
    /// This class should contain all the fields and properties that define a customers location.
    /// </summary>
    public class StoreLocation
    {
        public string Name {get; set;}
        public string Address {get; set;}
        public string State {get; set;}
        public string City {get; set;}
        public int Zip {get; set;}
        public int Id { get; set; }
        public override string ToString() => $"Inventory Details:\n\t Store Location: {this.Id}\n\t State: {this.State}";
    }
}