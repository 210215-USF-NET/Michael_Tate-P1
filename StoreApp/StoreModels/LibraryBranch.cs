using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModels
{
    public class LibraryBranch
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string Description { get; set; }
        public DateTime OpenDate { get; set; }

        public virtual ICollection<Patron> Patrons { get; set; }
        public virtual ICollection<LibraryAsset> LibraryAssets { get; set; }

        public string ImageUrl { get; set; }
    }
}