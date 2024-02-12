using Hackaton.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Domain.Entity.Orders
{
    public class Order : Auditable
    {
        public List<OrderInFood> Foods { get; set; }
        public int Prise { get; set; }

        public Order()
        {
            Foods = new List<OrderInFood>();
        }
    }
}
