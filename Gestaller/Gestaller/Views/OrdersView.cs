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
        }
        
        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        #endregion

        #region private methods

        private void getDB()
        {
            List<Order> orders = _businessLogicLayer.GetOrders();
            dataGridView1_Pre.DataSource = orders;
            dataGridView1_Pro.DataSource = orders;
            dataGridView1_F.DataSource = orders;
        }

        private void getOrdersItems()
        {
            List<ContactVehicle> contactsVehicles = _businessLogicLayer.GetContactVehicles();
            List<Order> orders = _businessLogicLayer.GetOrders();

            for(int i = 0; i < orders.Count(); i++)
            {
                cueComboBox1Cliente_Cliente_Pre.Items.Add(contactsVehicles[i].contact_fullName);
                cueComboBox2Cliente_Matricula_Pre.Items.Add(contactsVehicles[i].vehicle_enroll);
                cueComboBox3Cliente_Marca_Pre.Items.Add(contactsVehicles[i].vehicle_brand);
                cueComboBox4Cliente_Modelo_Pre.Items.Add(contactsVehicles[i].vehicle_model);
            }

        }

        #endregion
    }
}
