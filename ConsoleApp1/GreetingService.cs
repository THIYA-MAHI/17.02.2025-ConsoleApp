using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GreetingService
    {
        public void GenerateGreeting(person person)
        {
            person.PrintGreeting();
        }
    }
}
