using System;

namespace DemoApplication
{
    internal class AltNatWrdRev
    {
        // Method to reverse a single word
        public string ReverseString(string word)
        {
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        // Method to reverse alternate words in the sentence
        public string ReverseAlternateWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (i % 2 == 1) // Reverse 2nd, 4th, etc.
                {
                    words[i] = ReverseString(words[i]);
                }
            }
            return string.Join(" ", words); // Rejoin the modified words
        }

        // Main method
        static void Main()
        {
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();

          
            AltNatWrdRev obj = new AltNatWrdRev();

            
            string result = obj.ReverseAlternateWords(input);

            Console.WriteLine("Output: " + result);
        }
    }
}
