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
        }

        private void tabla2_clientes_V_Paint(object sender, PaintEventArgs e)
        {

        }

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

    }
}