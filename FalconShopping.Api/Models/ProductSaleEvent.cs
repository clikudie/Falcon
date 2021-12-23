using FalconShopping.MessageContracts.Models;

namespace FalconShopping.Api.Models
{
    public class ProductSaleEvent : IProductSaleEvent
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public User User { get; set; }
    }
}
