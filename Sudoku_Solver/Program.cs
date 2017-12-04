using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solver
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxCol = 3;
            int MaxRow = 3;

            double[,] matrix = new double[MaxCol, MaxRow];

            Console.WriteLine("Write in the sudoku numbers you know. Enter a zero for the ones you don't.");

            //this is a matrix.
            //it is a user input matrix.
            for (int i = 0; i < MaxCol; i++)
            {
                for (int j = 0; j < MaxRow; j++)
                {
                    Console.WriteLine("Enter static numbers for {0}, {1}", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }

            }
            //this prints in matrix format
            for (int m = 0; m < MaxCol; m++)
            {
                for (int j = 0; j < MaxRow; j++)
                {
                    Console.Write(matrix[m, j] + "\t");
                }

                Console.WriteLine("\n");
            }

            //now I want to sudoku.

            Console.WriteLine("Now let's take that vision of the matrix and do something with it. Let's solve the puzzle.");

            












        }
    }
}
