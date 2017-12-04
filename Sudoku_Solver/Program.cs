﻿using System;
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
            string userChoice;

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
            Console.WriteLine("Well actually, sudoku is much bigger than 3x3. It is 9x9. \nNever repeating any number 1 through 9 in the rows. This is the important bit.");
            Console.WriteLine("Knowing that, I can do better. It's 9 3x3 squares, in which there is no repeat of 1 through 9.");
            Console.WriteLine("Then also no repeat in the rows.");
            Console.WriteLine("Right, no big.");

            int sudMaxCol = 9;
            int sudMaxRow = 9;

            do
            {
                double[,] sudMatrix = new double[sudMaxCol, sudMaxRow];

                Console.WriteLine("Write in the sudoku numbers you know. Enter a zero for the ones you don't.");












                //setting it up for users to solve the puzzle. But I want to create a program that solves it for me.
                Console.WriteLine("Continue solving?");
                userChoice = Console.ReadLine();

            }
            while (userChoice == "yes");
            //any variable = 0


        }
    }
}
