using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Julka
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger amountOfApples;
            BigInteger disparity;
            for (int i = 0; i < 10; i++)
            {
                string x = Console.ReadLine();
                BigInteger.TryParse(x, out amountOfApples);
                x = Console.ReadLine();
                BigInteger.TryParse(x, out disparity);
                BigInteger V1 = (amountOfApples + disparity) / 2;
                BigInteger V2 = (amountOfApples - disparity) / 2;
                Console.WriteLine(V1);
                Console.WriteLine(V2);

            }
        }
    }
}
