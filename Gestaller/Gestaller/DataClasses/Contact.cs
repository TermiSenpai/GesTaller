using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestaller
{
    public class Contact
    {
        public Contact() { }

        public Contact(int id, string  company, string fullName, string cif, string email, string address,
                       string city, string district, string fax, string phone, string mobile,
                       int cp)
        {
            this.id = id;
            this.company = company;
            this.fullName = fullName;
            this.cif = cif;
            this.cp = cp;
            this.address = address;
            this.city = city;
            this.district = district;
            this.email = email;
            this.fax = fax;
            this.phone = phone;
            this.mobile = mobile;
        }
        public int id               { get; set; }
        public string company       { get; set; }
        public string fullName      { get; set; }
        public string cif           { get; set; }
        public string address       { get; set; }
        public string city          { get; set; }
        public int cp               { get; set; }
        public string district      { get; set; }
        public string email         { get; set; }
        public string fax           { get; set; }
        public string phone         { get; set; }
        public string mobile        { get; set; }
    }
}
