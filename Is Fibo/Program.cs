using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_Fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbTest = int.Parse(Console.ReadLine());

            for (int i = 0; i < nbTest; i++)
            {
                Int64 myNumer = Int64.Parse(Console.ReadLine());

                Int64 currentNumber = 1;
                Int64 previousNumber = 1;
                while (currentNumber < 10000000000 && currentNumber < myNumer)
                {
                    Int64 temp = currentNumber;
                    currentNumber = temp + previousNumber;
                    previousNumber = temp;
                }

                if (currentNumber == myNumer)
                    Console.WriteLine("IsFibo");
                else
                    Console.WriteLine("IsNotFibo");
            }
            Console.ReadLine();
        }
    }
}
