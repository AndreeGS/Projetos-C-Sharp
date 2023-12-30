using Sistema_de_Pedidos.Entities.Enums;
using System.Globalization;
using System.Text;

namespace Sistema_de_Pedidos.Entities
{
    internal class Order
    {
        public DateTime Moment {  get; set; }    
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        //Constructors
        public Order() { }
        public Order(DateTime moment, OrderStatus status , Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        //Add to List
        public void addItem(OrderItem obj) 
        {
            Items.Add(obj);
        }

        public void removeItem(OrderItem obj)
        {
            Items.Remove(obj);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");

            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));


            return sb.ToString();
        }
    }
}
