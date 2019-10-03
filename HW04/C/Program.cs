using System;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int v_count = 0;
            int c_count = 0;
            int syl_count = 0;
             
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Enter a letter");
                var keyInfo = Console.ReadKey();
                char letter = char.ToUpperInvariant(keyInfo.KeyChar);
                if (!char.IsLetter(letter))
                {
                    break;
                }
                else
                {
                    count++;
                    bool vowel = letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' | letter == 'Y';
                    if (vowel)
                    {
                        v_count++;
                        syl_count++;
                    }
                    else
                    {
                        c_count++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Total number of letters entered is: {count}");
            Console.WriteLine($"Vowel count {v_count}");
            Console.WriteLine($"Consonant count {c_count}");
            Console.WriteLine($"Number of syllables {syl_count}");
            //8b: example of words that this technique fails:
            //"people" has 3 vowels but only 2 syllables
            //"psst" is a word that has 1 syllable but no vowel at all.
        }
    }
}

 



