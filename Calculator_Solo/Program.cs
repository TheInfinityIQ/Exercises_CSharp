using Calculator_Solo.MenuSystem;
using System;

//Create a calculator that will validate input, allow the user to use the following operands (*,/,+,-)

namespace Calculator_Solo
{
    class Program
    {
        //Field - Kinda of like a global variabl
        private static ConsoleMenu _mainMenu;

        //Constructor
        static Program()
        {
            _mainMenu = new ConsoleMenu("Main Menu");
        }

        static void Main(string[] args)
        {

            ConsoleMenuOption[] optionSelections
            = {
                new ConsoleMenuOption("Add","Add","1", Add),
                new ConsoleMenuOption("Divide", "Divide", "2", Divide),
                new ConsoleMenuOption("Multiply", "Multiply", "3", Multiply),
                new ConsoleMenuOption("Minus", "Minus", "4", Minus),
                new ConsoleMenuOption("Exit", "Exits program", "0", () => Environment.Exit(0))
            };

            _mainMenu.Options.AddRange(optionSelections);
            ConsoleMenuOption selectedOption = _mainMenu.InputFromMenu(false);
            selectedOption.Outcome.Invoke();

        }

        //Create calculator class (take number, then operand, then another number)
        //Create methods inside calculator class that will use the operand
        //Create method to validate input then make it type CalculatorInput 
        //Create Method for output
        static string GetInput()
        {
            Console.Write("Enter a number: ");
            return Console.ReadLine();
        }
        static void ReturnToMenu()
        {
            Console.WriteLine(); //Makes things pretty
            ConsoleMenuOption selectedOption = _mainMenu.InputFromMenu(false);
            selectedOption.Outcome.Invoke();
        }
        static void Add()
        {
            Console.WriteLine("You've selected to Add numbers");
            Console.WriteLine(); //Make things pretty
            int num1 = int.Parse(GetInput());
            int num2 = int.Parse(GetInput());
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            
            ReturnToMenu();
        }
        static void Divide()
        {
            Console.WriteLine("You've selected to Divide numbers");
            Console.WriteLine(); //Make things pretty
            decimal num1 = decimal.Parse(GetInput());
            decimal num2 = decimal.Parse(GetInput());

            decimal result = Decimal.Divide(num1, num2);

            Console.WriteLine($"{num1} / {num2} = {result}");

            ReturnToMenu();
        }
        static void Multiply()
        {
            Console.WriteLine("You've selected to Multiply numbers");
            Console.WriteLine(); //Make things pretty
            int num1 = int.Parse(GetInput());
            int num2 = int.Parse(GetInput());
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");

            ReturnToMenu();
        }
        static void Minus()
        {
            Console.WriteLine("You've selected to Minus numbers");
            Console.WriteLine(); //Make things pretty
            int num1 = int.Parse(GetInput());
            int num2 = int.Parse(GetInput());
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");

            ReturnToMenu();
        }
    }
}

