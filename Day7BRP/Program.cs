using System;
using System.Collections.Generic;
using System.Text;

namespace Day7BRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Primefactors primeFactors = new Primefactors();
            primeFactors.findingPrimeFactors();

            SecondLargestAndSmallest secondLargest = new SecondLargestAndSmallest();
            secondLargest.FindSecondLargest();


            Binary binary = new Binary();
            binary.findingBinary();
        }

    }
}
   
