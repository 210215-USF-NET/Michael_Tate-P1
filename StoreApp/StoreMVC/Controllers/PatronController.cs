using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StoreBL;
using StoreDL;
using StoreModels;
using StoreMVC.Models.PatronModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Controllers
{
    public class PatronController : Controller
    {
        private IPatronBL _patron;

        private StoreDBContext _context;

        public PatronController(IPatronBL patron, StoreDBContext context)
        {
            _patron = patron;
            _context = context;
        }

        public IActionResult Index()
        {
            var allPatrons = _patron.GetAll();

            var patronModels = allPatrons.Select(p => new PatronDetailModel
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                LibraryCardId = p.LibraryCard.Id,
                OverdueFees = p.LibraryCard.Fees,
                HomeLibraryBranch = p.HomeLibraryBranch.Name
            }).ToList();

            var model = new PatronIndex()
            {
                Patrons = patronModels
            };

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var patron = _patron.Get(id);

            var model = new PatronDetailModel
            {
                LastName = patron.LastName,
                FirstName = patron.FirstName,
                Address = patron.Address,
                HomeLibraryBranch = patron.HomeLibraryBranch.Name,
                MemberSince = patron.LibraryCard.Created,
                OverdueFees = patron.LibraryCard.Fees,
                LibraryCardId = patron.LibraryCard.Id,
                PhoneNumber = patron.PhoneNumber,
                AssetsCheckedOut = _patron.GetCheckouts(id).ToList() ?? new List<CheckoutModel>(),
                CheckoutHistory = _patron.GetCheckoutHistories(id),
                Holds = _patron.GetHolds(id)
            };

            return View(model);
        }

        public ActionResult Add()
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Patron newPatron)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var model = new Patron
                    {
                        FirstName = newPatron.FirstName,
                        LastName = newPatron.LastName,
                        PhoneNumber = newPatron.PhoneNumber,
                    };
                    var patron = _patron.AddPatron(model);
                    return View(model);
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }
    }
}