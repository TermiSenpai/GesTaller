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
    public partial class IncomingView : Form
    {

        BussinessLogicLayer _bussinessLogicLayer = new BussinessLogicLayer();
        public IncomingView()
        {
            InitializeComponent();
        }

        private void IncomingView_Load(object sender, EventArgs e)
        {
            getIncomingDB();
            getVehicleDB();
            incomingItemSet();
        }

        private void getIncomingDB()
        {
            List<Incoming> incomings = _bussinessLogicLayer.GetIncomings();

            dataGridViewDepositos.DataSource = incomings;
        }

        private void getVehicleDB()
        {
            List<Vehicle> vehicles = _bussinessLogicLayer.GetVehicles();

            dataGridViewVehicles.DataSource = vehicles;
        }

       /* private void setToComboBox()
        {

            // Muestra los datos en los cueComboBox 
            cueComboBoxCliente.Text = _clientVehicle.contact_company;
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
        }*/

        private void incomingItemSet()
        {
            List<ContactVehicle> contactsVehicles = _bussinessLogicLayer.GetContactVehicles();

            for (int i = 0; i < contactsVehicles.Count(); i++)
            {
                #region contacto
                // Nombre
                cueComboBoxCliente.Items.Add(contactsVehicles[i].contact_fullName);
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
                // Tipo motor
                cueComboBoxTipoMotor.Items.Add(contactsVehicles[i].vehicle_engineType);
                #endregion
            }
        }
    }
}
