using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you want to draw triangle");
            Console.Write("Write your first digit");
            Console.Write(" Height = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write your second digit");
            Console.Write(" Width = ");
            int z = Convert.ToInt32(Console.ReadLine());
            int y = 0;


            for (int i = 0; i < x ; i++)
            {
                for (int r = 0; r < (y = z); r++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
