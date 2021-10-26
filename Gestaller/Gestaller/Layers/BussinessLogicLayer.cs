using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestaller.Layers
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
            List<ContactVehicle> contactVehicle = new List<ContactVehicle>();
            List<Contact> contacts = _dataLayerDummie.GetContacts();
            List<Vehicle> vehicles = _dataLayerDummie.GetVehicles();
            contactVehicle.Add(new ContactVehicle(contacts[0],vehicles[0]));
            return contactVehicle;
        }
    }
}
