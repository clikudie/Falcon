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
            var sendUri = new Uri($"{RabbitMqConstants.RabbitMqUri}{RabbitMqConstants.EmailerServiceQueue}");
            var endpoint = await messageBus.GetSendEndpoint(sendUri);
            await endpoint.Send<IProductSaleCommand>(model);
            //await messageBus.Publish<IProductSaleCommand>(model);
            return Ok();
        }
    }
}
