using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System_2._0
{
    public class MenuAdmin
    {
        public static int EnterAdminChoice()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to System Hotel, Admin!");
            Console.WriteLine("=======================");
            Console.WriteLine("What is your command?");
            Console.WriteLine("Press 1: Change Type");
            Console.WriteLine("Press 2: Add new room");
            Console.WriteLine("Press 3: Exit");
            Console.Write("Choose command: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
