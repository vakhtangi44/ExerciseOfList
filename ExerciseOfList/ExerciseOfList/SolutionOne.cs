using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfList
{
    internal class SolutionOne
    {
        public  void ShowSolutionOne()
        {
            var list = new List<string>();
            while (true)
            {
                Console.WriteLine("Write a name:");
                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    break;
                }
                else
                {
                    list.Add(input);
                }
                switch (list.Count)
                {
                    case 0:
                        Console.WriteLine("Nobody likes your post");
                        break;
                    case 1:
                        Console.WriteLine($"{list[0]} likes your post");
                        break;
                    case 2:
                        Console.WriteLine($"{list[0]} and {list[1]} likes your post");
                        break;
                    default:
                        Console.WriteLine($"{list[0]} and {list[1]} and {list.Count-2} likes your post");
                        break;

                }
            }
        }
    }
}
