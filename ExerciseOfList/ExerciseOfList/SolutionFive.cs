using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfList
{
    internal class SolutionFive
    {
        public  void ShowSolutionFive()
        {
            var list = new List<int>();
            while (true)
            {
                Console.WriteLine("Type a list of number, separated by commas");
                var input = Console.ReadLine();

                var array = input.Split(',');

                if ((array.Length == 0) || (array.Length < 5))
                {
                    Console.WriteLine("Invalid list! Try again.");
                }
                else
                {
                    foreach (var number in array)
                        list.Add(Convert.ToInt32(number));
                    break;
                }
            }
            list.Sort();

            for (int i = 0; i < 3; i++)
                Console.Write($"{list[i]} ");
        }
    }
}
