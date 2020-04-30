using Calculator_Solo.MenuSystem;

using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_Solo
{
    public class Calculator
    {
        //Fields
        private int timesThroughLoop;

        private string firstInput;
        private string secondInput;

        private int firstValidInput;
        private int secondValidInput;

        private decimal firstDecValidInput;
        private decimal secondDecValidInput;

        //Properties
        public string Title { get; set; }

        //Constructors
        public Calculator(string title)
        {
            Title = title;
        }

        public void ValidateInput(ConsoleMenuOption selectedOption)
        {
            bool errorDedected = true; //Used so GetInput() isn't invoked twice in ValidateInput()
            timesThroughLoop = 0;

            while (errorDedected)
            {
                if (errorDedected && timesThroughLoop > 0)
                {
                    Console.WriteLine("Previous input was not valid, please try again.");
                    Console.WriteLine(); //Makes things look pretty
                }

                //Gets input
                Console.WriteLine("Enter the first number: ");
                firstInput = Console.ReadLine();
                Console.WriteLine("Enter the second number: ");
                secondInput = Console.ReadLine();

                //Validates input and Invoked method from Methods above.
                switch (selectedOption.Selector)
                {
                    case "1":
                        if (int.TryParse(firstInput, out firstValidInput) && int.TryParse(secondInput, out secondValidInput))
                        {
                            Add();
                            errorDedected = false;
                        }
                        break;
                    case "2":
                        if (decimal.TryParse(firstInput, out firstDecValidInput) && decimal.TryParse(secondInput, out secondDecValidInput))
                        {
                            Divide();
                            errorDedected = false;
                        }
                        break;
                    case "3":
                        if (int.TryParse(firstInput, out firstValidInput) && int.TryParse(secondInput, out secondValidInput))
                        {
                            Multiply();
                            errorDedected = false;
                        }
                        break;
                    case "4":
                        if (int.TryParse(firstInput, out firstValidInput) && int.TryParse(secondInput, out secondValidInput))
                        {
                            Minus();
                            errorDedected = false;
                        }
                        break;
                    default:
                        errorDedected = true;
                        break;
                }
                timesThroughLoop++;
            }
        }

        //Methods
        private void Add()
        {
            Console.WriteLine("You've selected to Add numbers");
            Console.WriteLine(); //Make things pretty

            Console.WriteLine($"{firstValidInput} + {secondValidInput} = {firstValidInput + secondValidInput}");
        }
        private void Divide()
        {
            Console.WriteLine("You've selected to Divide numbers");
            Console.WriteLine(); //Make things pretty

            Console.WriteLine($"{firstDecValidInput} / {secondDecValidInput} = {decimal.Divide(firstDecValidInput, secondDecValidInput)}");
        }
        private void Multiply()
        {
            Console.WriteLine("You've selected to Multiply numbers");
            Console.WriteLine(); //Make things pretty

            Console.WriteLine($"{firstValidInput} * {secondValidInput} = {firstValidInput * secondValidInput}");
        }
        private void Minus()
        {
            Console.WriteLine("You've selected to Minus numbers");
            Console.WriteLine(); //Make things pretty

            Console.WriteLine($"{firstValidInput} - {secondValidInput} = {firstValidInput - secondValidInput}");
        }
    }
}
