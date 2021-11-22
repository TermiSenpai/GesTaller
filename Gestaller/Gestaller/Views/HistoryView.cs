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
    public partial class HistoryView : Form
    {
        BussinessLogicLayer _bussinessLogicLayer = new BussinessLogicLayer();
        public HistoryView()
        {
            InitializeComponent();
        }

        #region events

        private void button1Hist_Contable_Ver_Click(object sender, EventArgs e)
        {
            dateSearch();
        }

        #endregion

        #region provate methods

        private void dateSearch()
        {
            DateTime dateIni = dateTimePicker1Hist_Contable_FechaInicio.Value;
            DateTime dateFin = dateTimePicker2Hist_Contable_FechaFin.Value;
            List<Order> orders = _bussinessLogicLayer.GetOrders();
            List<Order> dateOrders = new List<Order>();
            foreach (Order order in orders)
            {
                if (order.dateInvoice > dateIni && order.dateInvoice < dateFin)
                {
                    dateOrders.Add(order);
                }
            }
            dataGridView1Hist_Contable.DataSource = dateOrders;
        }

        #endregion
    }
}
