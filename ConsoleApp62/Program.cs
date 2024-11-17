using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62
{
    public class UserAccount
    {
        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
        public UserAccount(string email, string username, string password)
        {
            Email= email;
            Username =username ;
           Password= password;

        }
        public UserAccount(UserAccount account)
        {
            Email = account.Email;
            Username = account.Username;
            Password=account.Password;

        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList accounts = new ArrayList();
            accounts.Add(new UserAccount("user1@example.com", "user1", "password1")); 
            accounts.Add(new UserAccount("user2@example.com",  "user2","password2"));
            accounts.Add(new UserAccount("user3@example.com", "user3", "password3"));
            Console.WriteLine("Enter Username:");
            string inputUsername= Console.ReadLine();

            Console.WriteLine("Enter Password: ");
            string inputPassword= Console.ReadLine();
            bool isValid = false;

            foreach (UserAccount account in accounts)

            {

                if(account.Username == inputUsername && account.Password== inputPassword)
                {
                    isValid=true;

                    break;
                }
                

            }



            if (isValid)
            {
                Console.WriteLine("Correct credentials!");
            }

            else
            {
                Console.WriteLine("Invalid credentiats!");
            }

            Console.ReadKey();

        }
    }
}
