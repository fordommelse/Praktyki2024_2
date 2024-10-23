using System;

namespace csPraktyki1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aplikacja konsoli C#, która pobiera od użytkownika jakiś tekst i zlicza ilość wystąpień znaku również podanego przez użytkownika
            Console.WriteLine("Podaj tekst");
            string inputText = Console.ReadLine();
            Console.WriteLine("Podaj znak do policzenia");
            char characterToCount = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int count = 0;
            foreach (char c in inputText)
            {
                if (c == characterToCount)
                {
                    count++;
                }

            }
            Console.WriteLine($"Znak '{characterToCount}' występuje {count} razy w tym tekście");
        }
    }
}