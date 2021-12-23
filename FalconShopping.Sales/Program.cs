using FalconShopping.MessageContracts;
using MassTransit;

namespace FalconShopping.Sales
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Sales";

            var messageBus = MessagingBus.ConfigureBus((cfg) =>
            {
                cfg.ReceiveEndpoint(RabbitMqConstants.SalesServiceQueue, e =>
                {
                    e.Consumer<ProductSaleCommandConsumer>();
                });
            });

            messageBus.StartAsync();
            Console.WriteLine("Sales Service listening for sales commands...");
            Console.ReadLine();

            messageBus.StopAsync();
        }
    }
}
