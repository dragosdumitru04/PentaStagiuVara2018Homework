using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            Retirement();
            // StringMethods();
        }

        public static void Retirement()
        {
            Console.Write("Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gender: ");
            string genderLetter = Console.ReadLine();

            DateTime birthDay = new DateTime(year, month, day);

            Console.WriteLine("Birthday: {0}", birthDay.ToShortDateString());

            int age = DateTime.Now.Year - birthDay.Year;

            DateTime birthDayThisYear = new DateTime(DateTime.Now.Year, month, day);

            if (birthDayThisYear > DateTime.Now)
            {
                age = age - 1;
            }

            Console.WriteLine("Your age is {0}.", age);

            Gender? genderValue = null;

            if (genderLetter == "M")
            {
                genderValue = Gender.Male;
            }

            if (genderLetter == "F")
            {
                genderValue = Gender.Female;
            }

            if (genderValue == Gender.Male)
            {
                if (age >= 65)
                {
                    Console.WriteLine("You are retired.");
                }
                else
                {
                    Console.WriteLine("You will retire at 65.");
                }
            }

            else if (genderValue == Gender.Female)
            {
                if (age >= 63)
                {
                    Console.WriteLine("You are retired.");
                }
                else
                {
                    Console.WriteLine("You will retire at 63.");
                }
            }
        }

        public static void StringMethods()
        {
            // StartsWith
            string name = "Dragos";
            Console.WriteLine(name.StartsWith("E"));

            Console.WriteLine();

            // ToLower
            string[] text = { "Ana", "Mere", "Mar", "Cirese" };
            foreach (string c in text)
            {
                Console.WriteLine(c.ToLower());
            }

            Console.WriteLine();

            // Replace
            string s = "aaaaabcd";
            s = s.Replace("a", "e");
            Console.WriteLine(s);

            Console.WriteLine();

            // Trim
            string word = "  abc xyz  ";
            Console.WriteLine(word.Trim());

            Console.WriteLine();

            // IsNullOrEmpty
            string s1 = null;

            if (String.IsNullOrEmpty(s1))
            {
                Console.WriteLine("It's null or empty");
            }
            else
            {
                Console.WriteLine("It's not null or empty");
            }

            Console.WriteLine();

            // Substring
            string value = "This is a string";
            int startIndex = 8;
            int length = 3;

            string substring = value.Substring(startIndex, length);
            Console.WriteLine(substring);

            Console.WriteLine();

            // ToUpper
            string[] phrase = { "Clatite", "Ciocolata", "Nutella" };
            foreach (string e in phrase)
            {
                Console.WriteLine(e.ToUpper());
            }
        }
    }


    public enum Gender
    {
        Male,
        Female
    }
}
