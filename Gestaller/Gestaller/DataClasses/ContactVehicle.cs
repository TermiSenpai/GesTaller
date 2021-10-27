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

        private Contact contact = new Contact();
        private Vehicle vehicle = new Vehicle();



        public int contact_id
        {
            get { return this.contact.id; }
            set { this.contact.id = contact_id; }
        }

        public int vehicle_id
        {
            get { return this.vehicle.id; }
            set { this.vehicle.id = vehicle_id; }
        }


        #region contact

        public string contact_company
        {
            get { return this.contact.company; }
            set { this.contact.company = contact_company; }
        }
        public string contact_fullName
        {
            get { return this.contact.fullName; }
            set { this.contact.fullName = contact_fullName; }
        }
        public string contact_cif
        {
            get { return this.contact.cif; }
            set { this.contact.cif = contact_cif; }
        }
        public string contact_address
        {
            get { return this.contact.address; }
            set { this.contact.address = contact_address; }
        }
        public string contact_city
        {
            get { return this.contact.city; }
            set { this.contact.city = contact_city; }
        }
        public int contact_cp
        {
            get { return this.contact.cp; }
            set { this.contact.cp = contact_cp; }
        }
        public string contact_district
        {
            get { return this.contact.district; }
            set { this.contact.district = contact_district; }
        }
        public string contact_email
        {
            get { return this.contact.email; }
            set { this.contact.email = contact_email; }
        }
        public string contact_fax
        {
            get { return this.contact.fax; }
            set { this.contact.fax = contact_fax; }
        }
        public string contact_phone
        {
            get { return this.contact.phone; }
            set { this.contact.phone = contact_phone; }
        }
        public string contact_mobile
        {
            get { return this.contact.mobile; }
            set { this.contact.mobile = contact_mobile; }
        }
        #endregion

        #region vehicle
        public string vehicle_enroll
        {
            get { return this.vehicle.enroll; }
            set { this.vehicle.enroll = vehicle_enroll; }
        }
        public string vehicle_brand
        {
            get { return this.vehicle.brand; }
            set { this.vehicle.brand = vehicle_brand; }
        }
        public string vehicle_model
        {
            get { return this.vehicle.model; }
            set { this.vehicle.model = vehicle_model; }
        }
        public string vehicle_kms
        {
            get { return this.vehicle.kms; }
            set { this.vehicle.kms = vehicle_kms; }
        }
        public string vehicle_frame
        {
            get { return this.vehicle.frame; }
            set { this.vehicle.frame = vehicle_frame; }
        }
        public string vehicle_discharge
        {
            get { return this.vehicle.discharge; }
            set { this.vehicle.discharge = vehicle_discharge; }
        }
        public string vehicle_expiration
        {
            get { return this.vehicle.expiration; }
            set { this.vehicle.expiration = vehicle_expiration; }
        }
        public string vehicle_engineType
        {
            get { return this.vehicle.engineType; }
            set { this.vehicle.engineType = vehicle_engineType; }
        }
        #endregion

    }
}
