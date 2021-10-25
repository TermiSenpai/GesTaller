using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestaller.DataClasses
{
    public class Order2Item
    {
        Order2Item() { }

        Order2Item(int quantity, float basePrice, float taxRate, int discount)
        {
            this.quantity = quantity;
            this.basePrice = basePrice;
            this.taxRate = taxRate;
            this.discount = discount;
        }

        public int quantity         { get; set; }
        public float basePrice      { get; set; }
        public float taxRate        { get; set; }
        public int discount         { get; set; }
    }
}
