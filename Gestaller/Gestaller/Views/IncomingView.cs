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
            getDB();
            incomingItemSet();
        }

        private void getDB()
        {
            List<Incoming> incomings = _bussinessLogicLayer.GetIncomings();

            dataGridViewDepositos.DataSource = incomings;
        }

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
