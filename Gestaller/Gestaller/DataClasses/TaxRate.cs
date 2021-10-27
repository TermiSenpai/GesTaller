using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestaller
{
    public class TaxRate
    {
        public TaxRate() { }

        public TaxRate(int value, string description)
        {
            this.value = value;
            this.description = description;
        }

        public int value { get; set; }
        public string description { get; set; }
    }
}
