using System;
using ToDo_Solo.MenuSystem;
using ToDo_Solo.TaskListSystem;

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
        #region FieldsAndConstructors
        //Fields
        private static ConsoleMenu _mainMenu;
        private static ConsoleMenuOption _selectableOption;
        private static ConsoleMenuOption _selectedOption;
        
        private static TaskList _taskList;
        private static Task _task;


        //Properties 
        /*Non in this program*/

        //Contructors
        static Program()
        {
            _mainMenu = new ConsoleMenu("Main Menu");
            _selectedOption = new ConsoleMenuOption();
            _taskList = new TaskList("List of tasks");

            ConsoleMenuOption[] _baseOptions
            = {
                new ConsoleMenuOption("Add Task", "NN" /*Not Needed*/, "1", AddTask),
                new ConsoleMenuOption("Edit Task", "NN" /*Not Needed*/, "2", EditTask),
                new ConsoleMenuOption("Remove Task", "NN" /*Not Needed*/, "3", RemoveTasks),
                new ConsoleMenuOption("Remove All Tasks", "NN" /*Not Needed*/, "4", RemoveAllTasks),
                new ConsoleMenuOption("Display All Tasks", "NN" /*Not Needed*/, "5", DisplayTasks),
                new ConsoleMenuOption("Exit", "Exits program", "0", () => Environment.Exit(0))
            };

            _mainMenu.Options.AddRange(_baseOptions);

        } 
        #endregion

        //Methods
        static void Main(string[] args)
        {
            OperateConsoleMenu();
        }

        #region TaskOperations
        static void AddTask()
        {
            Console.WriteLine(); //Makes things pretty
            _taskList.Tasks.Add(_taskList.AddTask()); //Accesses the list from _taskList and runs the AddTask method that returns type Task

            Console.WriteLine("You've added a task, returning to main menu");

            OperateConsoleMenu();
        }
        static void EditTask()
        {
            Console.WriteLine("Edit task was run");
            IsListEmpty();

            _taskList.EditTask();

            OperateConsoleMenu();
        }
        static void RemoveTasks()
        {
            Console.WriteLine("Remove task was run");
            IsListEmpty();

            _taskList.RemoveTask();

            OperateConsoleMenu();
        }
        static void RemoveAllTasks()
        {
            Console.WriteLine("All Tasks have been removed, returning to main menu. ");
            IsListEmpty();

            _taskList.Tasks.Clear();

            OperateConsoleMenu();
        }
        static void DisplayTasks()
        {
            _taskList.DisplayTasks();
            IsListEmpty();

            OperateConsoleMenu();
        }
        #endregion

        #region MenuOperations
        static void IsListEmpty()
        {
            if (_taskList.Tasks.Count == 0)
            {
                Console.WriteLine("There are no tasks in your list -> Taking you to main menu");
                Console.WriteLine();
                OperateConsoleMenu();
            }
        }

        static void OperateConsoleMenu()
        {
            _selectedOption = _mainMenu.InputFromMenu(false);
            _selectedOption.Outcome.Invoke();
        }
        #endregion
    }
}

