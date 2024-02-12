using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Service.DTOs
{
    public class TableDto
    {
        public string Info { get; set; }
        public OrderDto? Order { get; set; }
    }
}
