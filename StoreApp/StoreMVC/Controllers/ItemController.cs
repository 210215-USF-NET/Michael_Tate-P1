using Grpc.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting.Internal;
using StoreBL;
using StoreDL;
using StoreModels;
using StoreMVC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Extensions.Hosting;

namespace StoreMVC.Controllers
{
    public class ItemController : Controller
    {
        private readonly StoreDBContext _context;

        public ItemController(StoreDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ItemView objItemView = new ItemView();
            objItemView.CategorySelectListItem = (from objCat in _context.Categorie
                                                  select new SelectListItem()
                                                  {
                                                      Text = objCat.CategoryName,
                                                      Value = objCat.Categoryid.ToString(),
                                                      Selected = true
                                                  });
            return View(objItemView);
        }

        [HttpPost]
        public JsonResult Index(ItemView objItemView)
        {
            string NewImage = Guid.NewGuid() + Path.GetExtension(objItemView.ImagePath.FileName);
            objItemView.ImagePath.CopyTo(Server.MapPath("~/Images/" + NewImage));

            Item objItem = new Item();
            objItem.ImagePath = "~/Images/" + NewImage;
            return Json("HHHH");
        }
    }
}