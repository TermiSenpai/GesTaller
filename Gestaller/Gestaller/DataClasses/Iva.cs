using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestaller.DataClasses
{
    class Iva
    {
        Iva()
        {

        }

        Iva(int iva, string description)
        {
            this.iva = iva;
            this.description = description;
        }

        int iva                 { get; set; }
        string description      { get; set; }

    }
}
