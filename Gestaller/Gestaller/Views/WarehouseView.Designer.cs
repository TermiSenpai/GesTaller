
namespace Gestaller
{
    partial class WarehouseView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Productos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAnadir_Productos = new System.Windows.Forms.Button();
            this.btEliminar_Productos = new System.Windows.Forms.Button();
            this.btModificar_Productos = new System.Windows.Forms.Button();
            this.btVaciar_Productos = new System.Windows.Forms.Button();
            this.Grid_Productos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Referecia_Productos = new Gestaller.Views.CueComboBox();
            this.Proveedor_Productos = new Gestaller.Views.CueTextBox();
            this.Descripcion_Productos = new Gestaller.Views.CueComboBox();
            this.Base_Productos = new Gestaller.Views.CueTextBox();
            this.IVA_Productos = new Gestaller.Views.CueComboBox();
            this.PVP_Productos = new Gestaller.Views.CueComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Detallada_Productos = new System.Windows.Forms.RichTextBox();
            this.Proveedores = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Grid_Proveedores = new System.Windows.Forms.DataGridView();
            this.panel4_Pre = new System.Windows.Forms.Panel();
            this.btVaciar_Proveedores = new System.Windows.Forms.Button();
            this.btAnadir_Proveedores = new System.Windows.Forms.Button();
            this.btModificar_Proveedores = new System.Windows.Forms.Button();
            this.btBorrar_Proveedores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NIF_Proveedores = new Gestaller.Views.CueComboBox();
            this.Nombre_Proveedores = new Gestaller.Views.CueComboBox();
            this.Localidad_Proveedores = new Gestaller.Views.CueComboBox();
            this.Direccion_Proveedores = new Gestaller.Views.CueComboBox();
            this.Provincia_Proveedores = new Gestaller.Views.CueComboBox();
            this.CP_Proveedores = new Gestaller.Views.CueComboBox();
            this.Movil_Proveedores = new Gestaller.Views.CueComboBox();
            this.Telefono_Proveedores = new Gestaller.Views.CueComboBox();
            this.Fax_Proveedores = new Gestaller.Views.CueComboBox();
            this.Email_Proveedores = new Gestaller.Views.CueComboBox();
            this.NoCuenta_Proveedores = new Gestaller.Views.CueComboBox();
            this.Entidad_Proveedores = new Gestaller.Views.CueComboBox();
            this.firmaPago_Proveedores = new Gestaller.Views.CueTextBox();
            this.diasPago_Proveedores = new Gestaller.Views.CueComboBox();
            this.Localidad2_Proveedores = new Gestaller.Views.CueComboBox();
            this.Direccion2_Proveedores = new Gestaller.Views.CueComboBox();
            this.Provincia2_Proveedores = new Gestaller.Views.CueComboBox();
            this.CP2_Proveedores = new Gestaller.Views.CueComboBox();
            this.tabControl1.SuspendLayout();
            this.Productos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Productos)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.Proveedores.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Proveedores)).BeginInit();
            this.panel4_Pre.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Productos);
            this.tabControl1.Controls.Add(this.Proveedores);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 551);
            this.tabControl1.TabIndex = 0;
            // 
            // Productos
            // 
            this.Productos.Controls.Add(this.tableLayoutPanel2);
            this.Productos.Location = new System.Drawing.Point(4, 22);
            this.Productos.Name = "Productos";
            this.Productos.Padding = new System.Windows.Forms.Padding(3);
            this.Productos.Size = new System.Drawing.Size(792, 525);
            this.Productos.TabIndex = 1;
            this.Productos.Text = "Productos";
            this.Productos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.Grid_Productos, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Detallada_Productos, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 519);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btAnadir_Productos);
            this.panel1.Controls.Add(this.btEliminar_Productos);
            this.panel1.Controls.Add(this.btModificar_Productos);
            this.panel1.Controls.Add(this.btVaciar_Productos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 208);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 23);
            this.panel1.TabIndex = 4;
            // 
            // btAnadir_Productos
            // 
            this.btAnadir_Productos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btAnadir_Productos.Location = new System.Drawing.Point(486, 0);
            this.btAnadir_Productos.Name = "btAnadir_Productos";
            this.btAnadir_Productos.Size = new System.Drawing.Size(75, 23);
            this.btAnadir_Productos.TabIndex = 0;
            this.btAnadir_Productos.Text = "Añadir";
            this.btAnadir_Productos.UseVisualStyleBackColor = true;
            // 
            // btEliminar_Productos
            // 
            this.btEliminar_Productos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btEliminar_Productos.Location = new System.Drawing.Point(561, 0);
            this.btEliminar_Productos.Name = "btEliminar_Productos";
            this.btEliminar_Productos.Size = new System.Drawing.Size(75, 23);
            this.btEliminar_Productos.TabIndex = 1;
            this.btEliminar_Productos.Text = "Eliminar";
            this.btEliminar_Productos.UseVisualStyleBackColor = true;
            // 
            // btModificar_Productos
            // 
            this.btModificar_Productos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btModificar_Productos.Location = new System.Drawing.Point(636, 0);
            this.btModificar_Productos.Name = "btModificar_Productos";
            this.btModificar_Productos.Size = new System.Drawing.Size(75, 23);
            this.btModificar_Productos.TabIndex = 2;
            this.btModificar_Productos.Text = "Modificar";
            this.btModificar_Productos.UseVisualStyleBackColor = true;
            // 
            // btVaciar_Productos
            // 
            this.btVaciar_Productos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btVaciar_Productos.Location = new System.Drawing.Point(711, 0);
            this.btVaciar_Productos.Name = "btVaciar_Productos";
            this.btVaciar_Productos.Size = new System.Drawing.Size(75, 23);
            this.btVaciar_Productos.TabIndex = 3;
            this.btVaciar_Productos.Text = "Vaciar";
            this.btVaciar_Productos.UseVisualStyleBackColor = true;
            // 
            // Grid_Productos
            // 
            this.Grid_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Productos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Productos.Location = new System.Drawing.Point(3, 234);
            this.Grid_Productos.Name = "Grid_Productos";
            this.Grid_Productos.Size = new System.Drawing.Size(780, 282);
            this.Grid_Productos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(780, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "PRODUCTOS";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Referecia_Productos);
            this.flowLayoutPanel2.Controls.Add(this.Proveedor_Productos);
            this.flowLayoutPanel2.Controls.Add(this.Descripcion_Productos);
            this.flowLayoutPanel2.Controls.Add(this.Base_Productos);
            this.flowLayoutPanel2.Controls.Add(this.IVA_Productos);
            this.flowLayoutPanel2.Controls.Add(this.PVP_Productos);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(780, 90);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // Referecia_Productos
            // 
            this.Referecia_Productos.CueText = "Referencia";
            this.Referecia_Productos.FormattingEnabled = true;
            this.Referecia_Productos.Location = new System.Drawing.Point(3, 3);
            this.Referecia_Productos.Name = "Referecia_Productos";
            this.Referecia_Productos.Size = new System.Drawing.Size(121, 21);
            this.Referecia_Productos.TabIndex = 0;
            // 
            // Proveedor_Productos
            // 
            this.Proveedor_Productos.CueText = "Proveedor";
            this.Proveedor_Productos.Location = new System.Drawing.Point(130, 3);
            this.Proveedor_Productos.Name = "Proveedor_Productos";
            this.Proveedor_Productos.Size = new System.Drawing.Size(121, 20);
            this.Proveedor_Productos.TabIndex = 1;
            // 
            // Descripcion_Productos
            // 
            this.Descripcion_Productos.CueText = "Descripción";
            this.Descripcion_Productos.FormattingEnabled = true;
            this.Descripcion_Productos.Location = new System.Drawing.Point(257, 3);
            this.Descripcion_Productos.Name = "Descripcion_Productos";
            this.Descripcion_Productos.Size = new System.Drawing.Size(375, 21);
            this.Descripcion_Productos.TabIndex = 2;
            // 
            // Base_Productos
            // 
            this.Base_Productos.CueText = "Precio Base";
            this.Base_Productos.Location = new System.Drawing.Point(638, 3);
            this.Base_Productos.Name = "Base_Productos";
            this.Base_Productos.Size = new System.Drawing.Size(121, 20);
            this.Base_Productos.TabIndex = 3;
            // 
            // IVA_Productos
            // 
            this.IVA_Productos.CueText = "I.V.A.";
            this.IVA_Productos.FormattingEnabled = true;
            this.IVA_Productos.Location = new System.Drawing.Point(3, 30);
            this.IVA_Productos.Name = "IVA_Productos";
            this.IVA_Productos.Size = new System.Drawing.Size(121, 21);
            this.IVA_Productos.TabIndex = 4;
            // 
            // PVP_Productos
            // 
            this.PVP_Productos.CueText = "P.V.P.";
            this.PVP_Productos.FormattingEnabled = true;
            this.PVP_Productos.Location = new System.Drawing.Point(130, 30);
            this.PVP_Productos.Name = "PVP_Productos";
            this.PVP_Productos.Size = new System.Drawing.Size(121, 21);
            this.PVP_Productos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(780, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción Detallada";
            // 
            // Detallada_Productos
            // 
            this.Detallada_Productos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Detallada_Productos.Location = new System.Drawing.Point(3, 139);
            this.Detallada_Productos.Name = "Detallada_Productos";
            this.Detallada_Productos.Size = new System.Drawing.Size(780, 66);
            this.Detallada_Productos.TabIndex = 3;
            this.Detallada_Productos.Text = "";
            // 
            // Proveedores
            // 
            this.Proveedores.Controls.Add(this.tableLayoutPanel1);
            this.Proveedores.Location = new System.Drawing.Point(4, 22);
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Padding = new System.Windows.Forms.Padding(3);
            this.Proveedores.Size = new System.Drawing.Size(792, 525);
            this.Proveedores.TabIndex = 0;
            this.Proveedores.Text = "Proveedores";
            this.Proveedores.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Grid_Proveedores, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel4_Pre, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Grid_Proveedores
            // 
            this.Grid_Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Proveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Proveedores.Location = new System.Drawing.Point(3, 202);
            this.Grid_Proveedores.Name = "Grid_Proveedores";
            this.Grid_Proveedores.Size = new System.Drawing.Size(780, 314);
            this.Grid_Proveedores.TabIndex = 3;
            // 
            // panel4_Pre
            // 
            this.panel4_Pre.Controls.Add(this.btVaciar_Proveedores);
            this.panel4_Pre.Controls.Add(this.btAnadir_Proveedores);
            this.panel4_Pre.Controls.Add(this.btModificar_Proveedores);
            this.panel4_Pre.Controls.Add(this.btBorrar_Proveedores);
            this.panel4_Pre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4_Pre.Location = new System.Drawing.Point(0, 176);
            this.panel4_Pre.Margin = new System.Windows.Forms.Padding(0);
            this.panel4_Pre.Name = "panel4_Pre";
            this.panel4_Pre.Size = new System.Drawing.Size(786, 23);
            this.panel4_Pre.TabIndex = 2;
            // 
            // btVaciar_Proveedores
            // 
            this.btVaciar_Proveedores.Dock = System.Windows.Forms.DockStyle.Right;
            this.btVaciar_Proveedores.Location = new System.Drawing.Point(486, 0);
            this.btVaciar_Proveedores.Name = "btVaciar_Proveedores";
            this.btVaciar_Proveedores.Size = new System.Drawing.Size(75, 23);
            this.btVaciar_Proveedores.TabIndex = 0;
            this.btVaciar_Proveedores.Text = "Vaciar";
            this.btVaciar_Proveedores.UseVisualStyleBackColor = true;
            // 
            // btAnadir_Proveedores
            // 
            this.btAnadir_Proveedores.Dock = System.Windows.Forms.DockStyle.Right;
            this.btAnadir_Proveedores.Location = new System.Drawing.Point(561, 0);
            this.btAnadir_Proveedores.Name = "btAnadir_Proveedores";
            this.btAnadir_Proveedores.Size = new System.Drawing.Size(75, 23);
            this.btAnadir_Proveedores.TabIndex = 1;
            this.btAnadir_Proveedores.Text = "Añadir";
            this.btAnadir_Proveedores.UseVisualStyleBackColor = true;
            // 
            // btModificar_Proveedores
            // 
            this.btModificar_Proveedores.Dock = System.Windows.Forms.DockStyle.Right;
            this.btModificar_Proveedores.Location = new System.Drawing.Point(636, 0);
            this.btModificar_Proveedores.Name = "btModificar_Proveedores";
            this.btModificar_Proveedores.Size = new System.Drawing.Size(75, 23);
            this.btModificar_Proveedores.TabIndex = 2;
            this.btModificar_Proveedores.Text = "Modificar";
            this.btModificar_Proveedores.UseVisualStyleBackColor = true;
            // 
            // btBorrar_Proveedores
            // 
            this.btBorrar_Proveedores.Dock = System.Windows.Forms.DockStyle.Right;
            this.btBorrar_Proveedores.Location = new System.Drawing.Point(711, 0);
            this.btBorrar_Proveedores.Name = "btBorrar_Proveedores";
            this.btBorrar_Proveedores.Size = new System.Drawing.Size(75, 23);
            this.btBorrar_Proveedores.TabIndex = 3;
            this.btBorrar_Proveedores.Text = "Borrar";
            this.btBorrar_Proveedores.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS PROVEEDOR";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.NIF_Proveedores);
            this.flowLayoutPanel1.Controls.Add(this.Nombre_Proveedores);
            this.flowLayoutPanel1.Controls.Add(this.Localidad_Proveedores);
            this.flowLayoutPanel1.Controls.Add(this.Direccion_Proveedores);
            this.flowLayoutPanel1.Controls.Add(this.Provincia_Proveedores);
            this.flowLayoutPanel1.Controls.Add(this.CP_Proveedores);
            this.flowLayoutPanel1.Controls.Add(this.Movil_Proveedores);
            this.flowLayoutPanel1.Controls.Add(this.Telefono_Proveedores);
            this.flowLayoutPanel1.Controls.Add(this.Fax_Proveedores);
            this.flowLayoutPanel1.Controls.Add(this.Email_Proveedores);
            this.flowLayoutPanel1.Controls.Add(this.NoCuenta_Proveedores);
            this.flowLayoutPanel1.Controls.Add(this.Entidad_Proveedores);
            this.flowLayoutPanel1.Controls.Add(this.firmaPago_Proveedores);
            this.flowLayoutPanel1.Controls.Add(this.diasPago_Proveedores);
            this.flowLayoutPanel1.Controls.Add(this.Localidad2_Proveedores);
            this.flowLayoutPanel1.Controls.Add(this.Direccion2_Proveedores);
            this.flowLayoutPanel1.Controls.Add(this.Provincia2_Proveedores);
            this.flowLayoutPanel1.Controls.Add(this.CP2_Proveedores);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(780, 150);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // NIF_Proveedores
            // 
            this.NIF_Proveedores.CueText = "N.I.F.";
            this.NIF_Proveedores.FormattingEnabled = true;
            this.NIF_Proveedores.Location = new System.Drawing.Point(3, 3);
            this.NIF_Proveedores.Name = "NIF_Proveedores";
            this.NIF_Proveedores.Size = new System.Drawing.Size(121, 21);
            this.NIF_Proveedores.TabIndex = 0;
            // 
            // Nombre_Proveedores
            // 
            this.Nombre_Proveedores.CueText = "Nombre";
            this.Nombre_Proveedores.FormattingEnabled = true;
            this.Nombre_Proveedores.Location = new System.Drawing.Point(130, 3);
            this.Nombre_Proveedores.Name = "Nombre_Proveedores";
            this.Nombre_Proveedores.Size = new System.Drawing.Size(248, 21);
            this.Nombre_Proveedores.TabIndex = 1;
            // 
            // Localidad_Proveedores
            // 
            this.Localidad_Proveedores.CueText = "Localidad";
            this.Localidad_Proveedores.FormattingEnabled = true;
            this.Localidad_Proveedores.Location = new System.Drawing.Point(384, 3);
            this.Localidad_Proveedores.Name = "Localidad_Proveedores";
            this.Localidad_Proveedores.Size = new System.Drawing.Size(121, 21);
            this.Localidad_Proveedores.TabIndex = 2;
            // 
            // Direccion_Proveedores
            // 
            this.Direccion_Proveedores.CueText = "Dirección";
            this.Direccion_Proveedores.FormattingEnabled = true;
            this.Direccion_Proveedores.Location = new System.Drawing.Point(511, 3);
            this.Direccion_Proveedores.Name = "Direccion_Proveedores";
            this.Direccion_Proveedores.Size = new System.Drawing.Size(248, 21);
            this.Direccion_Proveedores.TabIndex = 3;
            // 
            // Provincia_Proveedores
            // 
            this.Provincia_Proveedores.CueText = "Provincia";
            this.Provincia_Proveedores.FormattingEnabled = true;
            this.Provincia_Proveedores.Location = new System.Drawing.Point(3, 30);
            this.Provincia_Proveedores.Name = "Provincia_Proveedores";
            this.Provincia_Proveedores.Size = new System.Drawing.Size(121, 21);
            this.Provincia_Proveedores.TabIndex = 4;
            // 
            // CP_Proveedores
            // 
            this.CP_Proveedores.CueText = "C.P.";
            this.CP_Proveedores.FormattingEnabled = true;
            this.CP_Proveedores.Location = new System.Drawing.Point(130, 30);
            this.CP_Proveedores.Name = "CP_Proveedores";
            this.CP_Proveedores.Size = new System.Drawing.Size(121, 21);
            this.CP_Proveedores.TabIndex = 5;
            // 
            // Movil_Proveedores
            // 
            this.Movil_Proveedores.CueText = "Móvil";
            this.Movil_Proveedores.FormattingEnabled = true;
            this.Movil_Proveedores.Location = new System.Drawing.Point(257, 30);
            this.Movil_Proveedores.Name = "Movil_Proveedores";
            this.Movil_Proveedores.Size = new System.Drawing.Size(121, 21);
            this.Movil_Proveedores.TabIndex = 6;
            // 
            // Telefono_Proveedores
            // 
            this.Telefono_Proveedores.CueText = "Teléfono";
            this.Telefono_Proveedores.FormattingEnabled = true;
            this.Telefono_Proveedores.Location = new System.Drawing.Point(384, 30);
            this.Telefono_Proveedores.Name = "Telefono_Proveedores";
            this.Telefono_Proveedores.Size = new System.Drawing.Size(121, 21);
            this.Telefono_Proveedores.TabIndex = 7;
            // 
            // Fax_Proveedores
            // 
            this.Fax_Proveedores.CueText = "Fax";
            this.Fax_Proveedores.FormattingEnabled = true;
            this.Fax_Proveedores.Location = new System.Drawing.Point(511, 30);
            this.Fax_Proveedores.Name = "Fax_Proveedores";
            this.Fax_Proveedores.Size = new System.Drawing.Size(121, 21);
            this.Fax_Proveedores.TabIndex = 8;
            // 
            // Email_Proveedores
            // 
            this.Email_Proveedores.CueText = "E-Mail";
            this.Email_Proveedores.FormattingEnabled = true;
            this.Email_Proveedores.Location = new System.Drawing.Point(3, 57);
            this.Email_Proveedores.Name = "Email_Proveedores";
            this.Email_Proveedores.Size = new System.Drawing.Size(248, 21);
            this.Email_Proveedores.TabIndex = 9;
            // 
            // NoCuenta_Proveedores
            // 
            this.NoCuenta_Proveedores.CueText = "Nº De Cuenta";
            this.NoCuenta_Proveedores.FormattingEnabled = true;
            this.NoCuenta_Proveedores.Location = new System.Drawing.Point(257, 57);
            this.NoCuenta_Proveedores.Name = "NoCuenta_Proveedores";
            this.NoCuenta_Proveedores.Size = new System.Drawing.Size(248, 21);
            this.NoCuenta_Proveedores.TabIndex = 10;
            // 
            // Entidad_Proveedores
            // 
            this.Entidad_Proveedores.CueText = "Entidad";
            this.Entidad_Proveedores.FormattingEnabled = true;
            this.Entidad_Proveedores.Location = new System.Drawing.Point(511, 57);
            this.Entidad_Proveedores.Name = "Entidad_Proveedores";
            this.Entidad_Proveedores.Size = new System.Drawing.Size(121, 21);
            this.Entidad_Proveedores.TabIndex = 11;
            // 
            // firmaPago_Proveedores
            // 
            this.firmaPago_Proveedores.CueText = "Firma-Pago";
            this.firmaPago_Proveedores.Location = new System.Drawing.Point(638, 57);
            this.firmaPago_Proveedores.Name = "firmaPago_Proveedores";
            this.firmaPago_Proveedores.Size = new System.Drawing.Size(121, 20);
            this.firmaPago_Proveedores.TabIndex = 12;
            // 
            // diasPago_Proveedores
            // 
            this.diasPago_Proveedores.CueText = "Días-Pago";
            this.diasPago_Proveedores.FormattingEnabled = true;
            this.diasPago_Proveedores.Location = new System.Drawing.Point(3, 84);
            this.diasPago_Proveedores.Name = "diasPago_Proveedores";
            this.diasPago_Proveedores.Size = new System.Drawing.Size(121, 21);
            this.diasPago_Proveedores.TabIndex = 13;
            // 
            // Localidad2_Proveedores
            // 
            this.Localidad2_Proveedores.CueText = "Localidad 2";
            this.Localidad2_Proveedores.FormattingEnabled = true;
            this.Localidad2_Proveedores.Location = new System.Drawing.Point(130, 84);
            this.Localidad2_Proveedores.Name = "Localidad2_Proveedores";
            this.Localidad2_Proveedores.Size = new System.Drawing.Size(121, 21);
            this.Localidad2_Proveedores.TabIndex = 14;
            // 
            // Direccion2_Proveedores
            // 
            this.Direccion2_Proveedores.CueText = "Dirección 2";
            this.Direccion2_Proveedores.FormattingEnabled = true;
            this.Direccion2_Proveedores.Location = new System.Drawing.Point(257, 84);
            this.Direccion2_Proveedores.Name = "Direccion2_Proveedores";
            this.Direccion2_Proveedores.Size = new System.Drawing.Size(248, 21);
            this.Direccion2_Proveedores.TabIndex = 15;
            // 
            // Provincia2_Proveedores
            // 
            this.Provincia2_Proveedores.CueText = "Provincia 2";
            this.Provincia2_Proveedores.FormattingEnabled = true;
            this.Provincia2_Proveedores.Location = new System.Drawing.Point(511, 84);
            this.Provincia2_Proveedores.Name = "Provincia2_Proveedores";
            this.Provincia2_Proveedores.Size = new System.Drawing.Size(121, 21);
            this.Provincia2_Proveedores.TabIndex = 16;
            // 
            // CP2_Proveedores
            // 
            this.CP2_Proveedores.CueText = "C.P. 2";
            this.CP2_Proveedores.FormattingEnabled = true;
            this.CP2_Proveedores.Location = new System.Drawing.Point(638, 84);
            this.CP2_Proveedores.Name = "CP2_Proveedores";
            this.CP2_Proveedores.Size = new System.Drawing.Size(121, 21);
            this.CP2_Proveedores.TabIndex = 17;
            // 
            // WarehouseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.tabControl1);
            this.Name = "WarehouseView";
            this.Text = "Almacen";
            this.Load += new System.EventHandler(this.WarehouseView_Load);
            this.tabControl1.ResumeLayout(false);
            this.Productos.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Productos)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.Proveedores.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Proveedores)).EndInit();
            this.panel4_Pre.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Proveedores;
        private System.Windows.Forms.TabPage Productos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView Grid_Proveedores;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView Grid_Productos;
        private System.Windows.Forms.Panel panel4_Pre;
        private System.Windows.Forms.Button btVaciar_Proveedores;
        private System.Windows.Forms.Button btAnadir_Proveedores;
        private System.Windows.Forms.Button btModificar_Proveedores;
        private System.Windows.Forms.Button btBorrar_Proveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Views.CueComboBox NIF_Proveedores;
        private Views.CueComboBox Nombre_Proveedores;
        private Views.CueComboBox Localidad_Proveedores;
        private Views.CueComboBox Direccion_Proveedores;
        private Views.CueComboBox Provincia_Proveedores;
        private Views.CueComboBox CP_Proveedores;
        private Views.CueComboBox Movil_Proveedores;
        private Views.CueComboBox Telefono_Proveedores;
        private Views.CueComboBox Fax_Proveedores;
        private Views.CueComboBox Email_Proveedores;
        private Views.CueComboBox NoCuenta_Proveedores;
        private Views.CueComboBox Entidad_Proveedores;
        private Views.CueTextBox firmaPago_Proveedores;
        private Views.CueComboBox diasPago_Proveedores;
        private Views.CueComboBox Direccion2_Proveedores;
        private Views.CueComboBox Localidad2_Proveedores;
        private Views.CueComboBox Provincia2_Proveedores;
        private Views.CueComboBox CP2_Proveedores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAnadir_Productos;
        private System.Windows.Forms.Button btEliminar_Productos;
        private System.Windows.Forms.Button btModificar_Productos;
        private System.Windows.Forms.Button btVaciar_Productos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Views.CueComboBox Referecia_Productos;
        private Views.CueComboBox PVP_Productos;
        private Views.CueComboBox Descripcion_Productos;
        private Views.CueComboBox IVA_Productos;
        private Views.CueTextBox Proveedor_Productos;
        private Views.CueTextBox Base_Productos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Detallada_Productos;
    }
}