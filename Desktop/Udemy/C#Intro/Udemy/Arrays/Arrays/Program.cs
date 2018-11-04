using System;

namespace Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 12, 1, 16 };

            //Length
            Console.WriteLine("Length " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            var indexplusone = index + 1; 
            Console.WriteLine("Index of 9 is {0}", index);
            Console.WriteLine("The location of 9 is {0}, since indexing is always base 0", indexplusone);

            //Clear()

            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Clear() does the following");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Copy()
            var anotherarray = new int[3];
            Array.Copy(numbers, anotherarray, 3);
            foreach (var value in anotherarray)
            {
                Console.WriteLine("anotherarray now has the first three values being: {0}", value);
            }

            //Sort()
            Console.WriteLine("The effects of sorting an array ");
            Array.Sort(numbers);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            //Reverse()
            Console.WriteLine("The effects of reversing an array: ");
            Array.Reverse(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
