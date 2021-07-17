using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermLibraryTerminal
{
    class Option
    {
        public string OptionText { get; }
        public Action Selected { get; }
        public Option(string optionText, Action selected)
        {
            OptionText = optionText;
            Selected = selected;
        }
    }
}
