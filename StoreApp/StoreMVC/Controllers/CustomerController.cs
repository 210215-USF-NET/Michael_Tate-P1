using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreBL;
using StoreMVC.Models;

namespace StoreMVC.Controllers
{
    public class CustomerController : Controller
    {
        private IstoreBL _storeBL;
        private IMapper _mapper;

        public CustomerController(IstoreBL storeBL, IMapper mapper)
        {
            _storeBL = storeBL;
            _mapper = mapper;
        }

        // GET: CusstomerController
        public ActionResult Index()
        {
            return View(_storeBL.GetCustomer()
                .Select(customer => _mapper.cast2StoreIndexVM(customer))
                .ToList());
        }

        // GET: CusstomerController/Details/5
        public ActionResult Details(string name)
        {
            return View(_mapper.cast2CustomerEditVM(_storeBL.GetCustomerByName(name)));
        }

        // GET: CusstomerController/Create
        public ActionResult Create()
        {
            return View("CreateCustomer");
        }

        // POST: CusstomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerCRVM newCustomer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _storeBL.AddCustomer(_mapper.cast2Customer(newCustomer));
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        // GET: CusstomerController/Edit/5
        public ActionResult Edit(string name)
        {
            return View(_mapper.cast2CustomerEditVM(_storeBL.GetCustomerByName(name)));
        }

        // POST: CusstomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CustomerEditVM customer2Bupdated)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _storeBL.UpdateCustomer(_mapper.cast2Customer(customer2Bupdated));
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        // GET: CusstomerController/Delete/5
        public ActionResult Delete(string name)
        {
            _storeBL.DeleteCustomer(_storeBL.GetCustomerByName(name));
            return RedirectToAction(nameof(Index));
        }

        // POST: CusstomerController/Delete/5
        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */
    }
}