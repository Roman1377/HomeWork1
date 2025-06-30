using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1;
    internal class ListNameLastName
    {
        public ListNameLastName() { }
        public void PrintFullName()
        {
        Console.WriteLine("Введіть ім'я користувача:");
        string firstname = Console.ReadLine();

        Console.WriteLine("Введіть прізвище користувача:");
        string lastname = Console.ReadLine();

        if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname))
        {
            Console.WriteLine("Ім'я або прізвище не можуть бути порожніми.");
        }
        else
        {
            char firstLetterFirstname = char.ToLower(firstname[0]);
            char firstLetterLastname = char.ToLower(lastname[0]);
            if (firstLetterFirstname == firstLetterLastname)
            {
                Console.WriteLine("Прізвище починається на ту ж літеру, що і ім'я.");
            }
            else
            {
                Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім'я.");
            }
        }
    }
}
