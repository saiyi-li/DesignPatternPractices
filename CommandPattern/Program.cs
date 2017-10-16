using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock abcStock = new Stock();

            BuyStock buyStockOrders = new BuyStock(abcStock);
            SellStock sellStockOrders = new SellStock(abcStock);

            Broker broker = new Broker();
            broker.TakeOrder(buyStockOrders);
            broker.TakeOrder(sellStockOrders);

            broker.PlaceOrders();

            Console.Read();
        }
    }
}
