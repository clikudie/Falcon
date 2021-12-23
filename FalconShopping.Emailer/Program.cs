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
                    e.Consumer<ProductSaleCommandConsumer>();
                });
            });

            messageBus.StartAsync();
            Console.WriteLine("Listening for sales commands");
            Console.ReadLine();

            messageBus.StopAsync();
        }
    }
}