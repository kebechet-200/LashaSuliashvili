using Compare;
using Generics.Interfaces;
using System;
using System.Collections;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //explicit properties in coffee class

            //Coffee instance = new Coffee();
            //IInventoryItem iItem = instance;
            //iItem.IsFairTrade = false;
            //IBeverage iItem2 = instance;
            //iItem2.IsFairTrade = true;
            //Console.WriteLine(iItem.IsFairTrade + " and " + iItem2.IsFairTrade);

            //Create some instances of the Coffee class.
            Coffee coffee1 = new Coffee();
            coffee1.AverageRating = 4.5;
            Coffee coffee2 = new Coffee();
            coffee2.AverageRating = 8.1;
            Coffee coffee3 = new Coffee();
            coffee3.AverageRating = 7.1;
            // Add the Coffee instances to an ArrayList.
            ArrayList coffeeList = new ArrayList();
            coffeeList.Add(coffee1);
            coffeeList.Add(coffee2);
            coffeeList.Add(coffee3);
            Tea tea = new Tea();
            tea.MeErrorUndaWarmovqmna = "Runtime Gagijeba";
            coffeeList.Add(tea);

            // it sucks for compile time
            IBeverage beverage = (IBeverage)coffeeList[3];
            Coffee coffeeConvert = (Coffee)beverage;
            Console.WriteLine(coffeeConvert.AverageRating);
            Tea tea2 = (Tea)beverage;
            //sorting coffeelist with a average rating 
            //esec erors isvris prosta ar miushvi aqamde ;D
            coffeeList.Sort(new CoffeeComparer());

        }
    }
}
