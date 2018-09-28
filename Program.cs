using System;

namespace NewRespository
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname, ageStr;
            int age;

            Console.WriteLine("Podaj imię:");
            name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko:");
            surname = Console.ReadLine();
            Console.WriteLine("Podaj wiek:");
            ageStr = Console.ReadLine();
            age = int.Parse(ageStr);

            Console.WriteLine("Twoje imię to:", name, "Nazwisko:", surname, "A wiek: ", age);
        }
    }
}
