using System;

namespace ScopeAndModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;

            switch (i)
            {
                case > 1:
                    Console.WriteLine("FUCK UUUUUUU");
                    break;
                case < 1:
                    Console.WriteLine("U are fucking wrong");
                    break;
            }
        }
    }
}