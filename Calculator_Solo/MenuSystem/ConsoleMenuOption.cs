﻿using System;

namespace Calculator_Solo.MenuSystem
{
    public class ConsoleMenuOption
    {
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
