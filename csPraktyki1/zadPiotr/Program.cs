using System;

namespace csPraktyki1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aplikacja konsoli C#, która pobiera od użytkownika liczbę całkowitą i sprawdza czy jest ona dodatnia, ujemna czy zerowa
            bool isNumberValid = false;
            int number = 0;
            while (!isNumberValid)
            {
                Console.WriteLine("Podaj liczbę całkowitą: ");
                string input = Console.ReadLine();
                isNumberValid = int.TryParse(input, out number);
                if (!isNumberValid)
                {
                    Console.WriteLine("Nieprawidłowy format. Spróbuj ponownie.");
                }
            }
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
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć program.");
            Console.ReadKey();
        }
    }
}