using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBL
{
    public interface ICheckoutBL
    {
        List<CheckoutModel> GetAll();

        CheckoutModel GetById(int checkoutId);

        void Add(CheckoutModel newCheckout);

        void CheckOutItem(int assetId, int libraryCardId);

        void CheckInItem(int assetId);

        List<CheckoutHistory> GetCheckoutHistories(int id);

        CheckoutModel GetLatestCheckout(int assetId);

        bool IsCheckedOut(int id);

        string GetCurrentCheckoutPatron(int assetId);

        void PlaceHolder(int assetId, int libraryCardId);

        string GetCurrentHoldPatronName(int id);

        DateTime GetCurrentHoldPlaced(int id);

        List<Hold> GetCurrentHolds(int id);

        void MarkLost(int assetId);

        void MarkFound(int assetId);
    }
}