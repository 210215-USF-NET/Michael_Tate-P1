using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDL
{
    public interface IPatronRepoDB
    {
        Patron Get(int id);

        List<Patron> GetAll();

        Patron AddPatron(Patron newPatron);

        List<CheckoutHistory> GetCheckoutHistories(int patronId);

        List<Hold> GetHolds(int patronId);

        List<CheckoutModel> GetCheckouts(int patronId);
    }
}