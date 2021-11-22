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
            firstContact.cif = "CIF 1";
            firstContact.cp = 20103;
            firstContact.address = "Avenida de Castilla";
            firstContact.city = "Guadalajara";
            firstContact.district = "Guadalajara";
            firstContact.email = "roberto_sencillo@gmail.com";
            firstContact.fax = "fax 1";
            firstContact.phone = "949 89 81 23";
            firstContact.mobile = "623 25 78 57"; 
            
            Contact secondContact = new Contact();
            secondContact.id = 2;
            secondContact.company = "company2";
            secondContact.fullName = "Samuel complicado";
            secondContact.cif = "CIF 2";
            secondContact.cp = 19003;
            secondContact.address = "Calle de Méndez álvaro";
            secondContact.city = "Madrid";
            secondContact.district = "Madrid";
            secondContact.email = "Samuel_complicado@gmail.com";
            secondContact.fax = "FAX 2";
            secondContact.phone = "989 87 75 29";
            secondContact.mobile = "684 11 23 16";

            contacts.Add(firstContact);
            contacts.Add(secondContact);

            return contacts;
        }

        public List<Vehicle> GetVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle firstVehicle = new Vehicle();

            firstVehicle.id = 1; 
            firstVehicle.enroll = "Matricula 1";
            firstVehicle.brand = "Marca 1";
            firstVehicle.model = "Modelo 1";
            firstVehicle.kms = "123100";
            firstVehicle.discharge = "Discharge";
            firstVehicle.expiration = "Expiracion";
            firstVehicle.engineType = "TipoMotor 1";
            firstVehicle.frame = "Bastidor 1";
            
            Vehicle secondVehicle = new Vehicle();

            secondVehicle.id = 2; 
            secondVehicle.enroll = "Matricula 2";
            secondVehicle.brand = "Marca 2";
            secondVehicle.model = "Modelo 2";
            secondVehicle.kms = "65489716";
            secondVehicle.discharge = "Dicharge 2";
            secondVehicle.expiration = "Expiracion 2";
            secondVehicle.engineType = "TipoMotor 2";
            secondVehicle.frame = "Bastidor 2";

            vehicles.Add(firstVehicle);
            vehicles.Add(secondVehicle);

            return vehicles;
        }


        public List<Incoming> GetIncomings()
        {
            // año, mes, día
            List<Incoming> incomings = new List<Incoming>();
            incomings.Add(new Incoming(new DateTime(2021, 5, 1), new DateTime(2021, 5, 20), new DateTime(2021, 5, 10), "Daño leve", 123131.1231f));
            incomings.Add(new Incoming(new DateTime(2008, 3, 1), new DateTime(2008, 4, 1), new DateTime(2008, 4, 10), "Daño grave", 6459f));
            return incomings;
        }

        public List<Item> GetItems()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item(1, "Aceite repsol", 100, 0.05f, 0.10f));
            items.Add(new Item(2, "Rueda ferrari", 10, 50.05f, 55.10f));
            return items;
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            orders.Add(new Order(1, 1, 1, 1, new DateTime(2018, 3, 1), new DateTime(2018, 5, 1), new DateTime(2018, 10, 1)));
            orders.Add(new Order(2, 2, 2, 2, new DateTime(2020, 3, 1), new DateTime(2021, 10, 1), new DateTime(2020, 12, 1)));
            return orders;
        }

        public List<TaxRate> GetTaxRate()
        {
            List<TaxRate> taxRates = new List<TaxRate>();
            taxRates.Add(new TaxRate(1, "Tax1"));
            return taxRates;
        }

        public void addContact(Contact contact)
        {
            contact.id = _contacts.Count();

            _contacts.Add(contact);
        }

        public void addVehicle(Vehicle vehicle)
        {
            vehicle.id = _vehicles.Count();

            _vehicles.Add(vehicle);
        }
    }
}
