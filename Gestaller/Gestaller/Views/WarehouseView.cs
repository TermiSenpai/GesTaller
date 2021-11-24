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
        Item _currentItem;

        private int _currentIndex;

        public WarehouseView()
        {
            InitializeComponent();
        }

        #region events
        
        private void WarehouseView_Load(object sender, EventArgs e)
        {
            getDB();
            addControls();
            setComboItems();
        }
        
        private void Grid_Productos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _currentIndex = Grid_Productos.CurrentCell.RowIndex;
            selectItem();
            itemToCombo();
        }
        
        private void btVaciar_Productos_Click(object sender, EventArgs e)
        {
            clearText();
        }

        #region selectedComboBox

        private void Referecia_Productos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _currentIndex = Referecia_Productos.SelectedIndex;
            selectItem();
            itemToCombo();
        }

        private void Descripcion_Productos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _currentIndex = Descripcion_Productos.SelectedIndex;
            selectItem();
            itemToCombo();
        }

        #endregion

        #endregion

        #region private methods

        private void setComboItems()
        {
            List<Item> items = getItems();
            for(int i = 0; i<items.Count(); i++)
            {
                Referecia_Productos.Items.Add(items[i]);
                Descripcion_Productos.Items.Add(items[i]);
                PVP_Productos.Items.Add(items[i]);
            }
        }

        private void selectItem()
        {
            List<Item> item = getItems();
            currentItem(item[_currentIndex]);
        }

        private void itemToCombo()
        {
            Referecia_Productos.Text = _currentItem.reference.ToString();
            Descripcion_Productos.Text = _currentItem.description;
            Base_Productos.Text = _currentItem.basePrice.ToString();
            PVP_Productos.Text = _currentItem.PVP.ToString();
        }

        private void currentItem(Item item)
        {
            _currentItem = item;
        }

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
