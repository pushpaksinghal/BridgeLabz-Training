using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_3
{
    internal class MatrixOperationsMethod
    {
        // Main method
        static Random rand = new Random();
        // Entry point of the program
        static void Main(string[] args)
        {
            double[,] A = CreateRandomMatrix(3, 3);
            double[,] B = CreateRandomMatrix(3, 3);

            DisplayMatrix(A);
            DisplayMatrix(B);
            DisplayMatrix(AddMatrix(A, B));
            DisplayMatrix(SubtractMatrix(A, B));
            DisplayMatrix(MultiplyMatrix(A, B));
            DisplayMatrix(TransposeMatrix(A));
            double detOfA = Determinant3x3(A);
            Console.WriteLine(detOfA);
        }
        // Method to create a random matrix

        static double[,] CreateRandomMatrix(double rows, double cols)
        {
            double[,] matrix = new double[(int)rows, (int)cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = rand.Next(1, 10);
            return matrix;
        }
        //  Method on two matrices
        static double[,] AddMatrix(double[,] A, double[,] B)
        {
            int rows = A.GetLength(0);
            int cols = A.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = A[i, j] + B[i, j];

            return result;
        }
        static double[,] SubtractMatrix(double[,] A, double[,] B)
        {
            int rows = A.GetLength(0);
            int cols = A.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = A[i, j] - B[i, j];

            return result;
        }
        static double[,] MultiplyMatrix(double[,] A, double[,] B)
        {
            int rows = A.GetLength(0);
            int cols = B.GetLength(1);
            int common = A.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    for (int k = 0; k < common; k++)
                        result[i, j] += A[i, k] * B[k, j];

            return result;
        }
        // method on a simgle matrix
        static double[,] TransposeMatrix(double[,] A)
        {
            int rows = A.GetLength(0);
            int cols = A.GetLength(1);
            double[,] result = new double[cols, rows];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[j, i] = A[i, j];

            return result;
        }
        static double Determinant2x2(double[,] A)
        {
            return A[0,0]*A[1,1]-A[0,1]*A[1,0];
        }
        static double Determinant3x3(double[,] A)
        {
            return A[0,0]*(A[1,1]*A[2,2]-A[1,2]*A[2,1])-A[0,1]*(A[1,0]*A[2,2]-A[1,2]*A[2,0])+A[0,2]*(A[1,0]*A[2,1]-A[1,1]*A[2,0]);
        }
        static void DisplayMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(Math.Round(matrix[i, j], 2) + " ");
                Console.WriteLine();
            }
        }
    }
}
