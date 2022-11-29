using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AccountValidation.Service_Credential_validation
{
    internal class User:IAccount
    {
        static int idCount = 0;
        public int Id { get; private set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password 
        { 
            get
            {
                 
                return Password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    Password = value;
                        
                }
                else
                {
                    Console.WriteLine(" You cannot choose this password");
                }
            }
        }


        Regex Passwordcheck = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*d)[a-zA-Zd]{8,}$");

        public User()
        {
            idCount++;
            Id = idCount;
        }

        public bool PasswordChecker(string password)
        {
            if (Passwordcheck.IsMatch(password))
            {
               Password = password;
            }
            return false;
        }

        public string ShowInfo()
        {

            Console.WriteLine($"User Id ->> {Id}, User Fullname ->> {Fullname}, User Email ->> {Email}");
            return "0";
        }
    }
}
