using System;
using static System.Console;

namespace B2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            char b = 'B';
            char c = 'C';
            //bool vowela = false;
            //bool vowelb = false;
            //bool vowelc = false;
            int vowels = 0;
            //int consonants = 0;
            WriteLine("Part a: 2 letter, 3- letter words at least 1 vowel");
            for (a = 'A'; a <= 'H'; a++)
            {
                bool vowela = a == 'A' || a == 'E';
                for (b = 'A'; b <= 'H'; b++)
                {
                    bool vowelb = b == 'A' || b == 'E';
                    vowels = (vowela ? 1 : 0) + (vowelb ? 1 : 0);
                    if (vowels >= 1)
                    {
                        Write($"{a}{b}, ");
                        for (c = 'A'; c <= 'H'; c++)
                        {
                            bool vowelc = c == 'A' || c == 'E';
                            vowels = (vowela ? 1 : 0) + (vowelb ? 1 : 0) + (vowelc ? 1 : 0);
                            if (vowels >= 1)
                            {
                                Write($"{a}{b}{c}, ");
                            }
                        }
                    }
                }
            }
            WriteLine();
            WriteLine("Part b: 2 letter, 3- letter words begin consonant, end vowel");
            for (a = 'A'; a <= 'H'; a++)
            {
                bool vowela = a == 'A' || a == 'E';
                for (b = 'A'; b <= 'H'; b++)
                {
                    bool vowelb = b == 'A' || b == 'E';
                    if (!vowela && vowelb)
                    {
                        Write($"{a}{b}, ");
                    }
                    for (c = 'A'; c <= 'H'; c++)
                    {
                        bool vowelc = c == 'A' || c == 'E';
                        if (!vowela && vowelc)
                        {
                            Write($"{a}{b}{c}, ");
                        }
                    }
                }
            }
            WriteLine();
            WriteLine("Part c: middle vowel, unique characters");
            for (a = 'A'; a <= 'H'; a++)
            {
                for (b = 'A'; b <= 'H'; b++)
                {
                    if (a != b && b == 'A' || b == 'E')
                    {
                        Write($"{a}{b}, ");
                    }
                    
                    for (c = 'A'; c <= 'H'; c++)
                    {
                        bool vowelb = b == 'A' || b == 'E';
                        bool unique = a != b && a != c && b != c;
                        if (vowelb && unique)
                        {
                            Write($"{a}{b}{c}, ");
                        }
                    }
                }
            }
        }
    }
}
    

                                            