using System;
using System.Collections.Generic;
using System.Text;
using ToDo_Solo.MenuSystem;

namespace ToDo_Solo.TaskListSystem
{
    class TaskList
    {
        //Properties
        public string Title { get; set; }
        public List<Task> Tasks { get; private set; }

        //Constructors
        public TaskList(string title)
        {
            Title = title;
            Tasks = new List<Task>();
        }

        //Methods
        public Task AddTask()
        {
            Console.WriteLine("Enter the name of your task: "); //Title
            string titleInput = Console.ReadLine();

            //Test if priority is taken (two tasks can not have #1 priority)
            Console.WriteLine("Enter the priority of your task"); //Priority
            string priorityInput = Console.ReadLine();

            Task task = new Task(titleInput, priorityInput);
            return task;
        }

        public void EditTask()
        {
            Console.WriteLine(); //Makes things pretty
            Task task = TaskSelector();

            Console.Write("Enter a new title for your task: ");
            string titleInput = Console.ReadLine();
            task.Title = titleInput;

            Console.WriteLine("Enter a new priority for your task: ");
            string priorityInput = Console.ReadLine();
            task.Priority = priorityInput;
        }

        public void RemoveTask()
        {
            Console.WriteLine(); //Makes things pretty
            Task task = TaskSelector();

            Console.WriteLine($"{task.Title} has been removed");

            this.Tasks.Remove(task);
        }

        //RemoveAllTasks is within Program.CS due to it's simplicity. 

        public void DisplayTasks()
        {
            Console.WriteLine(); // Makes things pretty
            for (int i = 0; i < this.Tasks.Count; i++)
            {
                Console.WriteLine($"{this.Tasks[i].Priority} -=- {this.Tasks[i].Title}");
            }
            Console.WriteLine(); // Makes things pretty
        }

        private Task TaskSelector()
        {

            ConsoleMenu taskMenu = new ConsoleMenu("Task Menu");
            ConsoleMenuOption taskOption;

            Task task = null;

            //Add tasks to the menu
            for (int i = 0; i < this.Tasks.Count; i++)
            {

                Task currentTask = this.Tasks[i];

                taskOption = new ConsoleMenuOption(currentTask.Title, null, i.ToString() /*Selector*/, () => task = currentTask);
                taskMenu.Options.Add(taskOption);

            }

            ConsoleMenuOption selectedTaskFromTaskMenu = taskMenu.InputFromMenu(false);
            selectedTaskFromTaskMenu.Outcome.Invoke();
            return task;
        }
    }
}