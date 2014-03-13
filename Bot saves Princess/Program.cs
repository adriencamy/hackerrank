using System;
using System.Collections.Generic;
using System.Linq;

namespace Bot_saves_Princess
{
    class Program
    {

        static void displayPathtoPrincess(int n, String[] grid)
        {
            int xPrincess = 0;
            int yPrincess = 0;
            int xBot = 0;
            int yBot = 0;

            for (int i = 0; i < n; i++)
            {
                string line = grid[i];
                Array lineArray = line.ToArray();
                int xPos = 0;
                foreach (char itm in lineArray)
                {
                    switch (itm)
                    {
                        case 'm':
                            xBot = xPos;
                            yBot = i;
                            break;
                        case 'p':
                            xPrincess = xPos;
                            yPrincess = i;
                            break;
                        default:
                            break;
                    }
                    ++xPos;
                }

            }

            while (xBot != xPrincess)
            {
                if (xBot < xPrincess)
                {
                    Console.WriteLine("RIGHT");
                    xBot += 1;
                }

                else
                {
                    Console.WriteLine("LEFT");
                    xBot -= 1;
                }
            }

            while (yBot != yPrincess)
            {
                if (yBot < yPrincess){
                    Console.WriteLine("DOWN");
                    yBot += 1;
                }
                    
                else{
                    Console.WriteLine("UP");
                    yBot -= 1;
                }
            }

            //Console.WriteLine("Bot position : (" + xBot + ", " + yBot + ")");
            //Console.WriteLine("Princess position : (" + xPrincess + ", " + yPrincess + ")");
            Console.ReadLine();

        }


        static void Main(string[] args)
        {

            

            int m;

            m = int.Parse(Console.ReadLine());

            String[] grid = new String[m];
            for (int i = 0; i < m; i++)
            {
                grid[i] = Console.ReadLine();
            }

            displayPathtoPrincess(m, grid);


        }
    }
}
