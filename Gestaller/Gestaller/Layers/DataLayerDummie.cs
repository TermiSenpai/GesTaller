using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestaller.Layers
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

            contacts.Add(firstContact);
            return contacts;
        }
    }
}
