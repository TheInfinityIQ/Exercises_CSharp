using System;

//=============================================================================================
//                                C# Exercises - OOP 1
//=============================================================================================
//- https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/object-oriented-programming
//=============================================================================================

//1 - Create a Car class with the following properties: car�s make, model, registration, year, and current value.

//2 - Implement a constructor for the Car class that will accept parameters corresponding to each of the properties above and set them.

//3 - Create a method called Drive that will print "{CarModel} - Vroom! Vroom! Vroom!" to the console.

//4 - On the main method create three different cars, print its full information to the console and call the Drive method.
//*BONUS: Override the ToString method to return a string containing the full information about the car.

namespace ObjectOrientatedExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Car fordTruck = new Car("Ford", "F-150", "Ford Sellers", 1997, 2500.50m);
            fordTruck.PrintCarInfo();
            fordTruck.Drive();

            Car chevyTruck = new Car("Chevy", "Silverado", "Chevy Sellers", 1998, 5.50m);
            chevyTruck.PrintCarInfo();
            chevyTruck.Drive();

            Car fordCar = new Car("Ford", "Taurus", "Ford Sellers Inc.", 2016, 10050.56m);
            fordCar.PrintCarInfo();
            fordCar.Drive();
        }
    }
}
