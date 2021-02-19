using System;
using System.Collections.Generic;

namespace Inverting_Arrays_Or_Lists_At_An_Index_Of
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Checker = new List<int>();
            Checker.Add(1);
            Checker.Add(2);
            Checker.Add(1);
            Checker.Add(3);

            List<int> UpdateList = new List<int>();
            UpdateList.Add(2);
            UpdateList.Add(3);

            List<List<int>> Operator = new List<List<int>>();
            Operator.Add(UpdateList);

            Console.Write("The original array/list was: ");

            foreach (int integer in Checker)
            {
                Console.Write($" {integer}");
            }

            Console.Write("\x20\x0A");

            Checker = InvertAtIndexOf(Checker, Operator);

            Console.Write("The new array/list is: ");

            foreach (int integer in Checker)
            {
                Console.Write($" {integer}");
            }

            Console.Write("\x20\x0A");
        }

        public static List<int> InvertAtIndexOf(List<int> arr, List<List<int>> operations)
        {
            List<int> result = new List<int>();

            foreach (int integer in arr)
            {
                result.Add(integer);
            }

            int position = 0;

            foreach (List<int> request in operations)
            {
                foreach (int integer in request)
                {
                    if (position == 1)
                    {
                        result[request[position]] = arr[request[position - 1]];
                        break;
                    }
                    else
                    {
                        result[request[position]] = arr[request[position + 1]];
                        position++;
                    }
                }
            }

            return result;
        }
    }
}
