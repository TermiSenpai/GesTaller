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
            int selectedCell = Grid_Vehicles_Recepciones.CurrentCell.RowIndex;
            cellClickEvent(selectedCell);
        }

        private void dataGridViewDepositos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedCell = Grid_Depositos_Recepciones.CurrentCell.RowIndex;
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
                    //((CueComboBox)control).SelectedIndex = -1;
                }

                if (control is CueTextBox)
                {
                    ((CueTextBox)control).ResetText();
                }

                if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Today;
                }

                if (control is RichTextBox)
                    ((RichTextBox)control).ResetText();
            }
        }

        // Añadir controles
        private void addControls()
        {
            _controls.Add(Cliente_Recepciones);
            _controls.Add(Matricula_Recepciones);
            _controls.Add(Marca_Recepciones);
            _controls.Add(Modelo_Recepciones);
            _controls.Add(Km_Vehiculo_Recepciones);
            _controls.Add(TipoMotor_Recepciones);
            _controls.Add(Bastidor_Recepciones);
            _controls.Add(Recepcion_Recepciones); // recepción
            _controls.Add(Estimado_Recepciones); // Estimado
            _controls.Add(Entrega_Recepciones); // Entrega
            _controls.Add(Km_Recepciones_Recepciones); // kilometros recepciones
            _controls.Add(Daños_Recepciones); // daños
        }

        // Obtener datos de incomings
        private void getIncomingDB()
        {
            List<Incoming> incomings = _bussinessLogicLayer.GetIncomings();

            Grid_Depositos_Recepciones.DataSource = incomings;
        }

        // Obtener datos de vehiculos
        private void getVehicleDB()
        {
            List<Vehicle> vehicles = _bussinessLogicLayer.GetVehicles();

            Grid_Vehicles_Recepciones.DataSource = vehicles;
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

            Cliente_Recepciones.Text = _clientVehicle.contact_fullName;
            Matricula_Recepciones.Text = _clientVehicle.vehicle_enroll;
            Marca_Recepciones.Text = _clientVehicle.vehicle_brand;
            Modelo_Recepciones.Text = _clientVehicle.vehicle_model;
            Km_Vehiculo_Recepciones.Text = _clientVehicle.vehicle_kms;
            TipoMotor_Recepciones.Text = _clientVehicle.vehicle_engineType;
            Bastidor_Recepciones.Text = _clientVehicle.vehicle_frame;
            Recepcion_Recepciones.Value = _incoming.incomingDate; // recepción
            Estimado_Recepciones.Value = _incoming.estimatedDate; // estimado
            Entrega_Recepciones.Value = _incoming.departureDate; // Entrega

        }

        // Añade la lista de items a los comboBoxes
        private void incomingItemSet()
        {
            List<ContactVehicle> contactsVehicles = _bussinessLogicLayer.GetContactVehicles();

            for (int i = 0; i < contactsVehicles.Count(); i++)
            {
                #region contacto
                // Nombre
                Cliente_Recepciones.Items.Add(contactsVehicles[i].contact_fullName);
                #endregion

                #region vehiculo
                // Matricula
                Matricula_Recepciones.Items.Add(contactsVehicles[i].vehicle_enroll);
                // Marca
                Marca_Recepciones.Items.Add(contactsVehicles[i].vehicle_brand);
                // Modelo
                Modelo_Recepciones.Items.Add(contactsVehicles[i].vehicle_model);
                // Bastidor
                Bastidor_Recepciones.Items.Add(contactsVehicles[i].vehicle_frame);
                // Tipo motor
                TipoMotor_Recepciones.Items.Add(contactsVehicles[i].vehicle_engineType);
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
            _comboIndex = Cliente_Recepciones.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBoxMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            _comboIndex = Matricula_Recepciones.SelectedIndex;
            changesComboBoxes();
        }

        private void cueComboBoxBastidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            _comboIndex = Bastidor_Recepciones.SelectedIndex;
            changesComboBoxes();
        }

        #endregion

    }
}
