using StoreModels;

namespace StoreMVC.Models
{
    public interface IMapper
    {
        Customer cast2Customer(CustomerCRVM customer2BCasted);

        Customer cast2Customer(CustomerEditVM customer2BCasted);

        CustomerIndexVM cast2StoreIndexVM(Customer customer2BCasted);

        CustomerEditVM cast2CustomerEditVM(Customer customer);
    }
}