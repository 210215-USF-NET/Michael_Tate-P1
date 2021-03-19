using Microsoft.EntityFrameworkCore;
using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDL
{
    public class PatronRepoDB : IPatronRepoDB
    {
        private StoreDBContext _context;

        public PatronRepoDB(StoreDBContext context)
        {
            _context = context;
        }

        public Patron AddPatron(Patron newPatron)
        {
            _context.Add(newPatron);
            _context.SaveChanges();
            return newPatron;
        }

        public Patron Get(int id)
        {
            return GetAll()
                .FirstOrDefault(patron => patron.Id == id);
        }

        public List<Patron> GetAll()
        {
            return _context.Patrons
                .Include(patron => patron.LibraryCard)
                .Include(patron => patron.HomeLibraryBranch)
                .ToList();
        }

        public List<CheckoutHistory> GetCheckoutHistories(int patronId)
        {
            var cardId = Get(patronId).LibraryCard.Id;

            return _context.CheckoutHistories
                .Include(co => co.LibraryCard)
                .Include(co => co.LibraryAsset)
                .Where(co => co.LibraryCard.Id == cardId)
                .OrderByDescending(co => co.CheckedOut)
                .ToList();
        }

        public List<CheckoutModel> GetCheckouts(int patronId)
        {
            var cardId = Get(patronId).LibraryCard.Id;

            return _context.Checkouts
                .Include(co => co.LibraryCard)
                .Include(co => co.LibraryAsset)
                .Where(co => co.LibraryCard.Id == cardId)
                .ToList();
        }

        public List<Hold> GetHolds(int patronId)
        {
            var cardId = Get(patronId).LibraryCard.Id;

            return _context.Holds
                .Include(co => co.LibraryCard)
                .Include(co => co.LibraryAsset)
                .Where(co => co.LibraryCard.Id == cardId)
                .OrderByDescending(h => h.HoldPlaced)
                .ToList();
        }

        public Patron GetPatronByName(string name)
        {
            return _context.Patrons
                .AsNoTracking()
                .FirstOrDefault(pat => pat.FirstName.ToLower().Equals(name.ToLower()));
        }
    }
}