using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MatrixMultiplication
    {
        public void MatrixMultiplicationProgram() {

            //matrixA = 2*3 
            //matrix = 3*2
            //rule = for multiplication = colsA should be equal to rowsB
            //result = 2*2

            //matrixA = 1,2,3
            //          4,5,6

            //matrixB = 1,2
            //          3,4
            //          5,6

            //result = 22 0 = 1,2,3 will be multiplied with 1,3 5 = 1*1 + 2*3 + 3*5 = 22
            //         0  0

            int[,] matrixA = {
                {1,2,3},
                {4,5,6}
            };

            int[,] matrixB = {
                {1,2},
                {3,4},
                {5,6}
            };

            int rowsA = matrixA.GetLength(0); //2
            int colsA = matrixA.GetLength(1); //3

            int rowsB = matrixB.GetLength(0); //3
            int colsB = matrixB.GetLength(1); //2

            if(colsA != rowsB)
            {
                Console.WriteLine("Multiplication is not possible");
                return;
            }

            int[,] result = new int[rowsA, colsB];

            for(int i=0; i<rowsA; i++)
            {
                for(int j=0; j<colsB; j++)
                {
                    for(int k=0; k<colsA; k++)
                    {
                        result[i,j] += matrixA[i,k] * matrixB[k,j];
                    }
                }
            }

            Console.WriteLine("The result matrx is ");

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    Console.Write(result[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
