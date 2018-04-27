using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone1_PigLat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");

            Console.WriteLine("Enter a word to translate: ");
            string input = Console.ReadLine().ToLower();

            string vowels = "aeiou";
            int index = -1;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (index < 0)
                    {
                        if (input[i] == vowels[j])
                        {
                            //seeing if each of the letters are a vowel
                            index = i;
                           
                        }
                    }
                }
            }

            if (index > 0)
            {

                Console.WriteLine(index);
                string end = input.Substring(index);

                string Beginning = input.Substring(0, index);

                string pigLat = (end + Beginning + "ay");

                Console.WriteLine($"Your word translated is {pigLat}");
            }
            else
            {
                if (index == 0)
                {
                    //if the word starts with a vowel, index is 0 and this happens
                    Console.WriteLine($"Your new word is {input}way");
                }
            }
        }
    }
}
