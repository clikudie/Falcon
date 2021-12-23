using MassTransit;
using MassTransit.RabbitMqTransport;

namespace FalconShopping.MessageContracts
{
    public static class MessagingBus
    {
        public static IBusControl ConfigureBus(Action<IRabbitMqBusFactoryConfigurator> registrationAction = null)
        {
            return Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                cfg.Host(new Uri(RabbitMqConstants.RabbitMqUri), hst =>
                {
                    hst.Username(RabbitMqConstants.UserName);
                    hst.Password(RabbitMqConstants.Password);
                });

                registrationAction?.Invoke(cfg);
            });
        }
    }
}