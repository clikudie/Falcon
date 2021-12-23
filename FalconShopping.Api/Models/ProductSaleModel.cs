using FalconShopping.MessageContracts.Models;

namespace FalconShopping.Api.Models
{
    public class ProductSaleModel : IProductSaleCommand
    {
        public Product Product { get; set; }
        public User User { get; set; }
        public CreditCard CreditCard { get; set; }
    }
}
