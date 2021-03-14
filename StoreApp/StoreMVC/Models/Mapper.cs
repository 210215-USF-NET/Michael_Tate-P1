﻿using StoreModels;

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

        public CustomerCRVM cast2CustomerCRVM(Customer customer)
        {
            return new CustomerCRVM
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            };
        }

        /*public Product cast2Product()
        {
            new Product
            {
                ProductID = 1,
                ProductName = "Convertible Car",
                Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included). Power it up and let it go!",
                ImagePath="carconvert.png",
                UnitPrice = 22.50,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 2,
                ProductName = "Old-time Car",
                Description = "There's nothing old about this toy car, except it's looks. Compatible with other old toy cars.",
                ImagePath="carearly.png",
                UnitPrice = 15.95,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 3,
                ProductName = "Fast Car",
                Description = "Yes this car is fast, but it also floats in water.",
                ImagePath="carfast.png",
                UnitPrice = 32.99,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 4,
                ProductName = "Super Fast Car",
                Description = "Use this super fast car to entertain guests. Lights and doors work!",
                ImagePath="carfaster.png",
                UnitPrice = 8.95,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 5,
                ProductName = "Old Style Racer",
                Description = "This old style racer can fly (with user assistance). Gravity controls flight duration. No batteries required.",
                ImagePath = "carracer.png",
                UnitPrice = 34.95,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 6,
                ProductName = "Ace Plane",
                Description = "Authentic airplane toy. Features realistic color and details.",
                ImagePath="planeace.png",
                UnitPrice = 95.00,
                CategoryID = 2
            },
            new Product
            {
                ProductID = 7,
                ProductName = "Glider",
                Description = "This fun glider is made from real balsa wood.Some assembly required.",
                ImagePath="planeglider.png",
                UnitPrice = 4.95,
                CategoryID = 2
            },
            new Product
            {
                ProductID = 8,
                ProductName = "Paper Plane",
                Description = "This paper plane is like no other paper plane.Some folding required.",
                ImagePath = "planepaper.png",
                UnitPrice = 2.95,
                CategoryID = 2
            },
            new Product
            {
                ProductID = 9,
                ProductName = "Propeller Plane",
                Description = "Rubber band powered plane features two wheels.",
                ImagePath = "planeprop.png",
                UnitPrice = 32.95,
                CategoryID = 2
            },
            new Product
            {
                ProductID = 10,
                ProductName = "Early Truck",
                Description = "This toy truck has a real gas powered engine.Requires regular tune ups.",
                ImagePath = "truckearly.png",
                UnitPrice = 15.00,
                CategoryID = 3
            },
            new Product
            {
                ProductID = 11,
                ProductName = "Fire Truck",
                Description = "You will have endless fun with this one quarter sized fire truck.",
                ImagePath="truckfire.png",
                UnitPrice = 26.00,
                CategoryID = 3
            },
            new Product
            {
                ProductID = 12,
                ProductName = "Big Truck",
                Description = "This fun toy truck can be used to tow other trucks that are not as big.",
                ImagePath="truckbig.png",
                UnitPrice = 29.00,
                CategoryID = 3
            },
            new Product
            {
                ProductID = 13,
                ProductName = "Big Ship",
                Description = "Is it a boat or a ship. Let this floating vehicle decide by using its artifically intelligent computer brain!",
                ImagePath = "boatbig.png",
                UnitPrice = 95.00,
                CategoryID = 4
            },
            new Product
            {
                ProductID = 14,
                ProductName = "Paper Boat",
                Description = "Floating fun for all! This toy boat can be assembled in seconds.Floats for minutes! Some folding required.",
                ImagePath="boatpaper.png",
                UnitPrice = 4.95,
                CategoryID = 4
            },
            new Product
            {
                ProductID = 15,
                ProductName = "Sail Boat",
                Description = "Put this fun toy sail boat in the water and let it go!",
                ImagePath="boatsail.png",
                UnitPrice = 42.95,
                CategoryID = 4
            },
            new Product
            {
                ProductID = 16,
                ProductName = "Rocket",
                Description = "This fun rocket will travel up to a height of 200 feet.",
                ImagePath = "rocket.png",
                UnitPrice = 122.95,
                CategoryID = 5
            }
        };
            return Product;
        }*/
    }
}