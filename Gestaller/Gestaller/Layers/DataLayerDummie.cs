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
            Contact secondContact = new Contact();
            secondContact.id = 1;
            secondContact.company = "company2";
            secondContact.fullName = "Roberto Complejo";
            secondContact.cif = "123asd12321vasdaad";
            secondContact.cp = 1995;
            secondContact.address = "Calle Robertillo";
            secondContact.city = "Marchamalo";
            secondContact.district = "Marchamalo";
            secondContact.email = "Marchamalo@gmail.com";
            secondContact.fax = "nosequesunfax2";
            secondContact.phone = "949282468";
            secondContact.mobile = "652487621";

            contacts.Add(firstContact);
            contacts.Add(secondContact);
            return contacts;
        }
    }
}
