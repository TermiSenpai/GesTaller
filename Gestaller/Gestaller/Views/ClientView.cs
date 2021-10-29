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

        public ClientView()
        {
            InitializeComponent();
            getDB();
            clientItemSet();
        }

        private void tabla2_clientes_V_Paint(object sender, PaintEventArgs e)
        {

        }

        #region events

        private void getDB()
        {
            List<ContactVehicle> contactsVehicles = getContactsVehicles();
            dataGrid.DataSource = contactsVehicles;
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

        private void cueComboBoxEmpresa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<ContactVehicle> contactsVehicles = getContactsVehicles();

            selectContactVehicle(contactsVehicles[cueComboBoxEmpresa.SelectedIndex]);

            setToComboBox();
        }

        private void cueComboBoxNombre_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        #endregion

        #region private methods

        private List<ContactVehicle> getContactsVehicles()
        {
            return _bussinessLogicLayer.GetContactVehicles();
        }

        private void selectContactVehicle(ContactVehicle contactVehicle)
        {
            _clientVehicle = contactVehicle;
        }
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
    }
}