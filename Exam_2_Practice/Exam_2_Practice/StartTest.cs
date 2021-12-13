using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exam_2_Practice
{
    class StartTest
    {
        private int _counter = 0;
        List<string[]> questionAnswers = new List<string[]>();
        private const string path = @"C:\Users\Owner\source\repos\LashaSuliashvili\Exam_2_Practice\Exam_2_Practice\Tests.txt";
        public StartTest()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                    questionAnswers.Add(sr.ReadLine().Split('|'));
            }
            string correctAnswer = string.Empty;
            for (int i = 0; i < questionAnswers.Count; i++)
            {
                foreach (string item in questionAnswers[i])
                {
                    if (item.EndsWith('*')) correctAnswer = item.TrimEnd('*');
                }
                Console.WriteLine(questionAnswers[i][0].EndsWith('*') ? questionAnswers[i][0].Substring(0, questionAnswers[i][0].Length - 1) : questionAnswers[i][0]);
                Console.WriteLine(questionAnswers[i][1].EndsWith('*') ? questionAnswers[i][1].Substring(0,questionAnswers[i][1].Length - 1) : questionAnswers[i][1]);
                Console.WriteLine(questionAnswers[i][2].EndsWith('*') ? questionAnswers[i][2].Substring(0, questionAnswers[i][2].Length - 1) : questionAnswers[i][2]);
                Console.WriteLine(questionAnswers[i][3].EndsWith('*') ? questionAnswers[i][3].Substring(0, questionAnswers[i][3].Length - 1) : questionAnswers[i][3]);
                Console.WriteLine(questionAnswers[i][4].EndsWith('*') ? questionAnswers[i][4].Substring(0, questionAnswers[i][4].Length - 1) : questionAnswers[i][4]);
                Console.Write("Choose correct answer (type answer as a text): ");
                string answer = Console.ReadLine();
                if (answer.ToLower() == correctAnswer.Substring(2).ToLower()) ++_counter;
                Console.WriteLine($"Correct answer was {correctAnswer}\n");
            }
            Console.WriteLine($"Your result is {_counter}/{questionAnswers.Count}");
        }
        
    }
}
