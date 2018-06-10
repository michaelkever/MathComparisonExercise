using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MathAndComparisonExercise
{
    class Program
    {
        static void Main()

        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Click Enter:");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("Enter Hourly Rate:");
            string HourlyRate1 = Console.ReadLine();
            int HRate1 = Convert.ToInt32(HourlyRate1);

            Console.WriteLine("Enter Hours Worked:");
            string HoursWorked1 = Console.ReadLine();
            int HWork1 = Convert.ToInt32(HoursWorked1);

            Console.WriteLine("Person 2");
            Console.WriteLine("Enter Hourly Rate:");
            string HourlyRate2 = Console.ReadLine();
            int HRate2 = Convert.ToInt32(HourlyRate2);

            Console.WriteLine("Enter Hours Worked:");
            string HoursWorked2 = Console.ReadLine();
            int HWork2 = Convert.ToInt32(HoursWorked2);
           
            Console.WriteLine("Annual salary of Person 1:");
            int Person1 = 52 * (HRate1 * HWork1);
            int annSal1 = Convert.ToInt32(Person1);
            Console.WriteLine("$" + annSal1);
            Console.WriteLine("Click Enter:");
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2:");
            int Person2 = 52 * (HRate2 * HWork2);
            int annSal2 = Convert.ToInt32(Person2);
            Console.WriteLine("$" + annSal2);
            Console.WriteLine("Click Enter:");
            Console.ReadLine();



            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = Person1 > Person2;
            Console.Write(trueOrFalse.ToString());

            Console.ReadLine();





        }
    }
}
