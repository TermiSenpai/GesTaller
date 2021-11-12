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

        private void OrdersView_Load(object sender, EventArgs e)
        {
            getDB();
            getBudgetClientItems();
            setComboItems();
            getProformaItems();
        }

        #endregion

        #region private methods

        private void getDB()
        {
            List<Item> items = _businessLogicLayer.GetItems();
            Grid_Presupuesto.DataSource = items;
            Grid_Proforma.DataSource = items;
            Grid_Factura.DataSource = items;
        }

        private void selectActiveContactVehicle(ContactVehicle contactVehicle)
        {
            _clientVehicle = contactVehicle;
        }

        private void selectActiveOrder(Order order)
        {
            _order = order;
        }

        private List<ContactVehicle> getContactsVehicles() => _businessLogicLayer.GetContactVehicles();
        

        private List<Order> getOrders() => _businessLogicLayer.GetOrders();
        
        
        private List<Item> getItems() => _businessLogicLayer.GetItems();

        private void setBudgetItemComboBox()
        {
            List<Item> items = getItems();
            Referencia_Pre.Text = items[_selectedCell].reference.ToString();
            Descripción_Pre.Text = items[_selectedCell].description;
            PVP_Pre.Text = items[_selectedCell].PVP.ToString();                                  
        }

        #endregion

        #region budget events
        
        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _selectedCell = Grid_Presupuesto.CurrentCell.RowIndex;
            budgetCellClick();
        }

        #region presupuesto comboBox selection event

        private void cueComboBox1Cliente_Cliente_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Cliente_Pre.SelectedIndex;
            changesBudgetComboBoxes();
        }

        private void cueComboBox2Cliente_Matricula_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Matricula_Pre.SelectedIndex;
            changesBudgetComboBoxes();
        }

        private void cueComboBox1Presupuesto_BudgetNum_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Presupuesto_Pre.SelectedIndex;
            changesBudgetComboBoxes();
        }

        private void cueComboBox2Presupuesto_ProformaNum_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Proforma_Pre.SelectedIndex;
            changesBudgetComboBoxes();
        }

        private void cueComboBox3Presupuesto_InvoiceNum_Pre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Factura_Pre.SelectedIndex;
            changesBudgetComboBoxes();
        }

        #endregion

        #endregion

        #region budget private methods

        void budgetCellClick()
        {
            _selectedCell = Grid_Presupuesto.CurrentCell.RowIndex;
            setBudgetItemComboBox();
        }


        private void getBudgetClientItems()
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

        private void setComboItems()
        {
            List<Item> items = getItems();

            for(int i = 0; i < items.Count(); i++)
            {
                Referencia_Pre.Items.Add(items[i].reference);
                Descripción_Pre.Items.Add(items[i].description);

                Referencia_Proforma.Items.Add(items[i].reference);
                Descripción_Proforma.Items.Add(items[i].description);

                Referencia_F.Items.Add(items[i].reference);
                Descripcion_F.Items.Add(items[i].description);
            }
        }

        private void budgetSetToComboBox()
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
        }

        private void changesBudgetComboBoxes()
        {
            List<ContactVehicle> contactsVehicles = getContactsVehicles();
            List<Order> orders = getOrders();

            selectActiveContactVehicle(contactsVehicles[_comboIndex]);
            selectActiveOrder(orders[_comboIndex]);

            budgetSetToComboBox();
        }

        #endregion

        #region proforma events

        private void Grid_Proforma_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _selectedCell = Grid_Proforma.CurrentCell.RowIndex;
            setProformaItemsToComboBox();
        }

        #region proforma comboBox selection event

        private void Cliente_Proforma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Cliente_Proforma.SelectedIndex;
            changesProformaComboBoxes();
        }

        private void Matricula_Proforma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Matricula_Proforma.SelectedIndex;
            changesProformaComboBoxes();
        }

        private void Presupuesto_Proforma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Presupuesto_Proforma.SelectedIndex;
            changesProformaComboBoxes();
        }

        private void Proforma_Proforma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Proforma_Proforma.SelectedIndex;
            changesProformaComboBoxes();
        }

        private void Factura_Proforma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Factura_Proforma.SelectedIndex;
            changesProformaComboBoxes();
        }

        #endregion

        #endregion

        #region proforma private methods

        private void getProformaItems()
        {
            List<ContactVehicle> contactsVehicles = _businessLogicLayer.GetContactVehicles();
            List<Order> orders = _businessLogicLayer.GetOrders();

            for (int i = 0; i < orders.Count(); i++)
            {
                Factura_Proforma.Items.Add(orders[i].numInvoice);
                Proforma_Proforma.Items.Add(orders[i].numProForma);
                Presupuesto_Proforma.Items.Add(orders[i].numBudget);
                Modelo_Proforma.Items.Add(contactsVehicles[i].vehicle_model);
                Marca_Proforma.Items.Add(contactsVehicles[i].vehicle_brand);
                Matricula_Proforma.Items.Add(contactsVehicles[i].vehicle_enroll);
                Cliente_Proforma.Items.Add(contactsVehicles[i].contact_fullName);
            }
        }

        private void setProformaItemsToComboBox()
        {
            List<Item> items = getItems();
            Referencia_Proforma.Text = items[_selectedCell].reference.ToString();
            Descripción_Proforma.Text = items[_selectedCell].description;
            PVP_Proforma.Text = items[_selectedCell].PVP.ToString();
        }

        private void changesProformaComboBoxes()
        {
            List<ContactVehicle> contactsVehicles = getContactsVehicles();
            List<Order> orders = getOrders();

            selectActiveContactVehicle(contactsVehicles[_comboIndex]);
            selectActiveOrder(orders[_comboIndex]);

            proformaSetToComboBox();
        }

        private void proformaSetToComboBox()
        {
            Cliente_Proforma.Text = _clientVehicle.contact_fullName;
            Matricula_Proforma.Text = _clientVehicle.vehicle_enroll;
            Marca_Proforma.Text = _clientVehicle.vehicle_brand;
            Modelo_Proforma.Text = _clientVehicle.vehicle_model;
            Km_Proforma.Text = _clientVehicle.vehicle_kms;
            Presupuesto_Proforma.Text = _order.numBudget.ToString(); // presupuesto
            Proforma_Proforma.Text = _order.numProForma.ToString(); // proforma
            Factura_Proforma.Text = _order.numInvoice.ToString(); // factura
            Fecha_Proforma.Value = _order.dateBudget;
        }

        #endregion

        #region invoice events

        private void Grid_Factura_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        #region invoice comboBox selection event



        #endregion

        #endregion

        #region invoice private methods

        #endregion

    }
}
