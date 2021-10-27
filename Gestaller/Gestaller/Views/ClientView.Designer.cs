
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
            this.components = new System.ComponentModel.Container();
            this.tabControl_Clientes = new System.Windows.Forms.TabControl();
            this.tab_clientes_vehiculos = new System.Windows.Forms.TabPage();
            this.tabla1_clientes_V = new System.Windows.Forms.TableLayoutPanel();
            this.tabla3_clientes_V = new System.Windows.Forms.TableLayoutPanel();
            this.EncabezadoVehiculo = new System.Windows.Forms.Label();
            this.flowVehiculo = new System.Windows.Forms.FlowLayoutPanel();

            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.botonVaciar = new System.Windows.Forms.Button();
            this.botonAnadir = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.tab_datos_bancarios = new System.Windows.Forms.TabPage();
            this.table1_DatosB = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EncabezadoDatos_Bancarios = new System.Windows.Forms.Label();
            this.flowBanco_Caja = new System.Windows.Forms.FlowLayoutPanel();
            this.cueComboBoxEntidad = new Gestaller.Views.CueComboBox();
            this.cueTextBoxNumeroCuenta = new Gestaller.Views.CueTextBox();
            this.cueTextBoxFirma_Pago = new Gestaller.Views.CueTextBox();
            this.cueTextBoxDias_Pago = new Gestaller.Views.CueTextBox();
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
            this.tabControl_Clientes.Size = new System.Drawing.Size(622, 828);
            this.tabControl_Clientes.TabIndex = 0;
            // 
            // tab_clientes_vehiculos
            // 
            this.tab_clientes_vehiculos.Controls.Add(this.tabla1_clientes_V);
            this.tab_clientes_vehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_clientes_vehiculos.Location = new System.Drawing.Point(4, 22);
            this.tab_clientes_vehiculos.Margin = new System.Windows.Forms.Padding(0);
            this.tab_clientes_vehiculos.Name = "tab_clientes_vehiculos";
            this.tab_clientes_vehiculos.Size = new System.Drawing.Size(614, 802);
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
            this.tabla1_clientes_V.Size = new System.Drawing.Size(614, 802);
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
            this.tabla3_clientes_V.Size = new System.Drawing.Size(614, 72);
            this.tabla3_clientes_V.TabIndex = 1;
            // 
            // EncabezadoVehiculo
            // 
            this.EncabezadoVehiculo.AutoSize = true;
            this.EncabezadoVehiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncabezadoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncabezadoVehiculo.Location = new System.Drawing.Point(3, 0);
            this.EncabezadoVehiculo.Name = "EncabezadoVehiculo";
            this.EncabezadoVehiculo.Size = new System.Drawing.Size(608, 14);
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
            this.flowVehiculo.Size = new System.Drawing.Size(608, 52);
            this.flowVehiculo.TabIndex = 1;
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
            this.tabla2_clientes_V.Size = new System.Drawing.Size(614, 160);
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
            this.EncabezadoFacturación.Size = new System.Drawing.Size(608, 32);
            this.EncabezadoFacturación.TabIndex = 0;
            this.EncabezadoFacturación.Text = "DATOS DE FACTURACION DEL CLIENTE";
            // 
            // flowFacturacion
            // 
            this.flowFacturacion.AutoScroll = true;
            this.flowFacturacion.Controls.Add(this.cueComboBoxEmpresa);
            this.flowFacturacion.Controls.Add(this.cueComboBoxCIF);
            this.flowFacturacion.Controls.Add(this.cueComboBoxNombre);
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
            this.flowFacturacion.Size = new System.Drawing.Size(614, 128);
            this.flowFacturacion.TabIndex = 1;
            // 

            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.botonVaciar);
            this.flowLayoutPanel1.Controls.Add(this.botonAnadir);
            this.flowLayoutPanel1.Controls.Add(this.botonModificar);
            this.flowLayoutPanel1.Controls.Add(this.botonBorrar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(269, 232);
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
            this.dataGrid.Size = new System.Drawing.Size(608, 500);
            this.dataGrid.TabIndex = 3;
            // 
            // tab_datos_bancarios
            // 
            this.tab_datos_bancarios.Controls.Add(this.table1_DatosB);
            this.tab_datos_bancarios.Location = new System.Drawing.Point(4, 22);
            this.tab_datos_bancarios.Margin = new System.Windows.Forms.Padding(0);
            this.tab_datos_bancarios.Name = "tab_datos_bancarios";
            this.tab_datos_bancarios.Padding = new System.Windows.Forms.Padding(3);
            this.tab_datos_bancarios.Size = new System.Drawing.Size(614, 802);
            this.tab_datos_bancarios.TabIndex = 1;
            this.tab_datos_bancarios.Text = "Datos Bancarios";
            this.tab_datos_bancarios.UseVisualStyleBackColor = true;
            // 
            // table1_DatosB
            // 
            this.table1_DatosB.ColumnCount = 1;
            this.table1_DatosB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table1_DatosB.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.table1_DatosB.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.table1_DatosB.Controls.Add(this.dataGridDatosB, 0, 2);
            this.table1_DatosB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table1_DatosB.Location = new System.Drawing.Point(3, 3);
            this.table1_DatosB.Name = "table1_DatosB";
            this.table1_DatosB.RowCount = 3;
            this.table1_DatosB.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table1_DatosB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table1_DatosB.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table1_DatosB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table1_DatosB.Size = new System.Drawing.Size(608, 796);
            this.table1_DatosB.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.button3);
            this.flowLayoutPanel2.Controls.Add(this.button4);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(263, 106);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(345, 64);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vaciar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Añadir Cliente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(249, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 56);
            this.button4.TabIndex = 3;
            this.button4.Text = "Borrar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.EncabezadoDatos_Bancarios, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowBanco_Caja, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(602, 100);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // EncabezadoDatos_Bancarios
            // 
            this.EncabezadoDatos_Bancarios.AutoSize = true;
            this.EncabezadoDatos_Bancarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncabezadoDatos_Bancarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncabezadoDatos_Bancarios.Location = new System.Drawing.Point(3, 0);
            this.EncabezadoDatos_Bancarios.Name = "EncabezadoDatos_Bancarios";
            this.EncabezadoDatos_Bancarios.Size = new System.Drawing.Size(596, 20);
            this.EncabezadoDatos_Bancarios.TabIndex = 1;
            this.EncabezadoDatos_Bancarios.Text = "BANCO-CAJA";
            // 
            // flowBanco_Caja
            // 
            this.flowBanco_Caja.Controls.Add(this.cueComboBoxEntidad);
            this.flowBanco_Caja.Controls.Add(this.cueTextBoxNumeroCuenta);
            this.flowBanco_Caja.Controls.Add(this.cueTextBoxFirma_Pago);
            this.flowBanco_Caja.Controls.Add(this.cueTextBoxDias_Pago);
            this.flowBanco_Caja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowBanco_Caja.Location = new System.Drawing.Point(3, 23);
            this.flowBanco_Caja.Name = "flowBanco_Caja";
            this.flowBanco_Caja.Size = new System.Drawing.Size(596, 74);
            this.flowBanco_Caja.TabIndex = 2;
            // 
            // cueComboBoxEntidad
            // 
            this.cueComboBoxEntidad.CueText = "Entidad";
            this.cueComboBoxEntidad.FormattingEnabled = true;
            this.cueComboBoxEntidad.Location = new System.Drawing.Point(3, 3);
            this.cueComboBoxEntidad.Name = "cueComboBoxEntidad";
            this.cueComboBoxEntidad.Size = new System.Drawing.Size(248, 21);
            this.cueComboBoxEntidad.TabIndex = 1;
            // 
            // cueTextBoxNumeroCuenta
            // 
            this.cueTextBoxNumeroCuenta.CueText = "Número de Cuenta";
            this.cueTextBoxNumeroCuenta.Location = new System.Drawing.Point(257, 3);
            this.cueTextBoxNumeroCuenta.Name = "cueTextBoxNumeroCuenta";
            this.cueTextBoxNumeroCuenta.Size = new System.Drawing.Size(100, 20);
            this.cueTextBoxNumeroCuenta.TabIndex = 2;
            // 
            // cueTextBoxFirma_Pago
            // 
            this.cueTextBoxFirma_Pago.CueText = "Firma Pago";
            this.cueTextBoxFirma_Pago.Location = new System.Drawing.Point(363, 3);
            this.cueTextBoxFirma_Pago.Name = "cueTextBoxFirma_Pago";
            this.cueTextBoxFirma_Pago.Size = new System.Drawing.Size(100, 20);
            this.cueTextBoxFirma_Pago.TabIndex = 3;
            // 
            // cueTextBoxDias_Pago
            // 
            this.cueTextBoxDias_Pago.CueText = "Días Pago";
            this.cueTextBoxDias_Pago.Location = new System.Drawing.Point(469, 3);
            this.cueTextBoxDias_Pago.Name = "cueTextBoxDias_Pago";
            this.cueTextBoxDias_Pago.Size = new System.Drawing.Size(100, 20);
            this.cueTextBoxDias_Pago.TabIndex = 4;
            // 
            // tab_otras_direcciones
            // 
            this.tab_otras_direcciones.Controls.Add(this.tabla1_OtrasD);
            this.tab_otras_direcciones.Location = new System.Drawing.Point(4, 22);
            this.tab_otras_direcciones.Margin = new System.Windows.Forms.Padding(0);
            this.tab_otras_direcciones.Name = "tab_otras_direcciones";
            this.tab_otras_direcciones.Padding = new System.Windows.Forms.Padding(3);
            this.tab_otras_direcciones.Size = new System.Drawing.Size(614, 802);
            this.tab_otras_direcciones.TabIndex = 2;
            this.tab_otras_direcciones.Text = "Otras Direcciones";
            this.tab_otras_direcciones.UseVisualStyleBackColor = true;
            // 

            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 828);
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

    }
}
