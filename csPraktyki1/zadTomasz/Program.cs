using System;

namespace csPraktyki1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aplikacja konsoli C# która po wczytaniu z klawiatury 3 liczb całkowitych wypisze na ekran ich sumę oraz informację czy ich reszta z dzielenia jest równa 0.
            Console.WriteLine("Podaj 3 liczby całkowite");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Suma liczb wynosi: " + (number1 + number2 + number3));
            if (number1 % number2 == 0 && number1 % number3 == 0 && number2 % number3 == 0)
                {
                Console.WriteLine("Reszta z dzielenia wynosi 0");
            }
            else
            {
                Console.WriteLine("Reszta z dzielenia nie wynosi 0");
            }
        }
    }
}