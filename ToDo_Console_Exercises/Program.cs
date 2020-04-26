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
        //static property that holds all the tasks
        public static List<Task> ListOfTasks { get; set; }

        static Program()
        {
            ListOfTasks = new List<Task>();
        }

        static void Main(string[] args)
        {
            ConsoleMenu mainMenu = new ConsoleMenu("Main Menu");

            ConsoleMenuOption listAllTasks = new ConsoleMenuOption("List All Tasks", "Will List All Tasks to the console.", "1", ListAllTasks);
            mainMenu.Options.Add(listAllTasks);

            for (int i = 0; i < mainMenu.Options.Count; i++)
            {
                Console.WriteLine($"Option {mainMenu.Options[i].Selector} will allow you to {mainMenu.Options[i].Title}");
            }

            //1 - Allow the user to add tasks. 
            //2 - Allow the user to edit tasks. 
            //3 - Allow the user to remove a specific task. 
            //4 - Allow the user to remove all tasks at once. 
            //5 - List all the current tasks. 

            //string lineSpam = new string('-', 10);
            //Console.WriteLine("Welcome to Task-A-Do");

            //Console.WriteLine("create task");
            //Task t1 = new Task("my first task", 0, 1);
            //ListOfTasks.Add(t1);
            //Task t2 = new Task("my second task", 0, 9);
            //ListOfTasks.Add(t2);

            //ListAllTasks();
            Console.ReadLine();
        }


        //Get input from User
        public static (string Title, string TimeDuration, string Priority, string Description) Input()
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

        //public static void findTask()
        //{
        //    ConsoleMenu taskMenu = new ConsoleMenu("Task Menu");
        //    ConsoleMenuOption taskOption;

        //    for (int i = 0; i < ListOfTasks.Count; i++)
        //    {
        //        taskOption = new ConsoleMenuOption(ListOfTasks[i].Title, ListOfTasks[i].Description, i.ToString(), null);
        //        taskMenu.Options.Add(taskOption);
        //    }


        //    //Display all tasks to user 
        //    //Assign each task to number 
        //    //Get input 
        //    //Locate and return 
        //}

        public static void AddTask()
        {
            Task task;

            (string title, string timeDuration, string priority, string description) = Input();

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
        }

        public static void EditTask()
        {
            //What task?
            //What do you want to change task to?
        }

        public static void RemoveTask()
        {
            //What task?
            //ListOfTasks.Remove(t1)
        }

        public static void RemoveAllTask()
        {
            ListOfTasks.Clear();
            Console.WriteLine("All tasks have been removed.");
        }

        public static void ListAllTasks()
        {
            for (int i = 0; i < ListOfTasks.Count; i++)
            {
                Task task = ListOfTasks[i];
                string taskInfo = task.DisplayInfo();
                Console.WriteLine(taskInfo);
            }
        }
    }
}
