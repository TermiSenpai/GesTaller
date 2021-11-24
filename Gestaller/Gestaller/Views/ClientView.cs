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
            Grid_ClienteVehiculo.DataSource = contactsVehicles;
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
            int selectedCell = Grid_ClienteVehiculo.CurrentCell.RowIndex;
            // Toma la lista de datos existente
            List<ContactVehicle> contactsVehicles = getContactsVehicles();
            // Selecciona el clienteVehiculo activo
            selectContactVehicle(contactsVehicles[selectedCell]);
            // Toma los datos del clienteVehiculo y los añade al comboBox
            setToComboBox();
        }

        private void button3AnadirCv_Click(object sender, EventArgs e) => newContact();

        #endregion

        #region private methods

        // Crea y añade un nuevo contacto y vehiculo
        private void newContact()
        {
            Contact contact = new Contact();
            Vehicle vehicle = new Vehicle();
            
            contact.company = Empresa_ClienteVehiculo.Text;
            contact.cif = CIF_ClienteVehiculo.Text;
            contact.fullName = Nombre_ClienteVehiculo.Text;
            contact.address = Direccion_ClienteVehiculo.Text;
            contact.city = Localidad_ClienteVehiculo.Text;
            contact.district = Provincia_ClienteVehiculo.Text;
            contact.cp = int.Parse(CP_ClienteVehiculo.Text);
            contact.mobile = Movil_ClienteVehiculo.Text;
            contact.phone = Telefono_ClienteVehiculo.Text;
            contact.fax = Fax_ClienteVehiculo.Text;
            contact.email = Email_ClienteVehiculo.Text;

            //_bussinessLogicLayer.newContact(contact);

            vehicle.enroll = Matricula_ClienteVehiculo.Text;
            vehicle.brand = Marca_ClienteVehiculo.Text;
            vehicle.model = Modelo_ClienteVehiculo.Text;
            vehicle.frame = Bastidor_ClienteVehiculo.Text;
            vehicle.kms = Kilometros_ClienteVehiculo.Text;
            vehicle.engineType = TipoMotor_ClienteVehiculo.Text;

            //_bussinessLogicLayer.newVehicle(vehicle);

            getDB();
        }

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
            _controls.Add(Empresa_ClienteVehiculo);
            _controls.Add(CIF_ClienteVehiculo);
            _controls.Add(Movil_ClienteVehiculo);
            _controls.Add(Telefono_ClienteVehiculo);
            _controls.Add(Fax_ClienteVehiculo);
            _controls.Add(Email_ClienteVehiculo);
            _controls.Add(Nombre_ClienteVehiculo);
            _controls.Add(Direccion_ClienteVehiculo);
            _controls.Add(Localidad_ClienteVehiculo);
            _controls.Add(Provincia_ClienteVehiculo);
            _controls.Add(CP_ClienteVehiculo);
            _controls.Add(Matricula_ClienteVehiculo);
            _controls.Add(Marca_ClienteVehiculo);
            _controls.Add(Modelo_ClienteVehiculo);
            _controls.Add(Bastidor_ClienteVehiculo);
            _controls.Add(Kilometros_ClienteVehiculo);
            _controls.Add(TipoMotor_ClienteVehiculo);
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
            Empresa_ClienteVehiculo.Text = _clientVehicle.contact_company;
            CIF_ClienteVehiculo.Text = _clientVehicle.contact_cif;
            Nombre_ClienteVehiculo.Text = _clientVehicle.contact_fullName;
            Direccion_ClienteVehiculo.Text = _clientVehicle.contact_address;
            Localidad_ClienteVehiculo.Text = _clientVehicle.contact_city;
            Provincia_ClienteVehiculo.Text = _clientVehicle.contact_district;
            CP_ClienteVehiculo.Text = _clientVehicle.contact_cp.ToString();
            Movil_ClienteVehiculo.Text = _clientVehicle.contact_mobile;
            Telefono_ClienteVehiculo.Text = _clientVehicle.contact_phone;
            Fax_ClienteVehiculo.Text = _clientVehicle.contact_fax;
            Email_ClienteVehiculo.Text = _clientVehicle.contact_email;
            Matricula_ClienteVehiculo.Text = _clientVehicle.vehicle_enroll;
            Marca_ClienteVehiculo.Text = _clientVehicle.vehicle_brand;
            Modelo_ClienteVehiculo.Text = _clientVehicle.vehicle_model;
            Bastidor_ClienteVehiculo.Text = _clientVehicle.vehicle_frame;
            Kilometros_ClienteVehiculo.Text = _clientVehicle.vehicle_kms;
            TipoMotor_ClienteVehiculo.Text = _clientVehicle.vehicle_engineType;
        }

        // Añade los items de los comboBoxes a la lista que se muestra
        private void clientItemSet()
        {
            List<ContactVehicle> contactsVehicles = getContactsVehicles();

            for (int i = 0; i < contactsVehicles.Count(); i++)
            {
                #region contacto

                // Empresa
                Empresa_ClienteVehiculo.Items.Add(contactsVehicles[i].contact_company);
                // CIF
                CIF_ClienteVehiculo.Items.Add(contactsVehicles[i].contact_cif);
                // Nombre
                Nombre_ClienteVehiculo.Items.Add(contactsVehicles[i].contact_fullName);
                // Dirección
                Direccion_ClienteVehiculo.Items.Add(contactsVehicles[i].contact_address);
                // Localidad
                Localidad_ClienteVehiculo.Items.Add(contactsVehicles[i].contact_city);
                // Provincia
                Provincia_ClienteVehiculo.Items.Add(contactsVehicles[i].contact_district);
                // CP
                CP_ClienteVehiculo.Items.Add(contactsVehicles[i].contact_cp);
                // Movil
                Movil_ClienteVehiculo.Items.Add(contactsVehicles[i].contact_mobile);
                // Teléfono
                Telefono_ClienteVehiculo.Items.Add(contactsVehicles[i].contact_phone);
                // FAX
                Fax_ClienteVehiculo.Items.Add(contactsVehicles[i].contact_fax);
                // Email
                Email_ClienteVehiculo.Items.Add(contactsVehicles[i].contact_email);
                #endregion

                #region vehiculo
                // Matricula
                Matricula_ClienteVehiculo.Items.Add(contactsVehicles[i].vehicle_enroll);
                // Marca
                Marca_ClienteVehiculo.Items.Add(contactsVehicles[i].vehicle_brand);
                // Modelo
                Modelo_ClienteVehiculo.Items.Add(contactsVehicles[i].vehicle_model);
                // Bastidor
                Bastidor_ClienteVehiculo.Items.Add(contactsVehicles[i].vehicle_frame);
                // Kilómetros
                Kilometros_ClienteVehiculo.Items.Add(contactsVehicles[i].vehicle_kms);
                // Tipo motor
                TipoMotor_ClienteVehiculo.Items.Add(contactsVehicles[i].vehicle_engineType);
                #endregion
            }


        }

        #endregion

        #region comboBoxSelectionEvent

        private void cueComboBoxEmpresa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Empresa_ClienteVehiculo.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBoxCIF_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = CIF_ClienteVehiculo.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBoxNombre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Nombre_ClienteVehiculo.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBoxDireccion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Direccion_ClienteVehiculo.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBoxMovil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Movil_ClienteVehiculo.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBoxEmail_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Email_ClienteVehiculo.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBoxMatricula_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Matricula_ClienteVehiculo.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBoxBastidor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _comboIndex = Bastidor_ClienteVehiculo.SelectedIndex;
            changesComboBoxes();
        }

        #endregion

    }
}