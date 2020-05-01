using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_Solo.TaskListSystem
{
    class TaskList
    {

        //Fields

        //Properties
        public string Title { get; set; }
        public List<Task> Tasks { get; set; }
        
        //Constructors
        public TaskList(string title, List<Task> tasks)
        {
            Title = title;
            Tasks = tasks;
        }

        //Methods
        
        //
    }
}
