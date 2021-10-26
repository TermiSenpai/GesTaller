using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestaller
{
    public class ContactVehicle
    {
        public ContactVehicle(Contact contact, Vehicle vehicle) 
        {
            this.contact = contact;
            this.vehicle = vehicle;
        }

        public Contact contact { get; set; }
        public Vehicle vehicle { get; set; }
    }
}
