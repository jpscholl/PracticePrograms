using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll
{
    public class Dice
    {
        public string openingLogo()
        {
            Console.WriteLine("***Welcome to dice roll***");
            string dice = "  .-------.      ______      \n" +
                          " /   o   / |    /\\     \\   \n" +
                          "/_______/o |   /o \\  o  \\  \n" +
                          "| o     |  |  /   o\\_____\\ \n" +
                          "|   o   | o/  \\o   /o    /  \n" +
                          "|     o | /    \\ o/  o  /   \n" +
                          "'-------'       \\/____o/    \n";


            return dice;
        }
        public void rollDice()
        {
            Random rand = new Random();

            int side = Math.Abs(rand.Next(1, 6));
            switch (side)
            {

                case 1:
                    Console.WriteLine("---------\n" +
                                      "|       | \n" +
                                      "|   o   | \n" +
                                      "|       | \n" +
                                      "--------- \n");
                    break;
                case 2:
                    Console.WriteLine("----- \n" +
                                      "|o  | \n" +
                                      "|   | \n" +
                                      "|  o| \n" +
                                      "----- \n");
                    break;
                case 3:
                    Console.WriteLine("----- \n" +
                                      "|o  | \n" +
                                      "| o | \n" +
                                      "|  o| \n" +
                                      "----- \n");
                    break;
                case 4:
                    Console.WriteLine("----- \n" +
                                      "|o o| \n" +
                                      "|   | \n" +
                                      "|o o| \n" +
                                      "----- \n");
                    break;
                case 5:
                    Console.WriteLine("----- \n" +
                                      "|o o| \n" +
                                      "| o | \n" +
                                      "|o o| \n" +
                                      "----- \n");
                    break;
                case 6:
                    Console.WriteLine("-----\n" +
                                      "|o  o| \n" +
                                      "|o  o| \n" +
                                      "|o  o| \n" +
                                      "-----\n");
                    break;
                default:
                    Console.WriteLine("Fell off the table");
                    break;
            }
        }
    }
}
