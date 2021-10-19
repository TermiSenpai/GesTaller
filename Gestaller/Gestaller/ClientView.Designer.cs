
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
            this.flowEmpresa = new System.Windows.Forms.FlowLayoutPanel();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.comboEmpresa = new System.Windows.Forms.ComboBox();
            this.flowCIF = new System.Windows.Forms.FlowLayoutPanel();
            this.labelCIF = new System.Windows.Forms.Label();
            this.comboCIF = new System.Windows.Forms.ComboBox();
            this.flowT_Movil = new System.Windows.Forms.FlowLayoutPanel();
            this.labelT_Movil = new System.Windows.Forms.Label();
            this.comboT_Movil = new System.Windows.Forms.ComboBox();
            this.flowTelefono = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.comboTelefono = new System.Windows.Forms.ComboBox();
            this.flowFax = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFax = new System.Windows.Forms.Label();
            this.comboFax = new System.Windows.Forms.ComboBox();
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
            this.tabla2_clientes_V.SuspendLayout();
            this.flowFacturacion.SuspendLayout();
            this.flowEmpresa.SuspendLayout();
            this.flowCIF.SuspendLayout();
            this.flowT_Movil.SuspendLayout();
            this.flowTelefono.SuspendLayout();
            this.flowFax.SuspendLayout();
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
            this.tabControl_Clientes.Size = new System.Drawing.Size(817, 450);
            this.tabControl_Clientes.TabIndex = 0;
            // 
            // tab_clientes_vehiculos
            // 
            this.tab_clientes_vehiculos.Controls.Add(this.tabla1_clientes_V);
            this.tab_clientes_vehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_clientes_vehiculos.Location = new System.Drawing.Point(4, 22);
            this.tab_clientes_vehiculos.Margin = new System.Windows.Forms.Padding(0);
            this.tab_clientes_vehiculos.Name = "tab_clientes_vehiculos";
            this.tab_clientes_vehiculos.Size = new System.Drawing.Size(809, 424);
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
            this.tabla1_clientes_V.Size = new System.Drawing.Size(809, 424);
            this.tabla1_clientes_V.TabIndex = 0;
            // 
            // tabla3_clientes_V
            // 
            this.tabla3_clientes_V.ColumnCount = 1;
            this.tabla3_clientes_V.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabla3_clientes_V.Controls.Add(this.Encabezado2, 0, 0);
            this.tabla3_clientes_V.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla3_clientes_V.Location = new System.Drawing.Point(0, 84);
            this.tabla3_clientes_V.Margin = new System.Windows.Forms.Padding(0);
            this.tabla3_clientes_V.Name = "tabla3_clientes_V";
            this.tabla3_clientes_V.RowCount = 2;
            this.tabla3_clientes_V.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabla3_clientes_V.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tabla3_clientes_V.Size = new System.Drawing.Size(809, 84);
            this.tabla3_clientes_V.TabIndex = 1;
            // 
            // Encabezado2
            // 
            this.Encabezado2.AutoSize = true;
            this.Encabezado2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Encabezado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encabezado2.Location = new System.Drawing.Point(3, 0);
            this.Encabezado2.Name = "Encabezado2";
            this.Encabezado2.Size = new System.Drawing.Size(803, 16);
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
            this.tabla2_clientes_V.Size = new System.Drawing.Size(809, 84);
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
            this.Encabezado1.Size = new System.Drawing.Size(803, 16);
            this.Encabezado1.TabIndex = 0;
            this.Encabezado1.Text = "DATOS DE FACTURACION DEL CLIENTE";
            // 
            // flowFacturacion
            // 
            this.flowFacturacion.Controls.Add(this.flowEmpresa);
            this.flowFacturacion.Controls.Add(this.flowCIF);
            this.flowFacturacion.Controls.Add(this.flowT_Movil);
            this.flowFacturacion.Controls.Add(this.flowTelefono);
            this.flowFacturacion.Controls.Add(this.flowFax);
            this.flowFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowFacturacion.Location = new System.Drawing.Point(0, 16);
            this.flowFacturacion.Margin = new System.Windows.Forms.Padding(0);
            this.flowFacturacion.Name = "flowFacturacion";
            this.flowFacturacion.Size = new System.Drawing.Size(809, 68);
            this.flowFacturacion.TabIndex = 1;
            // 
            // flowEmpresa
            // 
            this.flowEmpresa.Controls.Add(this.labelEmpresa);
            this.flowEmpresa.Controls.Add(this.comboEmpresa);
            this.flowEmpresa.Location = new System.Drawing.Point(3, 3);
            this.flowEmpresa.Name = "flowEmpresa";
            this.flowEmpresa.Size = new System.Drawing.Size(167, 25);
            this.flowEmpresa.TabIndex = 1;
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Location = new System.Drawing.Point(3, 4);
            this.labelEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(64, 17);
            this.labelEmpresa.TabIndex = 0;
            this.labelEmpresa.Text = "Empresa";
            // 
            // comboEmpresa
            // 
            this.comboEmpresa.FormattingEnabled = true;
            this.comboEmpresa.Location = new System.Drawing.Point(70, 0);
            this.comboEmpresa.Margin = new System.Windows.Forms.Padding(0);
            this.comboEmpresa.Name = "comboEmpresa";
            this.comboEmpresa.Size = new System.Drawing.Size(97, 24);
            this.comboEmpresa.TabIndex = 1;
            // 
            // flowCIF
            // 
            this.flowCIF.Controls.Add(this.labelCIF);
            this.flowCIF.Controls.Add(this.comboCIF);
            this.flowCIF.Location = new System.Drawing.Point(176, 3);
            this.flowCIF.Name = "flowCIF";
            this.flowCIF.Size = new System.Drawing.Size(143, 25);
            this.flowCIF.TabIndex = 2;
            // 
            // labelCIF
            // 
            this.labelCIF.AutoSize = true;
            this.labelCIF.Location = new System.Drawing.Point(3, 4);
            this.labelCIF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labelCIF.Name = "labelCIF";
            this.labelCIF.Size = new System.Drawing.Size(40, 17);
            this.labelCIF.TabIndex = 0;
            this.labelCIF.Text = "C.I.F.";
            // 
            // comboCIF
            // 
            this.comboCIF.FormattingEnabled = true;
            this.comboCIF.Location = new System.Drawing.Point(46, 0);
            this.comboCIF.Margin = new System.Windows.Forms.Padding(0);
            this.comboCIF.Name = "comboCIF";
            this.comboCIF.Size = new System.Drawing.Size(97, 24);
            this.comboCIF.TabIndex = 1;
            // 
            // flowT_Movil
            // 
            this.flowT_Movil.Controls.Add(this.labelT_Movil);
            this.flowT_Movil.Controls.Add(this.comboT_Movil);
            this.flowT_Movil.Location = new System.Drawing.Point(325, 3);
            this.flowT_Movil.Name = "flowT_Movil";
            this.flowT_Movil.Size = new System.Drawing.Size(143, 25);
            this.flowT_Movil.TabIndex = 3;
            // 
            // labelT_Movil
            // 
            this.labelT_Movil.AutoSize = true;
            this.labelT_Movil.Location = new System.Drawing.Point(3, 4);
            this.labelT_Movil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labelT_Movil.Name = "labelT_Movil";
            this.labelT_Movil.Size = new System.Drawing.Size(40, 17);
            this.labelT_Movil.TabIndex = 0;
            this.labelT_Movil.Text = "Movil";
            // 
            // comboT_Movil
            // 
            this.comboT_Movil.FormattingEnabled = true;
            this.comboT_Movil.Location = new System.Drawing.Point(46, 0);
            this.comboT_Movil.Margin = new System.Windows.Forms.Padding(0);
            this.comboT_Movil.Name = "comboT_Movil";
            this.comboT_Movil.Size = new System.Drawing.Size(97, 24);
            this.comboT_Movil.TabIndex = 1;
            // 
            // flowTelefono
            // 
            this.flowTelefono.Controls.Add(this.labelTelefono);
            this.flowTelefono.Controls.Add(this.comboTelefono);
            this.flowTelefono.Location = new System.Drawing.Point(474, 3);
            this.flowTelefono.Name = "flowTelefono";
            this.flowTelefono.Size = new System.Drawing.Size(167, 25);
            this.flowTelefono.TabIndex = 2;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(3, 4);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(64, 17);
            this.labelTelefono.TabIndex = 0;
            this.labelTelefono.Text = "Telefono";
            // 
            // comboTelefono
            // 
            this.comboTelefono.FormattingEnabled = true;
            this.comboTelefono.Location = new System.Drawing.Point(70, 0);
            this.comboTelefono.Margin = new System.Windows.Forms.Padding(0);
            this.comboTelefono.Name = "comboTelefono";
            this.comboTelefono.Size = new System.Drawing.Size(97, 24);
            this.comboTelefono.TabIndex = 1;
            // 
            // flowFax
            // 
            this.flowFax.Controls.Add(this.labelFax);
            this.flowFax.Controls.Add(this.comboFax);
            this.flowFax.Location = new System.Drawing.Point(647, 3);
            this.flowFax.Name = "flowFax";
            this.flowFax.Size = new System.Drawing.Size(143, 25);
            this.flowFax.TabIndex = 3;
            // 
            // labelFax
            // 
            this.labelFax.AutoSize = true;
            this.labelFax.Location = new System.Drawing.Point(3, 4);
            this.labelFax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labelFax.Name = "labelFax";
            this.labelFax.Size = new System.Drawing.Size(30, 17);
            this.labelFax.TabIndex = 0;
            this.labelFax.Text = "Fax";
            // 
            // comboFax
            // 
            this.comboFax.FormattingEnabled = true;
            this.comboFax.Location = new System.Drawing.Point(36, 0);
            this.comboFax.Margin = new System.Windows.Forms.Padding(0);
            this.comboFax.Name = "comboFax";
            this.comboFax.Size = new System.Drawing.Size(97, 24);
            this.comboFax.TabIndex = 1;
            this.comboFax.Text = "Fax";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.botonVaciar);
            this.flowLayoutPanel1.Controls.Add(this.botonAnadir);
            this.flowLayoutPanel1.Controls.Add(this.botonModificar);
            this.flowLayoutPanel1.Controls.Add(this.botonBorrar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(464, 168);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 63);
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
            this.dataGrid.Location = new System.Drawing.Point(3, 234);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(803, 187);
            this.dataGrid.TabIndex = 3;
            // 
            // tab_datos_bancarios
            // 
            this.tab_datos_bancarios.Location = new System.Drawing.Point(4, 22);
            this.tab_datos_bancarios.Margin = new System.Windows.Forms.Padding(0);
            this.tab_datos_bancarios.Name = "tab_datos_bancarios";
            this.tab_datos_bancarios.Padding = new System.Windows.Forms.Padding(3);
            this.tab_datos_bancarios.Size = new System.Drawing.Size(809, 424);
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
            this.tab_otras_direcciones.Size = new System.Drawing.Size(809, 424);
            this.tab_otras_direcciones.TabIndex = 2;
            this.tab_otras_direcciones.Text = "Otras Direcciones";
            this.tab_otras_direcciones.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.tabControl_Clientes);
            this.Name = "Clientes";
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
            this.flowEmpresa.ResumeLayout(false);
            this.flowEmpresa.PerformLayout();
            this.flowCIF.ResumeLayout(false);
            this.flowCIF.PerformLayout();
            this.flowT_Movil.ResumeLayout(false);
            this.flowT_Movil.PerformLayout();
            this.flowTelefono.ResumeLayout(false);
            this.flowTelefono.PerformLayout();
            this.flowFax.ResumeLayout(false);
            this.flowFax.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel flowEmpresa;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.ComboBox comboEmpresa;
        private System.Windows.Forms.FlowLayoutPanel flowFacturacion;
        private System.Windows.Forms.FlowLayoutPanel flowCIF;
        private System.Windows.Forms.Label labelCIF;
        private System.Windows.Forms.ComboBox comboCIF;
        private System.Windows.Forms.FlowLayoutPanel flowT_Movil;
        private System.Windows.Forms.Label labelT_Movil;
        private System.Windows.Forms.ComboBox comboT_Movil;
        private System.Windows.Forms.FlowLayoutPanel flowTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.ComboBox comboTelefono;
        private System.Windows.Forms.FlowLayoutPanel flowFax;
        private System.Windows.Forms.Label labelFax;
        private System.Windows.Forms.ComboBox comboFax;
    }
}