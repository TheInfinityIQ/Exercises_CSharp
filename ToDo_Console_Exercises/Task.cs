using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_Console_Exercises
{
    class Task
    {
        //Title
        public string Title { get; set; }
        //Time duration
        public int TimeDuration { get; set; }
        //Priority
        public int Priority { get; set; }
        //Description
        public string Description { get; set; }

        public Task(string title, int timeDuration, int priority, string description)
        {
            Title = title;
            TimeDuration = timeDuration;
            Priority = priority;
            Description = description;
        }

        public Task(string title, int timeDuration, int priority) : this(title, timeDuration, priority, "No description provided")
        {
        }

        // make a method to return a string containing all info of this Task
        public string DisplayInfo()
        {
            return $"Task Name: {Title}\nTime Duration: {TimeDuration}\nPriority Level: {Priority}\nDescription: {Description}\n\n";
        }
    }
}
