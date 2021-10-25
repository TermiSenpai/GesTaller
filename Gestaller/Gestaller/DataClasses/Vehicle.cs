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

        public Vehicle(string enroll, string brand, string model, string kms, string frame,
                       string discharge, string expiration, string motor)
        {
            this.enroll = enroll;
            this.brand = brand;
            this.model = model;
            this.kms = kms;
            this.frame = frame;
            this.discharge = discharge;
            this.expiration = expiration;
            this.motor = motor;

        }
        string enroll       { get; set; }
        string brand        { get; set; }
        string model        { get; set; }
        string kms          { get; set; }
        string frame        { get; set; }
        string discharge    { get; set; }
        string expiration   { get; set; }
        string motor        { get; set; }
    }
}
