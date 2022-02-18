using System;

namespace Practical_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth year : ");
            int birthYear = int.Parse(Console.ReadLine());
            int modifiedYear = birthYear % 12;
            string generateYear = string.Empty;
            switch (modifiedYear)
            {
                case 0:
                    generateYear = "Monkey";
                    break;
                case 1:
                    generateYear = "Rooster";
                    break;
                case 2:
                    generateYear = "Dog";
                    break;
                case 3:
                    generateYear = "Pig";
                    break;
                case 4:
                    generateYear = "Rat";
                    break;
                case 5:
                    generateYear = "Ox";
                    break;
                case 6:
                    generateYear = "Tigar";
                    break;
                case 7:
                    generateYear = "Rabbit";
                    break;
                case 8:
                    generateYear = "Dragon";
                    break;
                case 9:
                    generateYear = "Snake";
                    break;
                case 10:
                    generateYear = "Horse";
                    break;
                case 11:
                    generateYear = "Goat";
                    break;
            }
            Console.WriteLine($"{birthYear} was a {generateYear} year.");
        }
    }
}
