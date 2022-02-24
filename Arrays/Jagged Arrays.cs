/*
//  Author: Jonathan Scholl
//  Date: 2/24/2022
//  Project: https://www.youtube.com/watch?v=qM_xEU3bdpA
//  Notes: Brushing up on jagged arrays
*/

int[][] intJagArray = new int[4][];

intJagArray[0] = new int[2];
intJagArray[1] = new int[3];
intJagArray[2] = new int[5];
intJagArray[3] = new int[3];

for (int i = 0; i < intJagArray.GetLength(0); i++)
{
    for(int j = 0; j < intJagArray[i].GetLength(0); j++)
    {
        Console.Write("Input element: ");
        intJagArray[i][j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("\nArray elements: ");
for (int i = 0; i < intJagArray.GetLength(0); i++)
{
    for(int j = 0; j < intJagArray[i].GetLength(0); j++)
    {
        Console.Write($"{intJagArray[i][j]} ");
    }
    Console.WriteLine();
}
