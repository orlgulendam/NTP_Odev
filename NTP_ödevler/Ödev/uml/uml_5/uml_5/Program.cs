using System;
using System.Collections.Generic;

namespace CarRentalSystem
{
    // Customer Class
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public int Payment { get; set; }

        public void Update()
        {
            Console.WriteLine($"Customer {Name} information güncellendi.");
        }
    }

    // Car Class
    public class Car
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public string OrderType { get; set; }

        public void ProcessDebit()
        {
            Console.WriteLine($"Debit processed for car {Details} with order type {OrderType}.");
        }
    }

    // Payment Class
    public class Payment
    {
        public int Id { get; set; }
        public int CardNumber { get; set; }
        public int Amount { get; set; }

        public void Add()
        {
            Console.WriteLine($"Payment of {Amount} eklendi.");
        }

        public void Update()
        {
            Console.WriteLine($"Payment with ID {Id} güncellendi.");
        }
    }

    // Rentals Class
    public class Rentals
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public void Add()
        {
            Console.WriteLine($"Rental {Name} with price {Price} eklendi.");
        }
    }

    // Renting Owner Class
    public class RentingOwner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string ContactNum { get; set; }
        public string Password { get; set; }

        public void VerifyAccount()
        {
            Console.WriteLine($"Account of renting owner {Name} has been verified.");
        }
    }

    // Reservation Class
    public class Reservation
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public List<string> List { get; set; }

        public void Confirmation()
        {
            Console.WriteLine($"Reservation {Details} has been confirmed.");
        }
    }

    // Transaction Class
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Address { get; set; }

        public void Update()
        {
            Console.WriteLine($"Transaction {Name} on {Date} güncellendi.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a customer
            Customer customer = new Customer
            {
                Id = 1,
                Name = "John Doe",
                Contact = "555-1234",
                Address = "123 Main St",
                Payment = 200
            };
            customer.Update();

            // Create a car
            Car car = new Car
            {
                Id = 101,
                Details = "Toyota Corolla",
                OrderType = "Rental"
            };
            car.ProcessDebit();

            // Create a payment
            Payment payment = new Payment
            {
                Id = 201,
                CardNumber = 12345678,
                Amount = 500
            };
            payment.Add();
            payment.Update();

            // Create a rental
            Rentals rental = new Rentals
            {
                Id = 301,
                Name = "Long-term Rental",
                Price = 1200
            };
            rental.Add();

            // Create a renting owner
            RentingOwner owner = new RentingOwner
            {
                Id = 401,
                Name = "Jane Smith",
                Age = "45",
                ContactNum = "555-5678",
                Password = "securepassword"
            };
            owner.VerifyAccount();

            // Create a reservation
            Reservation reservation = new Reservation
            {
                Id = 501,
                Details = "Reservation for Toyota Corolla",
                List = new List<string> { "John Doe", "Toyota Corolla" }
            };
            reservation.Confirmation();

            // Create a transaction
            Transaction transaction = new Transaction
            {
                Id = 601,
                Name = "Rental Transaction",
                Date = "2025-01-01",
                Address = "123 Main St"
            };
            transaction.Update();
        }
    }
}