﻿using System;

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

            // I option
            Console.WriteLine("Twoje imię to: {0}, Nazwisko: {1}, A wiek: {2}", name, surname, age);

            // II option
            Console.WriteLine("Twoje imię to: " + name + ", Nazwisko: " + surname + ", A wiek: " + age);

            // III option
            Console.WriteLine($"Twoje imię to: {name}, Nazwisko: {surname}, Masz {age} lat.");



        }
    }
}
