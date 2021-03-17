using StoreModels;
using System;
using System.Collections.Generic;

namespace StoreMVC.Models.Branch
{
    public class BranchDetailModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string OpenDate { get; set; }

        public string PhoneNumber { get; set; }
        public bool IsOpen { get; set; }

        public string Description { get; set; }
        public int NumberOfPatrons { get; set; }
        public int NumberOfAssets { get; set; }
        public decimal TotalAssetValue { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<string> HoursOpen { get; set; }
    }
}