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
    public partial class OrdersView : Form
    {
        Order _order;
        ContactVehicle _clientVehicle;
        BussinessLogicLayer _businessLogicLayer = new BussinessLogicLayer();

        int _selectedCell;
        int _comboIndex;

        public OrdersView()
        {
            InitializeComponent();
        }



        #region events

        // Al cargar la vista
        private void OrdersView_Load(object sender, EventArgs e)
        {
            getDB();
            setClientItems();
            setComboItems();
        }

        #endregion

        #region private methods

        // Cambia los elementos activos a los nuevos
        private void changesActiveElements()
        {
            List<ContactVehicle> contactsVehicles = getContactsVehicles();
            List<Order> orders = getOrders();

            selectActiveContactVehicle(contactsVehicles[_comboIndex]);
            selectActiveOrder(orders[_comboIndex]);

            setToComboBox();
        }

        // Modifica el item cargado en los comboBoxes
        private void setItemsToComboBox()
        {
            List<Item> items = getItems();
            // Dependiendo del index tab en el que se encuentre
            switch (ordenesTab.SelectedIndex)
            {
                // Presupuesto
                case 0:
                    Referencia_Presupuesto.Text = items[_selectedCell].reference.ToString();
                    Descripción_Presupuesto.Text = items[_selectedCell].description;
                    PVP_Presupuesto.Text = items[_selectedCell].PVP.ToString();
                    break;

                // Proforma
                case 1:
                    Referencia_Proforma.Text = items[_selectedCell].reference.ToString();
                    Descripción_Proforma.Text = items[_selectedCell].description;
                    PVP_Proforma.Text = items[_selectedCell].PVP.ToString();
                    break;

                // Factura
                case 2:
                    Referencia_Factura.Text = items[_selectedCell].reference.ToString();
                    Descripcion_Factura.Text = items[_selectedCell].description;
                    PVP_Factura.Text = items[_selectedCell].PVP.ToString();
                    break;
            }
        }

        // Modifica el valor o texto con los elementos activos 
        private void setToComboBox()
        {
            // Dependiendo del index tab en el que se encuentre
            switch (ordenesTab.SelectedIndex)
            {
                // Presupuesto tab
                case 0:
                    Cliente_Presupuesto.Text = _clientVehicle.contact_fullName;
                    Matricula_Presupuesto.Text = _clientVehicle.vehicle_enroll;
                    Marca_Presupuesto.Text = _clientVehicle.vehicle_brand;
                    Modelo_Presupuesto.Text = _clientVehicle.vehicle_model;
                    Km_Presupuesto.Text = _clientVehicle.vehicle_kms;
                    Presupuesto_Presupuesto.Text = _order.numBudget.ToString();
                    Proforma_Presupuesto.Text = _order.numProForma.ToString();
                    Factura_Presupuesto.Text = _order.numInvoice.ToString();
                    Fecha_Presupuesto.Value = _order.dateBudget;
                    break;

                // Proforma tab
                case 1:
                    Cliente_Proforma.Text = _clientVehicle.contact_fullName;
                    Matricula_Proforma.Text = _clientVehicle.vehicle_enroll;
                    Marca_Proforma.Text = _clientVehicle.vehicle_brand;
                    Modelo_Proforma.Text = _clientVehicle.vehicle_model;
                    Km_Proforma.Text = _clientVehicle.vehicle_kms;
                    Presupuesto_Proforma.Text = _order.numBudget.ToString();
                    Proforma_Proforma.Text = _order.numProForma.ToString();
                    Factura_Proforma.Text = _order.numInvoice.ToString();
                    Fecha_Proforma.Value = _order.dateBudget;
                    break;

                // Factura tab
                case 2:
                    Cliente_Factura.Text = _clientVehicle.contact_fullName;
                    Matricula_Factura.Text = _clientVehicle.vehicle_enroll;
                    Marca_Factura.Text = _clientVehicle.vehicle_brand;
                    Modelo_Factura.Text = _clientVehicle.vehicle_model;
                    Km_Factura.Text = _clientVehicle.vehicle_kms;
                    Presupuesto_Factura.Text = _order.numBudget.ToString();
                    Proforma_Factura.Text = _order.numProForma.ToString();
                    Factura_Factura.Text = _order.numInvoice.ToString();
                    Fecha_Factura.Value = _order.dateBudget;
                    break;
            }
        }

        // Obtiene los datos y los añade al dataGrid
        private void getDB()
        {
            List<Item> items = _businessLogicLayer.GetItems();
            Grid_Presupuesto.DataSource = items;
            Grid_Proforma.DataSource = items;
            Grid_Factura.DataSource = items;
        }

        // Modifica el contacVehicle actual por el nuevo
        private void selectActiveContactVehicle(ContactVehicle contactVehicle) => _clientVehicle = contactVehicle;

        // Modifica la orden actual por el nuevo
        private void selectActiveOrder(Order order) => _order = order;

        // Obtiene la lista de contactsVehicles
        private List<ContactVehicle> getContactsVehicles() => _businessLogicLayer.GetContactVehicles();

        // Obtiene la lista de ordenes
        private List<Order> getOrders() => _businessLogicLayer.GetOrders();

        // Obtiene la lista de items
        private List<Item> getItems() => _businessLogicLayer.GetItems();

        // Añade los items a la lista del comboBox
        private void setComboItems()
        {
            List<Item> items = getItems();

            for (int i = 0; i < items.Count(); i++)
            {
                // Presupuesto
                Referencia_Presupuesto.Items.Add(items[i].reference);
                Descripción_Presupuesto.Items.Add(items[i].description);

                // Proforma
                Referencia_Proforma.Items.Add(items[i].reference);
                Descripción_Proforma.Items.Add(items[i].description);

                // Factura
                Referencia_Factura.Items.Add(items[i].reference);
                Descripcion_Factura.Items.Add(items[i].description);
            }
        }

        // añade los clientes a la lista de items del comboBox
        private void setClientItems()
        {
            List<ContactVehicle> contactsVehicles = _businessLogicLayer.GetContactVehicles();
            List<Order> orders = _businessLogicLayer.GetOrders();

            for (int i = 0; i < orders.Count(); i++)
            {
                // [PRESUPUESTO]
                Factura_Presupuesto.Items.Add(orders[i].numInvoice);
                Proforma_Presupuesto.Items.Add(orders[i].numProForma);
                Presupuesto_Presupuesto.Items.Add(orders[i].numBudget);
                Modelo_Presupuesto.Items.Add(contactsVehicles[i].vehicle_model);
                Marca_Presupuesto.Items.Add(contactsVehicles[i].vehicle_brand);
                Matricula_Presupuesto.Items.Add(contactsVehicles[i].vehicle_enroll);
                Cliente_Presupuesto.Items.Add(contactsVehicles[i].contact_fullName);

                // [PROFORMA]
                Factura_Proforma.Items.Add(orders[i].numInvoice);
                Proforma_Proforma.Items.Add(orders[i].numProForma);
                Presupuesto_Proforma.Items.Add(orders[i].numBudget);
                Modelo_Proforma.Items.Add(contactsVehicles[i].vehicle_model);
                Marca_Proforma.Items.Add(contactsVehicles[i].vehicle_brand);
                Matricula_Proforma.Items.Add(contactsVehicles[i].vehicle_enroll);
                Cliente_Proforma.Items.Add(contactsVehicles[i].contact_fullName);

                // [FACTURA]
                Factura_Factura.Items.Add(orders[i].numInvoice);
                Proforma_Factura.Items.Add(orders[i].numProForma);
                Presupuesto_Factura.Items.Add(orders[i].numBudget);
                Modelo_Factura.Items.Add(contactsVehicles[i].vehicle_model);
                Marca_Factura.Items.Add(contactsVehicles[i].vehicle_brand);
                Matricula_Factura.Items.Add(contactsVehicles[i].vehicle_enroll);
                Cliente_Factura.Items.Add(contactsVehicles[i].contact_fullName);
            }
        }

        #endregion




        #region budget events

        // Al hacer click en cualquier dato del dataGrid de presupuestos
        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) => budgetCellClick();

        #region presupuesto client comboBox selection event

        private void cueComboBox1Cliente_Cliente_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Cliente_Presupuesto.SelectedIndex;
            changesActiveElements();
        }

        private void cueComboBox2Cliente_Matricula_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Matricula_Presupuesto.SelectedIndex;
            changesActiveElements();
        }

        private void cueComboBox1Presupuesto_BudgetNum_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Presupuesto_Presupuesto.SelectedIndex;
            changesActiveElements();
        }

        private void cueComboBox2Presupuesto_ProformaNum_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Proforma_Presupuesto.SelectedIndex;
            changesActiveElements();
        }

        private void cueComboBox3Presupuesto_InvoiceNum_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Factura_Presupuesto.SelectedIndex;
            changesActiveElements();
        }

        #endregion

        #region item comboBox selection event

        private void Referencia_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _selectedCell = Referencia_Presupuesto.SelectedIndex;
            setItemsToComboBox();
        }

        private void Descripción_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _selectedCell = Descripción_Presupuesto.SelectedIndex;
            setItemsToComboBox();
        }

        #endregion

        #endregion

        #region budget private methods

        // modifica la celda activa con la que trabajamos y añade el item al comboBox
        void budgetCellClick()
        {
            _selectedCell = Grid_Presupuesto.CurrentCell.RowIndex;
            setItemsToComboBox();
        }

        #endregion




        #region proforma events

        // Al hacer click en cualquier dato del grid de proforma
        private void Grid_Proforma_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) => proformaCellClick();

        #region proforma comboBox selection event

        private void Cliente_Proforma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Cliente_Proforma.SelectedIndex;
            changesActiveElements();
        }

        private void Matricula_Proforma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Matricula_Proforma.SelectedIndex;
            changesActiveElements();
        }

        private void Presupuesto_Proforma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Presupuesto_Proforma.SelectedIndex;
            changesActiveElements();
        }

        private void Proforma_Proforma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Proforma_Proforma.SelectedIndex;
            changesActiveElements();
        }

        private void Factura_Proforma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Factura_Proforma.SelectedIndex;
            changesActiveElements();
        }

        #endregion

        #region item comboBox selection event

        private void Referencia_Proforma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _selectedCell = Referencia_Proforma.SelectedIndex;
            setItemsToComboBox();
        }

        private void Descripción_Proforma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _selectedCell = Descripción_Proforma.SelectedIndex;
            setItemsToComboBox();
        }

        #endregion

        #endregion

        #region proforma private methods

        // Cambia la celda activa y añade en el comboBox el item seleccionado
        private void proformaCellClick()
        {
            _selectedCell = Grid_Proforma.CurrentCell.RowIndex;
            setItemsToComboBox();
        }

        #endregion




        #region invoice events

        // Al hacer click en cualquier dato del grid de factura
        private void Grid_Factura_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) => invoiceCellClick();

        #region invoice comboBox selection event

        private void cueComboBox1Cliente_Cliente_F_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Cliente_Factura.SelectedIndex;
            changesActiveElements();
        }

        private void cueComboBox2Cliente_Matricula_F_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Matricula_Factura.SelectedIndex;
            changesActiveElements();
        }

        private void Presupuesto_F_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Presupuesto_Factura.SelectedIndex;
            changesActiveElements();
        }

        private void Proforma_F_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Proforma_Factura.SelectedIndex;
            changesActiveElements();
        }

        private void Factura_F_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Factura_Factura.SelectedIndex;
            changesActiveElements();
        }

        #endregion

        #region item comboBox selection event

        private void Referencia_F_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _selectedCell = Referencia_Factura.SelectedIndex;
            setItemsToComboBox();
        }

        private void Descripcion_F_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _selectedCell = Descripcion_Factura.SelectedIndex;
            setItemsToComboBox();
        }

        #endregion

        #endregion

        #region invoice private methods

        // Modifica la celda y añade los items al comboBox
        private void invoiceCellClick()
        {
            _selectedCell = Grid_Presupuesto.CurrentCell.RowIndex;
            setItemsToComboBox();
        }

        #endregion
    }
}
