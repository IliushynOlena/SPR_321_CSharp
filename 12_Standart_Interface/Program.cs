using System.Collections;

namespace _12_Standart_Interface
{
    class StudentCard
    {
        public int Number { get; set; }
        public string Series { get; set; }
        public override string ToString()
        {
            return $"Student Card : {Number} . Series : {Series}";
        }
    }

    class Student : IComparable<Student>, ICloneable
    {
        //copy.StudentCard.Number = 88888;
        //copy.Firstname = "Muroslava";
        //copy.Birthday = new DateTime(2022,5,5);
        public string Firstname { get; set; }//Bob = 0x8xx5x55x  = 0x8xx5x55x
        public string Lastname { get; set; }//Nicson = 2c5c5fd5f4sdf
        public DateTime Birthday { get; set; }//2000.12.4 = 2000.12.4
        public StudentCard StudentCard { get; set; }//33b5fgf6g = j3gh3jgh6j45gh

        public object Clone()
        {
            Student copy = this.MemberwiseClone() as Student;
            copy.StudentCard = new StudentCard() { Number = this.StudentCard.Number, 
             Series = this.StudentCard.Series};
            return copy;
        }

        public int CompareTo(Student? other)
        {
            return this.Firstname.CompareTo(other.Firstname);
        }
       
        //public int CompareTo(object? obj)
        //{            
        //    return this.Firstname.CompareTo( (obj as Student).Firstname);
        //}

        public override string ToString()
        {
            return $" {Firstname}  {Lastname} . Birthday : {Birthday.ToShortDateString()}\n" +
                $"{StudentCard} \n";
        }
    }

    class Auditory : IEnumerable
    {
       
        //Student[]  : Array
        Student[] students;//null
        public Auditory()
        {
            students = new Student[] {
            
                new Student
                {
                     Firstname = "Bob",
                     Lastname = "Nicson",
                     Birthday = new DateTime(2000,12,1),
                     StudentCard = new StudentCard { Number = 111111, Series = "AA"}                        
                },
                 new Student
                {
                     Firstname = "Olga",
                     Lastname = "Ivanchuk",
                     Birthday = new DateTime(2005,8,11),
                     StudentCard = new StudentCard { Number = 222222, Series = "BB"}
                },
                  new Student
                {
                     Firstname = "Ivan",
                     Lastname = "Petruk",
                     Birthday = new DateTime(2007,4,21),
                     StudentCard = new StudentCard { Number = 3333333, Series = "CC"}
                }
            };
        }

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();    
        }

        public void Print()
        {
            foreach (Student student in students) 
            {
                Console.WriteLine(student);
            }
        }
        public void Sort()
        {
            Array.Sort(students);   
        }
        public void Sort(IComparer<Student> comparer)
        {
            Array.Sort(students, comparer);
        }
    }
    class LastNameComparer : IComparer<Student> //IComparer
    {
        //public int Compare(object? x, object? y)
        //{
        //    if (x is Student && y is Student)
        //    {
        //        return ((x as Student).Lastname.CompareTo((y as Student).Lastname));
        //    }
        //    throw new NotImplementedException();
        //}
        public int Compare(Student? x, Student? y)
        {
            return x.Lastname.CompareTo(y.Lastname);
        }
    }
    class DataComparer : IComparer<Student> //IComparer
    {
        //public int Compare(object? x, object? y)
        //{
        //    if (x is Student && y is Student)
        //    {
        //        return ((x as Student).Birthday.CompareTo((y as Student).Birthday));
        //    }
        //    throw new NotImplementedException();
        //}
        public int Compare(Student? x, Student? y)
        {
            return x.Birthday.CompareTo(y.Birthday);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student original = new Student
            {
                Firstname = "Bob",
                Lastname = "Nicson",
                Birthday = new DateTime(2000, 12, 1),
                StudentCard = new StudentCard { Number = 111111, Series = "AA" }
            };
            Console.WriteLine(original);
            Student copy = (Student) original.Clone();
            Console.WriteLine("--------------Copy---------------");
            Console.WriteLine(copy);
            copy.StudentCard.Number = 88888;
            copy.Firstname = "Muroslava";
            copy.Birthday = new DateTime(2022,5,5);
            Console.WriteLine("--------------Change Copy---------------");
            Console.WriteLine(original);
            Console.WriteLine(copy);
            /*
            int[] arr = new int[] { 12, 5, 7, 9, 6, 4 };
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(  );
            Auditory auditory = new Auditory(); 
            auditory.Print();
            Console.WriteLine("----------- Name Sort ----------");
            auditory.Sort();    

            foreach (var st in auditory)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("----------- Last name Sort ----------");
            auditory.Sort(new LastNameComparer());

            foreach (var st in auditory)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("----------- Birthday Sort ----------");
            auditory.Sort(new DataComparer());

            foreach (var st in auditory)
            {
                Console.WriteLine(st);
            }
            */
        }
    }
}
