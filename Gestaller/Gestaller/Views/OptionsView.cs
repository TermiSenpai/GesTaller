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

        #region events

        // Al cargar la vista
        private void OptionsView_Load(object sender, EventArgs e) => getDB();

        #endregion

        #region private methods

        // obtiene la base de datos del IVA
        private void getDB()
        {
            List<Iva> ivas = getIvas();
            dataGridViewIVA.DataSource = ivas;
        }

        // obtiene la lista de IVAS
        private List<Iva> getIvas()
        {
            return _bussinessLogicLayer.getIvas();
        }

        #endregion
    }
}
