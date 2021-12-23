using FalconShopping.MessageContracts.Models;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconShopping.Sales
{
    internal class ProductSaleCommandConsumer : IConsumer<IProductSaleCommand>
    {
        public Task Consume(ConsumeContext<IProductSaleCommand> context)
        {
            var message = context.Message;
            Console.Write("Processing sales {0}", message.Product.Name);

            return Task.CompletedTask;
        }
    }
}
