using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_Solo.TaskListSystem
{
    public class Task
    {
        //Fields
        //Properties
        public string Title { get; set; }
        public string Priority { get; set; }

        //Constructors
        public Task(string title, string priority)
        {
            Title = title;
            Priority = priority;
        }

        //Methods
    }
}
