using StoreModels;
using StoreMVC.Models.PatronModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Models
{
    public class Mapper : IMapper
    {
        public Patron Cast2CreatePatron(CreatePatron newPatron)
        {
            return new Patron
            {
                FirstName = newPatron.FirstName,
                LastName = newPatron.LastName,
                //Address = newPatron.Address,
                //DateOfBirth = newPatron.DateOfBirth,
                PhoneNumber = newPatron.PhoneNumber
            };
        }

        public Patron Cast2Details(PatronDetailModel patronDetails)
        {
            throw new NotImplementedException();
        }

        public Patron Cast2Index(Patron currentPatrons)
        {
            throw new NotImplementedException();
        }
    }
}