/*
//  Author: Jonathan Scholl
//  Date: 10/19/2021
//  Project: Random Choice
//  Description: Add random objects to list and choose at random based on how many selections you want from list
*/
using System;
using System.Collections.Generic;

namespace RandomChoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a choice list");
            List<string> choiceList = createChoiceList();

            printChoiceList(choiceList);

            listRandomizer(choiceList);
        }

        public static List<string> createChoiceList()
        {
            List<string> choices = new List<string>();
            bool addItem = true;
            string item = "";

            while (addItem == true)
            {
                string anotherItem = "";

                Console.WriteLine("Add item to the list: ");
                item = Console.ReadLine();
                choices.Add(item);

                Console.WriteLine("Add another item? (Y/N)");
                anotherItem = Console.ReadLine().ToUpper();


                if (anotherItem == "Y")
                {
                    addItem = true;
                }
                else if (anotherItem == "N")
                {
                    addItem = false;
                }

            }

            return choices;
            
        }
        public static void printChoiceList(List<string> list)
        {
            Console.Write("List: " + String.Join(", ", list));
            Console.WriteLine("\n");
        }

        public static void listRandomizer(List<string> list)
        {
            var random = new Random();
            var index = random.Next(list.Count);

            Console.Write("\nHow many items from the list do you want: ");
            int numChoices = int.Parse(Console.ReadLine());

            while (list.Count != numChoices)
            {
                list.Remove(list[index]);
            }

            list.Sort();

            printChoiceList(list);
        }
    }
