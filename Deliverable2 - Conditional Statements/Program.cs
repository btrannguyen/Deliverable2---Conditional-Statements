/* 
 Author: Tran Nguyen
 Date: 1/19/2023
 Description: C# Console Application for calculating letter grade
*/

using System;

namespace Deliverable2___Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleaser enter your numeric grade: ");

            try
            {
                int input = int.Parse(Console.ReadLine());
                string letter;

                if (input >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your letter grade is " + letter);
                }
                else if (input >= 80 && input < 90)
                {
                    letter = "B";
                    Console.WriteLine("Your letter grade is " + letter);
                }
                else if (input >= 70 && input < 80)
                {
                    letter = "C";
                    Console.WriteLine("Your letter grade is " + letter);
                }
                else if (input >= 60 && input < 70)
                {
                    letter = "D";
                    Console.WriteLine("Your letter grade is " + letter);
                }
                else
                {
                    letter = "F";
                    Console.WriteLine("Your letter grade is " + letter);
                }
            }
            catch
            {
                Console.WriteLine("Please enter a numeric value");
            }
        }
    }
}