using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practice_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            //variable declaration
            LinqProgramLogic logic = new LinqProgramLogic();
            bool ContsLoop = true;

            while (ContsLoop)
            {
                Console.WriteLine("Enter Input from below options");
                Console.WriteLine("1.Find max, min, average in a list using LINQ");
                Console.WriteLine("2.Get even numbers from list using LINQ");
                Console.WriteLine("3.Merge two lists without duplicates (Union)");
                Console.WriteLine("4.Find common elements in two lists (Intersect)");
                Console.WriteLine("0.Exit");
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 0:
                            Console.WriteLine("Thank you");
                            ContsLoop = false;
                            break;
                        case 1:
                            logic.AggregationFunc();
                            break;
                        case 2:
                            logic.EvenNumberUsingLinq();
                            break;
                        case 3:
                            logic.MergeListFunc();
                            break;
                         case 4:
                            logic.CommonInListFunc();
                            break;
                        default:
                            Console.WriteLine("Please enter valid Input");
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            Console.WriteLine("");
        }
    }
}
