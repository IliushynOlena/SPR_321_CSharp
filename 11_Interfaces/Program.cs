namespace _11_Interfaces
{
    class Test//private
    {
        //constructor dufault      
    }
    interface IWorker//public
    {
        string Work();//=0 - pure virtual
        bool IsCompleted { get; }
        public string Name { get; set; }
        event EventHandler Completed;
    }
    abstract class Human
    {
        public string FirstName { get; set; }//null
        public string LastName { get; set; }//null
        public DateTime Birthday { get; set; }//01.01.0001
        public override string ToString()
        {
            return $"First name : {FirstName} . Last name : {LastName} " +
                $"\nBirthday : {Birthday.ToLongDateString()}";
        }
    }
    abstract class Employee : Human  
    {
        public double Salary { get; set; } //= 1500000;
        public string Position { get; set; }//null
        public override string ToString()
        {
            return base.ToString() + $"\nPosition {Position} . Salary : {Salary} ";
        }
    }
    interface IWorkable//Empty
    {
        bool IsWorking { get; }
        string Work();//{}
    }
    interface IManager
    { 
        List<IWorkable> ListOfWorkers { get; set; }   //null
        void Organize();
        void MakeBudget();
        void Control();
    }
    class Director : Employee, IManager//implement/ realize
    {
        public List<IWorkable> ListOfWorkers { get ; set ; }//null

        public void Control()
        {
            Console.WriteLine("Controling work !!!!!");
        }

        public void MakeBudget()
        {
            Console.WriteLine("I count money !!!");
        }

        public void Organize()
        {
            Console.WriteLine("I organize work");
        }
    }
    class Seller : Employee, IWorkable
    {
        public bool IsWorking => true;

        public string Work()
        {
            return "I selling product ";
        }
    }
    class Cashier : Employee, IWorkable
    {
        public bool IsWorking =>true;

        public string Work()
        {
            return "I get pay for product";
        }
    }
    class Administrator : Employee, IWorkable, IManager
    {
        //properties
        public bool IsWorking => true;

        public List<IWorkable> ListOfWorkers { get ; set ; }
        //construtors 
        //method
        public void Control()
        {
            Console.WriteLine("I am a boss))))))))");
        }

        public void MakeBudget()
        {
            Console.WriteLine("I have many money $$$$$");
        }

        public void Organize()
        {
            Console.WriteLine("I organize work");
        }

        public string Work()
        {
            return "((((((( I do my work!";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Director director= new Director()
            IManager director= new Director()
            {
                FirstName = "Tom",
                LastName = "Nikson",
                Birthday = new DateTime(2000, 10, 21),
                Position = "Director",
                Salary = 45000
            };

            Console.WriteLine(director);
            
            //director.Salary = 10;
            //Console.WriteLine(director);

            IWorkable seller = new Seller() {
                FirstName = "Olga",
                LastName = "Ivanchuk",
                Birthday = new DateTime(2005, 10, 21),
                Position = "Seller",
                Salary = 15000
            };
            Console.WriteLine(seller);
            Console.WriteLine(seller.Work()); ;
            Console.WriteLine(seller.IsWorking);
            //is as
            if( seller is Employee )
            {
                Console.WriteLine($"Seller salary : { (seller as Employee).Salary}");
            }

            List<int> list = new List<int>();
            director.ListOfWorkers = new List<IWorkable>
            {
                seller,
                new Cashier
                {
                     FirstName = "Ivanka",
                    LastName = "Petruc",
                    Birthday = new DateTime(1999, 10, 21),
                    Position = "Cashier",
                    Salary = 12000
                },
                new Seller
                {
                     FirstName = "Kolya",
                    LastName = "Oliunuk",
                    Birthday = new DateTime(1998, 10, 21),
                    Position = "Seller",
                    Salary = 14000
                }
            };

            foreach (var item in director.ListOfWorkers)
            {
                Console.WriteLine(item);
                if( item is Cashier ) { Console.WriteLine("It is cashier !!!"); }
            }
            //Multiple interface
            Administrator admin = new Administrator();
            
            //admin = 0x5896xx5x5
            IWorkable worker = admin;
            Console.WriteLine(worker.Work()); ;
            //worker = 0x5896xx5x5
            IManager manager = admin;
            manager.Organize();
            //manager = 0x5896xx5x5



        }
    }
}
