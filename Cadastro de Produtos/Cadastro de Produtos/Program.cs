using Cadastro_de_Produtos.Entities;

namespace Cadastro_de_Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Commom, used or imported (c/u/i)? ");

                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());

                    products.Add(new ImportedProduct(name, price, fee));
                }

                else if (type == 'u') 
                {
                    Console.Write("Manufacture (DD/MM/YYYY): ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufacture));
                }

                else
                {
                    products.Add(new Product(name, price));
                }

            }

            Console.WriteLine("\nPRICE TAGS: ");

            foreach (Product product in products)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}