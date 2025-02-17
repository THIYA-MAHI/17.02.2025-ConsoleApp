using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class employee: person
    {
        private string jobTitle;
        private double salary;
        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public employee(string name, int age, string jobTitle, double salary) : base(name, age)
        {
            this.jobTitle = jobTitle;
            this.salary = salary;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Job Title: " + jobTitle);
            Console.WriteLine("Salary: " + salary);
        }
        public override void PrintGreeting()
        {
            Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old. I work as a " + jobTitle + " and make " + salary + " a month.");
        }
    }
   
 }
