using System;
using System.Collections.Generic;

namespace UniversitySystem
{
    // Address Class
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }

        // Validates the address
        public bool Validate()
        {
            return !string.IsNullOrEmpty(Street) && !string.IsNullOrEmpty(City) && !string.IsNullOrEmpty(State) &&
                   PostalCode > 0 && !string.IsNullOrEmpty(Country);
        }

        // Outputs address as label
        public string OutputAsLabel()
        {
            return $"{Street}, {City}, {State}, {PostalCode}, {Country}";
        }
    }

    // Person Class
    public abstract class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public Address Address { get; set; }

        // Method to purchase parking pass
        public void PurchaseParkingPass()
        {
            Console.WriteLine($"{Name} has purchased a parking pass.");
        }
    }

    // Student Class
    public class Student : Person
    {
        public int StudentNumber { get; set; }
        public int AverageMark { get; set; }

        // Checks if the student is eligible to enroll in a specific course
        public bool IsEligibleToEnroll(string course)
        {
            // Placeholder logic: Eligible if average mark is 50 or above
            return AverageMark >= 50;
        }

        // Gets the number of seminars taken
        public int GetSeminarsTaken()
        {
            // Placeholder logic
            return new Random().Next(1, 10); // Random number of seminars
        }
    }

    // Professor Class
    public class Professor : Person
    {
        public int Salary { get; set; }
        public int StaffNumber { get; set; }
        public int YearsOfService { get; set; }
        public int NumberOfClasses { get; set; }

        // Placeholder logic to demonstrate Professor's unique methods
        public void SuperviseStudent(Student student)
        {
            Console.WriteLine($"{Name} is supervising student {student.Name} (Student Number: {student.StudentNumber}).");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an address
            Address address = new Address
            {
                Street = "123 Main St",
                City = "Springfield",
                State = "IL",
                PostalCode = 62704,
                Country = "USA"
            };

            // Validate address and output as label
            if (address.Validate())
            {
                Console.WriteLine("Address is valid:");
                Console.WriteLine(address.OutputAsLabel());
            }

            // Create a student
            Student student = new Student
            {
                Name = "John Doe",
                PhoneNumber = "555-1234",
                EmailAddress = "johndoe@example.com",
                Address = address,
                StudentNumber = 12345,
                AverageMark = 75
            };

            // Display student details and check enrollment eligibility
            Console.WriteLine($"Student Name: {student.Name}");
            Console.WriteLine($"Eligible to enroll: {student.IsEligibleToEnroll("Math 101")}");
            Console.WriteLine($"Number of seminars taken: {student.GetSeminarsTaken()}");

            // Create a professor
            Professor professor = new Professor
            {
                Name = "Dr. Smith",
                PhoneNumber = "555-5678",
                EmailAddress = "drsmith@example.com",
                Address = address,
                Salary = 85000,
                StaffNumber = 98765,
                YearsOfService = 10,
                NumberOfClasses = 3
            };

            // Professor supervises the student
            professor.SuperviseStudent(student);
            professor.PurchaseParkingPass();
        }
    }
}