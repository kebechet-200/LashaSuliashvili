using System;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            Console.Write("Enter hours: ");
            time.Hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter minutes: ");
            time.Minute = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter seconds: ");
            time.Second = Convert.ToInt32(Console.ReadLine());

            // first task
            time.AddSecond();
            time.AddSecond();
            time.AddSecond();
            time.AddSecond();

            // second task
            time.AddSecond();
            time.AddSecond();
            time.AddSecond();
            time.AddMinute();

            Console.WriteLine($"{time.Hour}:{time.Minute}:{time.Second}");
        }
    }
}
