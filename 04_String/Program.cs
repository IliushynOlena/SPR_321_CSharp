using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _04_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*
            string firstname = null, lastname = null;
            firstname = "Bob";
            lastname = "Tomson";
            Console.WriteLine($"Lenght First name {firstname.Length}");
            Console.WriteLine($"Lenght Last name {lastname.Length}");

            string fullname = firstname + " bla bla bla "+ lastname;
            Console.WriteLine($"Full name : {fullname}");

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            Console.WriteLine(letters.Length);
            //string greeting = new string(letters, 0, 3);
            string greeting = new string(letters);
            Console.WriteLine($"Greeting : {greeting}");

            string[] words = { "Hello", "From", "Point", "Rectangle" };
            string message = string.Join(" - ", words);
            Console.WriteLine($"Message : {message}");

            string []splitArr = message.Split(new string[] {" - "}, StringSplitOptions.None);
            foreach (var word in splitArr)
            {
                Console.WriteLine(word);
            }
           
            string mess = "Дано рядок слів, розділених пробілами. " +
                "Між словами може бути кілька пробілів, на початку і " +
                "вкінці рядка також можуть бути пробіли. ";
            splitArr = mess.Split(new char[] { ' ', ',', '!', '.', '?', '\n' },
                StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in splitArr)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine(splitArr.Length);

            //ConsoleKeyInfo key =  Console.ReadKey();
            //if(key.Key == ConsoleKey.F12)
            //{
            //    Console.WriteLine("Have a nice day !!!!");
            //}
            */

            /*
            DateTime dateNow = DateTime.Now;
            Console.WriteLine(dateNow);
            Console.WriteLine(dateNow.ToString());
            Console.WriteLine(dateNow.ToLongDateString());
            Console.WriteLine(dateNow.ToLongTimeString());
            Console.WriteLine(dateNow.ToShortDateString());
            Console.WriteLine(dateNow.ToShortTimeString());
            Console.WriteLine(dateNow.ToString("dd/MM/yyyy"));

            DateTime newDate = dateNow;
            newDate = newDate.AddDays(15);
            newDate = newDate.AddHours(14);

            TimeSpan timeSpan = newDate - dateNow;
            Console.WriteLine(timeSpan.ToString());

            Console.WriteLine($"Milliseconds : {timeSpan.Microseconds}");
            Console.WriteLine($"Seconds : {timeSpan.Seconds}");
            Console.WriteLine($"Minutes : {timeSpan.Minutes}");
            Console.WriteLine($"Hours : {timeSpan.Hours}");
            Console.WriteLine($"Days : {timeSpan.Days}");

            Console.WriteLine($"Total milliseconds : {timeSpan.TotalMilliseconds}");
            Console.WriteLine($"Total Seconds : {timeSpan.TotalSeconds}");
            Console.WriteLine($"Total Minutes : {timeSpan.TotalMinutes}");
            Console.WriteLine($"Total Hours : {timeSpan.TotalHours}");
            Console.WriteLine($"Total Days : {timeSpan.TotalDays}");

            decimal money = 39.73m;

            //CultureInfo us = new CultureInfo("PL-pl");
            //CultureInfo us = new CultureInfo("ka-GE");
            CultureInfo us = new CultureInfo("UA-ua");
            //CultureInfo us = new CultureInfo("ko-KR");
            //CultureInfo us = new CultureInfo("en-US");
            //CultureInfo us = new CultureInfo("fr-FR");

            string course = $" Today course of dollar is : {money.ToString("C2", us)}";
            //string course = $" Today course of dollar is : {money} $";
            Console.WriteLine(course);
            Console.WriteLine(money);

            string nullStr = null;

            if(nullStr != null)
                nullStr.ToLower();

            //nuu-conditional 
            nullStr?.ToLower();

            string emptyStr = "";
            Console.WriteLine(emptyStr.Length);
            if ( string.IsNullOrEmpty(nullStr) && string.IsNullOrEmpty(emptyStr )  )
            {
                Console.WriteLine("Is null or empty ");
            }

            string password = "                ";
            Console.WriteLine(password.Length);
            if(string.IsNullOrWhiteSpace(password) ) { Console.WriteLine("Is null whitespace"); }
            */
            /*
            // Comparing 2 strings 
            string str1 = "This is test";
            string str2 = "This is text";

            if (string.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }
            Console.ReadKey();

            //String Contains String:
            string str3 = "This is testing";
            if (str3.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }
            Console.ReadKey();

            //Getting a Substring:
            string str4 = "Last night I dreamt of San Pedro";
            Console.WriteLine(str4);
            string substr = str4.Substring(23);
            Console.WriteLine(substr);
            Console.ReadKey();

            //Joining Strings:
            string[] starray = new string[]{"Down, the way nights, are dark",
                                            "And the sun shines daily on the mountain top",
                                            "I took, a trip, on,a sailing ship",
                                            "And when I reached Jamaica",
                                            "I made a stop"};

            string str5 = string.Join("!\n", starray);
            Console.WriteLine(str5);
            Console.ReadKey();

            string[] words2 = str5.Split(new char[] { ' ', ',', '\n', '?', '!' },
                StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in words2)
            {
                Console.WriteLine("Word: " + item);
            }
            Console.ReadKey();
            */
            //String interpolations
            
            //C / c
            //Задает формат денежной единицы, указывает количество десятичных разрядов после запятой
            //
            //D / d
            //Целочисленный формат, указывает минимальное количество цифр
            //
            //E / e
            //Экспоненциальное представление числа, указывает количество десятичных разрядов после запятой
            //
            //F / f
            //Формат дробных чисел с фиксированной точкой, указывает количество десятичных разрядов после запятой
            //
            //G / g
            //Задает более короткий из двух форматов: F или E
            //
            //N / n
            //Также задает формат дробных чисел с фиксированной точкой, определяет количество разрядов после запятой
            //
            //P / p
            //Задает отображения знака процентов рядом с число, указывает количество десятичных разрядов после запятой
            //
            //X / x
            //Шестнадцатеричный формат числа

        /*
            int number = 23;
            Console.WriteLine(number);
            Console.WriteLine($"Number : {number}");
            Console.WriteLine("Number : {0} {1} {2}",number, 100,200);
            Console.WriteLine("Number {0:d2}", number);
            string result = String.Format("Number: {0:d5}", number);
            Console.WriteLine(result); // 23
            //string result2 = String.Format("{0:d4}", number);
            string result2 = $"Number : {number:d4}";
            Console.WriteLine(result2); // 0023
            Console.ReadKey(); // pause

            int number1 = 23;
            string result1 = String.Format("{0:f4}", number1);
            Console.WriteLine(result1); // 23,00
            Console.ReadKey(); // pause

            double number2 = 45.08;
            //string result3 = String.Format("{0:f4}", number2);
            string result3 = $"Number: {number2:f4}";
            Console.WriteLine(result3); // 45,0800
            Console.ReadKey(); // pause

            long number4 = 19876543210;
            string result5 = String.Format("{0:+# (###) ###-##-##}", number4);
            string result6 = $"{number4:+# (###) ###-##-##}";
            Console.WriteLine(result5); // +1 (987) 654-32-10
            Console.WriteLine(result6); // +1 (987) 654-32-10
            Console.ReadKey(); // pause

            //was            
            var anInt = 1;
            var aBool = true;
            var aString = "3";
            var formated = string.Format("{0},{1},{2}", anInt, aBool, aString);
            Console.WriteLine(formated);
            Console.ReadKey();
            //become
            var anInt1 = 1;
            var aBool1 = true;
            var aString1 = "3";
            var formated1 = $"{anInt1:f4},{aBool1},{aString1}";
            Console.WriteLine(formated1);
            Console.ReadKey();
            //
            var someDir = "a";
            Console.WriteLine($@"c:\{someDir}\b         
mvbjcvl;bncv;
xcvxckbvx
            kjhrgksjerhglearhglierhg
erjkghaer               kherlkf
            ejhjer

\c");
            Console.ReadKey();

            //
            Console.WriteLine($"Name: {"Ivan"} Age: {23}"); // spaces before
            Console.ReadKey();
            Console.WriteLine($"Name: {"Ivan",-10} Age: {23,10}"); // spaces before
            Console.WriteLine($"Name: {"Veronika",-10} Age: {34,10}"); // spaces after
            Console.ReadKey(); // pause
            */
            
            //Concatanation
            string s1 = "hello";
            string s2 = "world";
            string s3 = s1 + " " + s2; // = string "hello world"
            string s4 = String.Concat(s3, "!!!"); // = string "hello world!!!"



            Console.WriteLine(s4);
            Console.ReadKey();

            string s5 = "apple";
            string s6 = "a day";
            string s7 = "keeps";
            string s8 = "a doctor";
            string s9 = "away";
            string[] values = new string[] { s5, s6, s7, s8, s9 };

            String s10 = String.Join(" ", values);
            Console.WriteLine(s10);
            Console.ReadKey();
            //  result = "apple a day keeps a doctor away"

            //Finding in string 
            string s11 = "hello world";
            char ch = 'o';
            int indexOfChar = s11.IndexOf(ch); // = 4
            Console.WriteLine(indexOfChar);

            string subString = "wor";
            int indexOfSubstring = s11.IndexOf(subString); // = 6
            Console.WriteLine(indexOfSubstring);
            Console.ReadKey();

            //broken string
            string text = "This is the last day of ^ ^ ^       winter";

            string[] words = text.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();

            // remove empty string when "  "
            string[] words1 = text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in words1)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();

            string s12 = " ? Me tengo?!, To be honest!!!   ";
            //s12 = s12.Trim();

            var coll =  s12.Split(new char[] { ' ', ',', '\n', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in coll)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(string.Join(' ', coll)); 
            s12 = s12.Trim(new char[] { '?', ' ', '!' });

            Console.WriteLine($"After trimming: /{s12}/");
            Console.ReadKey();
            

        }
    }
}
