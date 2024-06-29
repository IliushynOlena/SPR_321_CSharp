namespace _15_Events
{
    public delegate void FinishAction();
    public delegate void ExamDelegate(string task);
    class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }

        private int age;

        public int Age
        {
            get { return age; }
            set { if(value> 18 && value <= 60) age = value; }
        }

        public void PassExam(string task)
        {
            Console.WriteLine($"Student : {Lastname}  {Firstname} pass the exam : {task}");
        }
    }

    class Teacher
    {
        public event Action TestEvent;// private Action delegate == void Action();
        //private ExamDelegate examDelegate = null;//MulticastingDelegate
        //public event ExamDelegate examDelegate = null;//MulticastingDelegate/
        //or
        private ExamDelegate examDelegate;

        public event ExamDelegate ExamDelegate
        {
            //+=
            add
            {
                examDelegate += value;
                Console.WriteLine(value.Method.Name + "was added ...");
            }
            //-=
            remove
            {
                examDelegate -= value;
                Console.WriteLine(value.Method.Name + "was removed ...");
            }
        }
        public void CreateExam(string task)
        {
            // Exam creating.....

            ///call students 
            examDelegate?.Invoke(task);
        }
        public void StartAction()
        {
            TestEvent?.Invoke();    
        }
    }
    internal class Program
    {
        static void HardWork(FinishAction action)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Operation {i + 1} working..........");
                Thread.Sleep(random.Next(500));
                Console.WriteLine($"Operation {i + 1} finished..........");
            }
            //some message
            action?.Invoke();// action();
        }
        static void Action1()
        {
            Console.WriteLine("You are very good worker!!!!");
        }
        static void Action2()
        {
            Console.WriteLine("Good");
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> {

                new Student
                {
                     Firstname = "Bob",
                     Lastname = "Nicson",
                     Birthday = new DateTime(2000,12,1),
                },
                new Student
                {
                     Firstname = "Olga",
                     Lastname = "Ivanchuk",
                     Birthday = new DateTime(2005,8,11),
                },
                new Student
                {
                     Firstname = "Ivan",
                     Lastname = "Petruk",
                     Birthday = new DateTime(2007,4,21),
                },
                new Student
                {
                     Firstname = "Tom",
                     Lastname = "Robson",
                     Birthday = new DateTime(2000,12,5),
                }
            };

            Teacher teacher = new Teacher();

            foreach (var st in students)
            {
                teacher.ExamDelegate += new ExamDelegate(st.PassExam);
            }

            teacher.ExamDelegate -= students[3].PassExam;
           // teacher.examDelegate = null;
            teacher.CreateExam("C# exam at 9:00 in 26 ayditory   22.06.2024");


            teacher.TestEvent += Console.Clear;
            teacher.TestEvent += delegate () { Console.ForegroundColor = ConsoleColor.Yellow; };
            teacher.TestEvent += () => Console.Beep(2000, 500);
            teacher.TestEvent += Teacher_TestEvent;
            teacher.TestEvent -= Console.Clear;
            //teacher.TestEvent -= delegate () { Console.ForegroundColor = ConsoleColor.Yellow; };

            teacher.StartAction();
            //HardWork(Action1);
            //HardWork(Action2);
            //HardWork(delegate () { Console.WriteLine("Your work is not good(((("); });
            //HardWork( ()=>Console.WriteLine("Your work is not good(((("));
        }

        private static void Teacher_TestEvent()
        {
            Console.WriteLine("Auto-created method by pressing TAB");
        }
    }
}
