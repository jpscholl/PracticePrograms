using System;

namespace NestedLoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 9; x >= 0; x--)
            {
                for(int y = x; y >= 0; y--)
                {
                    Console.Write(y + " IL");
                }
                Console.WriteLine(" OL");
            }
        }
    }
}
