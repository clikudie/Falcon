using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconShopping.MessageContracts.Models
{
    public interface IProductSaleEvent
    {
        public Guid Id { get; set; }
        public User User { get; set; }
    }
}
