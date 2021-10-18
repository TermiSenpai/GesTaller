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
    public partial class MainMenu : Form
    {
        Form _activeForm = null;
        public MainMenu()
        {
            InitializeComponent();
        }
        #region Eventos
        private void btnClientes_Click(object sender, EventArgs e)
        {
            //showChildForm(new Clientes());
        }
        private void btnOpciones_Click(object sender, EventArgs e)
        {
            showChildForm(new Opciones());
        }

        #endregion

        #region Funciones privadas
        private void showChildForm(Form childForm)
        {
            //si hay un formulario activo se cierra
            if (_activeForm != null)
                _activeForm.Close();

            //se asigna el nuevo formulario
            _activeForm = childForm;
            childForm.TopLevel = false;

            //se oculta el borde del nuevo formulario cargado
            childForm.FormBorderStyle = FormBorderStyle.None;

            //se ajusta a todo el espacio del panel
            childForm.Dock = DockStyle.Fill;
            ChildPanel.Controls.Add(childForm);
            ChildPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

    }
}
