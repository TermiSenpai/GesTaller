using Gestaller.Views;
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
        List<Control> _controls = new List<Control>();
        BussinessLogicLayer _bussinessLogicLayer = new BussinessLogicLayer();

        public WarehouseView()
        {
            InitializeComponent();
        }

        #region events
        
        private void WarehouseView_Load(object sender, EventArgs e)
        {
            getDB();
            addControls();
        }
        
        private void btVaciar_Productos_Click(object sender, EventArgs e)
        {
            clearText();
        }

        #endregion

        #region private methods

        private void clearText()
        {
            foreach (Control control in _controls)
            {
                if (control is CueComboBox)
                {
                    ((CueComboBox)control).ResetText();
                    ((CueComboBox)control).SelectedIndex = -1;
                }

                if (control is CueTextBox)
                {
                    ((CueTextBox)control).ResetText();
                }

                if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).ResetText();
                }
            }
        }

        private void addControls()
        {
            _controls.Add(Referecia_Productos);
            _controls.Add(Proveedor_Productos);
            _controls.Add(Descripcion_Productos);
            _controls.Add(Base_Productos);
            _controls.Add(IVA_Productos);
            _controls.Add(PVP_Productos);
            _controls.Add(Detallada_Productos);
        }

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
