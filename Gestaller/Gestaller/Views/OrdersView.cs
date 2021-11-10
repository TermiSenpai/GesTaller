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
        int _comboIndex;
        int _selectedCell;
        Order _order;
        ContactVehicle _clientVehicle;

        BussinessLogicLayer _businessLogicLayer = new BussinessLogicLayer();

        public OrdersView()
        {
            InitializeComponent();
        }

        #region events

        private void OrdersView_Load(object sender, EventArgs e)
        {
            getDB();
            getOrdersItems();
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _selectedCell = Grid_Presupuesto.CurrentCell.RowIndex;
            cellClickEvent();
        }

        #endregion

        #region private methods

        void cellClickEvent()
        {
            _selectedCell = Grid_Presupuesto.CurrentCell.RowIndex;
            setItemToComboBox();
        }

        private void setItemToComboBox()
        {
            List<Item> items = getItems();
            Referencia_Pre.Text = items[_selectedCell].reference.ToString();
            Descripción_Pre.Text = items[_selectedCell].description;
            PVP_Pre.Text = items[_selectedCell].PVP.ToString();                                  
        }

        private void getDB()
        {
            List<Item> items = _businessLogicLayer.GetItems();
            Grid_Presupuesto.DataSource = items;
            Grid_Proforma.DataSource = items;
            Grid_Factura.DataSource = items;
        }

        private void getOrdersItems()
        {
            List<ContactVehicle> contactsVehicles = _businessLogicLayer.GetContactVehicles();
            List<Order> orders = _businessLogicLayer.GetOrders();

            for (int i = 0; i < orders.Count(); i++)
            {
                Factura_Pre.Items.Add(orders[i].numInvoice);
                Proforma_Pre.Items.Add(orders[i].numProForma);
                Presupuesto_Pre.Items.Add(orders[i].numBudget);
                Modelo_Pre.Items.Add(contactsVehicles[i].vehicle_model);
                Marca_Pre.Items.Add(contactsVehicles[i].vehicle_brand);
                Matricula_Pre.Items.Add(contactsVehicles[i].vehicle_enroll);
                Cliente_Pre.Items.Add(contactsVehicles[i].contact_fullName);
            }

        }

        private void changesComboBoxes()
        {
            List<ContactVehicle> contactsVehicles = getContactsVehicles();
            List<Order> orders = getOrders();

            selectActiveContactVehicle(contactsVehicles[_comboIndex]);
            selectActiveOrder(orders[_comboIndex]);

            setToComboBox();
        }

        private void setToComboBox()
        {
            Cliente_Pre.Text = _clientVehicle.contact_fullName;
            Matricula_Pre.Text = _clientVehicle.vehicle_enroll;
            Marca_Pre.Text = _clientVehicle.vehicle_brand;
            Modelo_Pre.Text = _clientVehicle.vehicle_model;
            Km_Pre.Text = _clientVehicle.vehicle_kms;
            Presupuesto_Pre.Text = _order.numBudget.ToString(); // presupuesto
            Proforma_Pre.Text = _order.numProForma.ToString(); // proforma
            Factura_Pre.Text = _order.numInvoice.ToString(); // factura
            Fecha_Pre.Value = _order.dateBudget;
            // ComboBox4Presupuesto_Referencia_Pre.Text = (referencia);
            // cueComboBox5Presupuesto_Descripción_Pre.Text = _order.desc (descripción);

        }

        private void selectActiveContactVehicle(ContactVehicle contactVehicle)
        {
            _clientVehicle = contactVehicle;
        }

        private void selectActiveOrder(Order order)
        {
            _order = order;
        }

        private List<ContactVehicle> getContactsVehicles()
        {
            return _businessLogicLayer.GetContactVehicles();
        }

        private List<Order> getOrders()
        {
            return _businessLogicLayer.GetOrders();
        }
        
        private List<Item> getItems()
        {
            return _businessLogicLayer.GetItems();
        }

        #endregion

        #region presupuesto comboBox selection event

        private void cueComboBox1Cliente_Cliente_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Cliente_Pre.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBox2Cliente_Matricula_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Matricula_Pre.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBox1Presupuesto_BudgetNum_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Presupuesto_Pre.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBox2Presupuesto_ProformaNum_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Proforma_Pre.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBox3Presupuesto_InvoiceNum_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Factura_Pre.SelectedIndex;
            changesComboBoxes();
        }

        #endregion

        private void tableLayoutPanel1Proforma_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
