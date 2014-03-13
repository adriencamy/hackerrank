using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halloween_party
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbTrest = int.Parse(Console.ReadLine());

            for (int i = 0; i < nbTrest; i++)
            {
                int K = int.Parse(Console.ReadLine());
                int horizontal = K / 2;
                int vertical = K - horizontal;

                Console.WriteLine(horizontal * vertical);
            }
        }
    }
}
