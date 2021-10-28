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

        public ClientView()
        {
            InitializeComponent();
            getDB();
            itemSetComboBox();
        }

        private void tabla2_clientes_V_Paint(object sender, PaintEventArgs e)
        {

        }

        #region events

        private void getDB()
        {
            List<ContactVehicle> contactsVehicles = _bussinessLogicLayer.GetContactVehicles();
            dataGrid.DataSource = contactsVehicles;
        }

        // Al hacer click en cualquier celda se activa el evento
        private void dataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            setGridToComboBox();
        }

        #endregion

        #region private methods

        private void setGridToComboBox()
        {
            // toma el index de la celda selecionada
            int selectedCell = dataGrid.CurrentCell.RowIndex;
            // Toma la lista de datos existente
            List<ContactVehicle> contactsVehicles = _bussinessLogicLayer.GetContactVehicles();

            // Muestra los datos en los cueComboBox 
            cueComboBoxEmpresa.Text = contactsVehicles[selectedCell].contact_company;
            cueComboBoxCIF.Text = contactsVehicles[selectedCell].contact_cif;
            cueComboBoxNombre.Text = contactsVehicles[selectedCell].contact_fullName;
            cueComboBoxDireccion.Text = contactsVehicles[selectedCell].contact_address;
            cueComboBoxLocalidad.Text = contactsVehicles[selectedCell].contact_city;
            cueComboBoxProvincia.Text = contactsVehicles[selectedCell].contact_district;
            cueComboBoxCP.Text = contactsVehicles[selectedCell].contact_cp.ToString();
            cueComboBoxMovil.Text = contactsVehicles[selectedCell].contact_mobile;
            cueComboBoxTelefono.Text = contactsVehicles[selectedCell].contact_phone;
            cueComboBoxFax.Text = contactsVehicles[selectedCell].contact_fax;
            cueComboBoxEmail.Text = contactsVehicles[selectedCell].contact_email;
            cueComboBoxMatricula.Text = contactsVehicles[selectedCell].vehicle_enroll;
            cueComboBoxMarca.Text = contactsVehicles[selectedCell].vehicle_brand;
            cueComboBoxModelo.Text = contactsVehicles[selectedCell].vehicle_model;
            cueComboBoxBastidor.Text = contactsVehicles[selectedCell].vehicle_frame;
            cueComboBoxKilometros.Text = contactsVehicles[selectedCell].vehicle_kms;
            cueComboBoxTipoMotor.Text = contactsVehicles[selectedCell].vehicle_engineType;
        }

        private void itemSetComboBox()
        {
            List<ContactVehicle> contactsVehicles = _bussinessLogicLayer.GetContactVehicles();

            // Empresa
            for (int i = 0; i < contactsVehicles.Count(); i++)
            {
                #region contacto
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