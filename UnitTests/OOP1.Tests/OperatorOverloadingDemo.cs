using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOP1.Tests
{
    [TestClass]
    public class OperatorOverloadingDemo
    {
        [TestMethod]
        public void ReduceFraction_2and4_1div2retutned()
        {
            int numerator = 2;
            int denominator = 4;
            string expected = "1/2";

            MathLib.Fraction frac = new MathLib.Fraction(numerator, denominator);
            frac.ReduceFraction();

            Assert.AreEqual(expected, frac.ToString());
        }

        [TestMethod]
        public void CorrectView_2andneg4_neg1div2retutned()
        {
            int numerator = 2;
            int denominator = -4;
            string expected = "-1/2";

            MathLib.Fraction frac = new MathLib.Fraction(numerator, denominator);
            frac.ReduceFraction();

            Assert.AreEqual(expected, frac.ToString());
        }

        [TestMethod]
        public void PverloadMethodDivOperator_11div10andneg11div25_neg5div2retutned()
        {
            int numerator1 = 11;
            int denominator1 = 10;
            int numerator2 = -11;
            int denominator2 = 25;
            string expected = "-275/110";

            MathLib.Fraction frac1 = new MathLib.Fraction(numerator1, denominator1);
            MathLib.Fraction frac2 = new MathLib.Fraction(numerator2, denominator2);
            frac1 = frac1 / frac2;

            Assert.AreEqual(expected, frac1.ToString());
        }

        [TestMethod]
        public void ConvertFractionToDouble_neg5div2_2dot5retutned()
        {
            int numerator = -5;
            int denominator = 2;
            double expected = -2.5;

            MathLib.Fraction frac = new MathLib.Fraction(numerator, denominator);

            Assert.AreEqual(expected, (double)frac);
        }
    }
}
