using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETLConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = new Dictionary<int, string[]>
            {
                [1] = new[] { "A", "E", "I", "O", "U", "L", "N", "R", "S", "T" },
                [2] = new[] { "D", "G" },
                [3] = new[] { "B", "C", "M", "P" },
                [4] = new[] { "F", "H", "V", "W", "Y" },
                [5] = new[] { "K" },
                [8] = new[] { "J", "X" },
                [10] = new[] { "Q", "Z" }
            };

            var output = Transform(input);

            Console.WriteLine("expected item");

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("output value");

            foreach(var  item in output)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("input item");

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("input keys");

            foreach (var item in input)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine("input value");

            foreach (var item in input)
            {
                Console.WriteLine(item.Value);
            }

            Console.ReadLine();
        }

        public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
        {
            var expected = new Dictionary<string, int>
            {
                ["a"] = 1,
                ["b"] = 3,
                ["c"] = 3,
                ["d"] = 2,
                ["e"] = 1,
                ["f"] = 4,
                ["g"] = 2,
                ["h"] = 4,
                ["i"] = 1,
                ["j"] = 8,
                ["k"] = 5,
                ["l"] = 1,
                ["m"] = 3,
                ["n"] = 1,
                ["o"] = 1,
                ["p"] = 3,
                ["q"] = 10,
                ["r"] = 1,
                ["s"] = 1,
                ["t"] = 1,
                ["u"] = 1,
                ["v"] = 4,
                ["w"] = 4,
                ["x"] = 8,
                ["y"] = 4,
                ["z"] = 10
            };

            var output = new Dictionary<string, int>();


            foreach(var item in old)
            {
                for(int i = 0; i < item.Value.Length; i++)
                {
                   output.Add(item.Value[i].ToLower(), item.Key);
                }
            }
            return output;
        }
    }
}
