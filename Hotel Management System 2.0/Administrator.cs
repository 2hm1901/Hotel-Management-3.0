using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System_2._0
{
    public class Administrator
    {
        private string username = "admin";
        private string id = "GCD210060";
        private string password = "123456";
        

        
      
        public bool CheckLogin(string value)
        {
            bool check = false;
            if (string.Compare(value, username) == 0)
            {
                check = true;
            }
            else if (string.Compare(value, id) == 0)
            {
                check = true;
            }
            else if (string.Compare(value, password) == 0)
            {
                check = true;
            }
            return check;
        }
        
        public void Login()
        {
            bool check=false;
            do
            {
                Console.Write("Username: ");
                string name = Console.ReadLine();
                CheckLogin(name);
                Console.Write("ID: ");
                string id = Console.ReadLine();
                CheckLogin(id);
                Console.Write("Password: ");
                string pass = Console.ReadLine();
                CheckLogin(pass);
            } while (check == true);
        }
        
        
    }
}
