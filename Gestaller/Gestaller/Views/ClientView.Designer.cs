
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
            this.Encabezado2 = new System.Windows.Forms.Label();
            this.tabla2_clientes_V = new System.Windows.Forms.TableLayoutPanel();
            this.Encabezado1 = new System.Windows.Forms.Label();
            this.flowFacturacion = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.botonVaciar = new System.Windows.Forms.Button();
            this.botonAnadir = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.tab_datos_bancarios = new System.Windows.Forms.TabPage();
            this.tab_otras_direcciones = new System.Windows.Forms.TabPage();
            this.cueComboBoxEmpresa = new Gestaller.Views.CueComboBox();
            this.cueComboBoxCIF = new Gestaller.Views.CueComboBox();
            this.cueComboBoxMovil = new Gestaller.Views.CueComboBox();
            this.tabControl_Clientes.SuspendLayout();
            this.tab_clientes_vehiculos.SuspendLayout();
            this.tabla1_clientes_V.SuspendLayout();
            this.tabla3_clientes_V.SuspendLayout();
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
            this.tabla1_clientes_V.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabla1_clientes_V.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabla1_clientes_V.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tabla1_clientes_V.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tabla1_clientes_V.Size = new System.Drawing.Size(614, 802);
            this.tabla1_clientes_V.TabIndex = 0;
            // 
            // tabla3_clientes_V
            // 
            this.tabla3_clientes_V.ColumnCount = 1;
            this.tabla3_clientes_V.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabla3_clientes_V.Controls.Add(this.Encabezado2, 0, 0);
            this.tabla3_clientes_V.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla3_clientes_V.Location = new System.Drawing.Point(0, 160);
            this.tabla3_clientes_V.Margin = new System.Windows.Forms.Padding(0);
            this.tabla3_clientes_V.Name = "tabla3_clientes_V";
            this.tabla3_clientes_V.RowCount = 2;
            this.tabla3_clientes_V.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabla3_clientes_V.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tabla3_clientes_V.Size = new System.Drawing.Size(614, 160);
            this.tabla3_clientes_V.TabIndex = 1;
            // 
            // Encabezado2
            // 
            this.Encabezado2.AutoSize = true;
            this.Encabezado2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Encabezado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encabezado2.Location = new System.Drawing.Point(3, 0);
            this.Encabezado2.Name = "Encabezado2";
            this.Encabezado2.Size = new System.Drawing.Size(608, 32);
            this.Encabezado2.TabIndex = 0;
            this.Encabezado2.Text = "DATOS DEL VEHICULO";
            // 
            // tabla2_clientes_V
            // 
            this.tabla2_clientes_V.ColumnCount = 1;
            this.tabla2_clientes_V.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabla2_clientes_V.Controls.Add(this.Encabezado1, 0, 0);
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
            // Encabezado1
            // 
            this.Encabezado1.AutoSize = true;
            this.Encabezado1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Encabezado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encabezado1.Location = new System.Drawing.Point(3, 0);
            this.Encabezado1.Name = "Encabezado1";
            this.Encabezado1.Size = new System.Drawing.Size(608, 32);
            this.Encabezado1.TabIndex = 0;
            this.Encabezado1.Text = "DATOS DE FACTURACION DEL CLIENTE";
            // 
            // flowFacturacion
            // 
            this.flowFacturacion.Controls.Add(this.cueComboBoxEmpresa);
            this.flowFacturacion.Controls.Add(this.cueComboBoxCIF);
            this.flowFacturacion.Controls.Add(this.cueComboBoxMovil);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(269, 320);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 120);
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
            this.dataGrid.Location = new System.Drawing.Point(3, 443);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(608, 356);
            this.dataGrid.TabIndex = 3;
            // 
            // tab_datos_bancarios
            // 
            this.tab_datos_bancarios.Location = new System.Drawing.Point(4, 22);
            this.tab_datos_bancarios.Margin = new System.Windows.Forms.Padding(0);
            this.tab_datos_bancarios.Name = "tab_datos_bancarios";
            this.tab_datos_bancarios.Padding = new System.Windows.Forms.Padding(3);
            this.tab_datos_bancarios.Size = new System.Drawing.Size(1488, 809);
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
            this.tab_otras_direcciones.Size = new System.Drawing.Size(1488, 809);
            this.tab_otras_direcciones.TabIndex = 2;
            this.tab_otras_direcciones.Text = "Otras Direcciones";
            this.tab_otras_direcciones.UseVisualStyleBackColor = true;
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
            // cueComboBoxMovil
            // 
            this.cueComboBoxMovil.CueText = "Móvil";
            this.cueComboBoxMovil.FormattingEnabled = true;
            this.cueComboBoxMovil.Location = new System.Drawing.Point(384, 3);
            this.cueComboBoxMovil.Name = "cueComboBoxMovil";
            this.cueComboBoxMovil.Size = new System.Drawing.Size(121, 24);
            this.cueComboBoxMovil.TabIndex = 3;
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
            this.tabControl_Clientes.ResumeLayout(false);
            this.tab_clientes_vehiculos.ResumeLayout(false);
            this.tabla1_clientes_V.ResumeLayout(false);
            this.tabla3_clientes_V.ResumeLayout(false);
            this.tabla3_clientes_V.PerformLayout();
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
        private System.Windows.Forms.Label Encabezado2;
        private System.Windows.Forms.Label Encabezado1;
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
    }
}