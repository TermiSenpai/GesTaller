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

        // clientes btn
        private void btnClientes_Click(object sender, EventArgs e) => showChildForm(new ClientView());
        
        // recepciones btn
        private void btnRecepciones_Click(object sender, EventArgs e) => showChildForm(new IncomingView());

        //ordenes btn
        private void btnOrdenes_Click(object sender, EventArgs e) => showChildForm(new OrdersView());

        // historial btn
        private void btnHistorial_Click(object sender, EventArgs e) => showChildForm(new HistoryView());

        // almacen btn
        private void btnAlmacen_Click(object sender, EventArgs e) => showChildForm(new WarehouseView());

        // opciones btn
        private void btnOpciones_Click(object sender, EventArgs e) => showChildForm(new OptionsView());

        #endregion

        #region Funciones privadas
        
        // Añade el form seleccionado al panel y lo hace visible
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

        // Comprueba si la vista es visible al cargarse el programa
        private bool IsOnScreen(Form form)
        {
            Screen[] screens = Screen.AllScreens;
            
            foreach(Screen screen in screens)
            {
                Rectangle formRectangle = new Rectangle(form.Left, form.Top,
                                                         form.Width, form.Height);
                if (screen.WorkingArea.Contains(formRectangle))
                {
                    return true;
                }
            }
            return false;
        }
        
        // TODO
        // Detectar desaparición de segunda pantalla

        // Si no es visible se ajusta a una posición donde si lo sea
        private void adaptForm(bool visible)
        { 
            if (!visible)
            {
                this.Location = new Point(0, 0);
            }
        }

        // Carga las opciones guardadas en la ultima sesión
        private void loadLastSettings()
        {
            if (Properties.Settings.Default.Maximized)
            {
                WindowState = FormWindowState.Maximized;
                Location = Properties.Settings.Default.Location;
                Size = Properties.Settings.Default.Size;
            }

            else if (Properties.Settings.Default.Minimized)
            {
                WindowState = FormWindowState.Minimized;
                Location = Properties.Settings.Default.Location;
                Size = Properties.Settings.Default.Size;
            }

            else
            {
                Location = Properties.Settings.Default.Location;
                Size = Properties.Settings.Default.Size;
            }
        }

        #endregion

        #region FormEvents

        // Al cerrar el programa
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Maximized:
                    // Guarda la posición maximizada
                    Properties.Settings.Default.Location = RestoreBounds.Location;
                    Properties.Settings.Default.Size = RestoreBounds.Size;
                    Properties.Settings.Default.Maximized = true;
                    Properties.Settings.Default.Minimized = false;
                    break;

                case FormWindowState.Normal:
                    // Guarda la posición y el tamaño
                    Properties.Settings.Default.Location = Location;
                    Properties.Settings.Default.Size = Size;
                    Properties.Settings.Default.Maximized = false;
                    Properties.Settings.Default.Minimized = false;
                    break;

                default:
                    // Guarda la posición minimizada
                    Properties.Settings.Default.Location = RestoreBounds.Location;
                    Properties.Settings.Default.Size = RestoreBounds.Size;
                    Properties.Settings.Default.Maximized = false;
                    Properties.Settings.Default.Minimized = true;
                    break;
            }

            // Guarda las propiedades
            Properties.Settings.Default.Save();
        }

        // Al cargar la vista
        private void MainMenu_Load(object sender, EventArgs e)
        {
            loadLastSettings();
            adaptForm(IsOnScreen(this));
        }

        #endregion

    }
}
