using System;

namespace Day5BRP
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipCoin f = new FlipCoin();
            f.calculatePercentage();

            PowerOf2 p = new PowerOf2();
            p.printPowerOfTwo();

            Console.ReadLine();
        }
    }
}
