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
        BussinessLogicLayer _bussinessLogicLayer = new BussinessLogicLayer();
        List<Control> _controls = new List<Control>();
        ContactVehicle _clientVehicle = null;
        Incoming _incoming = null;
        int _comboIndex;

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

        private void dataGridViewVehicles_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedCell = dataGridViewVehicles.CurrentCell.RowIndex;
            cellClickEvent(selectedCell);
        }

        private void dataGridViewDepositos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedCell = dataGridViewDepositos.CurrentCell.RowIndex;
            cellClickEvent(selectedCell);
        }
        
        private void button1Create_Click(object sender, EventArgs e)
        {
            createIncoming();
        }

        #endregion

        #region private methods

        private void createIncoming()
        {

        }

        private void changesComboBoxes()
        {
            List<ContactVehicle> contactsVehicles = getContactsVehicles();
            List<Incoming> incomings = getIncomings();

            selectContactVehicle(contactsVehicles[_comboIndex]);
            selectIncoming(incomings[_comboIndex]);

            setToComboBox();
        }

        // Evento al clickar en alguna celda o fila de un dataGridView
        void cellClickEvent(int index)
        {
            int selectedCell = index;
            List<Incoming> incomings = getIncomings();
            List<ContactVehicle> contactsVehicles = getContactsVehicles();
            selectContactVehicle(contactsVehicles[selectedCell]);
            selectIncoming(incomings[selectedCell]);
            setToComboBox();
        }

        // Vaciar texto
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
                    ((DateTimePicker)control).Value = DateTime.Today;
                }
            }
        }

        // Añadir controles
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

        // Obtener datos de incomings
        private void getIncomingDB()
        {
            List<Incoming> incomings = _bussinessLogicLayer.GetIncomings();

            dataGridViewDepositos.DataSource = incomings;
        }

        // Obtener datos de vehiculos
        private void getVehicleDB()
        {
            List<Vehicle> vehicles = _bussinessLogicLayer.GetVehicles();

            dataGridViewVehicles.DataSource = vehicles;
        }

        // ContactVehicle activo
        private void selectContactVehicle(ContactVehicle contactVehicle)
        {
            _clientVehicle = contactVehicle;
        }

        // Incoming activo
        private void selectIncoming(Incoming incoming)
        {
            _incoming = incoming;
        }

        // Añade los elementos activos al valor del comboBox
        private void setToComboBox()
        {
            // TODO
            // Muestra los datos en los cueComboBox

            cueComboBoxCliente.Text = _clientVehicle.contact_fullName;
            cueComboBoxMatricula.Text = _clientVehicle.vehicle_enroll;
            cueComboBoxMarca.Text = _clientVehicle.vehicle_brand;
            cueComboBoxModelo.Text = _clientVehicle.vehicle_model;
            cueTextBoxKMS.Text = _clientVehicle.vehicle_kms;
            cueComboBoxTipoMotor.Text = _clientVehicle.vehicle_engineType;
            cueComboBoxBastidor.Text = _clientVehicle.vehicle_frame;
            dateTimePicker1.Value = _incoming.incomingDate; // recepción
            dateTimePicker2.Value = _incoming.estimatedDate; // estimado
            dateTimePicker3.Value = _incoming.departureDate; // Entrega

        }

        // Añade la lista de items a los comboBoxes
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

        // Obtiene la lista de contactVehicles
        private List<ContactVehicle> getContactsVehicles()
        {
            return _bussinessLogicLayer.GetContactVehicles();
        }

        // Obtiene la lista de incomings 
        private List<Incoming> getIncomings()
        {
            return _bussinessLogicLayer.GetIncomings();
        }

        #endregion

        #region comboBoxSelectionEvent
        private void cueComboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            _comboIndex = cueComboBoxCliente.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBoxMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            _comboIndex = cueComboBoxMatricula.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBoxBastidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            _comboIndex = cueComboBoxBastidor.SelectedIndex;
            changesComboBoxes();
        }

        #endregion

    }
}
