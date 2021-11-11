using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    class Person
    {
        public Person(string name, int age, string personalNumber)
        {
            Name = name;
            Age = age;
            PersonalIdNumber = personalNumber;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public string PersonalIdNumber { get; set; }

        public Home House { get; set; }
    }

    public class Home
    {
        public Home(string address, string city)
        {
            Address = address;
            City = city;
        }
        public string Address { get; set; }
        public string City { get; set; }
    }
}
