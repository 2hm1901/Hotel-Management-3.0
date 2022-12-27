using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System_2._0
{
    public class Customer:BaseInformation
    {
        public void InputInforCustomer()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Age: ");
            Age = int.Parse(Console.ReadLine());          
            do
            {
                Console.Write("What Kind of Room Would You Like to Rent(Standard/Vip/Family): ");
                Request = Console.ReadLine();
            } 
            while (Request != "Vip" && Request != "Standard" && Request != "Family");
            Console.Write("How long do you want to rent (Days): ");
            Time = int.Parse(Console.ReadLine());
        }
    }
}

