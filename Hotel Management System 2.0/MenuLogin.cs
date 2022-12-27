using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System_2._0
{
    public class MenuLogin
    {
        public static int EnterLoginChoice()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to System Hotel!");
            Console.WriteLine("=======================");
            Console.WriteLine("Who are you?");
            Console.WriteLine("Press 1: Admin");
            Console.WriteLine("Press 2: User");
            Console.WriteLine("Press 3: Exit");
            Console.Write("Choose command: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
