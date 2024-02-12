using Hackaton.Domain.Entity.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Service.DTOs
{
    public class OrderDto
    {
        public List<OrderInFood> Foods { get; set; }
        public int Prise { get; set; }
    }
}
