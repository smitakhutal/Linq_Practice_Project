using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practice_Project
{
    internal class LinqProgramLogic
    {
        public void AggregationFunc()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter numbers of elements in List");
            int len = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements for list");
            for (int i = 0; i <= len - 1; i++)
            {
                String num = Console.ReadLine();
                if (int.TryParse(num, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Please enter integer");
                    i--;//Retry for invalid input
                }
            }
            Console.WriteLine("Query Syntax");
            int max = (from no in numbers
                       select no).Max();
            Console.WriteLine($"{max} is maximum number in List");

            int min = (from no in numbers
                       select no).Min();
            Console.WriteLine($"{min} is minimum number in List");


            double Avg = (from no in numbers
                          select no).Average();
            Console.WriteLine($"{Avg} is Average of numbers exist in list\n");

            Console.WriteLine("Method Syntax");

            int maxMethod = numbers.Max();
            Console.WriteLine(maxMethod + " is Maximum number in list ");

            int minMethod = numbers.Min();
            Console.WriteLine(minMethod + " is Minimum number in list");

            double avgMethod = numbers.Average();
            Console.WriteLine(avgMethod + " is average of numbers exist in list\n");

        }

        public void EvenNumberUsingLinq()
        {

            Console.WriteLine("Enter  number of elements in list");
            string len = Console.ReadLine();

            if (!int.TryParse(len,out int length))
            {
                Console.WriteLine("Enter valid value");
                return;
            }

                List<int> numbers = new List<int>();

            Console.WriteLine("Enter elements for list");
            for (int i = 0; i <= length - 1; i++)
            {
                string num = Console.ReadLine();
                if (int.TryParse(num, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Enter integer value");
                    i--;//retry after invalid value
                }
            }

                Console.WriteLine("Query Syntax");
                var even = from no in numbers
                           where no % 2 == 0
                           select no;


            Console.WriteLine("Even numbers from List");
                foreach (var n in even)
                {
                    Console.WriteLine(n);
                }

                Console.WriteLine("\nMethod Syntax");

                var evenMethod = numbers.Where(no => no % 2 == 0).Select(no => no);

            Console.WriteLine("Even numbers from list");
                foreach (var n in even)
                {
                    Console.WriteLine(n);
                }

            
        }
    }
}
