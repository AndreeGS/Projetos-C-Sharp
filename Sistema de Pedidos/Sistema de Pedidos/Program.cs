using System;
using System.Globalization;
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


        Console.WriteLine("Enter Order data: ");
        Console.Write("Status: ");
        OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

        Client client = new Client(name, email, date);
        Order order = new Order(DateTime.Now, status, client);


        Console.Write("How many items to this order? ");
        int n = int.Parse(Console.ReadLine());

        DateTime dtNow = DateTime.Now;

        for (int i = 1; i < n; i++)
        {
            Console.WriteLine($"Product {i}: ");
            Console.Write("Product name: ");
            string productName = Console.ReadLine();

            Console.Write("Product price: ");
            double productPrice = double.Parse(Console.ReadLine());

            Product product = new Product(productName, productPrice);


            Console.Write("Quantity: ");
            int productQtd = int.Parse(Console.ReadLine());

            OrderItem orderItem = new OrderItem(productQtd, productPrice, product);

            order.addItem(orderItem);
        }


        Console.WriteLine();
        Console.WriteLine("ORDER SUMMARY:");
        Console.WriteLine(order);

    }
}