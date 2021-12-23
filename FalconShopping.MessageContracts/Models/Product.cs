using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconShopping.MessageContracts.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
}
