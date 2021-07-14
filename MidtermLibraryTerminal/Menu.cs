using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermLibraryTerminal
{
    class Menu
    {
        public static void MenuStart(List<Option> options, string prompt)
        {
            int index = 0;

            WriteMenu(options, options[index], prompt);

            bool menuLoop = true;

            //used like FileInfo;
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if(index + 1 < options.Count) //if there is an option below the current option, allow the down arrow input
                    {
                        index++; //set the index to the next option BEFORE calling the WriteMenu. otherwise it will just write out the same menu
                        WriteMenu(options, options[index], prompt);
                    }
                }
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (index - 1 >= 0) //if there is an option above the current option
                    {
                        index--;
                        WriteMenu(options, options[index], prompt);
                    }
                }

                if(keyInfo.Key == ConsoleKey.Enter)
                {
                    options[index].Selected.Invoke(); //do the Action associated with the option
                    index = 0; //reset the index back to the beginning
                    menuLoop = false; //break out of the menu's loop
                }
            }
            while (menuLoop == true);
        }

        public static void WriteMenu(List<Option> options, Option selectedOption, string prompt)
        {
            Console.Clear();
            Console.WriteLine($"{prompt}\n");

            foreach(Option option in options)
            {
                if (option == selectedOption)
                {
                    //way of distinguishing which option is the current option.
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.Write(string.Empty);
                }

                Console.WriteLine(option.OptionText);

                Console.ResetColor();
            }
        }
    }
}
