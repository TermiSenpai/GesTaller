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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        #region events

        private void OrdersView_Load(object sender, EventArgs e)
        {
            getDB();
            getOrdersItems();
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _selectedCell = dataGridView1_Pre.CurrentCell.RowIndex;
            cellClickEvent();
        }

        #endregion

        #region private methods

        void cellClickEvent()
        {
            _selectedCell = dataGridView1_Pre.CurrentCell.RowIndex;
            setItemToComboBox();
        }

        private void setItemToComboBox()
        {
            List<Item> items = getItems();
            cueComboBox4Presupuesto_Referencia_Pre.Text = items[_selectedCell].reference.ToString();
            cueComboBox5Presupuesto_Descripción_Pre.Text = items[_selectedCell].description;
            cueTextBox1Presupuesto_PVP_Pre.Text = items[_selectedCell].PVP.ToString();                                  
        }

        private void getDB()
        {
            List<Item> items = _businessLogicLayer.GetItems();
            dataGridView1_Pre.DataSource = items;
            dataGridView1_Pro.DataSource = items;
            dataGridView1_F.DataSource = items;
        }

        private void getOrdersItems()
        {
            List<ContactVehicle> contactsVehicles = _businessLogicLayer.GetContactVehicles();
            List<Order> orders = _businessLogicLayer.GetOrders();

            for (int i = 0; i < orders.Count(); i++)
            {
                cueComboBox1Cliente_Cliente_Pre.Items.Add(contactsVehicles[i].contact_fullName);
                cueComboBox2Cliente_Matricula_Pre.Items.Add(contactsVehicles[i].vehicle_enroll);
                cueComboBox3Cliente_Marca_Pre.Items.Add(contactsVehicles[i].vehicle_brand);
                cueComboBox4Cliente_Modelo_Pre.Items.Add(contactsVehicles[i].vehicle_model);
                cueComboBox1Presupuesto_BudgetNum_Pre.Items.Add(orders[i].numBudget);
                cueComboBox2Presupuesto_ProformaNum_Pre.Items.Add(orders[i].numProForma);
                cueComboBox3Presupuesto_InvoiceNum_Pre.Items.Add(orders[i].numInvoice);
                // cueComboBox1.Items.Add(orders[i].reference); // referencia
                // cueComboBox2.Items.Add(orders[i].numBudget); // descripcion
                // cueComboBox3.Items.Add(orders[i].numBudget); // cantidad
                // cueComboBox8.Items.Add(orders[i].numBudget); // descuento
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
            cueComboBox1Cliente_Cliente_Pre.Text = _clientVehicle.contact_fullName;
            cueComboBox2Cliente_Matricula_Pre.Text = _clientVehicle.vehicle_enroll;
            cueComboBox3Cliente_Marca_Pre.Text = _clientVehicle.vehicle_brand;
            cueComboBox4Cliente_Modelo_Pre.Text = _clientVehicle.vehicle_model;
            cueTextBox1Cliente_Km_Pre.Text = _clientVehicle.vehicle_kms;
            cueComboBox1Presupuesto_BudgetNum_Pre.Text = _order.numBudget.ToString(); // presupuesto
            cueComboBox2Presupuesto_ProformaNum_Pre.Text = _order.numProForma.ToString(); // proforma
            cueComboBox3Presupuesto_InvoiceNum_Pre.Text = _order.numInvoice.ToString(); // factura
            dateTimePicker1Presupuesto_Date_Pre.Value = _order.dateBudget;
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
            _comboIndex = cueComboBox1Cliente_Cliente_Pre.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBox2Cliente_Matricula_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = cueComboBox2Cliente_Matricula_Pre.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBox1Presupuesto_BudgetNum_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = cueComboBox1Presupuesto_BudgetNum_Pre.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBox2Presupuesto_ProformaNum_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = cueComboBox2Presupuesto_ProformaNum_Pre.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBox3Presupuesto_InvoiceNum_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = cueComboBox3Presupuesto_InvoiceNum_Pre.SelectedIndex;
            changesComboBoxes();
        }

        #endregion
    }
}
