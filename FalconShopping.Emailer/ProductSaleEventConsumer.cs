using FalconShopping.MessageContracts.Models;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconShopping.Emailer
{
    public class ProductSaleEventConsumer : IConsumer<IProductSaleEvent>
    {
        public Task Consume(ConsumeContext<IProductSaleEvent> context)
        {
            var message = context.Message;
            Console.Write("Email sent to {0}", message.User.Email);

            return Task.CompletedTask;
        }
    }
}
