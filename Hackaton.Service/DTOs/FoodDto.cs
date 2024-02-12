using Hackaton.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Service.DTOs
{
    public class FoodDto
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public int Prise { get; set; }
        public Mail Mails { get; set; }
    }
}
