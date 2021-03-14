using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IstoreBL
    {
        List<Customer> GetCustomer();

        Customer AddCustomer(Customer newCustomer);

        Order AddOrder(Order newOrder);

        Customer GetCustomerByName(string name);

        List<StoreLocation> GetStoreLocation();

        Customer UpdateCustomer(Customer customer2BUpdated);

        Customer DeleteCustomer(Customer customer2BDeleted);

        List<Order> GetOrder();
    }
}