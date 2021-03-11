using StoreModels;
using System.Collections.Generic;

//using Entity = StoreDL.Entities;
using Model = StoreModels;

namespace StoreDL
{
    public interface IStoreRepository
    {
        List<Customer> GetCustomers();

        Customer AddCustomer(Customer newCustomer);

        Customer GetCustomerByName(string name);

        List<Order> GetOrders();

        List<StoreLocation> GetStoreLocation();

        Order AddOrder(Order newOrder);

        Order FindOrder(int orderID);

        Order FindOrder(double totalCost);

        List<Order> GetCustomerOrders(int custID);

        Product GetProductByName(int ProductName);

        List<Product> GetProduct();

        Product GetPrice();

        Customer UpdateCustomer(Customer customer2BUpdated);

        Customer DeleteCustomer(Customer customer2BDeleted);

        Product UpdateInventory(Product inv);
    }
}