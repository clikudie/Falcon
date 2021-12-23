using FalconShopping.MessageContracts.Models;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconShopping.Emailer
{
    public class ProductSaleCommandConsumer : IConsumer<IProductSaleCommand>
    {
        public Task Consume(ConsumeContext<IProductSaleCommand> context)
        {
            var message = context.Message;
            Console.Write("Message received. Forwarding sales email to " + message.User.Email);

            return Task.CompletedTask;
        }
    }
}
