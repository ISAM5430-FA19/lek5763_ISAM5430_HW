using System;
using static System.Console;

namespace B2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            char b = 'B';
            char c = 'C';
            bool vowela = false;
            bool vowelb = false;
            bool vowelc = false;
            int vowels = 0;
            int consonants = 0;
            WriteLine("Part a: at least 1 vowel");
            for (a = 'A'; a <= 'H'; a++)
            {
                for (b = 'A'; b <= 'H'; b++)
                {
                    for (c = 'A'; c <= 'H'; c++)
                    {
                        if (a == 'A' || a == 'E')
                        {
                            vowela = true;
                        }
                        else
                        {
                            vowela = false;
                        }
                        if (b == 'A' || b == 'E')
                        {
                            vowelb = true;
                        }
                        else
                        {
                            vowelb = false;
                        }
                        vowels = (vowela ? 1 : 0) + (vowelb ? 1 : 0) + (vowelc ? 1 : 0);

                        if (vowels >= 1)
                        {
                            Write($"{a}{b}{c}, ");
                        }
                    }
                }
            }
            WriteLine();
            WriteLine("Part b: middle vowel");
            for (a = 'A'; a <= 'H'; a++)
            {
                for (b = 'A'; b <= 'H'; b++)
                {
                    for (c = 'A'; c <= 'H'; c++)
                    {
                        if (b == 'A' || b == 'E')
                        {

                            Write($"{a}{b}{c}, ");
                        }
                    }
                }
            }
            WriteLine();
            WriteLine("Part c: 1 consonant, 1 vowel");
            for (a = 'A'; a <= 'H'; a++)
            {
                for (b = 'A'; b <= 'H'; b++)
                {
                    for (c = 'A'; c <= 'H'; c++)
                    {
                        if (a == 'A' || a == 'E')
                        {
                            vowela = true;
                        }
                        else
                        {
                            vowela = false;
                        }
                        if (b == 'A' || b == 'E')
                        {
                            vowelb = true;
                        }
                        else
                        {
                            vowelb = false;
                        }
                        if (c == 'A' || c == 'E')
                        {
                            vowelc = true;
                        }
                        else
                        {
                            vowelc = false;
                        }
                        vowels = (vowela ? 1 : 0) + (vowelb ? 1 : 0) + (vowelc ? 1 : 0);
                        consonants = (!vowela ? 1 : 0) + (!vowelb ? 1 : 0) + (!vowelc ? 1 : 0);
                        if (vowels >= 1 && consonants >= 1)
                        {
                            Write($"{a}{b}{c}, ");
                        }
                    }
                }
            }
            WriteLine();
            WriteLine("Part d: unique characters, middle vowel");
            for (a = 'A'; a <= 'H'; a++)
            {
                for (b = 'A'; b <= 'H'; b++)
                {
                    for (c = 'A'; c <= 'H'; c++)
                    {
                        vowelb = b == 'A' || b == 'E';
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

                    
                    

        