using System;

namespace _Regex_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Regex");
            Validation value = new Validation();
            //Console.WriteLine("enter firstName");
            //string Firstname = Console.ReadLine();
            //value.ValidatingName(Firstname);
            //Console.WriteLine("Enter LastName");
            //string LastName = Console.ReadLine();
            //value.ValidatingName(LastName);
            //Console.ReadKey();
            //Console.WriteLine("Enter Valid mail id:");
            //string Mail = Console.ReadLine();
            //value.ValidatingMail(Mail);
            //Console.ReadKey();
            Console.WriteLine("Enter Phone Number:");
            string intNumber = Console.ReadLine();
            value.ValidatingPNumber(intNumber);
            Console.ReadKey();
        }
    }
}
