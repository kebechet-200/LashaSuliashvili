using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person [3];
            persons[0] = new Person("Lasha",27,"010012419241");
            persons[1] = new Person("Beqa", 26, "01002104124");
            persons[2] = new Person("Dimitri", 24, "0100120312");

            Home homeForLasha = new Home("Chavchavadzis 71", "Tbilisi");
            Home homeForBeqa = new Home("Masivi 2 mikro", "Tbilisi");
            Home homeForDimitri = new Home("Lublianas 2/6", "Tbilisi");

            persons[0].House = homeForLasha;
            persons[1].House = homeForBeqa;
            persons[2].House = homeForDimitri;
        }
    }
}
