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
    public partial class OptionsView : Form
    {
        BussinessLogicLayer _bussinessLogicLayer = new BussinessLogicLayer();
        public OptionsView()
        {
            InitializeComponent();
        }

        private void OptionsView_Load(object sender, EventArgs e)
        {
            getDB();
        }

        private void getDB()
        {
            List<Iva> ivas = getIvas();
            dataGridViewIVA.DataSource = ivas;
        }

        private List<Iva> getIvas()
        {
            return _bussinessLogicLayer.getIvas();
        }
    }
}
