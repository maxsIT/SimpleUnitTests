using OperatorOverloadingDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{

    /*public class Matrix
    {
        int Height;
        int Width;
        Random rnd = new Random();
        Fraction[,] matrix { set; get; }

        public Matrix(int Width, int Height)
        {
            this.Height = Height;
            this.Width = Width;

            InitMatrix();
        }

        public Matrix(int Width)
        {
            Height = 1;
            this.Width = Width;
            InitMatrix();
        }

        public Matrix()
        {
            Height = 1;
            Width = 1;
            InitMatrix();
        }

        private void InitMatrix()
        {
            matrix = new Fraction[Height, Width];
            for (int i = 0; i < Width; i++)
            {
                for(int g = 0; g < Height; g++)
                {
                    int num1 = rnd.Next(20) + 1;
                    int num2 = rnd.Next(20) + 1;
                    matrix[i, g] = new Fraction(num1, num2);
                    matrix[i, g].ReduceFraction();
                }
            }
        }

        public void Display()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int g = 0; g < Height; g++)
                {
                    Console.Write($"{matrix[i, g].ToString()} ");
                }
                Console.WriteLine();
            }
        }

        public static Matrix operator +(Matrix obj1, Matrix obj2)
        {
            Matrix matrixTemp = new Matrix(obj1.Width, obj1.Height);
            for (int i = 0; i < obj1.Width; i++)
            {
                for (int g = 0; g < obj1.Height; g++)
                {
                    matrixTemp.F[i, g] = obj1.matrix[i, g] + obj2.matrix[i, g];
                }
            }
            return matrixTemp;
        }

        public static bool operator -(Matrix obj1, Matrix obj2)
        {
            Fraction[,] matrixTemp = new Fraction[obj1.Height, obj1.Width];
            for (int i = 0; i < obj1.Width; i++)
            {
                for (int g = 0; g < obj1.Height; g++)
                {
                    matrixTemp[i, g] = obj1.matrix[i, g] + obj2.matrix[i, g];
                }
            }
            return matrixTemp;
        }

        /*public double Determinant()
        {
            int k = 1;
            double d = 0;

            Fraction[,] matrixForDeterminant = new Fraction[Height, Width];
            
            for (int i = 0; i < Width; i++)
            {

                for (int g = 0; g < Width; g++)
                {

                    matrixForDeterminant[i, g] = new Fraction(0);

                }

            }

            if (Width < 1) return 0;
            if (Width == 1) return matrixForDeterminant[0, 0];
            if (Width == 2) return (matrixForDeterminant[0, 0] * matrixForDeterminant[1, 1] -
                    matrixForDeterminant[0, 1] * matrixForDeterminant[1, 0]);

            for (int i = 0; i < Width; i++)
            {

                Minor(matrix_input, ref matrix, n, i, 0);
                d += k * matrix_input[i, 0] * Determinant(matrix, n - 1);
                k *= -1;

            }

            return d;
        }
    }*/
}
