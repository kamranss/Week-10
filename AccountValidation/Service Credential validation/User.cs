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

        private string _password;
        public string Password 
        { 
            get
            {                
                return _password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine(" << You cannot choose this password >>\n << Your password should follow provided structure >>");
                }
            }
        }
       
        Regex Passwordcheck3 = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

        public User()
        {
            idCount++;
            Id = idCount;

            Console.Write(" Write pasword \n Your password should contain the following atributes\n 1. at leats 8 carachters\n 2. at least 1 Digit\n 3. at least 1 Capital leter\n 4. at least 1 small latter\n  ->>");
            while (true)
            {
                Password = Console.ReadLine();
                if (!String.IsNullOrEmpty(_password))
                {
                    break;
                }
            }
            Console.Write("Write Email ->>");
            Email = Console.ReadLine();
        }

        public bool PasswordChecker(string password)
        {
            if (Passwordcheck3.IsMatch(password))
            {
                return true;
            }
            return false;
        }

        public void ShowInfo()
        {
          Console.Write(($" User Id ->> {Id}\n User Fullname ->> {Fullname}\n User Password ->> {Password}\n User Email ->> {Email}")); 
        }
    }
}
