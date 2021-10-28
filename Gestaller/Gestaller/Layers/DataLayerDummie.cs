using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestaller
{
    class DataLayerDummie
    {
        public List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();

            Contact firstContact = new Contact();
            firstContact.id = 1;
            firstContact.company = "company1";
            firstContact.fullName = "Roberto Sencillo";
            firstContact.cif = "12312321vad";
            firstContact.cp = 199903;
            firstContact.address = "General Ramón yo que se";
            firstContact.city = "Guadalajara";
            firstContact.district = "Guadalajara";
            firstContact.email = "asdfas@gmail.com";
            firstContact.fax = "nosequesunfax";
            firstContact.phone = "989898123";
            firstContact.mobile = "91382411231"; 
            
            Contact secondContact = new Contact();
            secondContact.id = 2;
            secondContact.company = "company2";
            secondContact.fullName = "Roberto complicado";
            secondContact.cif = "778212A";
            secondContact.cp = 199903;
            secondContact.address = "callecita Ramón yo que se";
            secondContact.city = "Marchamalo";
            secondContact.district = "Marchamalo";
            secondContact.email = "caracol@gmail.com";
            secondContact.fax = "nosequesunfax2";
            secondContact.phone = "9898775298123";
            secondContact.mobile = "11231654";

            contacts.Add(firstContact);
            contacts.Add(secondContact);

            return contacts;
        }

        public List<Vehicle> GetVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle firstVehicle = new Vehicle();

            firstVehicle.id = 1; 
            firstVehicle.enroll = "123VCA";
            firstVehicle.brand = "Mercedes";
            firstVehicle.model = "benQ";
            firstVehicle.kms = "1231";
            firstVehicle.discharge = "sdaf";
            firstVehicle.expiration = "Today";
            firstVehicle.engineType = "motorola";
            firstVehicle.frame = "12313123asfsadf";
            
            Vehicle secondVehicle = new Vehicle();

            secondVehicle.id = 2; 
            secondVehicle.enroll = "987CA";
            secondVehicle.brand = "6548764";
            secondVehicle.model = "Citroen";
            secondVehicle.kms = "65489716";
            secondVehicle.discharge = "1231313131";
            secondVehicle.expiration = "10-10";
            secondVehicle.frame = "123asda";
            secondVehicle.engineType = "Tipo lento";

            vehicles.Add(firstVehicle);
            vehicles.Add(secondVehicle);

            return vehicles;
        }


        public List<Incoming> GetIncomings()
        {
            List<Incoming> incomings = new List<Incoming>();
            incomings.Add(new Incoming(DateTime.Now, DateTime.UtcNow, DateTime.Today, "Daño leve", 123131.1231f));
            incomings.Add(new Incoming(DateTime.Now, DateTime.UtcNow, DateTime.Today, "Daño grave", 1231331f));
            return incomings;
        }

        public List<Item> GetItems()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item(1, "Caramelo con sabor caramelo", 100, 0.05f, 0.10f));
            items.Add(new Item(2, "Gato pelado", 10, 50.05f, 55.10f));
            return items;
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            orders.Add(new Order(1, 1, 1, 1, DateTime.Now, DateTime.Now, DateTime.Now));
            orders.Add(new Order(2, 2, 2, 2, DateTime.Now, DateTime.Now, DateTime.Now));
            return orders;
        }

        public List<TaxRate> GetTaxRate()
        {
            List<TaxRate> taxRates = new List<TaxRate>();
            taxRates.Add(new TaxRate(1, "Tax1"));
            return taxRates;
        }
    }
}
