using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestaller
{
    public class Incoming
    {
        public Incoming() { }

        public Incoming(DateTime incomingDate, DateTime departureDate,
                        DateTime estimatedDate, string damages, float kms)
        {
            this.incomingDate = incomingDate;
            this.departureDate = departureDate;
            this.estimatedDate = estimatedDate;
            this.damages = damages;
            this.kms = kms;
        }
        public DateTime incomingDate    { get; set; }
        public DateTime departureDate   { get; set; }
        public DateTime estimatedDate   { get; set; }
        public string damages           { get; set; }
        public float kms                { get; set; }

    }
}
