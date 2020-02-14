using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urok9
{
    class Student
    {
        private string name;
        private int course;
        private bool grant;
        private int age;

        public string Name
        {
            private get // получить значения
            {
                return name;
            }

            set // устанавлиаем
            {
                name = value; //устанавливает новые значения
            }
        }

        public int Age
        {
            private get
            {
                return age;
            }

            set
            {
                if (value > 16)
                {
                    age = value;
                }
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, course:{course}, grant:{grant}");
        }
    }

    class Animal
    {
        string name = "Georgia";
        string color = "grey";
        int age = 3;
        bool ishome = false;

        public Animal() { }
        public Animal( string name)
        {
            this.name = name;
        }
        public Animal(string name, string color, int age, bool isHome)
        {
            this.name = name;
            this.color = color;
            this.age = age;
            this.ishome = isHome;
            
        }

        public string Name { get { return name; } set { name = value; } }
        public string Color { get { return color; } set { color = value; } }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }

        }
        
        public bool isHome { get { return ishome; } set { ishome = value; } }
    
    public virtual void animalInfo()
    {
        Console.WriteLine($"Name:{name}, Color:{color}, Age:{age}, Home:{ishome}");
      }

  }


     class Dog : urok9.Animal
     {
         float speed;
    public Dog(float speed , string name) : base(name)
    {
        this.speed = speed;
    }
   
    public float Speed
    {
        get{
            return speed;
        }
        set{
            speed = value;
        }
    }
        public override void animalInfo()
        {
            base.animalInfo();
            Console.WriteLine($"Speed: {speed}");
        }
    }
     class Employee
    {

    }

    class Program
    {
        static void Main(string[] args)
        {

        /* Student jo = new Student();
         jo.Name = "rem";
         jo.Age = 18;
         jo.DisplayInfo();


         Student rem = new Student();
         rem.Name = "jo";
         rem.Age = 18;
         rem.DisplayInfo();

         Console.ReadKey();

         } */

        urok9.Animal jo = new urok9.Animal("jo", "Red", 2, false);
        Console.WriteLine(jo.Name);
         Console.WriteLine(jo.Color);
         Console.WriteLine(jo.Age);





        Dog kek = new Dog(5.78f);
        kek.Name = "lol";
        Console.WriteLine(kek.Name);
        Console.WriteLine(kek.Speed);




        Console.ReadKey();

    }
    }

