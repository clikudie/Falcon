using FalconShopping.Api.Models;
using FalconShopping.MessageContracts;
using FalconShopping.MessageContracts.Models;
using Microsoft.AspNetCore.Mvc;

namespace FalconShopping.Api.Controllers
{
    [ApiController]
    [Route("api/sales")]
    public class SalesController : ControllerBase
    {

        public SalesController()
        { }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductSaleModel model)
        {
            var messageBus = MessagingBus.ConfigureBus();

            ProductSaleEvent saleEvent = new()
            {
                User = model.User
            };
            await messageBus.Publish<IProductSaleEvent>(saleEvent);

            var sendUri = new Uri($"{RabbitMqConstants.RabbitMqUri}{RabbitMqConstants.SalesServiceQueue}");
            var endpoint = await messageBus.GetSendEndpoint(sendUri);
            await endpoint.Send<IProductSaleCommand>(model);

            return Ok();
        }
    }
}
