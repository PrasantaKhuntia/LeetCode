using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MatrixAddition
    {
        public void MatrixAdditionProgram()
        {
            //1,2,3   2,3,4   3,5,7
            //4,5,6 + 5,6,7 = 9,11,13
            //7,8,9   8,9,4   15,17,13

            int[,] matrixA =
            {
                { 1, 0, 3 },
                { 0, 8, 0 },
                { 9, 0, 7 }
            };

            int[,] matrixB =
            {
                { 8, 0, 0 },
                { 0, 6, 0 },
                { 7, 0, 5 }
            };

            int row = matrixA.GetLength(0);
            int col = matrixA.GetLength(1);

            int[,] result = new int[row, col];

            for(int i=0; i<row; i++)
            {
                for(int j=0; j<col; j++)
                {
                    result[i,j] = matrixA[i,j] + matrixB[i,j];
                }
            }

            Console.WriteLine("The result matrix is ");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(result[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
