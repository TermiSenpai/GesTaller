using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestaller
{
    public partial class WarehouseView : Form
    {
        BussinessLogicLayer _bussinessLogicLayer = new BussinessLogicLayer();

        public WarehouseView()
        {
            InitializeComponent();
        }

        #region events
        
        private void WarehouseView_Load(object sender, EventArgs e)
        {
            getDB();
        }

        #endregion

        #region private methods

        private void getDB()
        {
            List<Item> items = getItems();

            Grid_Productos.DataSource = items;
        }

        private List<Item> getItems()
        {
            return _bussinessLogicLayer.GetItems();
        }

        #endregion
    }
}
