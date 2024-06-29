using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            Dictionary<int, string> countries = new Dictionary<int, string>(6);
            countries.Add(3, "Great Britain");
            countries.Add(2, "USA");
            countries.Add(10, "France");
            countries.Add(5, "China");
            countries.Add(4, "Poland");
            //countries.Add(4, "Canada");

            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.ReadKey();

            // получение элемента по ключу
            string country = countries[10];
            Console.WriteLine(country);

            // изменение объекта
            countries[4] = "Spain";
            // додавання об'єкта, якщо його не існує
            countries[9] = "India";
            // удаление по ключу
            countries.Remove(2);

            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.ReadKey();

            /////////////////2
            Dictionary<char, Person> people = new Dictionary<char, Person>();
            people.Add('b', new Person() { Name = "Bill" });
            people.Add('t', new Person() { Name = "Tom" });
            people.Add('j', new Person() { Name = "John" });
            people.Add('r', new Person() { Name = "Rita" });

            foreach (KeyValuePair<char, Person> keyValue in people)
            {
                // keyValue.Value представляет класс Person
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value.Name);
            }
            Console.ReadKey();

            Console.WriteLine("\n\n changed value START");
            foreach (var keyValue in people)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value.Name);
            }
            Console.WriteLine("original end");

            if (people.ContainsKey('r'))
            {
                people['r'].Name = "rat";
            }
            else
            {
                Console.WriteLine("Collection does not contain such key");
            }
            foreach (var keyValue in people)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value.Name);
            }
            Console.WriteLine("changed value END");

            // перебор ключей
            foreach (char c in people.Keys)
            {
                Console.WriteLine(c);
            }

            // перебор по значениям
            foreach (Person p in people.Values)
            {
                Console.WriteLine(p.Name);
            }

            ////////adding
            Dictionary<char, Person> people2 = new Dictionary<char, Person>();
            people2.Add('b', new Person() { Name = "Bill" });
            people2['a'] = new Person() { Name = "Alice" };

            /////////init
            Dictionary<string, string> countries2 = new Dictionary<string, string>
            {
                {"Франция", "Париж"},
                {"Германия", "Берлин"},
                {"Великобритания", "Лондон"}
            };

            foreach (var pair in countries2)
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);

            ////// C# 6.0
            Dictionary<string, string> countries3 = new Dictionary<string, string>
            {
                ["Франция"] = "Париж",
                ["Германия"] = "Берлин",
                ["Великобритания"] = "Лондон"
            };

            foreach (var pair in countries3)
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
        }
    }

    internal class Person
    {
        public string Name { get; internal set; }
    }
}
