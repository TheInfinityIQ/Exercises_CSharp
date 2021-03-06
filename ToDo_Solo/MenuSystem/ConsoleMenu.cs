﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_Solo.MenuSystem
{
    class ConsoleMenu
    {
        public string Title { get; set; }
        public List<ConsoleMenuOption> Options { get; set; }

        public ConsoleMenu(string title)
        {
            Title = title;
            Options = new List<ConsoleMenuOption>();
        }

        public void DisplayMenu()
        {
            for (int i = 0; i < this.Options.Count; i++)
            {
                Console.WriteLine($"{this.Options[i].Selector}. -=- {this.Options[i].Title}");
            }
        }
        public ConsoleMenuOption InputFromMenu(bool isDisplayedAlready)
        {

            bool validInput = false;
            ConsoleMenuOption selectedMenuOption;

            do
            {

                if (!isDisplayedAlready)
                {
                    DisplayMenu();
                }

                //Makes Things Pretty
                Console.WriteLine();

                string input = Console.ReadLine();

                selectedMenuOption = FindConsoleMenuOptionByUsingSelector(input);

                if (selectedMenuOption != null)
                {
                    validInput = true;
                }

            } while (!validInput);

            return selectedMenuOption; //Selected ConsoleMenuOption

        }

        private ConsoleMenuOption FindConsoleMenuOptionByUsingSelector(string selector)
        {
            return this.Options.Find(option => option.Selector == selector);
        }
    }
}
