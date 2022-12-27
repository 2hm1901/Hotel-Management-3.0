using System.Security.AccessControl;

namespace Hotel_Management_System_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Administrator admin = new Administrator();
            // create Hotel
            Room room = new Room();
            room.AddTypeRoom();

            Customer customer = new Customer();
            int choice;
            int login;
            do
            {
                login = MenuLogin.EnterLoginChoice();
                switch(login)
                {
                    case 1:
                        admin.Login();
                        do
                        {
                            choice = MenuAdmin.EnterAdminChoice();
                            switch (choice)
                            {
                                case 1:
                                    room.ChangeType();
                                    break;
                                case 2:
                                    room.AddNewRoom();
                                    break;
                                case 3:
                                    Console.WriteLine("Thanks for using!");
                                    break;
                            }
                        } while (choice != 3);
                        break;
                        case 2:
                        do
                        {
                            choice = Menu.EnterUserChoice();
                            switch (choice)
                            {
                                case 1:
                                    customer.InputInforCustomer();
                                    break;
                                case 2:
                                    room.CheckRoom(customer.Request);
                                    room.ConfirmRent(customer.Name, customer.Time, customer.Request);
                                    break;
                                case 3:
                                    room.DisplayInfor();
                                    break;
                                case 4:
                                    room.DisplayBill();
                                    break;
                                case 5:
                                    Console.WriteLine("Thanks for using!");
                                    break;
                                default:
                                    Console.WriteLine("Error!");
                                    break;
                            }
                        } while (choice != 5);
                        break;
                    case 3:
                        Console.WriteLine("Thank for using!");
                        break;
                }
            }while (login != 3);
            
            
        }
    }
}
         
