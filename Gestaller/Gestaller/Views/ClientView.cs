using Gestaller.Views;
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
    public partial class ClientView : Form
    {
        BussinessLogicLayer _bussinessLogicLayer = new BussinessLogicLayer();
        ContactVehicle _clientVehicle = null;
        List<Control> _controls = new List<Control>();
        int _comboIndex;

        public ClientView()
        {
            InitializeComponent();
        }

        #region events

        // Ejecutado al cargar la vista
        private void ClientView_Load(object sender, EventArgs e)
        {
            addControls();
            getDB();
            clientItemSet();
        }

        // Obtiene los datos de clientVehicle
        private void getDB()
        {
            List<ContactVehicle> contactsVehicles = getContactsVehicles();
            dataGrid.DataSource = contactsVehicles;
        }

        // Vaciar texto (botón vaciar)
        private void button1_Click(object sender, EventArgs e)
        {
            clearText();
        }

        // Al hacer click en cualquier celda se activa el evento
        private void dataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // toma el index de la celda selecionada
            int selectedCell = dataGrid.CurrentCell.RowIndex;
            // Toma la lista de datos existente
            List<ContactVehicle> contactsVehicles = getContactsVehicles();
            // Selecciona el clienteVehiculo activo
            selectContactVehicle(contactsVehicles[selectedCell]);
            // Toma los datos del clienteVehiculo y los añade al comboBox
            setToComboBox();
        }

        #endregion

        #region private methods

        // Vacia el texto de los comboBoxes
        private void clearText()
        {
            foreach (Control control in _controls)
            {
                if (control is CueComboBox)
                {
                    ((CueComboBox)control).ResetText();
                    ((CueComboBox)control).SelectedIndex = -1;
                }

                if (control is CueTextBox)
                {
                    ((CueTextBox)control).ResetText();
                }

                if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).ResetText();
                }
            }
        }

        // Obtiene la lista de contactsVehicles del index seleccionado
        private void changesComboBoxes()
        {
            List<ContactVehicle> contactsVehicles = getContactsVehicles();

            selectContactVehicle(contactsVehicles[_comboIndex]);

            setToComboBox();
        }

        // Añade los controles a la lista 
        private void addControls()
        {
            _controls.Add(cueComboBoxEmpresa);
            _controls.Add(cueComboBoxCIF);
            _controls.Add(cueComboBoxMovil);
            _controls.Add(cueComboBoxTelefono);
            _controls.Add(cueComboBoxFax);
            _controls.Add(cueComboBoxEmail);
            _controls.Add(cueComboBoxNombre);
            _controls.Add(cueComboBoxDireccion);
            _controls.Add(cueComboBoxLocalidad);
            _controls.Add(cueComboBoxProvincia);
            _controls.Add(cueComboBoxCP);
            _controls.Add(cueComboBoxMatricula);
            _controls.Add(cueComboBoxMarca);
            _controls.Add(cueComboBoxModelo);
            _controls.Add(cueComboBoxBastidor);
            _controls.Add(cueComboBoxKilometros);
            _controls.Add(cueComboBoxTipoMotor);
        }

        // Obtiene la lista de todos los contactsVehicles
        private List<ContactVehicle> getContactsVehicles()
        {
            return _bussinessLogicLayer.GetContactVehicles();
        }

        // Selecciona el contactVehicle en uso
        private void selectContactVehicle(ContactVehicle contactVehicle)
        {
            _clientVehicle = contactVehicle;
        }

        // Modifica el valor de todos los comboBoxes al del contactVehicle en uso
        private void setToComboBox()
        {
            // Muestra los datos en los cueComboBox 
            cueComboBoxEmpresa.Text = _clientVehicle.contact_company;
            cueComboBoxCIF.Text = _clientVehicle.contact_cif;
            cueComboBoxNombre.Text = _clientVehicle.contact_fullName;
            cueComboBoxDireccion.Text = _clientVehicle.contact_address;
            cueComboBoxLocalidad.Text = _clientVehicle.contact_city;
            cueComboBoxProvincia.Text = _clientVehicle.contact_district;
            cueComboBoxCP.Text = _clientVehicle.contact_cp.ToString();
            cueComboBoxMovil.Text = _clientVehicle.contact_mobile;
            cueComboBoxTelefono.Text = _clientVehicle.contact_phone;
            cueComboBoxFax.Text = _clientVehicle.contact_fax;
            cueComboBoxEmail.Text = _clientVehicle.contact_email;
            cueComboBoxMatricula.Text = _clientVehicle.vehicle_enroll;
            cueComboBoxMarca.Text = _clientVehicle.vehicle_brand;
            cueComboBoxModelo.Text = _clientVehicle.vehicle_model;
            cueComboBoxBastidor.Text = _clientVehicle.vehicle_frame;
            cueComboBoxKilometros.Text = _clientVehicle.vehicle_kms;
            cueComboBoxTipoMotor.Text = _clientVehicle.vehicle_engineType;
        }

        // Añade los items de los comboBoxes a la lista que se muestra
        private void clientItemSet()
        {
            List<ContactVehicle> contactsVehicles = getContactsVehicles();

            for (int i = 0; i < contactsVehicles.Count(); i++)
            {
                #region contacto

                // Empresa
                cueComboBoxEmpresa.Items.Add(contactsVehicles[i].contact_company);
                // CIF
                cueComboBoxCIF.Items.Add(contactsVehicles[i].contact_cif);
                // Nombre
                cueComboBoxNombre.Items.Add(contactsVehicles[i].contact_fullName);
                // Dirección
                cueComboBoxDireccion.Items.Add(contactsVehicles[i].contact_address);
                // Localidad
                cueComboBoxLocalidad.Items.Add(contactsVehicles[i].contact_city);
                // Provincia
                cueComboBoxProvincia.Items.Add(contactsVehicles[i].contact_district);
                // CP
                cueComboBoxCP.Items.Add(contactsVehicles[i].contact_cp);
                // Movil
                cueComboBoxMovil.Items.Add(contactsVehicles[i].contact_mobile);
                // Teléfono
                cueComboBoxTelefono.Items.Add(contactsVehicles[i].contact_phone);
                // FAX
                cueComboBoxFax.Items.Add(contactsVehicles[i].contact_fax);
                // Email
                cueComboBoxEmail.Items.Add(contactsVehicles[i].contact_email);
                #endregion

                #region vehiculo
                // Matricula
                cueComboBoxMatricula.Items.Add(contactsVehicles[i].vehicle_enroll);
                // Marca
                cueComboBoxMarca.Items.Add(contactsVehicles[i].vehicle_brand);
                // Modelo
                cueComboBoxModelo.Items.Add(contactsVehicles[i].vehicle_model);
                // Bastidor
                cueComboBoxBastidor.Items.Add(contactsVehicles[i].vehicle_frame);
                // Kilómetros
                cueComboBoxKilometros.Items.Add(contactsVehicles[i].vehicle_kms);
                // Tipo motor
                cueComboBoxTipoMotor.Items.Add(contactsVehicles[i].vehicle_engineType);
                #endregion
            }


        }

        #endregion

        #region comboBoxSelectionEvent

        private void cueComboBoxEmpresa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = cueComboBoxEmpresa.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBoxCIF_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = cueComboBoxCIF.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBoxNombre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = cueComboBoxNombre.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBoxDireccion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = cueComboBoxDireccion.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBoxMovil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = cueComboBoxMovil.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBoxEmail_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = cueComboBoxEmail.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBoxMatricula_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = cueComboBoxMatricula.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBoxBastidor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = cueComboBoxBastidor.SelectedIndex;
            changesComboBoxes();
        }

        #endregion

    }
}