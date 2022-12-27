using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System_2._0
{
    public class Menu
    {
        public static int EnterUserChoice()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Our Hotel!");
            Console.WriteLine("=======================");
            Console.WriteLine("How I Can Help You?");
            Console.WriteLine("Press 1: Enter Customer Information");
            Console.WriteLine("Press 2: Check Available Rooms And Confirm Customer's Requirement");
            Console.WriteLine("Press 3: Display Status of All Room");
            Console.WriteLine("Press 4: Calaculate Bills");
            Console.WriteLine("Press 5: Exit");
            Console.Write("Choose command: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
