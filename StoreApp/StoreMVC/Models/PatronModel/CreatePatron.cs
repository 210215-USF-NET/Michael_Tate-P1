using Microsoft.AspNetCore.Mvc.Rendering;
using StoreModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Models.PatronModel
{
    public class CreatePatron
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        [Range(1, 3)]
        public int HomeLibraryBranchId { get; set; }

        [Required]
        public int CardId { get; set; }
    }
}