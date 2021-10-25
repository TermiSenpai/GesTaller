using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestaller
{
    public class Order
    {
        public Order() { }

        public Order(int status, int numBudget, int numProForma, int numInvoice,
                    DateTime dateBudget, DateTime dateProForma, DateTime dateInvoice)
        {
            this.status = status;
            this.numBudget = numBudget;
            this.numProForma = numProForma;
            this.numInvoice = numInvoice;
            this.dateBudget = dateBudget;
            this.dateProForma = dateProForma;
            this.dateInvoice = dateInvoice;
        }

        public int status                  { get; set; }
        public int numBudget               { get; set; }
        public int numProForma             { get; set; }
        public int numInvoice              { get; set; }
        public DateTime dateBudget         { get; set; }
        public DateTime dateProForma       { get; set; }
        public DateTime dateInvoice        { get; set; }

    }
}
