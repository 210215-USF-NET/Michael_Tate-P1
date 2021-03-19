using System;
using StoreDL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreModels;

namespace StoreBL
{
    public class PatronBL : IPatronBL
    {
        private IPatronRepoDB _repo;

        public PatronBL(IPatronRepoDB repo)
        {
            _repo = repo;
        }

        public Patron AddPatron(Patron newPatron)
        {
            return _repo.AddPatron(newPatron);
        }

        public Patron Get(int id)
        {
            return _repo.Get(id);
        }

        public List<Patron> GetAll()
        {
            return _repo.GetAll();
        }

        public List<CheckoutHistory> GetCheckoutHistories(int patronId)
        {
            return _repo.GetCheckoutHistories(patronId);
        }

        public List<CheckoutModel> GetCheckouts(int patronId)
        {
            return _repo.GetCheckouts(patronId);
        }

        public List<Hold> GetHolds(int patronId)
        {
            return _repo.GetHolds(patronId);
        }

        public Patron GetPatronByName(string name)
        {
            return _repo.GetPatronByName(name);
        }
    }
}