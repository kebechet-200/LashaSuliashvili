using System;

namespace Pracitce_1
{
    class ProgramsPerEatam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Cat object...");
            Cat cat = new Cat();
            Console.Write("Enter name: ");
            cat.Name = Console.ReadLine();
            Console.Write("Enter breed: ");
            cat.Breed = Console.ReadLine();
            Console.Write("Enter age: ");
            cat.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter gender: ");
            string gender = Console.ReadLine();
            if (gender.ToLower() == "male") cat.Gender = true;
            else cat.Gender = false;
            Console.WriteLine("Cat object created...");
            Console.Write("Enter food weight in grams: ");
            cat.Eat(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter meowing count: ");
            cat.Meow(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
