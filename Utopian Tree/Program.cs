using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopian_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbTest = int.Parse(Console.ReadLine());

            for (int i = 0; i < nbTest && i < 10; i++)
            {
                int cycles = int.Parse(Console.ReadLine());

                int height = 1;

                for (int j = 0; j < cycles; j++)
                {
                    if (j % 2 == 0)
                        height = height * 2;
                    else
                        height = height + 1;
                }

                Console.WriteLine(height);
            }
            

            Console.ReadLine();
        }
    }
}
