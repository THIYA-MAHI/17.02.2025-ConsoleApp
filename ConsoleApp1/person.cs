using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public abstract void DisplayInfo();

        public virtual void PrintGreeting()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }

    }
}
