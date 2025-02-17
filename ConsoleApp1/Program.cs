namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            employee[] employees = new employee[numberOfEmployees];

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine($"\nEnter details for Employee {i + 1}:");

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                int age;
                while (true)
                {
                    Console.Write("Enter Age: ");
                    if (int.TryParse(Console.ReadLine(), out age) && age > 0)
                        break;
                    Console.WriteLine("Invalid input! Please enter a valid age.");
                }

                Console.Write("Enter Job Title: ");
                string jobTitle = Console.ReadLine();

                double salary;
                while (true)
                {
                    Console.Write("Enter Salary: ");
                    if (double.TryParse(Console.ReadLine(), out salary) && salary > 0)
                        break;
                    Console.WriteLine("Invalid input! Please enter a valid salary.");
                }

                employees[i] = new employee(name, age, jobTitle, salary);
            }

            GreetingService greetingService = new GreetingService();

            Console.WriteLine("\nEmployee Details and Greetings:\n");

            foreach (var employee in employees)
            {
                greetingService.GenerateGreeting(employee); 
                employee.DisplayInfo();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
