using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class NewPass
    {
        public NewPass() { }
        public NewPass(string name) 
        {
            Console.WriteLine("Введіть пароль:");
            string password = Console.ReadLine();
            bool isValid = password.Length >= 8 &&
                           Regex.IsMatch(password, @"\d") && 
                           Regex.IsMatch(password, @"[!@#$%^&*(),.?""':;{}|<>]"); 
            if (isValid)
            {
                Console.WriteLine("Пароль прийнятний.");
            }
            else
            {
                Console.WriteLine("Пароль не відповідає вимогам. Він має містити принаймні 8 символів, одну цифру та один спеціальний символ.");
            }
        
        }

    }
}
