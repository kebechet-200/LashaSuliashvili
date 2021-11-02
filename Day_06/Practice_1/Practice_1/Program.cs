using System;
using System.Text;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Hello, world!";
            VowelOrConsonant(inputString);
            VowelOrConsonant(inputString, false);
        }

        static void VowelOrConsonant(string input, bool vowel = true)
        {
            StringBuilder vowels = new StringBuilder();
            int counterVowels = 0;
            StringBuilder consonants = new StringBuilder();
            int counterConsonants = 0;
            foreach (char letter in input)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    counterVowels++;
                    vowels.Append(letter + " ");
                }
                else
                {
                    if(char.IsLetter(letter))
                    {
                        counterConsonants++;
                        consonants.Append(letter + "");
                    }
                }
            }
            if (vowel) Console.WriteLine($"Vowel count: {counterVowels}\nVowels: {vowels.ToString()}");
            else Console.WriteLine($"consonants count: {counterConsonants}\nConsonants: {consonants.ToString()}");
        }
    }
}
