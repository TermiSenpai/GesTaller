
namespace Gestaller
{
    partial class OptionsView
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
            this.tableOpciones = new System.Windows.Forms.TableLayoutPanel();
            this.label1DatosEm = new System.Windows.Forms.Label();
            this.flowDatosEm = new System.Windows.Forms.FlowLayoutPanel();
            this.cueComboBoxEmpresa = new Gestaller.Views.CueComboBox();
            this.cueComboBoxCIF = new Gestaller.Views.CueComboBox();
            this.cueComboBoxDireccion = new Gestaller.Views.CueComboBox();
            this.cueComboBoxLocalidad = new Gestaller.Views.CueComboBox();
            this.cueComboBoxProvincia = new Gestaller.Views.CueComboBox();
            this.cueComboBoxCP = new Gestaller.Views.CueComboBox();
            this.cueComboBoxMovil = new Gestaller.Views.CueComboBox();
            this.cueComboBoxTelefono = new Gestaller.Views.CueComboBox();
            this.cueComboBoxFax = new Gestaller.Views.CueComboBox();
            this.cueComboBoxEmail = new Gestaller.Views.CueComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonAplicar = new System.Windows.Forms.Button();
            this.cueComboBoxValor = new Gestaller.Views.CueComboBox();
            this.cueComboBoxTipoIVA = new Gestaller.Views.CueComboBox();
            this.dataGridViewIVA = new System.Windows.Forms.DataGridView();
            this.tabControlOpciones = new System.Windows.Forms.TabControl();
            this.tabPageDatosE = new System.Windows.Forms.TabPage();
            this.tabPageServidor = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelServ = new System.Windows.Forms.TableLayoutPanel();
            this.labelServidor = new System.Windows.Forms.Label();
            this.tableLayoutPanelServidor = new System.Windows.Forms.TableLayoutPanel();
            this.panelLoggin_Servidor = new System.Windows.Forms.Panel();
            this.cueTextBoxContrasena = new Gestaller.Views.CueTextBox();
            this.flowLayoutPanelConex_Servidor = new System.Windows.Forms.FlowLayoutPanel();
            this.cueTextBoxHost = new Gestaller.Views.CueTextBox();
            this.cueTextBoxPuerto = new Gestaller.Views.CueTextBox();
            this.cueTextBoxUsuario = new Gestaller.Views.CueTextBox();
            this.labelIVA = new System.Windows.Forms.Label();
            this.tableOpciones.SuspendLayout();
            this.flowDatosEm.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIVA)).BeginInit();
            this.tabControlOpciones.SuspendLayout();
            this.tabPageDatosE.SuspendLayout();
            this.tabPageServidor.SuspendLayout();
            this.tableLayoutPanelServ.SuspendLayout();
            this.tableLayoutPanelServidor.SuspendLayout();
            this.panelLoggin_Servidor.SuspendLayout();
            this.flowLayoutPanelConex_Servidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableOpciones
            // 
            this.tableOpciones.ColumnCount = 1;
            this.tableOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableOpciones.Controls.Add(this.dataGridViewIVA, 0, 4);
            this.tableOpciones.Controls.Add(this.panel1, 0, 3);
            this.tableOpciones.Controls.Add(this.flowDatosEm, 0, 1);
            this.tableOpciones.Controls.Add(this.labelIVA, 0, 2);
            this.tableOpciones.Controls.Add(this.label1DatosEm, 0, 0);
            this.tableOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableOpciones.Location = new System.Drawing.Point(3, 3);
            this.tableOpciones.Name = "tableOpciones";
            this.tableOpciones.RowCount = 5;
            this.tableOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableOpciones.Size = new System.Drawing.Size(761, 527);
            this.tableOpciones.TabIndex = 0;
            // 
            // label1DatosEm
            // 
            this.label1DatosEm.AutoSize = true;
            this.label1DatosEm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1DatosEm.Location = new System.Drawing.Point(3, 7);
            this.label1DatosEm.Name = "label1DatosEm";
            this.label1DatosEm.Size = new System.Drawing.Size(755, 17);
            this.label1DatosEm.TabIndex = 0;
            this.label1DatosEm.Text = "DATOS DE EMPRESA";
            // 
            // flowDatosEm
            // 
            this.flowDatosEm.AutoScroll = true;
            this.flowDatosEm.Controls.Add(this.cueComboBoxEmpresa);
            this.flowDatosEm.Controls.Add(this.cueComboBoxCIF);
            this.flowDatosEm.Controls.Add(this.cueComboBoxDireccion);
            this.flowDatosEm.Controls.Add(this.cueComboBoxLocalidad);
            this.flowDatosEm.Controls.Add(this.cueComboBoxProvincia);
            this.flowDatosEm.Controls.Add(this.cueComboBoxCP);
            this.flowDatosEm.Controls.Add(this.cueComboBoxMovil);
            this.flowDatosEm.Controls.Add(this.cueComboBoxTelefono);
            this.flowDatosEm.Controls.Add(this.cueComboBoxFax);
            this.flowDatosEm.Controls.Add(this.cueComboBoxEmail);
            this.flowDatosEm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowDatosEm.Location = new System.Drawing.Point(3, 27);
            this.flowDatosEm.Name = "flowDatosEm";
            this.flowDatosEm.Size = new System.Drawing.Size(755, 90);
            this.flowDatosEm.TabIndex = 1;
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
            // cueComboBoxCIF
            // 
            this.cueComboBoxCIF.CueText = "C.I.F.";
            this.cueComboBoxCIF.FormattingEnabled = true;
            this.cueComboBoxCIF.Location = new System.Drawing.Point(257, 3);
            this.cueComboBoxCIF.Name = "cueComboBoxCIF";
            this.cueComboBoxCIF.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxCIF.TabIndex = 2;
            // 
            // cueComboBoxDireccion
            // 
            this.cueComboBoxDireccion.CueText = "Dirección";
            this.cueComboBoxDireccion.FormattingEnabled = true;
            this.cueComboBoxDireccion.Location = new System.Drawing.Point(384, 3);
            this.cueComboBoxDireccion.Name = "cueComboBoxDireccion";
            this.cueComboBoxDireccion.Size = new System.Drawing.Size(248, 24);
            this.cueComboBoxDireccion.TabIndex = 3;
            // 
            // cueComboBoxLocalidad
            // 
            this.cueComboBoxLocalidad.CueText = "Localidad";
            this.cueComboBoxLocalidad.FormattingEnabled = true;
            this.cueComboBoxLocalidad.Location = new System.Drawing.Point(3, 33);
            this.cueComboBoxLocalidad.Name = "cueComboBoxLocalidad";
            this.cueComboBoxLocalidad.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxLocalidad.TabIndex = 4;
            // 
            // cueComboBoxProvincia
            // 
            this.cueComboBoxProvincia.CueText = "Provincia";
            this.cueComboBoxProvincia.FormattingEnabled = true;
            this.cueComboBoxProvincia.Location = new System.Drawing.Point(130, 33);
            this.cueComboBoxProvincia.Name = "cueComboBoxProvincia";
            this.cueComboBoxProvincia.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxProvincia.TabIndex = 5;
            // 
            // cueComboBoxCP
            // 
            this.cueComboBoxCP.CueText = "C.P.";
            this.cueComboBoxCP.FormattingEnabled = true;
            this.cueComboBoxCP.Location = new System.Drawing.Point(257, 33);
            this.cueComboBoxCP.Name = "cueComboBoxCP";
            this.cueComboBoxCP.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxCP.TabIndex = 6;
            // 
            // cueComboBoxMovil
            // 
            this.cueComboBoxMovil.CueText = "Móvil";
            this.cueComboBoxMovil.FormattingEnabled = true;
            this.cueComboBoxMovil.Location = new System.Drawing.Point(384, 33);
            this.cueComboBoxMovil.Name = "cueComboBoxMovil";
            this.cueComboBoxMovil.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxMovil.TabIndex = 7;
            // 
            // cueComboBoxTelefono
            // 
            this.cueComboBoxTelefono.CueText = "Teléfono";
            this.cueComboBoxTelefono.FormattingEnabled = true;
            this.cueComboBoxTelefono.Location = new System.Drawing.Point(511, 33);
            this.cueComboBoxTelefono.Name = "cueComboBoxTelefono";
            this.cueComboBoxTelefono.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxTelefono.TabIndex = 8;
            // 
            // cueComboBoxFax
            // 
            this.cueComboBoxFax.CueText = "Fax";
            this.cueComboBoxFax.FormattingEnabled = true;
            this.cueComboBoxFax.Location = new System.Drawing.Point(3, 63);
            this.cueComboBoxFax.Name = "cueComboBoxFax";
            this.cueComboBoxFax.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxFax.TabIndex = 9;
            // 
            // cueComboBoxEmail
            // 
            this.cueComboBoxEmail.CueText = "E-Mail";
            this.cueComboBoxEmail.FormattingEnabled = true;
            this.cueComboBoxEmail.Location = new System.Drawing.Point(130, 63);
            this.cueComboBoxEmail.Name = "cueComboBoxEmail";
            this.cueComboBoxEmail.Size = new System.Drawing.Size(248, 24);
            this.cueComboBoxEmail.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Controls.Add(this.buttonEliminar);
            this.panel1.Controls.Add(this.buttonModificar);
            this.panel1.Controls.Add(this.buttonAplicar);
            this.panel1.Controls.Add(this.cueComboBoxValor);
            this.panel1.Controls.Add(this.cueComboBoxTipoIVA);
            this.panel1.Location = new System.Drawing.Point(3, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 74);
            this.panel1.TabIndex = 3;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(248, 48);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(167, 49);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(85, 49);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 3;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(4, 49);
            this.buttonAplicar.Name = "buttonAplicar";
            this.buttonAplicar.Size = new System.Drawing.Size(75, 23);
            this.buttonAplicar.TabIndex = 2;
            this.buttonAplicar.Text = "Aplicar";
            this.buttonAplicar.UseVisualStyleBackColor = true;
            // 
            // cueComboBoxValor
            // 
            this.cueComboBoxValor.CueText = "Valor";
            this.cueComboBoxValor.FormattingEnabled = true;
            this.cueComboBoxValor.Location = new System.Drawing.Point(130, 3);
            this.cueComboBoxValor.Name = "cueComboBoxValor";
            this.cueComboBoxValor.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxValor.TabIndex = 1;
            // 
            // cueComboBoxTipoIVA
            // 
            this.cueComboBoxTipoIVA.CueText = "Tipo";
            this.cueComboBoxTipoIVA.FormattingEnabled = true;
            this.cueComboBoxTipoIVA.Location = new System.Drawing.Point(3, 3);
            this.cueComboBoxTipoIVA.Name = "cueComboBoxTipoIVA";
            this.cueComboBoxTipoIVA.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxTipoIVA.TabIndex = 0;
            // 
            // dataGridViewIVA
            // 
            this.dataGridViewIVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIVA.Location = new System.Drawing.Point(3, 227);
            this.dataGridViewIVA.Name = "dataGridViewIVA";
            this.dataGridViewIVA.Size = new System.Drawing.Size(755, 297);
            this.dataGridViewIVA.TabIndex = 4;
            // 
            // tabControlOpciones
            // 
            this.tabControlOpciones.Controls.Add(this.tabPageDatosE);
            this.tabControlOpciones.Controls.Add(this.tabPageServidor);
            this.tabControlOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOpciones.Location = new System.Drawing.Point(0, 0);
            this.tabControlOpciones.Name = "tabControlOpciones";
            this.tabControlOpciones.SelectedIndex = 0;
            this.tabControlOpciones.Size = new System.Drawing.Size(775, 562);
            this.tabControlOpciones.TabIndex = 0;
            // 
            // tabPageDatosE
            // 
            this.tabPageDatosE.Controls.Add(this.tableOpciones);
            this.tabPageDatosE.Location = new System.Drawing.Point(4, 25);
            this.tabPageDatosE.Name = "tabPageDatosE";
            this.tabPageDatosE.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDatosE.Size = new System.Drawing.Size(767, 533);
            this.tabPageDatosE.TabIndex = 0;
            this.tabPageDatosE.Text = "Empresa e I.V.A.";
            this.tabPageDatosE.UseVisualStyleBackColor = true;
            // 
            // tabPageServidor
            // 
            this.tabPageServidor.Controls.Add(this.tableLayoutPanelServ);
            this.tabPageServidor.Location = new System.Drawing.Point(4, 25);
            this.tabPageServidor.Name = "tabPageServidor";
            this.tabPageServidor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServidor.Size = new System.Drawing.Size(767, 533);
            this.tabPageServidor.TabIndex = 1;
            this.tabPageServidor.Text = "Servidor";
            this.tabPageServidor.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelServ
            // 
            this.tableLayoutPanelServ.ColumnCount = 1;
            this.tableLayoutPanelServ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelServ.Controls.Add(this.labelServidor, 0, 0);
            this.tableLayoutPanelServ.Controls.Add(this.tableLayoutPanelServidor, 0, 1);
            this.tableLayoutPanelServ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelServ.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelServ.Name = "tableLayoutPanelServ";
            this.tableLayoutPanelServ.RowCount = 2;
            this.tableLayoutPanelServ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanelServ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelServ.Size = new System.Drawing.Size(761, 527);
            this.tableLayoutPanelServ.TabIndex = 0;
            // 
            // labelServidor
            // 
            this.labelServidor.AutoSize = true;
            this.labelServidor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelServidor.Location = new System.Drawing.Point(3, 7);
            this.labelServidor.Name = "labelServidor";
            this.labelServidor.Size = new System.Drawing.Size(755, 17);
            this.labelServidor.TabIndex = 1;
            this.labelServidor.Text = "SERVIDOR";
            // 
            // tableLayoutPanelServidor
            // 
            this.tableLayoutPanelServidor.ColumnCount = 1;
            this.tableLayoutPanelServidor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelServidor.Controls.Add(this.panelLoggin_Servidor, 0, 1);
            this.tableLayoutPanelServidor.Controls.Add(this.flowLayoutPanelConex_Servidor, 0, 0);
            this.tableLayoutPanelServidor.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanelServidor.Name = "tableLayoutPanelServidor";
            this.tableLayoutPanelServidor.RowCount = 2;
            this.tableLayoutPanelServidor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelServidor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelServidor.Size = new System.Drawing.Size(175, 104);
            this.tableLayoutPanelServidor.TabIndex = 2;
            // 
            // panelLoggin_Servidor
            // 
            this.panelLoggin_Servidor.Controls.Add(this.cueTextBoxUsuario);
            this.panelLoggin_Servidor.Controls.Add(this.cueTextBoxContrasena);
            this.panelLoggin_Servidor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoggin_Servidor.Location = new System.Drawing.Point(3, 38);
            this.panelLoggin_Servidor.Name = "panelLoggin_Servidor";
            this.panelLoggin_Servidor.Size = new System.Drawing.Size(169, 63);
            this.panelLoggin_Servidor.TabIndex = 1;
            // 
            // cueTextBoxContrasena
            // 
            this.cueTextBoxContrasena.CueText = "Contraseña";
            this.cueTextBoxContrasena.Location = new System.Drawing.Point(3, 36);
            this.cueTextBoxContrasena.Name = "cueTextBoxContrasena";
            this.cueTextBoxContrasena.Size = new System.Drawing.Size(161, 23);
            this.cueTextBoxContrasena.TabIndex = 4;
            // 
            // flowLayoutPanelConex_Servidor
            // 
            this.flowLayoutPanelConex_Servidor.Controls.Add(this.cueTextBoxHost);
            this.flowLayoutPanelConex_Servidor.Controls.Add(this.cueTextBoxPuerto);
            this.flowLayoutPanelConex_Servidor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelConex_Servidor.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelConex_Servidor.Name = "flowLayoutPanelConex_Servidor";
            this.flowLayoutPanelConex_Servidor.Size = new System.Drawing.Size(169, 29);
            this.flowLayoutPanelConex_Servidor.TabIndex = 0;
            // 
            // cueTextBoxHost
            // 
            this.cueTextBoxHost.CueText = "Host";
            this.cueTextBoxHost.Location = new System.Drawing.Point(3, 3);
            this.cueTextBoxHost.Name = "cueTextBoxHost";
            this.cueTextBoxHost.Size = new System.Drawing.Size(75, 23);
            this.cueTextBoxHost.TabIndex = 1;
            this.cueTextBoxHost.TextChanged += new System.EventHandler(this.cueTextBox1_TextChanged);
            // 
            // cueTextBoxPuerto
            // 
            this.cueTextBoxPuerto.CueText = "Puerto";
            this.cueTextBoxPuerto.Location = new System.Drawing.Point(84, 3);
            this.cueTextBoxPuerto.Name = "cueTextBoxPuerto";
            this.cueTextBoxPuerto.Size = new System.Drawing.Size(75, 23);
            this.cueTextBoxPuerto.TabIndex = 2;
            // 
            // cueTextBoxUsuario
            // 
            this.cueTextBoxUsuario.CueText = "Usuario";
            this.cueTextBoxUsuario.Location = new System.Drawing.Point(3, 7);
            this.cueTextBoxUsuario.Name = "cueTextBoxUsuario";
            this.cueTextBoxUsuario.Size = new System.Drawing.Size(161, 23);
            this.cueTextBoxUsuario.TabIndex = 3;
            // 
            // labelIVA
            // 
            this.labelIVA.AutoSize = true;
            this.labelIVA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelIVA.Location = new System.Drawing.Point(3, 127);
            this.labelIVA.Name = "labelIVA";
            this.labelIVA.Size = new System.Drawing.Size(755, 17);
            this.labelIVA.TabIndex = 2;
            this.labelIVA.Text = "I.V.A.";
            // 
            // OptionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 562);
            this.Controls.Add(this.tabControlOpciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OptionsView";
            this.Text = "Opciones";
            this.tableOpciones.ResumeLayout(false);
            this.tableOpciones.PerformLayout();
            this.flowDatosEm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIVA)).EndInit();
            this.tabControlOpciones.ResumeLayout(false);
            this.tabPageDatosE.ResumeLayout(false);
            this.tabPageServidor.ResumeLayout(false);
            this.tableLayoutPanelServ.ResumeLayout(false);
            this.tableLayoutPanelServ.PerformLayout();
            this.tableLayoutPanelServidor.ResumeLayout(false);
            this.panelLoggin_Servidor.ResumeLayout(false);
            this.panelLoggin_Servidor.PerformLayout();
            this.flowLayoutPanelConex_Servidor.ResumeLayout(false);
            this.flowLayoutPanelConex_Servidor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableOpciones;
        private System.Windows.Forms.Label label1DatosEm;
        private System.Windows.Forms.FlowLayoutPanel flowDatosEm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAplicar;
        private Views.CueComboBox cueComboBoxValor;
        private Views.CueComboBox cueComboBoxTipoIVA;
        private Views.CueComboBox cueComboBoxEmpresa;
        private Views.CueComboBox cueComboBoxCIF;
        private Views.CueComboBox cueComboBoxDireccion;
        private Views.CueComboBox cueComboBoxLocalidad;
        private Views.CueComboBox cueComboBoxProvincia;
        private Views.CueComboBox cueComboBoxCP;
        private Views.CueComboBox cueComboBoxMovil;
        private Views.CueComboBox cueComboBoxTelefono;
        private Views.CueComboBox cueComboBoxFax;
        private Views.CueComboBox cueComboBoxEmail;
        private System.Windows.Forms.DataGridView dataGridViewIVA;
        private System.Windows.Forms.TabControl tabControlOpciones;
        private System.Windows.Forms.TabPage tabPageDatosE;
        private System.Windows.Forms.TabPage tabPageServidor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelServ;
        private System.Windows.Forms.Label labelServidor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelServidor;
        private System.Windows.Forms.Panel panelLoggin_Servidor;
        private Views.CueTextBox cueTextBoxContrasena;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelConex_Servidor;
        private Views.CueTextBox cueTextBoxHost;
        private Views.CueTextBox cueTextBoxPuerto;
        private Views.CueTextBox cueTextBoxUsuario;
        private System.Windows.Forms.Label labelIVA;
    }
}