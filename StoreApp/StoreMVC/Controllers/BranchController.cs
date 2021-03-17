using Microsoft.AspNetCore.Mvc;
using StoreBL;
using StoreMVC.Models.Branch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Controllers
{
    public class BranchController : Controller
    {
        private IBranchBL _branch;

        public BranchController(IBranchBL branch)
        {
            _branch = branch;
        }

        public IActionResult Index()
        {
            var branches = _branch.GetAll()
                .Select(branch => new BranchDetailModel
                {
                    Id = branch.Id,
                    Name = branch.Name,
                    IsOpen = _branch.IsBranch(branch.Id),
                    NumberOfAssets = _branch.GetAssets(branch.Id).Count(),
                    NumberOfPatrons = _branch.GetPatrons(branch.Id).Count()
                });

            var model = new BranchIndexModel()
            {
                Branches = branches
            };

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var branch = _branch.Get(id);

            var model = new BranchDetailModel
            {
                Id = branch.Id,
                Name = branch.Name,
                Address = branch.Address,
                PhoneNumber = branch.PhoneNumber,
                OpenDate = branch.OpenDate.ToString("yyyy-MM-dd"),
                NumberOfAssets = _branch.GetAssets(id).Count(),
                NumberOfPatrons = _branch.GetPatrons(branch.Id).Count(),
                TotalAssetValue = _branch.GetAssets(id).Sum(a => a.Cost),
                ImageUrl = branch.ImageUrl,
                HoursOpen = _branch.GetBranchHours(id).ToList()
            };
            return View(model);
        }
    }
}