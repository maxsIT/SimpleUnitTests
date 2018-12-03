using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OperatorOverloadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MathLib.Fraction frac1 = new MathLib.Fraction(-2, -4);
            Console.WriteLine($"First fraction: {frac1.ToString()}");
            frac1.ReduceFraction();
            Console.WriteLine($"First fraction: {frac1.ToString()}");
            MathLib.Fraction frac2 = new MathLib.Fraction(3, 5);
            Console.WriteLine($"Second fraction: {frac2.ToString()}");
            frac1 = frac1 + frac2;
            Console.WriteLine($"First fraction: {frac1.ToString()}");
            frac2 = frac1 * frac2;
            Console.WriteLine($"Second fraction: {frac2.ToString()}");
            frac2 = frac2 - frac1;
            frac2.ReduceFraction();
            Console.WriteLine($"Second fraction: {frac2.ToString()}");
            frac1 = frac1 / frac2;
            frac1.ReduceFraction();
            Console.WriteLine($"First fraction: {frac1.ToString()}");
            Console.WriteLine($"First fraction converted to double: {(double)frac1}");
            if (frac1 > frac2) Console.WriteLine("Fraction1 is larger than Fraction2");
            if (frac1 < frac2) Console.WriteLine("Fraction1 is less than Fraction2");
            if (frac1 == frac2) Console.WriteLine("Fraction1 equals Fraction2");
            if (frac1 != frac2) Console.WriteLine("Fraction1 doesn`t equals Fraction2");
            if (frac1 >= frac2) Console.WriteLine("Fraction1 is larger or equals Fraction2");
            if (frac1 <= frac2) Console.WriteLine("Fraction1 is less or equals Fraction2");
            MathLib.Fraction frac3 = new MathLib.Fraction(3);
            Console.WriteLine($"Third fraction: {frac3.ToString()}");
            MathLib.Fraction frac4 = new MathLib.Fraction();
            Console.WriteLine($"Fourth fraction: {frac4.ToString()}");
            /*MathLib.Matrix matrix1 = new MathLib.Matrix(5, 5);
            matrix1.Display();
            Console.WriteLine();
            Thread.Sleep(100);
            MathLib.Matrix matrix2 = new MathLib.Matrix(5, 5);
            matrix2.Display();*/
            Console.ReadKey();
        }
    }
}
