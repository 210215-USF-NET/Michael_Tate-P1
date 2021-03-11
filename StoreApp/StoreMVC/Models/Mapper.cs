using StoreModels;

namespace StoreMVC.Models
{
    public class Mapper : IMapper
    {
        public CustomerIndexVM cast2StoreIndexVM(Customer customer2BCasted)
        {
            return new CustomerIndexVM
            {
                FirstName = customer2BCasted.FirstName,
                LastName = customer2BCasted.LastName,
                Email = customer2BCasted.Email,
                PhoneNumber = customer2BCasted.PhoneNumber
            };
        }

        public Customer cast2Customer(CustomerCRVM customer2BCasted)
        {
            return new Customer
            {
                FirstName = customer2BCasted.FirstName,
                LastName = customer2BCasted.LastName,
                Email = customer2BCasted.Email,
                PhoneNumber = customer2BCasted.PhoneNumber
            };
        }

        public Customer cast2Customer(CustomerEditVM customer2BCasted)
        {
            return new Customer
            {
                Id = customer2BCasted.CustID,
                FirstName = customer2BCasted.FirstName,
                LastName = customer2BCasted.LastName,
                Email = customer2BCasted.Email,
                PhoneNumber = customer2BCasted.PhoneNumber
            };
        }

        public CustomerEditVM cast2CustomerEditVM(Customer customer)
        {
            return new CustomerEditVM
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber,
                CustID = customer.Id
            };
        }
    }
}