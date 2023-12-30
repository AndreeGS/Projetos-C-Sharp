using Sistema_de_Pedidos.Entities.Enums;

namespace Sistema_de_Pedidos.Entities
{
    internal class Order
    {
        public DateTime Moment {  get; set; }

        //Order Status
        public OrderStatus Status { get; set; }

        //OrderItem
        public OrderItem Item { get; set; }

        //Client
        public Client Client { get; set; }

        //OrderItem List
        public Queue<OrderItem> Items { get; set; } = new Queue<OrderItem>();

        //Constructors
        public Order() { }
        public Order(DateTime moment, OrderStatus status, OrderItem Item, Client client)
        {
            Moment = moment;
            Status = status;
            this.Item = Item;
            this.Client = client;
        }

        //Add to List
        public void addItem (Order) 
        {
            Items.Add(Order);
        }

        public void removeItem()
        {
            Items.Remove();
        }

        public double Total()
        {

        }
    }
}
