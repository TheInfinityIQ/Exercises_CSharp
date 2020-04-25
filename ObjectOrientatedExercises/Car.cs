using System;
using System.Collections.Generic;
using System.Text;

//1 - Create a Car class with the following properties: car�s make, model, registration, year, and current value.

//2 - Implement a constructor for the Car class that will accept parameters corresponding to each of the properties above and set them.

//3 - Create a method called Drive that will print "{CarModel} - Vroom! Vroom! Vroom!" to the console.

//4 - On the main method create three different cars, print its full information to the console and call the Drive method.
//*BONUS: Override the ToString method to return a string containing the full information about the car.

namespace ObjectOrientatedExercises
{
    class Car
    {

        // Property
        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public int Year { get; set; }
        public decimal Value { get; set; }

        // Constructors
        public Car(string make, string model, string registration, int year, decimal value)
        {
            this.Make = make;
            this.Model = model;
            this.Registration = registration;
            this.Year = year;
            this.Value = value;
        }

        // Methods
        public void Drive()
        {
            Console.WriteLine($"{Model} - Vroom! Vroom! Vroom!");
        }

        public void PrintCarInfo()
        {
            Console.WriteLine("----------------------------------------\nCar Shit\n----------------------------------------\n");
            Console.WriteLine($"Make: {Make}\nModel: {Model}\nRegistration: {Registration}\nYear: {Year}\nValue: ${Value}");
        }
    }
}
