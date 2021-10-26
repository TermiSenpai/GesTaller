
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
            this.labelIVA = new System.Windows.Forms.Label();
            this.label1DatosEm = new System.Windows.Forms.Label();
            this.labelServidor = new System.Windows.Forms.Label();
            this.flowDatosEm = new System.Windows.Forms.FlowLayoutPanel();
            this.cueComboBoxValor = new Gestaller.Views.CueComboBox();
            this.cueComboBoxTipoIVA = new Gestaller.Views.CueComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAplicar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
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
            this.tableLayoutPanelServidor = new System.Windows.Forms.TableLayoutPanel();
            this.panelLoggin_Servidor = new System.Windows.Forms.Panel();
            this.panelConex_Servidor = new System.Windows.Forms.Panel();
            this.Host = new System.Windows.Forms.Button();
            this.buttonPuerto = new System.Windows.Forms.Button();
            this.cueComboBoxUsuario = new Gestaller.Views.CueComboBox();
            this.cueTextBoxContrasena = new Gestaller.Views.CueTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableOpciones.SuspendLayout();
            this.flowDatosEm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelServidor.SuspendLayout();
            this.panelLoggin_Servidor.SuspendLayout();
            this.panelConex_Servidor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableOpciones
            // 
            this.tableOpciones.ColumnCount = 1;
            this.tableOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableOpciones.Controls.Add(this.label1DatosEm, 0, 2);
            this.tableOpciones.Controls.Add(this.labelServidor, 0, 4);
            this.tableOpciones.Controls.Add(this.flowDatosEm, 0, 3);
            this.tableOpciones.Controls.Add(this.panel1, 0, 1);
            this.tableOpciones.Controls.Add(this.labelIVA, 0, 0);
            this.tableOpciones.Controls.Add(this.tableLayoutPanelServidor, 0, 5);
            this.tableOpciones.Controls.Add(this.dataGridView1, 0, 6);
            this.tableOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableOpciones.Location = new System.Drawing.Point(0, 0);
            this.tableOpciones.Name = "tableOpciones";
            this.tableOpciones.RowCount = 7;
            this.tableOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableOpciones.Size = new System.Drawing.Size(869, 562);
            this.tableOpciones.TabIndex = 0;
            // 
            // labelIVA
            // 
            this.labelIVA.AutoSize = true;
            this.labelIVA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelIVA.Location = new System.Drawing.Point(3, 7);
            this.labelIVA.Name = "labelIVA";
            this.labelIVA.Size = new System.Drawing.Size(863, 17);
            this.labelIVA.TabIndex = 0;
            this.labelIVA.Text = "I.V.A.";
            // 
            // label1DatosEm
            // 
            this.label1DatosEm.AutoSize = true;
            this.label1DatosEm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1DatosEm.Location = new System.Drawing.Point(3, 111);
            this.label1DatosEm.Name = "label1DatosEm";
            this.label1DatosEm.Size = new System.Drawing.Size(863, 17);
            this.label1DatosEm.TabIndex = 2;
            this.label1DatosEm.Text = "DATOS DE EMPRESA";
            // 
            // labelServidor
            // 
            this.labelServidor.AutoSize = true;
            this.labelServidor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelServidor.Location = new System.Drawing.Point(3, 231);
            this.labelServidor.Name = "labelServidor";
            this.labelServidor.Size = new System.Drawing.Size(863, 17);
            this.labelServidor.TabIndex = 4;
            this.labelServidor.Text = "SERVIDOR";
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
            this.flowDatosEm.Location = new System.Drawing.Point(3, 131);
            this.flowDatosEm.Name = "flowDatosEm";
            this.flowDatosEm.Size = new System.Drawing.Size(863, 90);
            this.flowDatosEm.TabIndex = 3;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Controls.Add(this.buttonEliminar);
            this.panel1.Controls.Add(this.buttonModificar);
            this.panel1.Controls.Add(this.buttonAplicar);
            this.panel1.Controls.Add(this.cueComboBoxValor);
            this.panel1.Controls.Add(this.cueComboBoxTipoIVA);
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 74);
            this.panel1.TabIndex = 1;
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
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(85, 49);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 3;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
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
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(248, 48);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
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
            this.cueComboBoxEmpresa.TabIndex = 6;
            // 
            // cueComboBoxCIF
            // 
            this.cueComboBoxCIF.CueText = "C.I.F.";
            this.cueComboBoxCIF.FormattingEnabled = true;
            this.cueComboBoxCIF.Location = new System.Drawing.Point(257, 3);
            this.cueComboBoxCIF.Name = "cueComboBoxCIF";
            this.cueComboBoxCIF.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxCIF.TabIndex = 7;
            // 
            // cueComboBoxDireccion
            // 
            this.cueComboBoxDireccion.CueText = "Dirección";
            this.cueComboBoxDireccion.FormattingEnabled = true;
            this.cueComboBoxDireccion.Location = new System.Drawing.Point(384, 3);
            this.cueComboBoxDireccion.Name = "cueComboBoxDireccion";
            this.cueComboBoxDireccion.Size = new System.Drawing.Size(248, 24);
            this.cueComboBoxDireccion.TabIndex = 8;
            // 
            // cueComboBoxLocalidad
            // 
            this.cueComboBoxLocalidad.CueText = "Localidad";
            this.cueComboBoxLocalidad.FormattingEnabled = true;
            this.cueComboBoxLocalidad.Location = new System.Drawing.Point(638, 3);
            this.cueComboBoxLocalidad.Name = "cueComboBoxLocalidad";
            this.cueComboBoxLocalidad.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxLocalidad.TabIndex = 9;
            // 
            // cueComboBoxProvincia
            // 
            this.cueComboBoxProvincia.CueText = "Provincia";
            this.cueComboBoxProvincia.FormattingEnabled = true;
            this.cueComboBoxProvincia.Location = new System.Drawing.Point(3, 33);
            this.cueComboBoxProvincia.Name = "cueComboBoxProvincia";
            this.cueComboBoxProvincia.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxProvincia.TabIndex = 10;
            // 
            // cueComboBoxCP
            // 
            this.cueComboBoxCP.CueText = "C.P.";
            this.cueComboBoxCP.FormattingEnabled = true;
            this.cueComboBoxCP.Location = new System.Drawing.Point(130, 33);
            this.cueComboBoxCP.Name = "cueComboBoxCP";
            this.cueComboBoxCP.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxCP.TabIndex = 11;
            // 
            // cueComboBoxMovil
            // 
            this.cueComboBoxMovil.CueText = "Móvil";
            this.cueComboBoxMovil.FormattingEnabled = true;
            this.cueComboBoxMovil.Location = new System.Drawing.Point(257, 33);
            this.cueComboBoxMovil.Name = "cueComboBoxMovil";
            this.cueComboBoxMovil.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxMovil.TabIndex = 12;
            // 
            // cueComboBoxTelefono
            // 
            this.cueComboBoxTelefono.CueText = "Teléfono";
            this.cueComboBoxTelefono.FormattingEnabled = true;
            this.cueComboBoxTelefono.Location = new System.Drawing.Point(384, 33);
            this.cueComboBoxTelefono.Name = "cueComboBoxTelefono";
            this.cueComboBoxTelefono.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxTelefono.TabIndex = 13;
            // 
            // cueComboBoxFax
            // 
            this.cueComboBoxFax.CueText = "Fax";
            this.cueComboBoxFax.FormattingEnabled = true;
            this.cueComboBoxFax.Location = new System.Drawing.Point(511, 33);
            this.cueComboBoxFax.Name = "cueComboBoxFax";
            this.cueComboBoxFax.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxFax.TabIndex = 14;
            // 
            // cueComboBoxEmail
            // 
            this.cueComboBoxEmail.CueText = "E-Mail";
            this.cueComboBoxEmail.FormattingEnabled = true;
            this.cueComboBoxEmail.Location = new System.Drawing.Point(3, 63);
            this.cueComboBoxEmail.Name = "cueComboBoxEmail";
            this.cueComboBoxEmail.Size = new System.Drawing.Size(248, 24);
            this.cueComboBoxEmail.TabIndex = 15;
            // 
            // tableLayoutPanelServidor
            // 
            this.tableLayoutPanelServidor.ColumnCount = 1;
            this.tableLayoutPanelServidor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelServidor.Controls.Add(this.panelLoggin_Servidor, 0, 1);
            this.tableLayoutPanelServidor.Controls.Add(this.panelConex_Servidor, 0, 0);
            this.tableLayoutPanelServidor.Location = new System.Drawing.Point(3, 251);
            this.tableLayoutPanelServidor.Name = "tableLayoutPanelServidor";
            this.tableLayoutPanelServidor.RowCount = 2;
            this.tableLayoutPanelServidor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelServidor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelServidor.Size = new System.Drawing.Size(177, 100);
            this.tableLayoutPanelServidor.TabIndex = 5;
            // 
            // panelLoggin_Servidor
            // 
            this.panelLoggin_Servidor.Controls.Add(this.cueTextBoxContrasena);
            this.panelLoggin_Servidor.Controls.Add(this.cueComboBoxUsuario);
            this.panelLoggin_Servidor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoggin_Servidor.Location = new System.Drawing.Point(3, 38);
            this.panelLoggin_Servidor.Name = "panelLoggin_Servidor";
            this.panelLoggin_Servidor.Size = new System.Drawing.Size(171, 59);
            this.panelLoggin_Servidor.TabIndex = 2;
            // 
            // panelConex_Servidor
            // 
            this.panelConex_Servidor.Controls.Add(this.buttonPuerto);
            this.panelConex_Servidor.Controls.Add(this.Host);
            this.panelConex_Servidor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConex_Servidor.Location = new System.Drawing.Point(3, 3);
            this.panelConex_Servidor.Name = "panelConex_Servidor";
            this.panelConex_Servidor.Size = new System.Drawing.Size(171, 29);
            this.panelConex_Servidor.TabIndex = 1;
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(6, 3);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(75, 23);
            this.Host.TabIndex = 15;
            this.Host.Text = "Host";
            this.Host.UseVisualStyleBackColor = true;
            // 
            // buttonPuerto
            // 
            this.buttonPuerto.Location = new System.Drawing.Point(88, 2);
            this.buttonPuerto.Name = "buttonPuerto";
            this.buttonPuerto.Size = new System.Drawing.Size(75, 23);
            this.buttonPuerto.TabIndex = 16;
            this.buttonPuerto.Text = "Puerto";
            this.buttonPuerto.UseVisualStyleBackColor = true;
            // 
            // cueComboBoxUsuario
            // 
            this.cueComboBoxUsuario.CueText = "Usuario";
            this.cueComboBoxUsuario.FormattingEnabled = true;
            this.cueComboBoxUsuario.Location = new System.Drawing.Point(7, 4);
            this.cueComboBoxUsuario.Name = "cueComboBoxUsuario";
            this.cueComboBoxUsuario.Size = new System.Drawing.Size(161, 24);
            this.cueComboBoxUsuario.TabIndex = 17;
            // 
            // cueTextBoxContrasena
            // 
            this.cueTextBoxContrasena.CueText = "Contraseña";
            this.cueTextBoxContrasena.Location = new System.Drawing.Point(7, 35);
            this.cueTextBoxContrasena.Name = "cueTextBoxContrasena";
            this.cueTextBoxContrasena.Size = new System.Drawing.Size(161, 23);
            this.cueTextBoxContrasena.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(863, 202);
            this.dataGridView1.TabIndex = 19;
            // 
            // OptionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 562);
            this.Controls.Add(this.tableOpciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OptionsView";
            this.Text = "Opciones";
            this.tableOpciones.ResumeLayout(false);
            this.tableOpciones.PerformLayout();
            this.flowDatosEm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanelServidor.ResumeLayout(false);
            this.panelLoggin_Servidor.ResumeLayout(false);
            this.panelLoggin_Servidor.PerformLayout();
            this.panelConex_Servidor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableOpciones;
        private System.Windows.Forms.Label labelIVA;
        private System.Windows.Forms.Label label1DatosEm;
        private System.Windows.Forms.Label labelServidor;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelServidor;
        private System.Windows.Forms.Panel panelLoggin_Servidor;
        private Views.CueTextBox cueTextBoxContrasena;
        private Views.CueComboBox cueComboBoxUsuario;
        private System.Windows.Forms.Panel panelConex_Servidor;
        private System.Windows.Forms.Button buttonPuerto;
        private System.Windows.Forms.Button Host;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}