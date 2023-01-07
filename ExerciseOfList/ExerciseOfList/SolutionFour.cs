using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfList
{
    internal class SolutionFour
    {

        public  void ShowSolutionFour()
        {
            var unique = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or type quit to leave");
                var input = Console.ReadLine();

                if (input.CompareTo("quit") == 0)
                    break;
                else
                {
                    var number = Convert.ToInt32(input);
                    if (unique.Contains(number))
                        continue;
                    else
                        unique.Add(number);
                }
            }

            foreach (var output in unique)
                Console.Write($"{output} ");
        }

    }
}
