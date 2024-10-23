using System;

namespace csPraktyki1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aplikacja konsoli C#, która pobiera od użytkownika liczbę całkowitą i sprawdza czy jest ona dodatnia, ujemna czy zerowa
            Console.WriteLine("Podaj liczbę całkowitą");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("Liczba dodatnia");
            }
            else if (number == 0)
            {
                Console.WriteLine("Liczba równa 0");
            }
            else
            {
                Console.WriteLine("Liczba ujemna");
            }
        }
    }
}