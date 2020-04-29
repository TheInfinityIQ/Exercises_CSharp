using System;

namespace Calculator_Solo.MenuSystem
{
    class ConsoleMenuOption
    {

        //Title
        //Actions performed when option is executed
        //Description of Option
        //Input needed to select Option
        public string Title { get; set; }
        public string Define { get; set; }
        public string Selector { get; set; }
        public Action Outcome { get; set; }

        public ConsoleMenuOption(string title, string define, string selector, Action outcome)
        {
            Title = title;
            Outcome = outcome;
            Define = define;
            Selector = selector;
        }
    }
}
