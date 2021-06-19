﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _Regex_Validation
{
    public class Validation
    {
        /// <summary>
        /// Validating name Using Regex
        /// </summary>
        /// <param name="Name"></param>
        public void ValidatingName(string Name)
        {
            string stringValidation = "^[A-Z]{1}[A-Za-z]{3,20}";
            if (Regex.IsMatch(Name, stringValidation))
            {
                Console.WriteLine(Name + "Its Validated");

            }
            else
            {
                Console.WriteLine("Not Given valid Name");
            }

        }
        /// <summary>
        /// Validating Mail ID Using Regex
        /// </summary>
        /// <param name="Mail"></param>
        public void ValidatingMail(string Mail)
        {
            string stringmail = "^[A-Z]{1}[A-Za-z]{3,30}[0-9]@gmail(.com|.in)";
            if(Regex.IsMatch(Mail,stringmail))
            {
                Console.WriteLine(Mail + "Its valid Mail Id");

            }
            else
            {
                Console.WriteLine("Its in Valid mailId");
            }
        }
        public void ValidatingPNumber(string PNumber)
        {
            string intNumber = "^91[0-9]{10}";
            if (Regex.IsMatch(PNumber, intNumber))
            {
                Console.WriteLine("ValidPhoneNumber:" +PNumber);

            }
            else
            {
                Console.WriteLine("Number is Not Valid:" + PNumber);
            }
        }
        public void validatingPassword(string password)
        {
            string strPassword = "[A-Za-z0-9]{8,10}";
            string UpperCase = "[A-Z]{1}";
            string OneInteger = "[0-9]{1}";
            if (Regex.IsMatch(password, strPassword)&&Regex.IsMatch(password,UpperCase)&&Regex.IsMatch(password,OneInteger))

            {
                Console.WriteLine ("valid Password:" + password);

            }
            else
            {
                Console.WriteLine("Password Not Valid:" + password);
            }
        }
    }
}
