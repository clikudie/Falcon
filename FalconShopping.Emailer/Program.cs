using FalconShopping.MessageContracts;
using MassTransit;

namespace FalconShopping.Emailer
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.Title = "Emailer";

            var messageBus = MessagingBus.ConfigureBus((cfg) =>
            {
                cfg.ReceiveEndpoint(RabbitMqConstants.EmailerServiceQueue, e =>
                {
                    e.Consumer<ProductSaleEventConsumer>();
                });
            });

            messageBus.StartAsync();
            Console.WriteLine("Emailer listening for sales events...");
            Console.ReadLine();

            messageBus.StopAsync();
        }
    }
}