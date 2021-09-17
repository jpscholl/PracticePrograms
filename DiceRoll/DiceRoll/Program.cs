/*
//  Author: Jonathan Scholl
//  Date: 9/17/2021
//  Project: DiceRoll
//  Description: Simple program to simulate six sided dice roll (ouputs picture of dice)
*/

using System;

namespace DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();

            Console.WriteLine(dice.openingLogo());

            Console.WriteLine("You rolled a: ");
            dice.rollDice();

        }
    }
}
