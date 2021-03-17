using StoreDL;
using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBL
{
    public class CheckoutBL : ICheckoutBL
    {
        private ICheckoutRepo _repo;

        public CheckoutBL(ICheckoutRepo repo)
        {
            _repo = repo;
        }

        public void Add(CheckoutModel newCheckout)
        {
            _repo.Add(newCheckout);
        }

        public void CheckInItem(int assetId)
        {
            _repo.CheckInItem(assetId);
        }

        public void CheckOutItem(int assetId, int libraryCardId)
        {
            _repo.CheckOutItem(assetId, libraryCardId);
        }

        public List<CheckoutModel> GetAll()
        {
            return _repo.GetAll();
        }

        public CheckoutModel GetById(int checkoutId)
        {
            return GetById(checkoutId);
        }

        public List<CheckoutHistory> GetCheckoutHistories(int id)
        {
            return _repo.GetCheckoutHistories(id);
        }

        public string GetCurrentCheckoutPatron(int assetId)
        {
            return _repo.GetCurrentCheckoutPatron(assetId);
        }

        public string GetCurrentHoldPatronName(int id)
        {
            return _repo.GetCurrentHoldPatronName(id);
        }

        public DateTime GetCurrentHoldPlaced(int id)
        {
            return _repo.GetCurrentHoldPlaced(id);
        }

        public List<Hold> GetCurrentHolds(int id)
        {
            return _repo.GetCurrentHolds(id);
        }

        public CheckoutModel GetLatestCheckout(int assetId)
        {
            return _repo.GetLatestCheckout(assetId);
        }

        public bool IsCheckedOut(int id)
        {
            return _repo.IsCheckedOut(id);
        }

        public void MarkFound(int assetId)
        {
            _repo.MarkFound(assetId);
        }

        public void MarkLost(int assetId)
        {
            _repo.MarkLost(assetId);
        }

        public void PlaceHolder(int assetId, int libraryCardId)
        {
            _repo.PlaceHolder(assetId, libraryCardId);
        }
    }
}