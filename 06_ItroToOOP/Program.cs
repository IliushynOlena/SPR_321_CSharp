namespace _06_IntroToOOP
{
    /*
     private (default for all fields)
     public
     protected
     internal -don'n acess from another projects
     protected internal     
     */
    public class MyClass : Object
    {
      
        //class body
        private int number = 1;//  private:
        protected internal int count;
        private string name;
        private const float pi = 3.14f;
        private readonly int id = 10;
        public MyClass()
        {
            id = 10;
            name = "Test";  
        }
        //void setId(int id)
        //{
        //    this.id = id;
        //}
        public void Print()
        {
            Console.WriteLine($"Id : {id} . Name {name}");
        }
        public override string ToString()
        {
            return $"Id : {id} . Name {name}";
        }

    }
    class MyClass2 { }
    class DerivedClass: MyClass  //public
    {
    }
    struct Point_2D
    {
        public int x;
        public int y;   
    }

    partial class Point
    {
        private int xCoord;
        private int yCoord;
        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //Auto property --> prop + TAB
        public string Name { get; set; }
        public string Type { get; }//readonly field
       //full property - fullprop + TAB
        private double salary;
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
                else
                {
                    salary = 0;
                }

            }
        }
        public string Color { get; private set; } = "Red";

        private static int count;
       
      
        //properties
        public int XCoord//value
        {
            get
            {
                return xCoord;
            }
            set
            {
                if (value > 0)
                    xCoord = value;
                else
                    xCoord = 0;
            }
        }
        public int YCoord//value
        {
            get
            {
                return yCoord;
            }
            set
            {
                if (value > 0)
                    yCoord = value;
                else
                    yCoord = 0;
            }
        }

        public void Print()
        {
            Console.SetCursorPosition(xCoord, yCoord);
            Console.WriteLine($"X : {xCoord} . Y : {yCoord}");
        }
        public override string ToString()
        {
            return $"X : {xCoord} . Y : {yCoord}";
        }
    }

     class Program
    {
        static void Main(string[] args)
        {

            Point p = new Point(-5,10);  

            //p.Print();
            Console.WriteLine(p);

            p.SetXCoord(12);
            p.Print();

            Console.WriteLine(p.GetX());

            p.XCoord = 100;//setter
            Console.WriteLine(p.XCoord);//gettes

            p.Name = "2D_Point";//setter
            Console.WriteLine(p.Name);//getter
           
            p.Test();
            Random random   = new Random();
            Point[] points = new Point[5];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(random.Next(50),random.Next(50)); 
            }

            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine(points[i]);
            }


            //MyClass myClass = new MyClass();
            // myClass.Print();
            // Console.WriteLine(myClass.ToString());
            // Console.WriteLine(myClass);

            // MyClass @class = new MyClass();


        }
    }
}
