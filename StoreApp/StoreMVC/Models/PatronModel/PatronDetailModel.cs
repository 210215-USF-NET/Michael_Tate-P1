using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Models.PatronModel
{
    public class PatronDetailModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Fullname
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public int LibraryCardId { get; set; }
        public string Address { get; set; }
        public DateTime MemberSince { get; set; }
        public string PhoneNumber { get; set; }
        public string HomeLibraryBranch { get; set; }
        public decimal OverdueFees { get; set; }
        public ICollection<CheckoutModel> AssetsCheckedOut { get; set; }
        public ICollection<CheckoutHistory> CheckoutHistory { get; set; }
        public ICollection<Hold> Holds { get; set; }
    }
}