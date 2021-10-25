using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestaller
{
    public class Item
    {
        public Item() { }

        public Item(int reference, string description, int quantity, 
                       float basePrice, float PVP)
        {
            this.reference = reference;
            this.description = description;
            this.quantity = quantity;
            this.basePrice = basePrice;
            this.PVP = PVP;
        }

        public int reference        { get; set; }
        public string description   { get; set; }
        public int quantity         { get; set; }
        public float basePrice      { get; set; }
        public float PVP            { get; set; }
    }
}
