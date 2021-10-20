/*
//  Author: Jonathan Scholl
//  Date: 10/20/2021
//  Project: Array Method - CopyTo
//  Description: Need more understanding of builtin methods, so practicing them
*/
using System;

namespace Arrays_Practice___CopyTo_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = initializeArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");


            int[] targetArray = new int[userArray.Length + 3];
            userArray.CopyTo(targetArray, 3);

            Console.WriteLine($"\nNew Array: {printArray(targetArray)}");

        }
            //create a unique array based on how many elements
            public static int[] initializeArray()
        {
            Console.Write("How many elements: ");
            var length = int.Parse(Console.ReadLine());

            int[] numArray = new int[length];

            for (int x = 0; x < numArray.Length; x++)
            {
                numArray[x] = int.Parse(Console.ReadLine());
            }

            return numArray;
        }

        //print the contents of an array
        public static string printArray(int[] numArray)
        {
            return "{ " + String.Join(", ", numArray) + " }";
        }
    }
}
