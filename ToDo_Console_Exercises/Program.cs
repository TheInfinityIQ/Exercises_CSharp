using System;
using System.Collections.Generic;
using ToDo_Console_Exercises.MenuSystem;

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

namespace ToDo_Console_Exercises
{
    class Program
    {

        //Fields
        private static ConsoleMenu _mainMenu;
        //static property that holds all the tasks
        private static List<Task> ListOfTasks { get; set; }

        static Program()
        {
            ListOfTasks = new List<Task>();
            _mainMenu = new ConsoleMenu("Main Menu");
        }

        static void Main(string[] args)
        {
            #region ConsoleMenuOptionCreation
            ConsoleMenuOption[] actionOptions
            = {
                new ConsoleMenuOption("Add Defined Task", "Invokes method AddTask", "1", AddTask),
                new ConsoleMenuOption("Edit Selected Task", "Invokes to method EditTask", "2", EditTask),
                new ConsoleMenuOption("Remove Selected Task", "Invokes to method RemoveTask", "3", RemoveTask),
                new ConsoleMenuOption("Remove All Tasks From List", "Invokes to method RemoveAllTask", "4", RemoveAllTask),
                new ConsoleMenuOption("List All Tasks", "Invokes to method listAllTaskOptions", "5", ListAllTasks),
                new ConsoleMenuOption("Exit Program", "Exits program", "6", () => Environment.Exit(0))
            };
            #endregion

            _mainMenu.Options.AddRange(actionOptions);

            ConsoleMenuOption selectedOption = _mainMenu.InputFromMenu(false);
            Console.WriteLine(); //Makes Things Pretty
            Console.WriteLine(selectedOption.Title);
            selectedOption.Outcome.Invoke();
        }

        //Get input from User
        public static (string Title, string TimeDuration, string Priority, string Description) TaskInput()
        {
            Console.WriteLine($"Enter the {nameof(Task.Title)} of your Task: ");
            string title = Console.ReadLine();

            Console.WriteLine($"Enter the {nameof(Task.TimeDuration)} of your Task: ");
            string timeDuration = Console.ReadLine();

            Console.WriteLine($"Enter the {nameof(Task.Priority)} of your Task: ");
            string priority = Console.ReadLine();

            Console.WriteLine($"(Optional)Enter the {nameof(Task.Description)} of your Task: ");
            string description = Console.ReadLine();

            (string Title, string TimeDuration, string Priority, string Description) taskInfo = (title, timeDuration, priority, description);
            return taskInfo;
        }

        public static Task TaskSelector()
        {

            ConsoleMenu taskMenu = new ConsoleMenu("Task Menu");
            ConsoleMenuOption taskOption;

            Task task = null;

            if (ListOfTasks.Count <= 0)
            {
                Console.WriteLine("No tasks found... returning to main menu.");
                Console.WriteLine(); //Pretty lines
                return null;
            }

            //Add tasks to the menu
            for (int i = 0; i < ListOfTasks.Count; i++)
            {

                Task currentTask = ListOfTasks[i];

                taskOption = new ConsoleMenuOption(currentTask.Title, currentTask.Description, i.ToString() /*Selector*/, () => task = currentTask);
                taskMenu.Options.Add(taskOption);

            }

            ConsoleMenuOption selectedTaskFromTaskMenu = taskMenu.InputFromMenu(false);
            selectedTaskFromTaskMenu.Outcome.Invoke();
            return task;

        }

        public static void AddTask()
        {
            Task task;

            (string title, string timeDuration, string priority, string description) = TaskInput();

            if (description == null)
            {
                task = new Task(title, int.Parse(timeDuration), int.Parse(priority));
            }
            else
            {
                task = new Task(title, int.Parse(timeDuration), int.Parse(priority), description);
            }
            ListOfTasks.Add(task);
            
            //Go back to menu
            ConsoleMenuOption definedOption = _mainMenu.InputFromMenu(false);
            definedOption.Outcome.Invoke();
        }

        public static void EditTask()
        {
            Task selectedTask = TaskSelector();

            if (selectedTask != null)
            {
                (string title, string timeDuration, string priority, string description) taskTuple = TaskInput();

                selectedTask.Title = taskTuple.title;
                selectedTask.TimeDuration = int.Parse(taskTuple.timeDuration);
                selectedTask.Priority = int.Parse(taskTuple.priority);
                selectedTask.Description = taskTuple.description;
            }

            ConsoleMenuOption definedOption = _mainMenu.InputFromMenu(false);
            definedOption.Outcome.Invoke();
        }

        //<Task1, Task2, Task3>

        public static void RemoveTask()
        {
            Task selectedTask = TaskSelector();

            if (selectedTask != null)
                ListOfTasks.Remove(selectedTask);

            ConsoleMenuOption definedOption = _mainMenu.InputFromMenu(false);
            definedOption.Outcome.Invoke();
        }

        public static void RemoveAllTask()
        {
            ListOfTasks.Clear();
            Console.WriteLine("All tasks have been removed.");
            
            ConsoleMenuOption definedOption = _mainMenu.InputFromMenu(false);
            definedOption.Outcome.Invoke();
        }

        public static void ListAllTasks()
        {
            for (int i = 0; i < ListOfTasks.Count; i++)
            {
                Task task = ListOfTasks[i];
                string taskInfo = task.DisplayInfo();
                Console.WriteLine(taskInfo);
            }
            
            ConsoleMenuOption definedOption = _mainMenu.InputFromMenu(false);
            definedOption.Outcome.Invoke();
        }
    }
}
