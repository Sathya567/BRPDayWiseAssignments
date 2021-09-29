using System;

namespace Day4BRP
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Enter input \n" +
                "1.Temperature Conversion \n" +
                "2.Square root of a non -negative c\n" +
                "3.Harmoic series \n" +
                "4.Trignometric function");

            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            switch (input)
            {

                case 1:
                    TemperatureConversion t = new TemperatureConversion();
                    t.convertTemperature();
                    break;

                case 2:
                    SquareRoot s = new SquareRoot();
                    s.caculateSquareRoot();
                    break;

                case 3:
                    HarmonicNumber h = new HarmonicNumber();
                    h.findHarmonicSeries();
                    break;

                case 4:
                    TrignometricFunctions T = new TrignometricFunctions();
                    T.TrignometricFunction();
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.ReadLine();
        }
    }
}