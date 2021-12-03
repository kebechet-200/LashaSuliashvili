using Generics;
using System;
using System.Collections;
using System.Collections.Generic;

namespace TypeSafeCollections
{
    class Program
    {

        static void Main(string[] args)
        {


            CustomList<Coffee> coffees = new CustomList<Coffee>();
            Coffee coffee1 = new Coffee();
            coffee1.AverageRating = 4.5;
            coffee1.Strength = 3;
            coffee1.Variety = "Arabica";
            Coffee coffee2 = new Coffee();
            coffee2.AverageRating = 3.9;
            coffee2.Strength = 2;
            coffee2.Variety = "Nescafe";
            Coffee coffee3 = new Coffee();
            coffee3.AverageRating = 3.3;
            coffee3.Strength = 1;
            coffee3.Variety = "Pele";

            coffees.Add(coffee1);
            coffees.Add(coffee2);
            coffees.Add(coffee3);
            Coffee returnedCoffee = coffees[2];
            Console.WriteLine(returnedCoffee.Variety.ToString());

            CustomList<int> ints = new CustomList<int>(); // no problem

            Queue<int> q = new Queue<int>();
            q.Enqueue(15);
            q.Enqueue(25);
            q.Enqueue(35);
            q.Enqueue(45);
            q.Enqueue(55);
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            int a = q.Dequeue();
            int b = q.Dequeue();
            Console.WriteLine(a + " " + b);

            Stack<int> s = new Stack<int>();
            s.Push(15);
            s.Push(25);
            s.Push(35);
            s.Push(45);
            s.Push(55);
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            int c = s.Pop();
            int d = s.Pop();
            Console.WriteLine(c + " " + d);
            int e = s.Peek(); // last item
            Stack<int> s2 = new Stack<int>();
            s2.Push(15);
            s2.Push(25);
            s2.Push(35);
            s2.Push(45);
            s2.Push(55);
            //Console.WriteLine(e);
            Console.Write(s.Equals(s2));

        }
    }
}
