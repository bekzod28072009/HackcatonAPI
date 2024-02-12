using Hackaton.Domain.Entity.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Service.DTOs
{
    public class OrderInFoodDto
    {
        public Food Foods { get; set; }
        public int Amount { get; set; }
        public int Prise { get; set; }
    }
}
