using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconShopping.MessageContracts.Models
{
    public class CreditCard
    {
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string CVV { get; set; }
    }
}
