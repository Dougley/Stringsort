using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number range seperated by commas.");
            while (true)
            {
                String input = Console.ReadLine();
                char[] delimiters = { ',' };
                string[] step = input.Split(delimiters);
                List<int> step2 = new List<int>();
                foreach (String t in step)
                {
                    int value;
                    if (!int.TryParse(t, out value))
                    {
                        Console.WriteLine("Can only enter numbers.\n");
                    }
                    else
                    {
                        step2.Add(value);
                    }
                }
                if (step2.ToArray().Length > 0)
                {
                    int[] step3 = step2.ToArray();
                    gnomeSort(ref step3);
                    String anwser = String.Join(",", step3);
                    Console.WriteLine(anwser + "\n");
                }
            }
        }
        public static void gnomeSort(ref int[] input)
        {
            int x = 2;
            int y = 1;

            while (y < input.Length)
            {
                if (input[y - 1] <= input[y])
                {
                    y = x;
                    x++;
                }
                else
                {
                    int tmp = input[y - 1];
                    input[y - 1] = input[y];
                    input[y] = tmp;
                    y -= 1;
                    if (y == 0)
                    {
                        y = 1;
                        x = 2;
                    }
                }
            }
        }
    }
}
