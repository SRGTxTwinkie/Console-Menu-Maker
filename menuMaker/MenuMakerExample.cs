using System;
using Menu;

namespace menuMaker
{
    public class MenuMakerExample
    {
        
        public static void Main(string[] args)
        {
            MenuTemplate menu_0 = new MenuTemplate("This is menu 0");
            MenuTemplate menu_1 = new MenuTemplate("This is menu 1");
            MenuTemplate menu_2 = new MenuTemplate("This is menu 2");

            int menu_1_arr_position;
            string menu_2_string_value;

            menu_0.AddItem("This is Menu 0");
            menu_0.AddItem("Item 1");
            menu_0.AddItem("This menu takes no input");
            menu_0.AddItem("It has no return value");
            menu_0.AddItem("It will only print out the items");
            menu_0.DisplayList();

            Console.WriteLine("\n");

            menu_1.AddItem("This is Menu 1");
            menu_1.AddItem("Item 2");
            menu_1.AddItem("This menu will take input");
            menu_1.AddItem("It will prompt the user for a number in between 1 and the number of items in the array");
            menu_1.AddItem("It will return an integer containing the number chosen");
            menu_1_arr_position = menu_1.DisplayList(true);

            Console.WriteLine("\n");
            
            menu_2.AddItem("This is Menu 2");
            menu_2.AddItem("Item 3");
            menu_2.AddItem("This menu will take input");
            menu_2.AddItem("It will prompt the user for a number in between 1 and the number of items in the array");
            menu_2.AddItem("This will return a string containing that value of the array position they chose");
            menu_2_string_value = menu_2.DisplayList(true, true);

            menu_0.RemoveItem(0);
            menu_0.RemoveItem("Item 1");

            Console.Clear();

            Console.WriteLine("Menu 1 input: {0}", menu_1_arr_position);
            Console.WriteLine("Menu 2 input: {0}", menu_2_string_value);

            Console.WriteLine("\n");

            Console.WriteLine("Contents of Menu 0 after removal - ");
            menu_0.DisplayList();
        }
    }
}