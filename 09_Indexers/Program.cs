using System.Collections.Specialized;
using System.Reflection;

namespace _09_Indexers
{
    class Laptop : Object
    {
        public string Model { get; set; }//""
        public double Price { get; set; }//0

        public void Print()
        {
            Console.WriteLine($"{Model}  {Price}");
        }
        public override string ToString()
        {
            return $"{Model}  {Price}";
        }
    }
    class Shop
    {
        //int a;//0
        //double b;//0
        //bool flag;// = false;
        //string name;//
        //string surname = "Ivanchuck";
        //int[] arr;// = new int[3] { 1, 2, 3 };
        Laptop[] laptops; //null
        public Shop(int size)
        {
            laptops = new Laptop[size];
        }
        public int Length { get { return laptops.Length; }  }

        public Laptop GetLaptop(int index) 
        { 
            if(index >= 0 && index < laptops.Length)
            {
                return laptops[index];
            }
            else
            {
               throw new IndexOutOfRangeException();    
            }           
        }
        public void SetLaptop(Laptop value, int index)
        {
            if (index >= 0 && index < laptops.Length)
            {
                 laptops[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public Laptop this[int index]
        {
            get 
            {
                if (index >= 0 && index < laptops.Length)
                {
                    return laptops[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set 
            {
                if (index >= 0 && index < laptops.Length)
                {
                    laptops[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }

        }
        public Laptop this[string model]
        {
            get
            {
                for (int i = 0; i < laptops.Length; i++)
                {
                    if (laptops[i].Model == model)
                    {
                        return laptops[i];
                    }
                }
                return null;
            }
            private set
            {
                for (int i = 0; i < laptops.Length; i++)
                {
                    if (laptops[i].Model == model)
                    {
                        laptops[i] = value;
                        break;
                    }
                }

            }
        }
        public int FindByPrice(double price)
        {
            for (int i = 0; i < laptops.Length; i++)
            {
                if (laptops[i].Price == price)
                {
                    return i;
                }
            }
            return -1;
        }
        public Laptop this[double price]
        {
            get
            {
                int index = FindByPrice(price); 
                if(index != -1)
                {
                    return laptops[index];  
                }
                else
                {
                    throw new Exception("Incorrect price");
                }
            }
            set
            {
                int index = FindByPrice(price);
                if (index != -1)
                {
                    laptops[index] = value;
                }
                else
                {
                    throw new Exception("Incorrect price");
                }
            }


        }




        }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop(3);
            //shop.SetLaptop(new Laptop() { Model = "HP", Price = 20000 }, 0);
            //Console.WriteLine(shop.GetLaptop(0)); 

            shop[0] = new Laptop() { Model = "HP", Price = 20000.33 };//set
            shop[1] = new Laptop() { Model = "Samsung", Price = 35000.85 };//set
            shop[2] = new Laptop() { Model = "Dell", Price = 15000.99 };//set
            var laptop = shop[0];
            Console.WriteLine(laptop);


            shop[15000.99] = new Laptop() { Model = "Mac", Price = 1000000.00 };
            Console.WriteLine(shop[1000000.00]);
            //shop["HP"] = new Laptop() {  Model = "Mac", Price = 1000000.00};  

            try
            {
                for (int i = 0; i < shop.Length + 5; i++)
                {
                    Console.WriteLine(shop[i]);//get
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            //Laptop laptop = new Laptop();
            //laptop.Model = "HP";
            //laptop.Price = 36000.99;
            //laptop.Print();
            //Console.WriteLine("My laptop");
            //Console.WriteLine(laptop.ToString());

        }
    }
}
