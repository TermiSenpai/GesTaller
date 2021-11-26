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

        // Al cargar la vista
        private void HistoryView_Load(object sender, EventArgs e) => getDB();
        
        #endregion

        #region private methods

        // obtiene la lista de ordenes y la selecciona como source para el grid
        private void getDB()
        {
            List<Order> orders = getOrders();

            dataGridView1Hist_Contable.DataSource = orders;
            dataGridView1.DataSource = orders;
            dataGridView2.DataSource = orders;
        }

        // Obtiene la lista de ordenes del bussiness layer
        private List<Order> getOrders()
        {
            return _bussinessLogicLayer.GetOrders();
        }

        #endregion

        #region contable events
        
        // Click en boton ver
        private void button1Hist_Contable_Ver_Click(object sender, EventArgs e) => dateSearch();

        #endregion

        #region contable private methods

        // busca las facturas entre el rango de fechas
        private void dateSearch()
        {
            DateTime dateIni = dateTimePicker1Hist_Contable_FechaInicio.Value;
            DateTime dateFin = dateTimePicker2Hist_Contable_FechaFin.Value;
            List<Order> orders = getOrders();
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
