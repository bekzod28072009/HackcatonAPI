using Hackaton.Domain.Commons;
using Hackaton.Domain.Entity.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Domain.Entity.Orders
{
    public class OrderInFood : Auditable
    {
        public Food Foods { get; set; }
        public int Amount { get; set; }
        public int Prise { get; set; }
    }
}
