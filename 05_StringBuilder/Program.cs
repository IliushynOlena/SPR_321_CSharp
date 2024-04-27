using System.Text;

namespace _05_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";//
            Console.WriteLine(str.Length);
            Console.WriteLine(str.Count());

            str += ", world";

        
            StringBuilder stringBuilder = new StringBuilder();
            Console.WriteLine("Length : " +  stringBuilder.Length); 
            Console.WriteLine("Capacity : " + stringBuilder.Capacity);

            stringBuilder.Append(str);
            stringBuilder.Append(", world");
            stringBuilder.Append(", world");

            Console.WriteLine("Length : " + stringBuilder.Length);
            Console.WriteLine("Capacity : " + stringBuilder.Capacity);

            stringBuilder.Append(", world");
            stringBuilder.AppendLine(", world");
            stringBuilder.Append(", world");
            stringBuilder.Append(", world");
            Console.WriteLine(stringBuilder);

            Console.WriteLine("Length : " + stringBuilder.Length);
            Console.WriteLine("Capacity : " + stringBuilder.Capacity);
            string message = "Helodslghdsfokhdfokh";
            //foreach (char c in message)
            //{
            //    if (char.IsUpper(c)) countUpper++;
            //    if (char.IsLower(c)) countLower++;
            //}
            //char.IsLower(message[0]);

        }
    }
}
