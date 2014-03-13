using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate_Feast
{
    class Program
    {
        static void Main(string[] args)
        {

            int money = 0;
            int price = 0;
            int wrappers = 0;

            int chocoTotal = 0;

            int nbTest = int.Parse(Console.ReadLine());

            for (int i = 0; i < nbTest && i < 1000; i++)
            {
                string line = Console.ReadLine();
                string[] lineArray = line.Split(' ');

                money = int.Parse(lineArray[0]);
                price = int.Parse(lineArray[1]);
                wrappers = int.Parse(lineArray[2]);

                chocoTotal = (money / price) ;
                int chocoBonus = chocoTotal;
                bool loop = false;
                while (chocoBonus >= wrappers)
                {
                    loop = true;
                    int temp = (chocoBonus / wrappers);
                    chocoTotal += temp ;
                    chocoBonus = chocoBonus - wrappers*temp + temp;
                }

                Console.WriteLine(chocoTotal);

            }
            Console.ReadLine();
        }
    }
}
