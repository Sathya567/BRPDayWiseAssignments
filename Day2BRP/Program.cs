using System;

namespace Day2BRP
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfTwoDice s = new SumOfTwoDice();
            s.AddDice();

            IntOpt i = new IntOpt();
            i.AddInput();

            DoubleOpt d = new DoubleOpt();
            d.CheckOperation();

            Distance distance = new Distance();
            distance.FindDistance();
        }
    }
}