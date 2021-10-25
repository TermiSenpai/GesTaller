using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestaller
{
    public struct Contact
    {
        public Contact(string  business, string name, string cif, string email, string address,
                       string town, string district, string fax, string phone, string mobile,
                       int id, int cp)
        {
            this.id = id;
            this.business = business;
            this.name = name;
            this.cif = cif;
            this.address = address;
            this.cp = cp;
            this.town = town;
            this.district = district;
            this.email = email;
            this.fax = fax;
            this.phone = phone;
            this.mobile = mobile;
        }
        public int id               { get; set; }
        public string business      { get; set; }
        public string name          { get; set; }
        public string cif           { get; set; }
        public string address       { get; set; }
        public string town          { get; set; }
        public int cp               { get; set; }
        public string district      { get; set; }
        public string email         { get; set; }
        public string fax           { get; set; }
        public string phone         { get; set; }
        public string mobile        { get; set; }
    }
}
