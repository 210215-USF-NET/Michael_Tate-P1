using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StoreMVC.Models
{
    public class ItemView
    {
        public Guid Itemid { get; set; }
        public int Categoryid { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public decimal ItemPrice { get; set; }
        public IFormFile ImagePath { get; set; }

        public IEnumerable<SelectListItem> CategorySelectListItem { get; set; }
    }
}