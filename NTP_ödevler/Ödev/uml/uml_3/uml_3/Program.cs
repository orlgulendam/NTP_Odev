using System;
using System.Collections.Generic;
using System.Linq;

namespace PetManagementSystem
{
    // Protocol (Interface): Identifiable
    public interface IIdentifiable
    {
        Guid Id { get; }
    }

    // Protocol (Interface): Experienced
    public interface IExperienced
    {
        string Name { get; }
    }

    // Vaccine Class
    public class Vaccine
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Vaccine(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Name} ({Type})";
        }
    }

    // PetInformation Class
    public class PetInformation
    {
        public List<string> Traits { get; set; }
        public List<Vaccine> Vaccines { get; set; }

        public PetInformation()
        {
            Traits = new List<string>();
            Vaccines = new List<Vaccine>();
        }

        public void AddTrait(string trait)
        {
            Traits.Add(trait);
        }

        public void AddVaccine(Vaccine vaccine)
        {
            Vaccines.Add(vaccine);
        }

        public override string ToString()
        {
            var traitsString = string.Join(", ", Traits);
            var vaccinesString = string.Join("; ", Vaccines.Select(v => v.ToString()));
            return $"Traits: {traitsString}\nVaccines: {vaccinesString}";
        }
    }

    // Animal Class
    public class Animal
    {
        public string Type { get; set; }
        public string Breed { get; set; }
        public bool Carnivore { get; set; }

        public Animal(string type, string breed, bool carnivore)
        {
            Type = type;
            Breed = breed;
            Carnivore = carnivore;
        }

        public override string ToString()
        {
            return $"Type: {Type}, Breed: {Breed}, Carnivore: {Carnivore}";
        }
    }

    // Owner Class
    public class Owner : IExperienced
    {
        public string Name { get; set; }

        public Owner(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Owner Name: {Name}";
        }
    }

    // Pet Class
    public class Pet : IIdentifiable
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Age { get; set; }
        public Owner Owner { get; set; }
        public Animal Type { get; set; }
        public PetInformation PetInfo { get; set; }

        public Pet(string name, int age, Owner owner, Animal type, PetInformation petInfo)
        {
            Name = name;
            Age = age;
            Owner = owner;
            Type = type;
            PetInfo = petInfo;
        }

        public void Feed()
        {
            Console.WriteLine($"{Name} has been fed.");
        }

        public bool IsHerbivore()
        {
            return !Type.Carnivore;
        }

        public override string ToString()
        {
            return $"Pet ID: {Id}\nName: {Name}\nAge: {Age}\nOwner: {Owner}\nAnimal: {Type}\nInformation:\n{PetInfo}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create Owner
            Owner owner = new Owner("John Doe");

            // Create Animal
            Animal animal = new Animal("Dog", "Labrador", false);

            // Create Pet Information
            PetInformation petInfo = new PetInformation();
            petInfo.AddTrait("Friendly");
            petInfo.AddTrait("Loyal");
            petInfo.AddVaccine(new Vaccine("Rabies", "Mandatory"));
            petInfo.AddVaccine(new Vaccine("Distemper", "Optional"));

            // Create Pet
            Pet pet = new Pet("Buddy", 3, owner, animal, petInfo);

            // Display Pet Information
            Console.WriteLine(pet);

            // Feed the pet
            pet.Feed();

            // Check if the pet is herbivore
            Console.WriteLine($"Is {pet.Name} herbivore? {pet.IsHerbivore()}");
        }
    }
}