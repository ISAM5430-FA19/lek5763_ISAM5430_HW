using System;
using static System.Console;

namespace B2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            char b = 'B';
            bool vowela = false;
            bool vowelb = false;
            int vowels = 0;
            int consonants = 0;
            WriteLine("Part a: at least 1 vowel");
            for (a = 'A'; a <= 'H'; a++)
            {
                for (b = 'A'; b <= 'H'; b++)
                {
                    if (a == 'A' || a == 'E' || b == 'A' || b == 'E')
                    {
                        WriteLine($"{a}{b}");
                    }
                }
            }
            WriteLine("Part b: 1 vowel, 1 consonant");
            for (a = 'A'; a <= 'H'; a++)
            {
                for (b = 'A'; b <= 'H'; b++)
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
                    vowels = (vowela ? 1 : 0) + (vowelb ? 1 : 0);
                    consonants = (!vowela ? 1 : 0) + (!vowelb ? 1 : 0);
                    if (vowels == 1 && consonants == 1)
                    {
                        WriteLine($"{a}{b}");
                    }
                }
            }
            WriteLine("Part c: begin consonant, end vowel");
            for (a = 'A'; a <= 'H'; a++)
            {
                for (b = 'A'; b <= 'H'; b++)
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
                    vowels = (vowela ? 1 : 0) + (vowelb ? 1 : 0);
                    consonants = (!vowela ? 1 : 0) + (!vowelb ? 1 : 0);
                    if (a != 'A' && a != 'E' && consonants == 1)
                    {
                        WriteLine($"{a}{b}");
                    }
                }
            }
        }
    }
} 
                    
                