﻿using Gestaller.Views;
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

        // Al cargar la vista
        private void WarehouseView_Load(object sender, EventArgs e)
        {
            getDB();
            addControls();
            setComboItems();
        }
        
        // Click en boton vaciar de proveedores
        private void btVaciar_Proveedores_Click(object sender, EventArgs e) => clearText();
        
        // Al clickar en cualquier dato del dataGrid de productos
        private void Grid_Productos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _currentIndex = Grid_Productos.CurrentCell.RowIndex;
            selectItem();
            itemToCombo();
        }
        
        // click en bton vaciar de productos
        private void btVaciar_Productos_Click(object sender, EventArgs e) =>  clearText();

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

        // añade los items en la lista del comboBox
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

        // Busca el item con la ID seleccionada
        private void selectItem()
        {
            List<Item> item = getItems();
            currentItem(item[_currentIndex]);
        }

        // modifica el texto de los comboBoxes con el item activo
        private void itemToCombo()
        {
            Referecia_Productos.Text = _currentItem.reference.ToString();
            Descripcion_Productos.Text = _currentItem.description;
            Base_Productos.Text = _currentItem.basePrice.ToString();
            PVP_Productos.Text = _currentItem.PVP.ToString();
        }

        // selecciona el item activo
        private void currentItem(Item item) => _currentItem = item;

        // Vacia el texto
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

        // añade la lista de controles
        private void addControls()
        {
            _controls.Add(Referecia_Productos);
            _controls.Add(Proveedor_Productos);
            _controls.Add(Descripcion_Productos);
            _controls.Add(Base_Productos);
            _controls.Add(IVA_Productos);
            _controls.Add(PVP_Productos);
            _controls.Add(Detallada_Productos);

            _controls.Add(NIF_Proveedores);
            _controls.Add(Nombre_Proveedores);
            _controls.Add(Descripcion_Productos);
            _controls.Add(Localidad_Proveedores);
            _controls.Add(Direccion_Proveedores);
            _controls.Add(Provincia_Proveedores);
            _controls.Add(CP_Proveedores);
            _controls.Add(Movil_Proveedores);
            _controls.Add(Telefono_Proveedores);
            _controls.Add(Fax_Proveedores);
            _controls.Add(Email_Proveedores);
            _controls.Add(NoCuenta_Proveedores);
            _controls.Add(Entidad_Proveedores);
            _controls.Add(firmaPago_Proveedores);
            _controls.Add(diasPago_Proveedores);
            _controls.Add(Localidad2_Proveedores);
            _controls.Add(Direccion2_Proveedores);
            _controls.Add(Provincia2_Proveedores);
        }

        // obtiene la lista de items y las muestra en el dataGrid
        private void getDB()
        {
            List<Item> items = getItems();

            Grid_Productos.DataSource = items;
        }

        // Obtiene la lista de items
        private List<Item> getItems()
        {
            return _bussinessLogicLayer.GetItems();
        }

        #endregion
    }
}
