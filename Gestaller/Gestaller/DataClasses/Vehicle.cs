using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestaller
{
    public class Vehicle
    {
        public Vehicle() { }

        public Vehicle(int id, string enroll, string brand, string model, string kms, string frame,
                       string discharge, string expiration, string engineType)
        {
            this.id = id;
            this.enroll = enroll;
            this.brand = brand;
            this.model = model;
            this.kms = kms;
            this.frame = frame;
            this.discharge = discharge;
            this.expiration = expiration;
            this.engineType = engineType;

        }
        public int id              { get; set; }
        public string enroll       { get; set; }
        public string brand        { get; set; }
        public string model        { get; set; }
        public string kms          { get; set; }
        public string frame        { get; set; }
        public string discharge    { get; set; }
        public string expiration   { get; set; }
        public string engineType   { get; set; }
    }
}
