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

            if (!int.TryParse(len, out int length))
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
            foreach (var n in evenMethod)
            {
                Console.WriteLine(n);
            }


        }

        public void MergeListFunc()
        {
            Console.WriteLine("Enter Number of elements in one list");
            string len1 = Console.ReadLine();

            List<int> oneList = new List<int>();
            List<int> twoList = new List<int>();

            if (!int.TryParse(len1, out int length)|| length < 0)
            {
                Console.WriteLine("Enter interger value only");
                return;
            }

            Console.WriteLine("Enter number of elements in second list");
            string len2 = Console.ReadLine();
            if (!int.TryParse(len2, out int length2) || length2 < 0)
            {
                Console.WriteLine("Enter integer value only");
                return;
            }

            Console.WriteLine("Enter elements for first list");
            for (int i = 0; i < length; i++)
            {
                string num = Console.ReadLine();
                if (int.TryParse(num, out int number))
                {
                    oneList.Add(number);
                }
                else
                {
                    Console.WriteLine("Enter valid integer value");
                    i--;
                }
            }

            Console.WriteLine("Enter elements for second list");
            for (int i = 0; i < length2; i++)
            {
                string num2 = Console.ReadLine();
                if (int.TryParse(num2, out int number2))
                {
                    twoList.Add(number2);
                }
                else
                {
                    Console.WriteLine("Enter Valid Integer");
                    i--;
                }
            }

            Console.WriteLine("Query Syntax");

            // var mergeResult = (from no in oneList select no).Union(from no1 in twoList select no1);

            var mergeResult = (from no in oneList.Union(twoList) select no);


            Console.WriteLine("List after merge using query syntax");
            foreach (var num in mergeResult)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Method Syntax");

            var mergeResultMethod = oneList.Union(twoList);

            Console.WriteLine("List after merge using Method syntax");

            foreach (var num in mergeResultMethod)
            {
                Console.WriteLine(num);
            }

        }
        public void CommonInListFunc()
        {
            Console.WriteLine("Enter length of  First List");
            string len = Console.ReadLine();

            List<int> oneList = new List<int>();
            List<int> twoList = new List<int>();

            if (!int.TryParse(len, out int lenFirst) || lenFirst < 0)
            {
                Console.WriteLine("Please enter valid input");
                return;
            }

            Console.WriteLine("Please enter length of second list");
            len = Console.ReadLine();

            if (!int.TryParse(len, out int lenSecond) || lenSecond < 0)
            {
                Console.WriteLine("please enter valid input");
                return;
            }


            Console.WriteLine("Enter elements for First List");
            for (int i = 0; i < lenFirst; i++)
            {
                string num = Console.ReadLine();
                if (int.TryParse(num, out int number))
                {
                    oneList.Add(number);
                }
                else
                {
                    Console.WriteLine("Enter valid integer");
                    i--;
                }
            }

            Console.WriteLine("Enter elements for second list");
            for (int i = 0; i < lenSecond; i++)
            {
                string num = Console.ReadLine();
                if (int.TryParse(num, out int number))
                {
                    twoList.Add(number);
                }
                else
                {
                    Console.WriteLine("Please enter valid integer");
                    i--;
                }
            }



            var CommonInList = (from no in oneList.Intersect(twoList) select no);
            if (CommonInList.Any())
            {
                Console.WriteLine("Common elements in List using Query Syntax: " + string.Join(", ", CommonInList));
            }
            var CommonInListMethod = oneList.Intersect(twoList);
            if (CommonInListMethod.Any())
            {
                Console.WriteLine("Common elements in list using Method Syntax: " + string.Join(", ", CommonInListMethod));
            }

            if (!CommonInListMethod.Any())
            {
                Console.WriteLine("No common elements in List");
            }


        }

        public void SortUsingLinq()
        {
            Console.WriteLine("Enter length of  List");
            string len = Console.ReadLine();

            if (!int.TryParse(len, out int Length) || Length < 0)
            {
                Console.WriteLine("Enter length is invalid");
                return;
            }

            Console.WriteLine("Enter elements for List");

            List<int> numberListforSort = new List<int>();
            for (int i = 0; i < Length; i++)
            {
                string num = Console.ReadLine();
                if (int.TryParse(num, out int number))
                {
                    numberListforSort.Add(number);
                }
                else
                {
                    Console.WriteLine("Enter valid integer");
                    i--;
                }
            }

            var ResultQueryAsc = from num in numberListforSort orderby num select num;
            Console.WriteLine("List after ascending order sorting using Query Syntax: " + string.Join(", ", ResultQueryAsc));

            var ResultQueryDesc = from num in numberListforSort orderby num descending select num;

            Console.WriteLine("List after descending order sorting using Query syntax: " + string.Join(", ", ResultQueryDesc));

            var ResultMethodAsc = numberListforSort.OrderBy(no => no).Select(no => no);

            Console.WriteLine("List after ascending order sorting using Method Syntax: " + string.Join(", ", ResultMethodAsc));

            var ResultMethodDec = numberListforSort.OrderByDescending(no => no).Select(no => no);

            Console.WriteLine("List after descending order sorting using method syntax: " + string.Join(", ", ResultMethodDec));

        }

        public void SortByStringLenLinq()
        {
            Console.WriteLine("Enter Length of list");
            string len = Console.ReadLine();

            if (!int.TryParse(len, out int Length) || Length < 0)
            {
                Console.WriteLine("Valid integer is expected");
                return;
            }

            List<string> words = new List<string>();


            Console.WriteLine("Enter string to list for sorting");
            for (int i = 0; i < Length; i++)
            {
                
                words.Add(Console.ReadLine());
            }


            var ResultQueryAse = from w in words orderby w.Length select w;
            Console.WriteLine("string after sorting in ascending order by length using Query syntax: " + string.Join(", ", ResultQueryAse));

            var ResultQueryDesc = from w in words orderby w.Length descending select w;

            Console.WriteLine("string after sorting in descending order by length using Query syntax: " + string.Join(", ", ResultQueryDesc));

            var ResultMethodAse = words.OrderBy(w => w.Length).Select(w => w);
            Console.WriteLine("string after sorting in ascending order by length using Method syntax: " + string.Join(", ", ResultMethodAse));

            var ResultMethoddesc = words.OrderByDescending(w => w.Length).Select(w => w);
            Console.WriteLine("string after sorting in descending order by length using Method syntax: " + string.Join(", ", ResultMethoddesc));

        }

    }
}