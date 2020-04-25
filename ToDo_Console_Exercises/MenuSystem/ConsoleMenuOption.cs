using System;

namespace ToDo_Console_Exercises.MenuSystem
{
    class ConsoleMenuOption
    {
        //Title
        //Actions performed when option is executed
        //Description of Option
        //Input needed to select Option
        public string Title { get; set; }
        public Action Outcome { get; set; }
        public string Define { get; set; }
        public string Selector { get; set; }

    }
}
