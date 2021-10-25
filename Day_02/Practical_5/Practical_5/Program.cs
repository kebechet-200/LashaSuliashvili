using System;

namespace Practical_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your day of birth");
            byte birthDay = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter your month of birth");
            string birthMonth = Console.ReadLine();
          
            switch (birthMonth)
            {
                case "January":
                    if (birthDay > 21) Console.WriteLine($"{birthDay} {birthMonth} is Aquarius");
                    else Console.WriteLine($"{birthDay} {birthMonth} is Capricorn");
                    break;
                case "February":
                    if (birthDay > 21) Console.WriteLine($"{birthDay} {birthMonth} is Pisces");
                    else Console.WriteLine($"{birthDay} {birthMonth} is Aquarius");
                    break;
                case "March":
                    if (birthDay > 21) Console.WriteLine($"{birthDay} {birthMonth} is Aries");
                    else Console.WriteLine($"{birthDay} {birthMonth} is Pisces");
                    break;
                case "April":
                    if (birthDay > 21) Console.WriteLine($"{birthDay} {birthMonth} is Taurus");
                    else Console.WriteLine($"{birthDay} {birthMonth} is Aries");
                    break;
                case "May":
                    if (birthDay > 21) Console.WriteLine($"{birthDay} {birthMonth} is Gemini");
                    else Console.WriteLine($"{birthDay} {birthMonth} is Taurus");
                    break;
                case "Jun":
                    if (birthDay > 22) Console.WriteLine($"{birthDay} {birthMonth} is Cancer");
                    else Console.WriteLine($"{birthDay} {birthMonth} is Gemini");
                    break;
                case "July":
                    if (birthDay > 23) Console.WriteLine($"{birthDay} {birthMonth} is Leo");
                    else Console.WriteLine($"{birthDay} {birthMonth} is Cancer");
                    break;
                case "August":
                    if (birthDay > 24) Console.WriteLine($"{birthDay} {birthMonth} is Virgo");
                    else Console.WriteLine($"{birthDay} {birthMonth} is Leo");
                    break;
                case "September":
                    if (birthDay > 24) Console.WriteLine($"{birthDay} {birthMonth} is Libra");
                    else Console.WriteLine($"{birthDay} {birthMonth} is Virgo");
                    break;
                case "October":
                    if (birthDay > 24) Console.WriteLine($"{birthDay} {birthMonth} is Scorpio");
                    else Console.WriteLine($"{birthDay} {birthMonth} is Libra");
                    break;
                case "November":
                    if (birthDay > 23) Console.WriteLine($"{birthDay} {birthMonth} is Sagittarius");
                    else Console.WriteLine($"{birthDay} {birthMonth} is Scorpio");
                    break;
                case "December":
                    if (birthDay > 21) Console.WriteLine($"{birthDay} {birthMonth} is Capricorn");
                    else Console.WriteLine($"{birthDay} {birthMonth} is Sagittarius");
                    break;
            }
        }
    }
}
