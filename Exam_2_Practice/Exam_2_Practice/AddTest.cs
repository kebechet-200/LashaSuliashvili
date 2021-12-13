using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exam_2_Practice
{
    public static class AddTest
    {
        
        private const string path = @"C:\Users\Owner\source\repos\LashaSuliashvili\Exam_2_Practice\Exam_2_Practice\Tests.txt";
        public static void AddQuestion(string question)
        {
            File.AppendAllText(path, $"\n{question}|");
        }

        public static void AddAnswers(string ans1, string ans2, string ans3, string ans4)
        {
            StringBuilder sr = new StringBuilder();
            sr.Append($"{ans1}|{ans2}|{ans3}|{ans4}");
            File.AppendAllText(path,sr.ToString());
        }
    }
}
