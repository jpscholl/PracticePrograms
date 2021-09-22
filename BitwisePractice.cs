/*
//  Author: Jonathan Scholl
//  Date: 9/22/2021
//  Project: Practice with Bitwise https://www.youtube.com/watch?v=tNO05yKSQcU
//  Description: Following AngelSix C# tutorial to learn about bitwise
*/
using System;
using System.Threading.Tasks;

namespace BitwisePractice
{
    class Program
    {
        public enum SomeColors
        {
            Red = 1,
            Blue = 2,
            Green = 4,
            Black = 8,
            White = 16,
            Orange = 32,
            Yellow = 64,
            Pink = 128,
        }

        static void Main(string[] args)
        {
            // Binary


            //
            //   Bitwise operators
            //
            //      And     & (Both)
            //      Or      | (Either)
            //      Xor     ^ (Exclusive or, different)
            //      Not     ~ (Invert)
            //   

            //var a = 122;
            //var b = 7;

            //var result = (byte)(a & b);

            //Console.WriteLine($"{Convert.ToString(a, 2).PadLeft(8, '0')} ~");
            //Console.WriteLine($"{Convert.ToString(b, 2).PadLeft(8, '0')}");
            //Console.WriteLine($"--------");
            //Console.WriteLine($"{Convert.ToString(result, 2).PadLeft(8, '0')}");
            //Console.WriteLine($"--------\n");

            //
            //   Bitwise operators
            //
            //      And     & (Both)
            //      Or      | (Either)
            //      Xor     ^ (Exclusive or, different)
            //      Not     ~ (Invert)
            //

            //byte c = 25;

           // var cResult = (byte)(c << 1);


           // Console.WriteLine($"{Convert.ToString(c, 2).PadLeft(8, '0')} << 1");
            //Console.WriteLine($"--------");
            //Console.WriteLine($"{Convert.ToString(cResult, 2).PadLeft(8, '0')}");


            //   Usage
            //   
            //      Toggling boolean
            //      Enum flags
            //      Masking
            //

            // Invert booleans
            var d = true;
            d ^= true;

            // Enum flags
            var someColors = (byte)(SomeColors.Blue);
            Console.WriteLine($"{Convert.ToString((byte)someColors, 2).PadLeft(8, '0')}");

            if ((someColors & (byte)SomeColors.Blue) == (byte)SomeColors.Blue)
            {
                Console.WriteLine("Blue was included");
            }
            if ((someColors & (byte)SomeColors.White) == (byte)SomeColors.White)
            {
                Console.WriteLine("White was included");
            }

            // Masking
            var input = (byte)(SomeColors.White | SomeColors.Blue);
            var mask = (byte)SomeColors.Blue;
            var r = input & mask;

            Console.ReadLine();
        }
    }
}
