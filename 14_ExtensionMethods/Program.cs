using System.Runtime.CompilerServices;

namespace _14_ExtensionMethods
{

    static class ExampleExtensions
    {
        public static int NumberWords(this string data)
        {
            if(string.IsNullOrEmpty(data)) return 0;
            return data.Split(new char[] { ' ', '.', ',', '!', '?' }, 
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static int NumberSymbols(this string data, char s)
        {
            if (string.IsNullOrEmpty(data)) return 0;

            int c = 0;
            foreach (char item in data)
            {
                if (item == s) ++c;
            }
            return c;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello world. Have a nice day!!!!";
            Console.WriteLine("Count words : " + message.NumberWords()); 
            Console.WriteLine("Count symbols 'l' : " + message.NumberSymbols('l')); 
            
            
        }
    }
}
