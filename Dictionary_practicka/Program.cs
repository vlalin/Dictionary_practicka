using System;
using System.Collections.Generic;

namespace Dictionary_practicka
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Man> keyValuePairs = new Dictionary<int, Man>();

            Add(keyValuePairs);
            items(keyValuePairs);

            ManSearch(keyValuePairs, Human_inventory());

            Console.Read();
        }

        static Man Human_inventory()
        {
            Man man = new Man();

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string patronymic = Console.ReadLine();

            man.name = name;
            man.surname = surname;
            man.patronymic = patronymic;

            int age = 0;

            Console.Write("Введите возрвст: ");
            Int32.TryParse(Console.ReadLine(), out age);

            man.age = age;

            return man;
        }

        static void Add(Dictionary<int, Man> keyValuePairs)
        {
            keyValuePairs.Add(0, Human_inventory());       
        }

        static void ManSearch(Dictionary<int, Man> dict, Man key)
        {
            foreach (var item in dict)
            {
                if(item.Value == key)
                    Console.WriteLine("Найден!");
            }
        }

        static void items(Dictionary<int, Man> keyValuePairs)
        {
            foreach (var item in keyValuePairs)
            {
                Console.Write(item.Key);
                Console.Write(item.Value.name);
                Console.Write(item.Value.surname);
                Console.Write(item.Value.patronymic);
                Console.Write(item.Value.age);
            }
            
        }
    }
}
