using Calcular_Imposto.Entities;
using System.Globalization;

namespace Calcular_Imposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine());   

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine());

                    list.Add(new Individual(name, income, health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, income, employees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Taxes paid: ");

            double sum = 0;

            foreach (Person person in list)
            {
                double tax = person.taxCalculation();

                Console.WriteLine(person.Name + ": $" + tax.ToString("F2", CultureInfo.InvariantCulture));

                sum += tax;
            }

            Console.WriteLine($"\nTotal taxes: ${sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}