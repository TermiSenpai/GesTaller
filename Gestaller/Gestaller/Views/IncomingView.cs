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
    public partial class IncomingView : Form
    {
        List<Control> _controls = new List<Control>();
        BussinessLogicLayer _bussinessLogicLayer = new BussinessLogicLayer();
        public IncomingView()
        {
            InitializeComponent();
            addControls();
        }

        #region events
        private void IncomingView_Load(object sender, EventArgs e)
        {
            getIncomingDB();
            getVehicleDB();
            incomingItemSet();
        }

        private void button7Vaciar_Click(object sender, EventArgs e)
        {
            clearText();
        }
        #endregion

        #region private methods

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

        private void addControls()
        {
            _controls.Add(cueComboBoxCliente);
            _controls.Add(cueComboBoxMatricula);
            _controls.Add(cueComboBoxMarca);
            _controls.Add(cueComboBoxModelo);
            _controls.Add(cueTextBoxKMS);
            _controls.Add(cueComboBoxTipoMotor);
            _controls.Add(cueComboBoxBastidor);
            _controls.Add(dateTimePicker1); // recepción
            _controls.Add(dateTimePicker2); // Estimado
            _controls.Add(dateTimePicker3); // Entrega
            _controls.Add(cueTextBox1); // kilometros recepciones
            _controls.Add(richTextBox1); // daños
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

        private void setToComboBox()
        {
            // TODO
            // Muestra los datos en los cueComboBox             
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

        #endregion
    }
}
