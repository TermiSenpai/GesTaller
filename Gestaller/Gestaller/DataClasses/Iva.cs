using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestaller
{
    public class Iva
    {
        public Iva()
        {

        }

        public Iva(int iva, string description)
        {
            this.iva = iva;
            this.description = description;
        }

        int iva                 { get; set; }
        string description      { get; set; }

    }
}
