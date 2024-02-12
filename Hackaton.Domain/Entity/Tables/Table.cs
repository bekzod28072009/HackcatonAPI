using Hackaton.Domain.Commons;
using Hackaton.Domain.Entity.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Domain.Entity.Tables
{
    public class Table : Auditable
    {
        public string Info { get; set; }
        public Order? Order { get; set; }
    }
}
