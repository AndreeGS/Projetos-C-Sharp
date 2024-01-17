using SistemaBancarioSimples.Entities;
using System.Globalization;

namespace SistemaBancarioSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter Account data ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balanceInitial = double.Parse(Console.ReadLine());

                Console.Write("Withdraw limit: ");
                double withdrawlimit = double.Parse(Console.ReadLine());

                Account acc = new Account(number, holder, balanceInitial, withdrawlimit);

                Console.Write("\nEnter amount for withdraw: ");
                double valueSaque = double.Parse(Console.ReadLine());

                try
                {
                    acc.withdraw(valueSaque);
                    Console.WriteLine("New balance: " + acc.balanceHolder.ToString("F2", CultureInfo.InvariantCulture));

                }
                catch (SystemException ex)
                {
                    Console.WriteLine("WithDraw error: " + ex.Message);
                }
            }
            catch (SystemException ex)
            {
                Console.WriteLine("Algo deu errado!" + ex.Message);
            }
        }
    }
}