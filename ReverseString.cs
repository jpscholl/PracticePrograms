/*
//  Author: Jonathan Scholl
//  Date: 10/27/2021
//  Project: Reverse the character of a string
*/
using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string userInputString;

            //prompt user input and store
            Console.Write("Please input a string: ");
            userInputString = Console.ReadLine();


            //solution 1 (adds the chars from one char array in reverse order to the new char array):
            //create array of same length and reverse string
            char[] stringToCharArray = userInputString.ToCharArray();
            char[] reverseCharArray = new char[stringToCharArray.Length];
            for (int x = 0; x < stringToCharArray.Length; x++)
            { 
                reverseCharArray[x] = stringToCharArray[stringToCharArray.Length - 1 - x];
            }
            
            //output reversed string
            for(int x = 0; x < reverseCharArray.Length; x++)
            {
                Console.Write(reverseCharArray[x]);
            }


            //solution 2 (adds invidual chars to a string in reverse order and output the string):
            string reverseString = "";

            for (int x = 0; x < stringToCharArray.Length; x++)
            {
                reverseString += stringToCharArray[stringToCharArray.Length - 1 - x];
            }

            Console.WriteLine("\n" + reverseString);
        }
    }
}
