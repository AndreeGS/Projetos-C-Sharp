using System;
using Sistema_de_Pedidos.Entities;
using Sistema_de_Pedidos.Entities.Enums;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter client data: ");
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Birth date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Client client = new Client(name, email, date);

        Console.WriteLine("Enter Order data: ");
        Console.Write("Status: ");
        OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

        Console.Write("How many items to this order? ");
        int qtd = int.Parse(Console.ReadLine());

        DateTime dtNow = DateTime.Now;

        for (int i = 1; i < qtd; i++)
        {
            Console.WriteLine($"Product {i}: ");
            Console.Write("Product name: ");
            string productName = Console.ReadLine();

            Console.Write("Product price: ");
            double productPrice = double.Parse(Console.ReadLine());

            Console.Write("Quantity: ");
            int productQtd = int.Parse(Console.ReadLine());


            Product product = new Product(productName, productPrice);

            OrderItem orderItem = new OrderItem(productQtd, productPrice, product);
        }


        Order order = new Order(dtNow, status, orderItem, client);

        order.addItem(order)
    }
}