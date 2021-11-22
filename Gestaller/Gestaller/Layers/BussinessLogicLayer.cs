using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestaller
{
    class BussinessLogicLayer
    {
        private DataLayerDummie _dataLayerDummie;
        public BussinessLogicLayer()
        {
            _dataLayerDummie = new DataLayerDummie();
        }
        public List<Contact> GetContacts()
        {
            return _dataLayerDummie.GetContacts();
        }

        public List<Vehicle> GetVehicles()
        {
            return _dataLayerDummie.GetVehicles();
        }

        public List<ContactVehicle> GetContactVehicles()
        {
            List<ContactVehicle> contactsVehicles = new List<ContactVehicle>();
            List<Contact> contacts = _dataLayerDummie.GetContacts();
            List<Vehicle> vehicles = _dataLayerDummie.GetVehicles();
            ContactVehicle first = new ContactVehicle(contacts[0], vehicles[0]);
            ContactVehicle second = new ContactVehicle(contacts[1], vehicles[1]);
            contactsVehicles.Add(first);
            contactsVehicles.Add(second);

            return contactsVehicles;
        }

        public List<Incoming> GetIncomings()
        {
            return _dataLayerDummie.GetIncomings();
        }

        public List<Item> GetItems()
        {
            return _dataLayerDummie.GetItems();
        }

        public List<Order> GetOrders()
        {
            return _dataLayerDummie.GetOrders();
        }

        public List<TaxRate> GetTaxRate()
        {
            return _dataLayerDummie.GetTaxRate();
        }

        public void newContact(Contact contact)
        {
            _dataLayerDummie.addContact(contact);
        }

        public void newVehicle(Vehicle vehicle)
        {
            _dataLayerDummie.addVehicle(vehicle);
        }
    }
}
