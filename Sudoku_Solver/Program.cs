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

            //int MaxCol = 3;
            //int MaxRow = 3;

            //double[,] matrix = new double[MaxCol, MaxRow];

            //Console.WriteLine("Write in the sudoku numbers you know. Enter a zero for the ones you don't.");

            ////this is a matrix.
            ////it is a user input matrix.
            //for (int i = 0; i < MaxCol; i++)
            //{
            //    for (int j = 0; j < MaxRow; j++)
            //    {
            //        Console.WriteLine("Enter static numbers for {0}, {1}", i, j);
            //        matrix[i, j] = int.Parse(Console.ReadLine());
            //    }

            //}
            ////this prints in matrix format
            //for (int m = 0; m < MaxCol; m++)
            //{
            //    for (int j = 0; j < MaxRow; j++)
            //    {
            //        Console.Write(matrix[m, j] + "\t");
            //    }

            //    Console.WriteLine("\n");
            //}

            //now I want to sudoku.

            //Console.WriteLine("Now let's take that vision of the matrix and do something with it. Let's solve the puzzle.");
            //Console.WriteLine("Well actually, sudoku is much bigger than 3x3. It is 9x9. \nNever repeating any number 1 through 9 in the rows. This is the important bit.");
            //Console.WriteLine("Knowing that, I can do better. It's 9 3x3 squares, in which there is no repeat of 1 through 9.");
            //Console.WriteLine("Then also no repeat in the rows.");
            //Console.WriteLine("Right, no big.");

            Console.WriteLine("Sudoku! 3x3");

            //temp change to make the matrix smaller, to deal with just these.
            int sudMaxCol = 3;
            int sudMaxRow = 3;

            do
            {
                //you know, I bet I could leave it in a matrix and still compare well. In fact I think I need to. NESTED MATRICES.
                int[,] sudMatrix = new int[sudMaxCol, sudMaxRow];                             

                int[] sudoku = new int[9];

                Console.WriteLine("Write in the sudoku numbers you know. Enter a zero for the ones you don't.");

                
                //user input matrix 1-3
                for (int i = 0; i < sudMaxCol; i++)
                {
                    for (int j = 0; j < sudMaxRow; j++)
                    {                        
                        Console.WriteLine("Enter static numbers for {0}, {1}", i, j);
                        sudMatrix[i, j] = int.Parse(Console.ReadLine());                                            
                        
                    }
                    
                }

                //this prints in matrix format
                for (int m = 0; m < sudMaxCol; m++)
                {
                    for (int j = 0; j < sudMaxRow; j++)
                    {
                        Console.Write(sudMatrix[m, j] + "\t");
                    }

                    Console.WriteLine("\n");
                }

                int col = 0;
                int row = 0;
                
                //do I need these as place holders? Also I might still need an array. 
                //like possibly 1000 arrays.

                //comparing internally, maybe
                for (int i = 0; i < sudMaxCol; i++)
                {
                    

                    for (int j = 0; j < sudMaxRow; j++)
                    {
                        

                        if (sudMatrix[i, j] == 0)
                        {
                            
                            col++;
                        }                        
                    }
                }













                //setting it up for users to solve the puzzle. But I want to create a program that solves it for me.
                Console.WriteLine("Continue solving?");
                userChoice = Console.ReadLine();

            }
            while (userChoice == "yes");
            //any variable = 0


        }
    }
}

//what if I set up different variables for the different squares?
//for one 3x3, I use one set of variables and compare those.
//Complex if statements is how I'm forseeing this.