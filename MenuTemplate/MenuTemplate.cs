using System;
using System.Collections.Generic;
using System.Linq;

namespace Menu
{
    public class MenuTemplate
    {
        string[] items;
        string title;

        public MenuTemplate() // Just a Default Constructor
        {
            title = "Menu Items";
            items = new string[0];
        }

        public MenuTemplate(string new_title) // Overload for changing the name of the Menu.
        {
            title = new_title;
            items = new string[0];
        }

        public void AddItem(string to_add) // I could change this so it goes straight to the function, but I like it better like this. Better readability.
        {
            items = ArrayAdd(items, to_add);
        }

        public void RemoveItem(string to_remove) // Same for this one.
        {
            items = ArrRemove(items, to_remove);
        }

        public void RemoveItem(int to_remove) // and this one.
        {
            items = ArrRemove(items, to_remove);
        }

        public void DisplayList() // Prints out the list only, no input handling.
        {
            Console.WriteLine("{0} \n", title);

            for(int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, items[i]);
            }

        }

        public int DisplayList(bool grab_input) // Grabs the input from the console using the InputParser method.
        {
            if (!grab_input)
            {
                throw new NotImplementedException("__**Use empty method call when not returning any values**__");
            }
            else
            {
                Console.WriteLine("{0} \n", title);

                for (int i = 0; i < items.Length; i++)
                {
                    Console.WriteLine("{0}: {1}", i + 1, items[i]);
                }

                Console.Write("[1/{0}]: ", items.Length);

                return InputParser(Console.ReadLine());
            }
        }

        public string DisplayList(bool grab_input, bool return_string_value) // Takes input and returns the string value of the list item chosen. 
        {
            if (!grab_input && !return_string_value)
            {
                throw new NotImplementedException("__**Use empty method call when not returning any values**__");
            }

            else if (grab_input && !return_string_value)
            {
                throw new NotImplementedException("__**Leave the second bool empty when not returning the string value**__");
            }

            else if (!grab_input && return_string_value)
            {
                throw new NotImplementedException("__**Cannot return string value when not returning input**__");
            }

            else if (grab_input && return_string_value)
            {
                Console.WriteLine("{0} \n", title);

                for (int i = 0; i < items.Length; i++)
                {
                    Console.WriteLine("{0}: {1}", i + 1, items[i]);
                }

                Console.Write("[1/{0}]: ", items.Length);

                return items[InputParser(Console.ReadLine()) - 1];
            }
            else
            {
                throw new NotImplementedException("__**You did something I didn't count on, this is the default fallthru**__");
            }
        }

        private int InputParser(string to_parse) // Keeps asking for input until a valid number is chosen.
        {
            int number;

            while (true)
            {
                if (int.TryParse(to_parse, out number))
                {
                    if(number <= items.Length && number >= 1)
                    {
                        return number;
                    }
                }
                Console.WriteLine("Please enter a number in range 0 - {0}.", items.Length);
                Console.Write("[1/{0}]: ", items.Length);
                to_parse = Console.ReadLine();
            }
        }

        private string[] ArrRemove(string[] array, int arr_position) // Removes item at given arr position.
        {
            List<string> new_arr = array.ToList();
            new_arr.RemoveAt(arr_position);

            return new_arr.ToArray();
        }
        private string[] ArrRemove(string[] array, string item_name) // Overload for removing string value of an array.
        {
            List<string> new_arr = array.ToList();
            new_arr.Remove(item_name);

            return new_arr.ToArray();
        }

        private string[] ArrayAdd(string[] array, string to_add) // Adds a new string to the item list.
        {
            string[] new_arr = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                new_arr[i] = array[i];
            }

            new_arr[array.Length] = to_add;

            return new_arr;
        }
    }
}
