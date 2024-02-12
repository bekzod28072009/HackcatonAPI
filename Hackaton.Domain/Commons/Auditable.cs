using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Domain.Commons
{
    public class Auditable
    {
        public int Id { get; set; }

        public string MyProperty { get; set; } = DateTime.Now.ToString();
    }
}
