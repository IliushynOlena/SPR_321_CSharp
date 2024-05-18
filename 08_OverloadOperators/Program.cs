namespace _08_OverloadOperators
{
    class Point_3D
    {   

        public int X { get; set; }//  private int x;
        public int Y { get; set; }
        public int Z { get; set; }
        public Point_3D(): this(0,0,0) { }       
        public Point_3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"X : {X}. Y : {Y}. Z : {Z}";
        }
    }
    class Point_2D
    {

        public int X { get; set; }//  private int x;
        public int Y { get; set; }
        public Point_2D() : this(0, 0) { }
        public Point_2D(int x, int y)
        {
            X = x;
            Y = y;
        }
        //Override ToString()
        public override string ToString()
        {
            return $"X : {X}. Y : {Y}. ";
        }
        //Overload operators
        /*
         * ref , out not allowed
         public static ruturn_type  operator [symbol](parameters)
        {
           //code
        }
         */
        #region Унарні оператори
        public static Point_2D operator -(Point_2D p)
        {
            Point_2D res = new Point_2D
            {
                X = -p.X,    
                Y = -p.Y,
            };
            return res ;    
        }
        public static Point_2D operator ++(Point_2D p)
        {
            p.X++;
            p.Y++;
            return p;
        }
        public static Point_2D operator --(Point_2D p)
        {
            p.X--;
            p.Y--;
            return p;
        }

        #endregion

        #region Бінарні оператори
        public static Point_2D operator +(Point_2D p1 , Point_2D p2)
        {
            Point_2D res = new Point_2D
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y
            };
            return res;
        }
        public static Point_2D operator -(Point_2D p1, Point_2D p2)
        {
            Point_2D res = new Point_2D
            {
                X = p1.X - p2.X,
                Y = p1.Y - p2.Y
            };
            return res;
        }
        public static Point_2D operator *(Point_2D p1, Point_2D p2)
        {
            Point_2D res = new Point_2D
            {
                X = p1.X * p2.X,
                Y = p1.Y * p2.Y
            };
            return res;
        }
        public static Point_2D operator /(Point_2D p1, Point_2D p2)
        {
            Point_2D res = new Point_2D
            {
                X = p1.X / p2.X,
                Y = p1.Y / p2.Y
            };
            return res;
        }
        #endregion
        #region Logic operators
        public static bool operator ==(Point_2D p1, Point_2D p2)
        { 
            return p1.X== p2.X && p1.Y== p2.Y;  
        }
        //in pair
        public static bool operator !=(Point_2D p1, Point_2D p2)
        {
            return !(p1 == p2);
            //return p1.X != p2.X || p1.Y != p2.Y;
        }
        public static bool operator >(Point_2D p1, Point_2D p2)
        {
            return p1.X + p1.Y > p2.X+ p2.Y;
        }
        //in pair
        public static bool operator <(Point_2D p1, Point_2D p2)
        {
            return p1.X + p1.Y < p2.X + p2.Y;
        }
        public static bool operator >=(Point_2D p1, Point_2D p2)
        {
            return p1.X + p1.Y >= p2.X + p2.Y;
        }
        //in pair
        public static bool operator <=(Point_2D p1, Point_2D p2)
        {
            return p1.X + p1.Y <= p2.X + p2.Y;
        }
        #endregion
        #region True/False operators
        public static bool operator true(Point_2D p)
        {
            return p.X != 0 || p.Y != 0;    
        }
        public static bool operator false(Point_2D p)
        {
            return p.X == 0 && p.Y == 0;
        }

        #endregion
        #region Оператори приведення типів
        public static explicit operator int(Point_2D p)
        {
            return p.X + p.Y;
        }
        public static explicit operator double(Point_2D p)
        {
            return p.X + p.Y*2;
        }
        public static implicit operator Point_3D(Point_2D p)
        {
            return new Point_3D(p.X, p.Y, 0);
        }

        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;//int => int
            double b = 6.7;//double => double
            b = a;//5.00000000000000 implicit   int => double
            a = (int) b;// doublle => int 6 explicit




            Console.WriteLine( 5 + 7);
            Point_2D point1 = new Point_2D(5,8);

            //a = point1;//Point_2D => int
            //Console.WriteLine($"A = {a}");
            b =(double) point1;
            Console.WriteLine($"b = {b}");

            Point_3D p3 = point1;
            Console.WriteLine($"Point 3D : {p3}");

            Point_2D point2 = new Point_2D(3,1);

            if(point1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            
            Console.WriteLine($"Point 2D : {point1}");
            Console.WriteLine($"Point 2D : {++point1}");
            Console.WriteLine($"Point 2D : {point1++}");
            Console.WriteLine($"Point 2D : {--point1}");
            Console.WriteLine($"Point 2D : {point1--}");

            Point_2D res = -point1;
            Console.WriteLine($"Res : {res}");

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Point 2D : {point1}");
            Console.WriteLine($"Point 2D : {point2}");
            res = point1 + point2;
            Console.WriteLine($"Res + : {res}");
            res = point1 - point2;
            Console.WriteLine($"Res - : {res}");
            res = point1 * point2;
            Console.WriteLine($"Res * : {res}");
            res = point1 / point2;
            Console.WriteLine($"Res / : {res}");
           

            if(point1 < point2)
            {
                Console.WriteLine("First point is smaller");
            }
            else
            {
                Console.WriteLine("Second point is smaller");
            }

            if (point1 == point2)
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("Not equals ");
            }





        }
    }
}
