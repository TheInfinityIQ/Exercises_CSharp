using System;
using ToDo_Solo.MenuSystem;

//=============================================================================================
//                                C# Exercises - OOP 2
//=============================================================================================

//- https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/object-oriented-programming
//=============================================================================================

//Your job is to create a console application that will manage a TODO list. The application should do the following:

//1 - Allow the user to add tasks.

//2 - Allow the user to edit tasks.

//3 - Allow the user to remove a specific task.

//4 - Allow the user to remove all tasks at once.

//5 - List all the current tasks.

//You should use the OOP techniques (C# Classes, methods, properties etc...) that have been learned up to this point. A menu-based console application should be used for presentation.

namespace ToDo_Solo
{
    class Program
    {
        //Fields
        private static ConsoleMenu _mainMenu;
        private static ConsoleMenuOption _selectedOption;
        
        //Properties 
        /*Non in this program*/

        //Contructors
        static Program()
        {
            _mainMenu = new ConsoleMenu("Main Menu");

            ConsoleMenuOption[] selectableOption 
            = {
                new ConsoleMenuOption("Add Task", "NN" /*Not Needed*/, "1", AddTask),
            new ConsoleMenuOption("Edit Task", "NN" /*Not Needed*/, "2", EditTask),
            new ConsoleMenuOption("Remove Task", "NN" /*Not Needed*/, "3", RemoveTasks),
            new ConsoleMenuOption("Remove All Tasks", "NN" /*Not Needed*/, "4", RemoveAllTasks),
            new ConsoleMenuOption("Exit", "Exits program", "0", () => Environment.Exit(0))
            };
        }

        //Methods
        static void Main(string[] args)
        {
            
        }

        static void AddTask()
        {

        }
        static void EditTask()
        {

        }
        static void RemoveTasks()
        {

        }
        static void RemoveAllTasks()
        {

        }
    }
}

