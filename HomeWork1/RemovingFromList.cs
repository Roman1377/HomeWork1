using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class RemovengFromList
    {
        public RemovengFromList() { }
        public void RemoveElementFromList()
        {
            static async Task Main(string[] args)
            {
                string input = "apple, banana, cherry, date";
                string result = RemoveSpaces(input);
                Console.WriteLine(result);
            }
            static string RemoveSpaces(string input)
            {
                return Regex.Replace(input, @"\s+", "");
            }
        }
    }

}

