using System.Collections.Generic;
using System.Text;

namespace ToDo_Console_Exercises.MenuSystem
{
    class ConsoleMenu
    {
        //Title
        //Options
        //Options within options

        public string Title { get; set; }
        public List<ConsoleMenuOption> Options { get; set; }

        public ConsoleMenu(string title)
        {
            Title = title;
            Options = new List<ConsoleMenuOption>();
        }

        public void DisplayMenu()
        {
            
        }
    }
}
