/*
 *   Author: Jonathan Scholl
 *   Date: 3/10/2022
 *   Project: https://docs.microsoft.com/en-us/shows/c-advanced/introduction-to-language-integrated-query-linq--c-advanced-1-of-8
 * 
 */

//new variables can be made from existing objects using linq clauses
List<int> numList = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var oddNums = from num in numList where num % 2 != 0 select num;
var evenNums = from num in numList where num % 2 == 0 select num;

//output results
Console.WriteLine("Odd numbers:");
foreach (var oddNum in oddNums)
{
    Console.Write($"{oddNum} ");
}
Console.WriteLine("\nEven numbers:");
foreach (var evenNum in evenNums)
{
    Console.Write($"{evenNum} ");
}
Console.WriteLine("\n");

//filter elements base on position
string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
var shortDigits = digits.Where((digit, index) => digit.Length < index);

foreach (var d in shortDigits)
{
    Console.WriteLine($"Word {d} is shorter than its value.");
}

//projections operator
int[] numbers = {1, 2, 3, 4, 5 };
var textNums = from n in numbers
               select digits[n];
Console.WriteLine();
foreach (var d in textNums)
{
    Console.WriteLine(d);
}
