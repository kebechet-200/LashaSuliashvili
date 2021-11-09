using System;
using System.Collections.Generic;
using System.Text;

namespace Pracitce_1
{
    class Cat
    {

        private int gramsPerEat = 10;

        string _variety;
        public string Name { get; set; }
        public string Breed 
        {
            get
            {
                return _variety;
            }
            set
            {
                _variety = value;
            }
        }

        public int Age { get; set; }
        public bool Gender { get; set; }



        public void Meow(int countMeow)
        {
            for (int i = 0; i < countMeow; i++)
            {
                Console.WriteLine("Meowing");
            }

        }

        public void Eat(int gramsPerEatams)
        {
            Console.WriteLine($"{Name} start eating.");
            int timesToEat = gramsPerEatams / gramsPerEat;
            if (gramsPerEatams % gramsPerEat == 0)
            {
                for (int i = 0; i < timesToEat; i++)
                {
                    Console.WriteLine("Eating . . . ");
                }
            }
            else
            {
                for (int i = 0; i < timesToEat + 1; i++)
                {
                    Console.WriteLine("Eating . . .");
                }
            }
            Console.WriteLine($"{Name} finished eating.");
        }
    }
}
