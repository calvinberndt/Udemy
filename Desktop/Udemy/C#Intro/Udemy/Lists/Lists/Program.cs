using System;
using System.Collections.Generic;
namespace Lists
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>() {1,2,3,4};
            numbers.Add(1);

            //We can add either a list or an array, in this case we add array
            numbers.AddRange(new int[3] { 5, 4, 7 });

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            Console.WriteLine("Index of first 1 is " + numbers.IndexOf(1));
            Console.WriteLine("Index of last 1 is " + numbers.LastIndexOf(1));
            Console.WriteLine("Count: " + numbers.Count);

            //Doing this will only delete the first iteration of 1.
            //Console.WriteLine("Remove the value of 1 in the list: " + numbers.Remove(1));
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            numbers.Clear();
            Console.WriteLine("The current count of the list is: " + numbers.Count);

        }
    }
}
