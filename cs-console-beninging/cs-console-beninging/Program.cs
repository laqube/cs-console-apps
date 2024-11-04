using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace cs_console_beninging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double gpa;
            char mark;
            bool onStipend = false;
            string message;

            Console.WriteLine("Who are you?");
            name = Console.ReadLine();
            Console.WriteLine("How old is u?");
            age = int.Parse(Console.ReadLine()) ;
            Console.WriteLine("What is your GPA?");
            gpa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            message = gpa switch
            {
                > 4.0 => "your grade is A or A+",
                > 3.7 => "your grade is A-",
                > 3.3 => "your grade is B+",
                > 3.0 => "your grade is B",
                >= 2.7 => "your grade is B-",
                >= 2.3 => "your grade is C+",
                >= 2.0 => "your grade is C",
                >= 1.7 => "your grade is C-",
                >= 1.3 => "your grade is D+",
                >= 1.0 => "your grade is D",
                0 => "your grade is F"
            };

            if (gpa>=3.4)
            {
                onStipend=true;
            }


            Console.WriteLine("What is your gpa?");
            Console.WriteLine("You are " + name + ".\n" +
                              "You is " + age + "years old.\n" +
                              "your GPA is " + gpa + ", which means " + message + "s.\n" +
                              "And it is " + onStipend + " that you are on stipend."
                              
                              ); 
            Console.WriteLine("");
        }
    }
}
