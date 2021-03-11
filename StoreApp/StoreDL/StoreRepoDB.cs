using Microsoft.EntityFrameworkCore;
using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDL
{
    public class StoreRepoDB : IStoreRepository
    {
        private readonly StoreDBContext _context;

        public StoreRepoDB(StoreDBContext context)
        {
            _context = context;
        }

        public Customer AddCustomer(Customer newCustomer)
        {
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();
            return newCustomer;
        }

        public Order AddOrder(Order newOrder)
        {
            _context.Orders.Add(newOrder);
            _context.SaveChanges();
            return newOrder;
        }

        public Customer DeleteCustomer(Customer customer2BDeleted)
        {
            _context.Customers.Remove(customer2BDeleted);
            _context.SaveChanges();
            return customer2BDeleted;
        }

        public Order FindOrder(int orderID)
        {
            throw new NotImplementedException();
        }

        public Order FindOrder(double totalCost)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerByName(string name)
        {
            return _context.Customers
                .AsNoTracking()
                .FirstOrDefault(customer => customer.FirstName == name);
        }

        public List<Order> GetCustomerOrders(int custID)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customers
                .AsNoTracking()
                .Select(customer => customer)
                .ToList();
        }

        public List<Order> GetOrders()
        {
            return _context.Orders
                .Include("Order")
                .AsNoTracking()
                .Select(order => order)
                .ToList();
        }

        public Product GetPrice()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProduct()
        {
            throw new NotImplementedException();
        }

        public Product GetProductByName(int ProductName)
        {
            throw new NotImplementedException();
        }

        public List<StoreLocation> GetStoreLocation()
        {
            throw new NotImplementedException();
        }

        public Customer UpdateCustomer(Customer customer2BUpdated)
        {
            Customer oldCustomer = _context.Customers.Find(customer2BUpdated.Id);
            _context.Entry(oldCustomer).CurrentValues.SetValues(customer2BUpdated);
            _context.SaveChanges();
            _context.ChangeTracker.Clear();
            return customer2BUpdated;
        }

        public Product UpdateInventory(Product inv)
        {
            throw new NotImplementedException();
        }
    }
}