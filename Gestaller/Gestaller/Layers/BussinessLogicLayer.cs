using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestaller.Layers
{
    class BussinessLogicLayer
    {
        private DataLayerDummie _dataLayerDummie;
        public BussinessLogicLayer()
        {
            _dataLayerDummie = new DataLayerDummie();
        }
        public List<Contact> GetContacts()
        {
            return _dataLayerDummie.GetContacts();
        }
    }
}
