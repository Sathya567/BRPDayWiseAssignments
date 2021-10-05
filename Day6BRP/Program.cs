using System;

namespace Day6BRP
{
    class Program
    {
        
           

            static void Main(string[] args)
            {

                PrimeNumber p = new PrimeNumber();
                p.PrintPrimeNumber();


                RollDie roll = new RollDie();
                roll.findMaximum();

                RepeatedNumber repeatedNumber = new RepeatedNumber();
                repeatedNumber.FindRepeatedNumber();
            }
        
    }
}
   
