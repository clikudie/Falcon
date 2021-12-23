using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconShopping.MessageContracts
{
    public class RabbitMqConstants
    {
        public const string RabbitMqUri = "rabbitmq://localhost/";
        public const string UserName = "guest";
        public const string Password = "guest";
        public const string EmailerServiceQueue = "emailer.service";
        public const string SalesServiceQueue = "sales.service";
        public const string PaymentServiceQueue = "payment.service";
    }
}
