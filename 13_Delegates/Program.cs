namespace _13_Delegates
{

    //class MyDelegate :  MulticastDelegate
    //{

    //}


    //public delegate int IntDelegate(double x);
    //public delegate void VoidDelegate(int i);

    public delegate void SetStringDelegate(string str);
    public delegate double GetDoubleDelegate();
    public delegate void VoidDelegate();
    class SuperClass
    {
        public void Print(string str)
        {
            Console.WriteLine(  "String : " + str);
        }
        public static double GetKoef()
        {
            double res = new Random().NextDouble();
            return res;
        }
        public  double GetNumber()
        {
            return new Random().Next();
        }
        public void DoWork()
        {
            Console.WriteLine("Doing work.......");
        }
        public void Test()
        {
            Console.WriteLine("Testing.......");
        }
    }
    public delegate double CalculatorDelegate(double x, double y);
    class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Multy(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            if (y != 0)
                return x / y;
            throw new DivideByZeroException();
        }
    }
    public delegate int ChangeDelegate(int value);
    internal class Program
    {
        static int TestFunction(double x)
        {
            return (int)x;  
        }
        public static void DoOperation(double a, double b, CalculatorDelegate operation)
        {
            Console.WriteLine(operation.Invoke(a, b));
        }
        static void ChangeEachElement(int[]arr, ChangeDelegate act )
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]  = act(arr[i]);   
            }
        }
        static int Sqr(int v)
        {
            return v * v;
        }
        static int Inrement(int v)
        {
            return ++v;
        }
        static int Decrement(int v)
        {
            return --v;
        }

        static void Main(string[] args)
        {
            int[] arr = { 4, 7, 9, 3, 5, 6, 44, 22, 11 };
            foreach (int item in arr) Console.Write(item + " "); Console.WriteLine();
            ChangeEachElement(arr, Sqr);
            foreach (int item in arr) Console.Write(item + " "); Console.WriteLine();
            //ChangeEachElement(arr, Inrement);
            //ChangeEachElement(arr, delegate (int v) { return ++v; });//anonim delegate
            ChangeEachElement(arr, (v) => ++v);//lambda function
            foreach (int item in arr) Console.Write(item + " "); Console.WriteLine();
            ChangeEachElement(arr, Decrement);
            foreach (int item in arr) Console.Write(item + " "); Console.WriteLine();

            /*
            Calculator calculator = new Calculator();
            CalculatorDelegate calculatorDelegate = calculator.Add;
            calculatorDelegate += calculator.Sub;
            calculatorDelegate += calculator.Multy;
            calculatorDelegate += calculator.Div;
            calculatorDelegate -= calculator.Div;

            foreach (var i in calculatorDelegate.GetInvocationList())
            {
                Console.WriteLine( (i as CalculatorDelegate).Invoke(100,15) );
            }

            DoOperation(150, 14, calculator.Add);
            DoOperation(150, 14, calculator.Sub);
            DoOperation(150, 14, calculator.Multy);
            DoOperation(150, 14, calculator.Div);
            */
            /*
                        Calculator calculator = new Calculator();
                        double x, y;
                        int key;
                        do
                        {
                            CalculatorDelegate calcDelegate = null;
                            Console.WriteLine("Enter first number ");
                            x = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number ");
                            y = double.Parse(Console.ReadLine());
                            Console.WriteLine("Add  - 1 ");
                            Console.WriteLine("Sub  - 2 ");
                            Console.WriteLine("Mult  - 3 ");
                            Console.WriteLine("Divide  - 4 ");
                            Console.WriteLine("Exit  - 0 ");
                            key = int.Parse(Console.ReadLine());
                            switch (key)
                            {
                                case 1:
                                    calcDelegate = new CalculatorDelegate(calculator.Add);
                                    break;
                                case 2:
                                    calcDelegate = new CalculatorDelegate(calculator.Sub);
                                    break;
                                case 3:
                                    calcDelegate = calculator.Multy;
                                    break;
                                case 4:
                                    calcDelegate = calculator.Div;
                                    break;
                                case 0:
                                    Console.WriteLine("Good  Buy");
                                    break;
                                default:
                                    Console.WriteLine("Error choice......");
                                    break;
                            }

                            Console.WriteLine("Res = " + calcDelegate?.Invoke(x,y));
                        } while (key != 0);
            */
            /*
            SuperClass superClass = new SuperClass();
            Console.WriteLine(SuperClass.GetKoef());    
            Console.WriteLine(superClass.GetNumber());
            //GetDoubleDelegate method = new GetDoubleDelegate(superClass.GetNumber);
            GetDoubleDelegate method = SuperClass.GetKoef;// superClass.GetNumber;
            Console.WriteLine(method());
            Console.WriteLine(method?.Invoke());//
            Console.WriteLine("Continue................");

            GetDoubleDelegate[] arr = new GetDoubleDelegate[]
            {
                SuperClass.GetKoef,
                superClass.GetNumber
            };
            Console.WriteLine(arr[0].Invoke());    
            Console.WriteLine(arr[1].Invoke());    
      
            GetDoubleDelegate del1 = new GetDoubleDelegate(SuperClass.GetKoef); 
            SetStringDelegate del2 = new SetStringDelegate(superClass.Print); 
            VoidDelegate del3 = new VoidDelegate(superClass.DoWork);

            Console.WriteLine(del1.Invoke());
            del2.Invoke("Have a good day!!!!");
            del3.Invoke();
            //Multicasting 

            //Delegate.Combine(del1, new GetDoubleDelegate(superClass.GetNumber));
           // del1 += new GetDoubleDelegate(superClass.GetNumber);
            del1 += superClass.GetNumber;
            Console.WriteLine("-----------------------");
            foreach (Delegate item in del1.GetInvocationList())
            {
                Console.WriteLine( (item as GetDoubleDelegate).Invoke());
            }

            Console.WriteLine(del1.Invoke());//Last addres of method
            */
        }
    }
}
