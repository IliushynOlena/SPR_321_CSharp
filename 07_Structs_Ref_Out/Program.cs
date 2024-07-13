
//using _2D_Object;

namespace _07_Structs_Ref_Out
{
    /*
     private (default for all fields)
     public
     protected
     internal -don'n acess from another projects
     protected internal     
     */
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = y;
            this.Y = x; 
        }
        public void Print()
        {
            Console.WriteLine($"X = {X}. Y = {Y}");
        }
        public override string ToString()
        {
            return $"X = {X}. Y = {Y}";
        }
    }
    class Time
    {
        private int age;

        public int Age
        {
            get { return age; }
            set 
            {
                if(value > 18)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Incorrect age!");
                }
            }
        }

        public int H { get; set; }
        public int M { get; set; }
        public int S { get; set; }
    }
    class User
    {
        public string Name { get; set; }
        public User()
        {
            
        }
        public User(string name)
        {
            this.Name = name;   
        }
    }
    internal class Program
    {
        //public static void MethodsWithParams(string name, int[]marks)
        //{
        //    Console.WriteLine($"-----------------------{name}--------------");
        //    foreach (var mark in marks)
        //    {
        //        Console.Write($"{mark}  ");
        //    }
        //    Console.WriteLine();
        //}
        public static void MethodsWithParams(string name, int age, params int[]marks)
        {
            Console.WriteLine($"-----------------------{name}--------------");
            Console.WriteLine($"-----------------------{age}--------------");
            foreach (var mark in marks)
            {
                Console.Write($"{mark}  ");
            }
            Console.WriteLine();
        }
        static void Modify(ref int num,ref string str,ref Point p)
        {
            num += 1;
            str += "!";
            p.X++;
            p.Y++;
        }
        static void GetCurentTime(out int hour, out int minute ,out int second)
        {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;   
            second = DateTime.Now.Second;
          
        }

        static void Main(string[] args)
        {
            User user = new User(); 
            user.Name ="Test";
            Console.WriteLine(user.Name);
            
            Point point = new Point();   //invoke default construtor

            Time time = new Time(); //new - create dynamic memory

            Point emptyPoint;

            Time emptyTime;

            int a;

            ///string str = "Hello";


            //out 
            int h ,m,s;
            //Console.WriteLine($"{h}:{m}:{s}");
            GetCurentTime(out h,out  m,out s);
            Console.WriteLine($"{h}:{m}:{s}");

            //ref 
            int num = 10;
            string str = "Hello academy";
            Console.WriteLine($"Length : {str.Length}");
            Point p = new Point() { X = 5, Y = 6 };
            Console.WriteLine($"Num : {num}");
            Console.WriteLine($"Str : {str}");
            Console.WriteLine($"Point : {p}");
            Modify(ref num, ref str,ref  p);
            Console.WriteLine($"Num : {num}");
            Console.WriteLine($"Str : {str}");
            Console.WriteLine($"Point : {p}");


            //int[]marks  = new int[8] { 12, 10, 12, 5,12,12,12,11 };
            //MethodsWithParams("Bob",15, marks);
            //MethodsWithParams("Tom",21, new int[] {5,6,3,4,7,8,7,8,9,6});
            //MethodsWithParams("Ella",16, 11,11,12,9,10,9,7,12,12,12,12);




            //Point p = new Point();//_2D_Object
            //_3D_Object.Point p2 = new _3D_Object.Point();
            //p.Print();
            //p2.Print();
            //Point point = new Point();
            //Console.WriteLine(point);

        }
    }
}
namespace _2D_Object
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Print()
        {
            Console.WriteLine($"X = {X}. Y = {Y}");
        }
        public override string ToString()
        {
            return $"X = {X}. Y = {Y}";
        }
    }
}
namespace _3D_Object
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public void Print()
        {
            Console.WriteLine($"X = {X}. Y = {Y}. Z = {Z}");
        }
    }
}


