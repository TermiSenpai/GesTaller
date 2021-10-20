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
            showChildForm(new ClientView());
        }
        private void btnRecepciones_Click(object sender, EventArgs e)
        {
            showChildForm(new IncomingView());
        }
        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            showChildForm(new OrdersView());
        }
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            showChildForm(new HistoryView());
        }
        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            showChildForm(new WarehouseView());
        }
        private void btnOpciones_Click(object sender, EventArgs e)
        {
            showChildForm(new OptionsView());
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

        #region FormEvents
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Maximized:
                    Properties.Settings.Default.Location = RestoreBounds.Location;
                    Properties.Settings.Default.Size = RestoreBounds.Size;
                    Properties.Settings.Default.Maximized = true;
                    Properties.Settings.Default.Minimized = false;
                    break;

                case FormWindowState.Normal:
                    Properties.Settings.Default.Location = Location;
                    Properties.Settings.Default.Size = Size;
                    Properties.Settings.Default.Maximized = false;
                    Properties.Settings.Default.Minimized = false;
                    break;

                default:
                    Properties.Settings.Default.Location = RestoreBounds.Location;
                    Properties.Settings.Default.Size = RestoreBounds.Size;
                    Properties.Settings.Default.Maximized = false;
                    Properties.Settings.Default.Minimized = true;
                    break;
            }

            Properties.Settings.Default.Save();
        }
