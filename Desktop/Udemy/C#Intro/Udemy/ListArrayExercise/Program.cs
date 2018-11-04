using System;
using System.Collections.Generic;
namespace ListArrayExercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Facebook();
        }
        public static void Facebook()
        {
            var names = new List<string>();
            Console.WriteLine("Enter in the names of people: ");
            names.Add(Console.ReadLine());
           
            for (int i = 0; i < names.Count; i++)
            {
                names.Add(Console.ReadLine());

                if (Console.ReadLine() == String.Empty)
                {
                    var result2 = String.Join(" and ", names.ToArray());
                    var liketracker = names.Count;
                    var shownumberoflikes = liketracker - 2;

                    if (names.Count < 3)
                    {
                       Console.WriteLine(result2 + " like your post");
                    }
                    if (names.Count > 2)
                    {
                        Console.WriteLine(names[0] + " and " + names[1] + " plus {0}", shownumberoflikes);
                    }

                }
            }
        }
    }
}
