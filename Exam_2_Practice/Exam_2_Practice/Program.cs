using System;

namespace Exam_2_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Start Test");
            Console.WriteLine("2.Add Test");
            Console.Write("Choose one: ");
            int answer = Convert.ToInt32(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    StartTest st = new StartTest();
                    break;
                case 2:
                    
                    Console.WriteLine("Enter the question: ");
                    AddTest.AddQuestion(Console.ReadLine());
                    Console.WriteLine("Enter answers : ");
                    AddTest.AddAnswers(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                    break;
            }
        }
    }
}
