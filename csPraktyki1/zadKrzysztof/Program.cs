using System;

namespace csPraktyki1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aplikacja konsoli C# która pobiera od użytkownika 2 liczby, wykonuje na nich działania odejmowania, mnożenia, dodawania i dzielenia i je wyświetla.
            Console.WriteLine("Podaj 2 liczby");
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podane liczby to: " +  number1 + " i " + number2);
            Console.WriteLine("Dodawanie: " + (number1 + number2));
            Console.WriteLine("Odejmowanie: " + (number1 - number2));
            Console.WriteLine("Mnożenie: " + (number1 * number2));
            Console.WriteLine("Dzielenie: " + (number1 / number2));
        }
    }
}