using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_Solo.TaskListSystem
{
    class Task
    {
        //Fields
        //Properties
        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public Action Outcome { get; set; }

        //Constructors
        public Task(string title, string description, int priority, Action outcome)
        {
            Title = title;
            Description = description;
            Priority = priority;
            Outcome = outcome;
        }



        //Methods
    }
}
