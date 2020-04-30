using Calculator_Solo.MenuSystem;
using System;

//Create a calculator that will validate input, allow the user to use the following operands (*,/,+,-)

namespace Calculator_Solo
{
    class Program
    {
        //Field - Kinda of like a global variabl
        private static ConsoleMenu _mainMenu;
        private static Calculator _calculator;
        private static ConsoleMenuOption _selectedOption;

        //Constructor
        static Program()
        {

            _mainMenu = new ConsoleMenu("Main Menu");
            _calculator = new Calculator("Calculator");

            ConsoleMenuOption[] optionSelections
            = {
                new ConsoleMenuOption("Add","Add","1", Add),
                new ConsoleMenuOption("Divide", "Divide", "2", Divide),
                new ConsoleMenuOption("Multiply", "Multiply", "3", Multiply),
                new ConsoleMenuOption("Minus", "Minus", "4", Minus),
                new ConsoleMenuOption("Exit", "Exits program", "0", () => Environment.Exit(0))
            };

            _mainMenu.Options.AddRange(optionSelections);

        }

        //Methods
        static void Main(string[] args)
        {
            _selectedOption = _mainMenu.InputFromMenu(false);
            _selectedOption.Outcome.Invoke();
        }

        static void ReturnToMenu()
        {
            Console.WriteLine(); //Makes things pretty
            _selectedOption = _mainMenu.InputFromMenu(false);
            _selectedOption.Outcome.Invoke();
        }
        #region CalculationMethods
        static void Add()
        {
            _calculator.ValidateInput(_selectedOption);
            ReturnToMenu();
        }
        static void Divide()
        {
            _calculator.ValidateInput(_selectedOption);
            ReturnToMenu();
        }
        static void Multiply()
        {
            _calculator.ValidateInput(_selectedOption);
            ReturnToMenu();
        }
        static void Minus()
        {
            _calculator.ValidateInput(_selectedOption);
            ReturnToMenu();
        } 
        #endregion
    }
}