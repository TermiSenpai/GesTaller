﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestaller.Layers;

namespace Gestaller
{
    public partial class ClientView : Form
    {
        BussinessLogicLayer _bussinessLogicLayer = new BussinessLogicLayer();

        public ClientView()
        {
            InitializeComponent();
        }

        private void tabla2_clientes_V_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClientView_Load(object sender, EventArgs e)
        {
            getDB();
        }

        private void getDB()
        {
            List<ContactVehicle> contactsVehicles = _bussinessLogicLayer.GetContactVehicles();
            dataGrid.DataSource = contactsVehicles;
        }
    }
}
