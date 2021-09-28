/*
//  Author: Jonathan Scholl
//  Date: 9/28/2021
//  Project: https://www.youtube.com/watch?v=bqEBIKbtm7Q
//  Description: Practicing 2D arrays for better understanding
*/
using System;

namespace _2D_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid =
            {
                {1, 2 },
                {3, 4 },
                {5, 6 },
            };

            int[,] numArray2 = new int[2, 3];

            Console.WriteLine(numberGrid[0, 0]);

            print2DArray(numberGrid);

        }
        public static void print2DArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
            }
        }
    }
}
