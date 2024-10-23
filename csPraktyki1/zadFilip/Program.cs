using System;

namespace csPraktyki1
{
    class Program
    {
        static void Main(string[] args)
        {
            //aplikacja konsolowa w C#, która pobiera od użytkownika 4 liczby całkowite. Program sprawdza, czy wszystkie liczby są parzyste, a następnie wypisuje wynik w postaci "Tak" lub "Nie".
            Console.WriteLine("Podaj 4 liczby całkowite");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            if (number1 % 2 == 0 && number2 % 2 == 0 && number3 % 2 == 0 && number4 % 2 == 0)
            {
                Console.WriteLine("Wszystkie liczby są parzyste");
            }
            else
            {
                Console.WriteLine("Nie wszystkie liczby są parzyste");
            }
        }
    }
}