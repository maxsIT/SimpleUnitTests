using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class Fraction
    {
        int Numerator;
        int Denominator;

        public Fraction(int Numerator, int Denominator)
        {
            this.Numerator = Numerator;
            this.Denominator = CheckSuitability(Denominator);
            CheckSign();
        }

        private void CheckSign()
        {
            if(Denominator < 0)
            {
                Numerator *= -1;
                Denominator *= -1;
            }
        }

        public Fraction(int Numerator)
        {
            this.Numerator = Numerator;
            Denominator = 1;
        }

        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }

        public Fraction(Fraction obj)
        {
            Numerator = obj.Numerator;
            Denominator = obj.Denominator;
        }

        private int CheckSuitability(int Denominator)
        {
            while (Denominator == 0)
            {
                Console.WriteLine("Denominator can't equal zero! Input new value:");
                Denominator = Convert.ToInt32(Console.ReadLine());
            }
            return Denominator;
        }

        public static int operator +(Fraction obj)
        {
            return obj.Numerator += obj.Denominator;
        }

        public static int operator -(Fraction obj)
        {
            return obj.Numerator -= obj.Denominator;
        }

        public static Fraction operator +(Fraction obj1, Fraction obj2)
        {
            Fraction fraction = new Fraction();
            int numenator = obj1.Denominator * obj2.Denominator / LCD(obj1.Denominator,
                obj2.Denominator);
            fraction.Numerator = obj1.Numerator * (numenator / obj1.Denominator) + 
                obj2.Numerator * (numenator / obj2.Denominator);
            fraction.Denominator = numenator;
            return fraction;
        }

        public static Fraction operator -(Fraction obj1, Fraction obj2)
        {
            Fraction fraction = obj1 + obj2;
            fraction.Numerator -= 2 * obj2.Numerator * (fraction.Denominator / obj2.Denominator);
            return fraction;
        }

        public static Fraction operator *(Fraction obj1, Fraction obj2)
        {
            Fraction fraction = new Fraction();
            fraction.Numerator = obj1.Numerator * obj2.Numerator;
            fraction.Denominator = obj1.Denominator * obj2.Denominator;
            return fraction;
        }

        public static Fraction operator /(Fraction obj1, Fraction obj2)
        {
            Exchange(ref obj1.Numerator, ref obj2.Denominator);
            return obj1 * obj2;
        }

        public static bool operator >(Fraction obj1, Fraction obj2)
        {
            if (obj1.Numerator * obj2.Denominator > obj2.Numerator * obj1.Denominator) return true;
            return false;
        }

        public static bool operator <(Fraction obj1, Fraction obj2)
        {
            if (obj1.Numerator * obj2.Denominator < obj2.Numerator * obj1.Denominator) return true;
            return false;
        }

        public static bool operator ==(Fraction obj1, Fraction obj2)
        {
            if (!(obj1 > obj2) && !(obj1 < obj2)) return true;
            return false;
        }

        public static bool operator !=(Fraction obj1, Fraction obj2)
        {
            if (!(obj1 == obj2)) return true;
            return false;
        }

        public static bool operator >=(Fraction obj1, Fraction obj2)
        {
            if (!(obj1 < obj2)) return true;
            return false;
        }

        public static bool operator <=(Fraction obj1, Fraction obj2)
        {
            if (!(obj1 > obj2)) return true;
            return false;
        }

        public static implicit operator double(Fraction obj)
        {
            return obj.Numerator * 1.0 / obj.Denominator;
        }

        public override string ToString()
        {
            CheckSign();
            if (Numerator % Denominator == 0)
            {
                return Convert.ToString(Numerator / Denominator);
            }
            else if (Denominator == 1)
            {
                return Convert.ToString(Numerator);
            }
            return Numerator + "/" + Denominator;
        }

        public void ReduceFraction()
        {
            int divider = LCD(Numerator, Denominator);
            Numerator /= divider;
            Denominator /= divider;
        }

        public static void Exchange<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }

        private static int LCD(int num1, int num2)
        {
            while(num2 != 0)
            {
                num1 %= num2;
                Exchange(ref num1, ref num2);
            }

            return num1;
        }
    }
}
