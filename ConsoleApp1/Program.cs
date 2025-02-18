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
                    try
                    {
                        age = int.Parse(Console.ReadLine());
                        if (age > 0)
                            break;
                        else
                            Console.WriteLine("Age must be greater than zero. Please enter a valid age.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input! Please enter a valid integer for age.");
                    }
                }

                Console.Write("Enter Job Title: ");
                string jobTitle = Console.ReadLine();

                double salary;
                while (true)
                {
                    Console.Write("Enter Salary: ");
                    try
                    {
                        salary = double.Parse(Console.ReadLine());
                        if (salary > 0)
                            break;
                        else
                            Console.WriteLine("Salary must be greater than zero. Please enter a valid salary.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number for salary.");
                    }
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
