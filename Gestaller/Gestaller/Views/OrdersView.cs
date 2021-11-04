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

        private void OrdersView_Load(object sender, EventArgs e)
        {
            getDB();
        }

        private void getDB()
        {
            List<Order> orders = _businessLogicLayer.GetOrders();
            dataGridView1_Pre.DataSource = orders;
            dataGridView2.DataSource = orders;
            dataGridView1.DataSource = orders;
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
