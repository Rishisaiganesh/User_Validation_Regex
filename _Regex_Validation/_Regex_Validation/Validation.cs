using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _Regex_Validation
{
    public class Validation
    {
        public void ValidatingName(string Name)
        {
            string stringValidation = "^[A-Z]{1}[A-Za-z]{3,10}";
            if (Regex.IsMatch(Name, stringValidation))
            {
                Console.WriteLine(Name + "Its Validated");

            }
            else
            {
                Console.WriteLine("Not Given valid Name");
            }

        }
    }
}
