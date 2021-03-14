using System;
using System.Collections.Generic;
using StoreModels;
using StoreDL;

namespace StoreBL
{
    public class storeBL : IstoreBL
    {
        private IStoreRepository _repo;

        public storeBL(IStoreRepository repo)
        {
            _repo = repo;
        }

        public Customer AddCustomer(Customer newCustomer)
        {
            return _repo.AddCustomer(newCustomer);
        }

        public Order AddOrder(Order newOrder)
        {
            return _repo.AddOrder(newOrder);
        }

        public Customer DeleteCustomer(Customer customer2BDeleted)
        {
            return _repo.DeleteCustomer(customer2BDeleted);
        }

        public List<Customer> GetCustomer()
        {
            return _repo.GetCustomers();
        }

        public Customer GetCustomerByName(string name)
        {
            return _repo.GetCustomerByName(name);
        }

        public List<StoreLocation> GetStoreLocation()
        {
            return _repo.GetStoreLocation();
        }

        public Customer UpdateCustomer(Customer customer2BUpdated)
        {
            return _repo.UpdateCustomer(customer2BUpdated);
        }

        public List<Order> GetOrder()
        {
            return _repo.GetOrders();
        }
    }
}