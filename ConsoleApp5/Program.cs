using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп_c_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new Animals();
            Console.WriteLine(cat.getinfo());
            Animals dog = new Animals();
           
        }
    }

    class Animals
    {
        public string Type;
        public int Age;
        public string Name;
        public string Sound;

        public Animals()
        {
            Type = "ыыыыыыы";
            Age = 12;
            Name = "Дибил";
            Sound = "ыыы";
        }

        public Animals(string type, int age, string name,string sound)
        {
            Type = type;
            Age = age;
            Name = name;
            Sound = sound;
        }

        public string type
        {
            get { return Type; }
            set
            {
                if (value == null || value == "")
                {
                    Console.WriteLine("You have to enter a type");
                }
                else Type = value;
            }
        }
        public int age
        {
            get { return Age; }
            set
            { 
                    Console.WriteLine("You have to enter an age");
            }
        }
        public string name
        {
            get { return Name; }
            set
            {
                if (value == null || value == "")
                {
                    Console.WriteLine("You have to enter a name");
                }
                else Name = value;
            }
        }
        public string sound
        {
            get { return Sound; }
            set
            {
                if (value == null || value == "")
                {
                    Console.WriteLine("You have to enter a sound");
                }
                else Sound = value;
            }
        }
        public string getinfo()
        {
            return $"\nВид: {type}\nВозраст: {age} \nКличка: {name}";
        }

        public string sayHello()
        {
            return sound;
        }
    }

}
