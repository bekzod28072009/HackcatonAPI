using Hackaton.Domain.Commons;
using Hackaton.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Domain.Entity.Foods
{
    public class Food : Auditable
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public int Prise { get; set; }
        public Mail Mails { get; set; }
    }
}
