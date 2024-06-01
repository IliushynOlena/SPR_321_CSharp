namespace _10_Inheritance
{
    //public
    //private
    //protected 
    abstract class Person :Object
    {
        protected string name;
        private readonly DateTime birthDate;
        public Person()
        {
            name = "no name";
            birthDate = DateTime.Now;   
        }
        public Person(string n, DateTime d)
        {
            name = n;
            if(d > DateTime.Now)
            {
                birthDate = new DateTime();
            }
            else
            {
                birthDate = d;  
            }
        }
        public virtual void Print()
        {
            Console.WriteLine($"Name : {name}. Birthday : {birthDate.ToShortDateString()}");
        }
        public override string ToString()
        {
            return $"Name : {name}. Birthday : {birthDate.ToShortDateString()}\n";
        }
        public abstract void DoWork();//pure virtual method
    }
    //class Child : ParrentClass, Interface1, Interface2, Interface3, 
    class Worker : Person//public
    {
        //public int Salary { get; set; }
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set 
            { 
                this.salary = value > 0 ? value : 0;
                
            }
        }
        public Worker(): base()
        {
            //name = "no name";
            //birthDate = new DateTime();
            this.Salary = 0;    
        }
        public Worker(string n, DateTime b, decimal s): base(n,b)
        {
            Salary = s;//-10000
        }
        public override void DoWork()
        {
            Console.WriteLine("I am worker .... I am working....");
        }
        //new - create new mwmber and hides method base class - stop virtual
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Salary : {Salary} grn");
        }

    }
    sealed class  Programmer: Worker 
    {
        public int CodeLines { get; set; }
        public Programmer():base()
        {
            CodeLines = 0;  
        }
        public Programmer(string n, DateTime b, decimal s):base(n,b,s)
        {
            CodeLines = 0;
        }
        public sealed override void DoWork()
        {
            Console.WriteLine("I am programmer. I write C# code. I am senior!!!!");
        }
        public void WriteCode()
        {
            CodeLines++;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Code lines : {CodeLines}");
        }
    }
    //sealed 
    class TeamLead : Worker
    {
        public int ProjectCount { get; set; }
        //public override void DoWork()
        //{
        //    Console.WriteLine("I am Team Lead. I manage projects");
        //}
    }
    class AllPersons
    {
        Person[] persons;
        public AllPersons()
        {
            persons = new Person[0];    
        }
        public AllPersons(params Person[] person)
        {
            persons = person;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AllPersons allPersons = new AllPersons(new Worker(), new Programmer(), new TeamLead());   
          
            Worker worker = new Worker("Vova",new DateTime(2010,5,16),12000);   
            worker.DoWork();
            worker.Print();

            Programmer programmer = new Programmer("David",new DateTime(2005,4,21), 45000);
            programmer.WriteCode();
            programmer.WriteCode();
            programmer.WriteCode();
            programmer.DoWork();
            programmer.Print();

            Person[] persons = new Person[]
            {
                worker,
               // new Person(),
                programmer,
                new TeamLead()
            };

            foreach (var item in persons)
            {
                Console.WriteLine("------------Info-----------");
                //item.Print();
            }
            Programmer pr = null;
            try
            {
                //1 - use cast()
                pr = (Programmer)persons[2];
                pr.DoWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //2 - use as
            pr = persons[1] as Programmer;//address or null
            if (pr == null)
                Console.WriteLine("Incorrect type ....");
            else
                pr.Print();

            //3 - use as and is
            if (persons[2] is Programmer)
            {
                pr = persons[2] as Programmer;
                pr.Print();
            }

        }
    }
}
