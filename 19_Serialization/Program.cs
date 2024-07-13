using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Binary;

namespace _20_Serializable
{
    [Serializable]
    public class Passport
    {
        public int Number { get; set; }
        public Passport()
        {
            Number = 600458;
        }
        public override string ToString()
        {
            return Number.ToString();
        }
    }
    [Serializable]
    class Person
    {
        public Passport Passport { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        private int _identNumber;
        [NonSerialized]
        const string Planet = "Earth";
        public Person(int number)
        {
            _identNumber = number;
            Passport = new Passport();
        }
        public override string ToString()
        {
            return $"Name {Name}\nAge : {Age}\nIdentification number : {_identNumber}\n" +
                $"Planet {Planet}\nPassport {Passport}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person(369852) { Name = "Jack", Age = 22};
            List<Person> persons = new List<Person>()
            {
                new Person(369852) { Name = "Jack", Age = 22},
                new Person(369852) { Name = "Bob", Age = 27},
                new Person(369852) { Name = "Tom", Age = 12},
                new Person(369852) { Name = "Olga", Age = 4}
            };
            BinaryFormatter bf = new BinaryFormatter();
           
            try
            {
                using (Stream fstream = File.Create("persons.bin"))
                {
                    //bf.Serialize(fstream, person);  
                    bf.Serialize(fstream, persons);
                }
                Console.WriteLine("BinaryFormatter serializable is OK!!!!");
                //Person pr = null;
                List<Person> pr = null;

                using (Stream fstream = File.OpenRead("persons.bin"))
                {
                    //pr =  bf.Deserialize(fstream) as Person;
                    pr = bf.Deserialize(fstream) as List<Person>;
                }
                //Console.WriteLine(pr);
                foreach (Person p in pr)
                {
                    Console.WriteLine(p);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}