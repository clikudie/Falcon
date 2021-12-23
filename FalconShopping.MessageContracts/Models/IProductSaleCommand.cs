using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconShopping.MessageContracts.Models
{
    public interface IProductSaleCommand
    {
        public Product Product { get; set; }
        public User User { get; set; }
        public CreditCard CreditCard { get; set; }
    }
}
