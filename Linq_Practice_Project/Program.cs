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
                Console.WriteLine("5.Sort integers ascending & descending (LINQ query + method syntax)");
                Console.WriteLine("6.Sort strings by length using LINQ");
                Console.WriteLine("7.Group students by department");
                Console.WriteLine("8.Count frequency of elements in a list");
                Console.WriteLine("9.Find top 3 numbers in a list using LINQ");
                Console.WriteLine("10.Find numbers greater than 50 from a list");
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
                        case 5:
                            logic.SortUsingLinq();
                            break;
                        case 6:
                            logic.SortByStringLenLinq(); 
                            break;
                        case 7:
                            logic.GroupStudentByDept();
                            break;
                        case 8:
                            logic.FrequencyOfElementsFunc();
                            break;
                        case 9:
                            logic.FindTo3NoFunc();
                            break;
                        case 10:
                            logic.NoGreaterThan50Func();
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
