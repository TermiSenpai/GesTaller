
namespace Gestaller
{
    partial class ClientView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_Clientes = new System.Windows.Forms.TabControl();
            this.tab_clientes_vehiculos = new System.Windows.Forms.TabPage();
            this.tabla1_clientes_V = new System.Windows.Forms.TableLayoutPanel();
            this.tabla3_clientes_V = new System.Windows.Forms.TableLayoutPanel();
            this.EncabezadoVehiculo = new System.Windows.Forms.Label();
            this.flowVehiculo = new System.Windows.Forms.FlowLayoutPanel();
            this.cueComboBoxMatricula = new Gestaller.Views.CueComboBox();
            this.cueComboBoxMarca = new Gestaller.Views.CueComboBox();
            this.cueComboBoxModelo = new Gestaller.Views.CueComboBox();
            this.cueComboBoxBastidor = new Gestaller.Views.CueComboBox();
            this.cueComboBoxKilometros = new Gestaller.Views.CueComboBox();
            this.cueComboBoxTipoMotor = new Gestaller.Views.CueComboBox();
            this.tabla2_clientes_V = new System.Windows.Forms.TableLayoutPanel();
            this.EncabezadoFacturación = new System.Windows.Forms.Label();
            this.flowFacturacion = new System.Windows.Forms.FlowLayoutPanel();
            this.cueComboBoxEmpresa = new Gestaller.Views.CueComboBox();
            this.cueComboBoxNombre = new Gestaller.Views.CueComboBox();
            this.cueComboBoxCIF = new Gestaller.Views.CueComboBox();
            this.cueComboBoxDireccion = new Gestaller.Views.CueComboBox();
            this.cueComboBoxLocalidad = new Gestaller.Views.CueComboBox();
            this.cueComboBoxProvincia = new Gestaller.Views.CueComboBox();
            this.cueComboBoxCP = new Gestaller.Views.CueComboBox();
            this.cueComboBoxMovil = new Gestaller.Views.CueComboBox();
            this.cueComboBoxTelefono = new Gestaller.Views.CueComboBox();
            this.cueComboBoxFax = new Gestaller.Views.CueComboBox();
            this.cueComboBoxEmail = new Gestaller.Views.CueComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.botonVaciar = new System.Windows.Forms.Button();
            this.botonAnadir = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.tab_datos_bancarios = new System.Windows.Forms.TabPage();
            this.tab_otras_direcciones = new System.Windows.Forms.TabPage();
            this.tabControl_Clientes.SuspendLayout();
            this.tab_clientes_vehiculos.SuspendLayout();
            this.tabla1_clientes_V.SuspendLayout();
            this.tabla3_clientes_V.SuspendLayout();
            this.flowVehiculo.SuspendLayout();
            this.tabla2_clientes_V.SuspendLayout();
            this.flowFacturacion.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Clientes
            // 
            this.tabControl_Clientes.Controls.Add(this.tab_clientes_vehiculos);
            this.tabControl_Clientes.Controls.Add(this.tab_datos_bancarios);
            this.tabControl_Clientes.Controls.Add(this.tab_otras_direcciones);
            this.tabControl_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Clientes.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Clientes.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl_Clientes.Name = "tabControl_Clientes";
            this.tabControl_Clientes.SelectedIndex = 0;
            this.tabControl_Clientes.Size = new System.Drawing.Size(1102, 804);
            this.tabControl_Clientes.TabIndex = 0;
            // 
            // tab_clientes_vehiculos
            // 
            this.tab_clientes_vehiculos.Controls.Add(this.tabla1_clientes_V);
            this.tab_clientes_vehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_clientes_vehiculos.Location = new System.Drawing.Point(4, 22);
            this.tab_clientes_vehiculos.Margin = new System.Windows.Forms.Padding(0);
            this.tab_clientes_vehiculos.Name = "tab_clientes_vehiculos";
            this.tab_clientes_vehiculos.Size = new System.Drawing.Size(1094, 778);
            this.tab_clientes_vehiculos.TabIndex = 0;
            this.tab_clientes_vehiculos.Text = "Clientes-Vehiculos";
            this.tab_clientes_vehiculos.UseVisualStyleBackColor = true;
            // 
            // tabla1_clientes_V
            // 
            this.tabla1_clientes_V.ColumnCount = 1;
            this.tabla1_clientes_V.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabla1_clientes_V.Controls.Add(this.tabla3_clientes_V, 0, 1);
            this.tabla1_clientes_V.Controls.Add(this.tabla2_clientes_V, 0, 0);
            this.tabla1_clientes_V.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tabla1_clientes_V.Controls.Add(this.dataGrid, 0, 3);
            this.tabla1_clientes_V.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla1_clientes_V.Location = new System.Drawing.Point(0, 0);
            this.tabla1_clientes_V.Margin = new System.Windows.Forms.Padding(0);
            this.tabla1_clientes_V.Name = "tabla1_clientes_V";
            this.tabla1_clientes_V.RowCount = 4;
            this.tabla1_clientes_V.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabla1_clientes_V.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tabla1_clientes_V.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tabla1_clientes_V.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabla1_clientes_V.Size = new System.Drawing.Size(1094, 778);
            this.tabla1_clientes_V.TabIndex = 0;
            // 
            // tabla3_clientes_V
            // 
            this.tabla3_clientes_V.ColumnCount = 1;
            this.tabla3_clientes_V.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabla3_clientes_V.Controls.Add(this.EncabezadoVehiculo, 0, 0);
            this.tabla3_clientes_V.Controls.Add(this.flowVehiculo, 0, 1);
            this.tabla3_clientes_V.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla3_clientes_V.Location = new System.Drawing.Point(0, 160);
            this.tabla3_clientes_V.Margin = new System.Windows.Forms.Padding(0);
            this.tabla3_clientes_V.Name = "tabla3_clientes_V";
            this.tabla3_clientes_V.RowCount = 2;
            this.tabla3_clientes_V.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabla3_clientes_V.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tabla3_clientes_V.Size = new System.Drawing.Size(1094, 72);
            this.tabla3_clientes_V.TabIndex = 1;
            // 
            // EncabezadoVehiculo
            // 
            this.EncabezadoVehiculo.AutoSize = true;
            this.EncabezadoVehiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncabezadoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncabezadoVehiculo.Location = new System.Drawing.Point(3, 0);
            this.EncabezadoVehiculo.Name = "EncabezadoVehiculo";
            this.EncabezadoVehiculo.Size = new System.Drawing.Size(1088, 14);
            this.EncabezadoVehiculo.TabIndex = 0;
            this.EncabezadoVehiculo.Text = "DATOS DEL VEHICULO";
            // 
            // flowVehiculo
            // 
            this.flowVehiculo.AutoSize = true;
            this.flowVehiculo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowVehiculo.Controls.Add(this.cueComboBoxMatricula);
            this.flowVehiculo.Controls.Add(this.cueComboBoxMarca);
            this.flowVehiculo.Controls.Add(this.cueComboBoxModelo);
            this.flowVehiculo.Controls.Add(this.cueComboBoxBastidor);
            this.flowVehiculo.Controls.Add(this.cueComboBoxKilometros);
            this.flowVehiculo.Controls.Add(this.cueComboBoxTipoMotor);
            this.flowVehiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowVehiculo.Location = new System.Drawing.Point(3, 17);
            this.flowVehiculo.Name = "flowVehiculo";
            this.flowVehiculo.Size = new System.Drawing.Size(1088, 52);
            this.flowVehiculo.TabIndex = 1;
            // 
            // cueComboBoxMatricula
            // 
            this.cueComboBoxMatricula.CueText = "Matrícula";
            this.cueComboBoxMatricula.FormattingEnabled = true;
            this.cueComboBoxMatricula.Location = new System.Drawing.Point(3, 3);
            this.cueComboBoxMatricula.Name = "cueComboBoxMatricula";
            this.cueComboBoxMatricula.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxMatricula.TabIndex = 0;
            // 
            // cueComboBoxMarca
            // 
            this.cueComboBoxMarca.CueText = "Marca";
            this.cueComboBoxMarca.FormattingEnabled = true;
            this.cueComboBoxMarca.Location = new System.Drawing.Point(130, 3);
            this.cueComboBoxMarca.Name = "cueComboBoxMarca";
            this.cueComboBoxMarca.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxMarca.TabIndex = 1;
            // 
            // cueComboBoxModelo
            // 
            this.cueComboBoxModelo.CueText = "Modelo";
            this.cueComboBoxModelo.FormattingEnabled = true;
            this.cueComboBoxModelo.Location = new System.Drawing.Point(257, 3);
            this.cueComboBoxModelo.Name = "cueComboBoxModelo";
            this.cueComboBoxModelo.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxModelo.TabIndex = 2;
            // 
            // cueComboBoxBastidor
            // 
            this.cueComboBoxBastidor.CueText = "Bastidor";
            this.cueComboBoxBastidor.FormattingEnabled = true;
            this.cueComboBoxBastidor.Location = new System.Drawing.Point(384, 3);
            this.cueComboBoxBastidor.Name = "cueComboBoxBastidor";
            this.cueComboBoxBastidor.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxBastidor.TabIndex = 3;
            // 
            // cueComboBoxKilometros
            // 
            this.cueComboBoxKilometros.CueText = "Kilómetros";
            this.cueComboBoxKilometros.FormattingEnabled = true;
            this.cueComboBoxKilometros.Location = new System.Drawing.Point(511, 3);
            this.cueComboBoxKilometros.Name = "cueComboBoxKilometros";
            this.cueComboBoxKilometros.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxKilometros.TabIndex = 4;
            // 
            // cueComboBoxTipoMotor
            // 
            this.cueComboBoxTipoMotor.CueText = "Tipo de Motor";
            this.cueComboBoxTipoMotor.FormattingEnabled = true;
            this.cueComboBoxTipoMotor.Location = new System.Drawing.Point(638, 3);
            this.cueComboBoxTipoMotor.Name = "cueComboBoxTipoMotor";
            this.cueComboBoxTipoMotor.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxTipoMotor.TabIndex = 5;
            // 
            // tabla2_clientes_V
            // 
            this.tabla2_clientes_V.ColumnCount = 1;
            this.tabla2_clientes_V.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabla2_clientes_V.Controls.Add(this.EncabezadoFacturación, 0, 0);
            this.tabla2_clientes_V.Controls.Add(this.flowFacturacion, 0, 1);
            this.tabla2_clientes_V.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla2_clientes_V.Location = new System.Drawing.Point(0, 0);
            this.tabla2_clientes_V.Margin = new System.Windows.Forms.Padding(0);
            this.tabla2_clientes_V.Name = "tabla2_clientes_V";
            this.tabla2_clientes_V.RowCount = 2;
            this.tabla2_clientes_V.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabla2_clientes_V.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tabla2_clientes_V.Size = new System.Drawing.Size(1094, 160);
            this.tabla2_clientes_V.TabIndex = 0;
            this.tabla2_clientes_V.Paint += new System.Windows.Forms.PaintEventHandler(this.tabla2_clientes_V_Paint);
            // 
            // EncabezadoFacturación
            // 
            this.EncabezadoFacturación.AutoSize = true;
            this.EncabezadoFacturación.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncabezadoFacturación.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncabezadoFacturación.Location = new System.Drawing.Point(3, 0);
            this.EncabezadoFacturación.Name = "EncabezadoFacturación";
            this.EncabezadoFacturación.Size = new System.Drawing.Size(1088, 32);
            this.EncabezadoFacturación.TabIndex = 0;
            this.EncabezadoFacturación.Text = "DATOS DE FACTURACION DEL CLIENTE";
            // 
            // flowFacturacion
            // 
            this.flowFacturacion.AutoScroll = true;
            this.flowFacturacion.Controls.Add(this.cueComboBoxEmpresa);
            this.flowFacturacion.Controls.Add(this.cueComboBoxNombre);
            this.flowFacturacion.Controls.Add(this.cueComboBoxCIF);
            this.flowFacturacion.Controls.Add(this.cueComboBoxDireccion);
            this.flowFacturacion.Controls.Add(this.cueComboBoxLocalidad);
            this.flowFacturacion.Controls.Add(this.cueComboBoxProvincia);
            this.flowFacturacion.Controls.Add(this.cueComboBoxCP);
            this.flowFacturacion.Controls.Add(this.cueComboBoxMovil);
            this.flowFacturacion.Controls.Add(this.cueComboBoxTelefono);
            this.flowFacturacion.Controls.Add(this.cueComboBoxFax);
            this.flowFacturacion.Controls.Add(this.cueComboBoxEmail);
            this.flowFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowFacturacion.Location = new System.Drawing.Point(0, 32);
            this.flowFacturacion.Margin = new System.Windows.Forms.Padding(0);
            this.flowFacturacion.Name = "flowFacturacion";
            this.flowFacturacion.Size = new System.Drawing.Size(1094, 128);
            this.flowFacturacion.TabIndex = 1;
            // 
            // cueComboBoxEmpresa
            // 
            this.cueComboBoxEmpresa.CueText = "Empresa";
            this.cueComboBoxEmpresa.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cueComboBoxEmpresa.FormattingEnabled = true;
            this.cueComboBoxEmpresa.Items.AddRange(new object[] {
            "Empresa",
            "Empresa"});
            this.cueComboBoxEmpresa.Location = new System.Drawing.Point(3, 3);
            this.cueComboBoxEmpresa.Name = "cueComboBoxEmpresa";
            this.cueComboBoxEmpresa.Size = new System.Drawing.Size(248, 24);
            this.cueComboBoxEmpresa.TabIndex = 1;
            // 
            // cueComboBoxNombre
            // 
            this.cueComboBoxNombre.CueText = "Nombre";
            this.cueComboBoxNombre.FormattingEnabled = true;
            this.cueComboBoxNombre.Location = new System.Drawing.Point(257, 3);
            this.cueComboBoxNombre.Name = "cueComboBoxNombre";
            this.cueComboBoxNombre.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxNombre.TabIndex = 7;
            // 
            // cueComboBoxCIF
            // 
            this.cueComboBoxCIF.CueText = "C.I.F.";
            this.cueComboBoxCIF.FormattingEnabled = true;
            this.cueComboBoxCIF.Location = new System.Drawing.Point(384, 3);
            this.cueComboBoxCIF.Name = "cueComboBoxCIF";
            this.cueComboBoxCIF.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxCIF.TabIndex = 2;
            // 
            // cueComboBoxDireccion
            // 
            this.cueComboBoxDireccion.CueText = "Dirección";
            this.cueComboBoxDireccion.FormattingEnabled = true;
            this.cueComboBoxDireccion.Location = new System.Drawing.Point(511, 3);
            this.cueComboBoxDireccion.Name = "cueComboBoxDireccion";
            this.cueComboBoxDireccion.Size = new System.Drawing.Size(248, 24);
            this.cueComboBoxDireccion.TabIndex = 8;
            // 
            // cueComboBoxLocalidad
            // 
            this.cueComboBoxLocalidad.CueText = "Localidad";
            this.cueComboBoxLocalidad.FormattingEnabled = true;
            this.cueComboBoxLocalidad.Location = new System.Drawing.Point(765, 3);
            this.cueComboBoxLocalidad.Name = "cueComboBoxLocalidad";
            this.cueComboBoxLocalidad.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxLocalidad.TabIndex = 9;
            // 
            // cueComboBoxProvincia
            // 
            this.cueComboBoxProvincia.CueText = "Provincia";
            this.cueComboBoxProvincia.FormattingEnabled = true;
            this.cueComboBoxProvincia.Location = new System.Drawing.Point(892, 3);
            this.cueComboBoxProvincia.Name = "cueComboBoxProvincia";
            this.cueComboBoxProvincia.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxProvincia.TabIndex = 10;
            // 
            // cueComboBoxCP
            // 
            this.cueComboBoxCP.CueText = "C.P.";
            this.cueComboBoxCP.FormattingEnabled = true;
            this.cueComboBoxCP.Location = new System.Drawing.Point(3, 33);
            this.cueComboBoxCP.Name = "cueComboBoxCP";
            this.cueComboBoxCP.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxCP.TabIndex = 11;
            // 
            // cueComboBoxMovil
            // 
            this.cueComboBoxMovil.CueText = "Móvil";
            this.cueComboBoxMovil.FormattingEnabled = true;
            this.cueComboBoxMovil.Location = new System.Drawing.Point(130, 33);
            this.cueComboBoxMovil.Name = "cueComboBoxMovil";
            this.cueComboBoxMovil.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxMovil.TabIndex = 3;
            // 
            // cueComboBoxTelefono
            // 
            this.cueComboBoxTelefono.CueText = "Teléfono";
            this.cueComboBoxTelefono.FormattingEnabled = true;
            this.cueComboBoxTelefono.Location = new System.Drawing.Point(257, 33);
            this.cueComboBoxTelefono.Name = "cueComboBoxTelefono";
            this.cueComboBoxTelefono.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxTelefono.TabIndex = 4;
            // 
            // cueComboBoxFax
            // 
            this.cueComboBoxFax.CueText = "Fax";
            this.cueComboBoxFax.FormattingEnabled = true;
            this.cueComboBoxFax.Location = new System.Drawing.Point(384, 33);
            this.cueComboBoxFax.Name = "cueComboBoxFax";
            this.cueComboBoxFax.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxFax.TabIndex = 5;
            // 
            // cueComboBoxEmail
            // 
            this.cueComboBoxEmail.CueText = "E-Mail";
            this.cueComboBoxEmail.FormattingEnabled = true;
            this.cueComboBoxEmail.Location = new System.Drawing.Point(511, 33);
            this.cueComboBoxEmail.Name = "cueComboBoxEmail";
            this.cueComboBoxEmail.Size = new System.Drawing.Size(248, 24);
            this.cueComboBoxEmail.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.botonVaciar);
            this.flowLayoutPanel1.Controls.Add(this.botonAnadir);
            this.flowLayoutPanel1.Controls.Add(this.botonModificar);
            this.flowLayoutPanel1.Controls.Add(this.botonBorrar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(749, 232);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 64);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // botonVaciar
            // 
            this.botonVaciar.Location = new System.Drawing.Point(6, 3);
            this.botonVaciar.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.botonVaciar.Name = "botonVaciar";
            this.botonVaciar.Size = new System.Drawing.Size(75, 56);
            this.botonVaciar.TabIndex = 0;
            this.botonVaciar.Text = "Vaciar";
            this.botonVaciar.UseVisualStyleBackColor = true;
            // 
            // botonAnadir
            // 
            this.botonAnadir.Location = new System.Drawing.Point(87, 3);
            this.botonAnadir.Name = "botonAnadir";
            this.botonAnadir.Size = new System.Drawing.Size(75, 56);
            this.botonAnadir.TabIndex = 1;
            this.botonAnadir.Text = "Añadir Cliente";
            this.botonAnadir.UseVisualStyleBackColor = true;
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(168, 3);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(75, 56);
            this.botonModificar.TabIndex = 2;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            // 
            // botonBorrar
            // 
            this.botonBorrar.Location = new System.Drawing.Point(249, 3);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(89, 56);
            this.botonBorrar.TabIndex = 3;
            this.botonBorrar.Text = "Borrar";
            this.botonBorrar.UseVisualStyleBackColor = true;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(3, 299);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1088, 500);
            this.dataGrid.TabIndex = 3;
            // 
            // tab_datos_bancarios
            // 
            this.tab_datos_bancarios.Location = new System.Drawing.Point(4, 22);
            this.tab_datos_bancarios.Margin = new System.Windows.Forms.Padding(0);
            this.tab_datos_bancarios.Name = "tab_datos_bancarios";
            this.tab_datos_bancarios.Padding = new System.Windows.Forms.Padding(3);
            this.tab_datos_bancarios.Size = new System.Drawing.Size(614, 802);
            this.tab_datos_bancarios.TabIndex = 1;
            this.tab_datos_bancarios.Text = "Datos Bancarios";
            this.tab_datos_bancarios.UseVisualStyleBackColor = true;
            // 
            // tab_otras_direcciones
            // 
            this.tab_otras_direcciones.Location = new System.Drawing.Point(4, 22);
            this.tab_otras_direcciones.Margin = new System.Windows.Forms.Padding(0);
            this.tab_otras_direcciones.Name = "tab_otras_direcciones";
            this.tab_otras_direcciones.Padding = new System.Windows.Forms.Padding(3);
            this.tab_otras_direcciones.Size = new System.Drawing.Size(614, 802);
            this.tab_otras_direcciones.TabIndex = 2;
            this.tab_otras_direcciones.Text = "Otras Direcciones";
            this.tab_otras_direcciones.UseVisualStyleBackColor = true;
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 804);
            this.Controls.Add(this.tabControl_Clientes);
            this.Name = "ClientView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ClientView_Load);
            this.tabControl_Clientes.ResumeLayout(false);
            this.tab_clientes_vehiculos.ResumeLayout(false);
            this.tabla1_clientes_V.ResumeLayout(false);
            this.tabla3_clientes_V.ResumeLayout(false);
            this.tabla3_clientes_V.PerformLayout();
            this.flowVehiculo.ResumeLayout(false);
            this.tabla2_clientes_V.ResumeLayout(false);
            this.tabla2_clientes_V.PerformLayout();
            this.flowFacturacion.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Clientes;
        private System.Windows.Forms.TabPage tab_clientes_vehiculos;
        private System.Windows.Forms.TabPage tab_datos_bancarios;
        private System.Windows.Forms.TabPage tab_otras_direcciones;
        private System.Windows.Forms.TableLayoutPanel tabla1_clientes_V;
        private System.Windows.Forms.TableLayoutPanel tabla2_clientes_V;
        private System.Windows.Forms.TableLayoutPanel tabla3_clientes_V;
        private System.Windows.Forms.Label EncabezadoVehiculo;
        private System.Windows.Forms.Label EncabezadoFacturación;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button botonVaciar;
        private System.Windows.Forms.Button botonAnadir;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.FlowLayoutPanel flowFacturacion;
        private Views.CueComboBox cueComboBoxEmpresa;
        private Views.CueComboBox cueComboBoxCIF;
        private Views.CueComboBox cueComboBoxMovil;
        private Views.CueComboBox cueComboBoxTelefono;
        private Views.CueComboBox cueComboBoxFax;
        private Views.CueComboBox cueComboBoxEmail;
        private Views.CueComboBox cueComboBoxNombre;
        private Views.CueComboBox cueComboBoxDireccion;
        private Views.CueComboBox cueComboBoxLocalidad;
        private Views.CueComboBox cueComboBoxProvincia;
        private Views.CueComboBox cueComboBoxCP;
        private System.Windows.Forms.FlowLayoutPanel flowVehiculo;
        private Views.CueComboBox cueComboBoxMatricula;
        private Views.CueComboBox cueComboBoxMarca;
        private Views.CueComboBox cueComboBoxModelo;
        private Views.CueComboBox cueComboBoxBastidor;
        private Views.CueComboBox cueComboBoxKilometros;
        private Views.CueComboBox cueComboBoxTipoMotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleDataGridViewTextBoxColumn;
    }
}