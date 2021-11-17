
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
            this.Proveedores = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4_Pre = new System.Windows.Forms.Panel();
            this.btnImprimir_Pre = new System.Windows.Forms.Button();
            this.btnPresupuestor_Pre = new System.Windows.Forms.Button();
            this.btnProforma_Pre = new System.Windows.Forms.Button();
            this.btnFactura_Pre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cueComboBoxCIF = new Gestaller.Views.CueComboBox();
            this.cueComboBoxNombre = new Gestaller.Views.CueComboBox();
            this.cueComboBoxLocalidad = new Gestaller.Views.CueComboBox();
            this.cueComboBoxDireccion = new Gestaller.Views.CueComboBox();
            this.cueComboBoxProvincia = new Gestaller.Views.CueComboBox();
            this.cueComboBoxCP = new Gestaller.Views.CueComboBox();
            this.cueComboBoxMovil = new Gestaller.Views.CueComboBox();
            this.cueComboBoxTelefono = new Gestaller.Views.CueComboBox();
            this.cueComboBoxFax = new Gestaller.Views.CueComboBox();
            this.cueComboBoxEmail = new Gestaller.Views.CueComboBox();
            this.cueComboBox1 = new Gestaller.Views.CueComboBox();
            this.cueComboBox2 = new Gestaller.Views.CueComboBox();
            this.cueTextBox1 = new Gestaller.Views.CueTextBox();
            this.cueComboBox3 = new Gestaller.Views.CueComboBox();
            this.cueComboBox4 = new Gestaller.Views.CueComboBox();
            this.Productos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cueComboBox5 = new Gestaller.Views.CueComboBox();
            this.cueComboBox6 = new Gestaller.Views.CueComboBox();
            this.cueComboBox7 = new Gestaller.Views.CueComboBox();
            this.tabControl1.SuspendLayout();
            this.Proveedores.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4_Pre.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Productos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Proveedores);
            this.tabControl1.Controls.Add(this.Productos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 551);
            this.tabControl1.TabIndex = 0;
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
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 3);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4_Pre
            // 
            this.panel4_Pre.Controls.Add(this.btnImprimir_Pre);
            this.panel4_Pre.Controls.Add(this.btnPresupuestor_Pre);
            this.panel4_Pre.Controls.Add(this.btnProforma_Pre);
            this.panel4_Pre.Controls.Add(this.btnFactura_Pre);
            this.panel4_Pre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4_Pre.Location = new System.Drawing.Point(0, 176);
            this.panel4_Pre.Margin = new System.Windows.Forms.Padding(0);
            this.panel4_Pre.Name = "panel4_Pre";
            this.panel4_Pre.Size = new System.Drawing.Size(786, 23);
            this.panel4_Pre.TabIndex = 14;
            // 
            // btnImprimir_Pre
            // 
            this.btnImprimir_Pre.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImprimir_Pre.Location = new System.Drawing.Point(486, 0);
            this.btnImprimir_Pre.Name = "btnImprimir_Pre";
            this.btnImprimir_Pre.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir_Pre.TabIndex = 0;
            this.btnImprimir_Pre.Text = "Vaciar";
            this.btnImprimir_Pre.UseVisualStyleBackColor = true;
            // 
            // btnPresupuestor_Pre
            // 
            this.btnPresupuestor_Pre.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPresupuestor_Pre.Location = new System.Drawing.Point(561, 0);
            this.btnPresupuestor_Pre.Name = "btnPresupuestor_Pre";
            this.btnPresupuestor_Pre.Size = new System.Drawing.Size(75, 23);
            this.btnPresupuestor_Pre.TabIndex = 1;
            this.btnPresupuestor_Pre.Text = "Añadir";
            this.btnPresupuestor_Pre.UseVisualStyleBackColor = true;
            // 
            // btnProforma_Pre
            // 
            this.btnProforma_Pre.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProforma_Pre.Location = new System.Drawing.Point(636, 0);
            this.btnProforma_Pre.Name = "btnProforma_Pre";
            this.btnProforma_Pre.Size = new System.Drawing.Size(75, 23);
            this.btnProforma_Pre.TabIndex = 2;
            this.btnProforma_Pre.Text = "Modificar";
            this.btnProforma_Pre.UseVisualStyleBackColor = true;
            // 
            // btnFactura_Pre
            // 
            this.btnFactura_Pre.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFactura_Pre.Location = new System.Drawing.Point(711, 0);
            this.btnFactura_Pre.Name = "btnFactura_Pre";
            this.btnFactura_Pre.Size = new System.Drawing.Size(75, 23);
            this.btnFactura_Pre.TabIndex = 3;
            this.btnFactura_Pre.Text = "Borrar";
            this.btnFactura_Pre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "DATOS PROVEEDOR";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cueComboBoxCIF);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBoxNombre);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBoxLocalidad);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBoxDireccion);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBoxProvincia);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBoxCP);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBoxMovil);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBoxTelefono);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBoxFax);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBoxEmail);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBox1);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBox2);
            this.flowLayoutPanel1.Controls.Add(this.cueTextBox1);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBox3);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBox5);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBox4);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBox6);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBox7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(780, 150);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // cueComboBoxCIF
            // 
            this.cueComboBoxCIF.CueText = "N.I.F.";
            this.cueComboBoxCIF.FormattingEnabled = true;
            this.cueComboBoxCIF.Location = new System.Drawing.Point(3, 3);
            this.cueComboBoxCIF.Name = "cueComboBoxCIF";
            this.cueComboBoxCIF.Size = new System.Drawing.Size(121, 21);
            this.cueComboBoxCIF.TabIndex = 5;
            // 
            // cueComboBoxNombre
            // 
            this.cueComboBoxNombre.CueText = "Nombre";
            this.cueComboBoxNombre.FormattingEnabled = true;
            this.cueComboBoxNombre.Location = new System.Drawing.Point(130, 3);
            this.cueComboBoxNombre.Name = "cueComboBoxNombre";
            this.cueComboBoxNombre.Size = new System.Drawing.Size(248, 21);
            this.cueComboBoxNombre.TabIndex = 4;
            // 
            // cueComboBoxLocalidad
            // 
            this.cueComboBoxLocalidad.CueText = "Localidad";
            this.cueComboBoxLocalidad.FormattingEnabled = true;
            this.cueComboBoxLocalidad.Location = new System.Drawing.Point(384, 3);
            this.cueComboBoxLocalidad.Name = "cueComboBoxLocalidad";
            this.cueComboBoxLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cueComboBoxLocalidad.TabIndex = 16;
            // 
            // cueComboBoxDireccion
            // 
            this.cueComboBoxDireccion.CueText = "Dirección";
            this.cueComboBoxDireccion.FormattingEnabled = true;
            this.cueComboBoxDireccion.Location = new System.Drawing.Point(511, 3);
            this.cueComboBoxDireccion.Name = "cueComboBoxDireccion";
            this.cueComboBoxDireccion.Size = new System.Drawing.Size(248, 21);
            this.cueComboBoxDireccion.TabIndex = 15;
            // 
            // cueComboBoxProvincia
            // 
            this.cueComboBoxProvincia.CueText = "Provincia";
            this.cueComboBoxProvincia.FormattingEnabled = true;
            this.cueComboBoxProvincia.Location = new System.Drawing.Point(3, 30);
            this.cueComboBoxProvincia.Name = "cueComboBoxProvincia";
            this.cueComboBoxProvincia.Size = new System.Drawing.Size(121, 21);
            this.cueComboBoxProvincia.TabIndex = 17;
            // 
            // cueComboBoxCP
            // 
            this.cueComboBoxCP.CueText = "C.P.";
            this.cueComboBoxCP.FormattingEnabled = true;
            this.cueComboBoxCP.Location = new System.Drawing.Point(130, 30);
            this.cueComboBoxCP.Name = "cueComboBoxCP";
            this.cueComboBoxCP.Size = new System.Drawing.Size(121, 21);
            this.cueComboBoxCP.TabIndex = 18;
            // 
            // cueComboBoxMovil
            // 
            this.cueComboBoxMovil.CueText = "Móvil";
            this.cueComboBoxMovil.FormattingEnabled = true;
            this.cueComboBoxMovil.Location = new System.Drawing.Point(257, 30);
            this.cueComboBoxMovil.Name = "cueComboBoxMovil";
            this.cueComboBoxMovil.Size = new System.Drawing.Size(121, 21);
            this.cueComboBoxMovil.TabIndex = 9;
            // 
            // cueComboBoxTelefono
            // 
            this.cueComboBoxTelefono.CueText = "Teléfono";
            this.cueComboBoxTelefono.FormattingEnabled = true;
            this.cueComboBoxTelefono.Location = new System.Drawing.Point(384, 30);
            this.cueComboBoxTelefono.Name = "cueComboBoxTelefono";
            this.cueComboBoxTelefono.Size = new System.Drawing.Size(121, 21);
            this.cueComboBoxTelefono.TabIndex = 12;
            // 
            // cueComboBoxFax
            // 
            this.cueComboBoxFax.CueText = "Fax";
            this.cueComboBoxFax.FormattingEnabled = true;
            this.cueComboBoxFax.Location = new System.Drawing.Point(511, 30);
            this.cueComboBoxFax.Name = "cueComboBoxFax";
            this.cueComboBoxFax.Size = new System.Drawing.Size(121, 21);
            this.cueComboBoxFax.TabIndex = 13;
            // 
            // cueComboBoxEmail
            // 
            this.cueComboBoxEmail.CueText = "E-Mail";
            this.cueComboBoxEmail.FormattingEnabled = true;
            this.cueComboBoxEmail.Location = new System.Drawing.Point(3, 57);
            this.cueComboBoxEmail.Name = "cueComboBoxEmail";
            this.cueComboBoxEmail.Size = new System.Drawing.Size(248, 21);
            this.cueComboBoxEmail.TabIndex = 14;
            // 
            // cueComboBox1
            // 
            this.cueComboBox1.CueText = "Nº De Cuenta";
            this.cueComboBox1.FormattingEnabled = true;
            this.cueComboBox1.Location = new System.Drawing.Point(257, 57);
            this.cueComboBox1.Name = "cueComboBox1";
            this.cueComboBox1.Size = new System.Drawing.Size(248, 21);
            this.cueComboBox1.TabIndex = 19;
            // 
            // cueComboBox2
            // 
            this.cueComboBox2.CueText = "Entidad";
            this.cueComboBox2.FormattingEnabled = true;
            this.cueComboBox2.Location = new System.Drawing.Point(511, 57);
            this.cueComboBox2.Name = "cueComboBox2";
            this.cueComboBox2.Size = new System.Drawing.Size(121, 21);
            this.cueComboBox2.TabIndex = 20;
            // 
            // cueTextBox1
            // 
            this.cueTextBox1.CueText = "Firma-Pago";
            this.cueTextBox1.Location = new System.Drawing.Point(638, 57);
            this.cueTextBox1.Name = "cueTextBox1";
            this.cueTextBox1.Size = new System.Drawing.Size(121, 20);
            this.cueTextBox1.TabIndex = 22;
            this.cueTextBox1.TextChanged += new System.EventHandler(this.cueTextBox1_TextChanged);
            // 
            // cueComboBox3
            // 
            this.cueComboBox3.CueText = "Días-Pago";
            this.cueComboBox3.FormattingEnabled = true;
            this.cueComboBox3.Location = new System.Drawing.Point(3, 84);
            this.cueComboBox3.Name = "cueComboBox3";
            this.cueComboBox3.Size = new System.Drawing.Size(121, 21);
            this.cueComboBox3.TabIndex = 21;
            // 
            // cueComboBox4
            // 
            this.cueComboBox4.CueText = "Dirección 2";
            this.cueComboBox4.FormattingEnabled = true;
            this.cueComboBox4.Location = new System.Drawing.Point(257, 84);
            this.cueComboBox4.Name = "cueComboBox4";
            this.cueComboBox4.Size = new System.Drawing.Size(248, 21);
            this.cueComboBox4.TabIndex = 23;
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView2, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 519);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 119);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(780, 397);
            this.dataGridView2.TabIndex = 0;
            // 
            // cueComboBox5
            // 
            this.cueComboBox5.CueText = "Localidad 2";
            this.cueComboBox5.FormattingEnabled = true;
            this.cueComboBox5.Location = new System.Drawing.Point(130, 84);
            this.cueComboBox5.Name = "cueComboBox5";
            this.cueComboBox5.Size = new System.Drawing.Size(121, 21);
            this.cueComboBox5.TabIndex = 24;
            // 
            // cueComboBox6
            // 
            this.cueComboBox6.CueText = "Provincia 2";
            this.cueComboBox6.FormattingEnabled = true;
            this.cueComboBox6.Location = new System.Drawing.Point(511, 84);
            this.cueComboBox6.Name = "cueComboBox6";
            this.cueComboBox6.Size = new System.Drawing.Size(121, 21);
            this.cueComboBox6.TabIndex = 25;
            // 
            // cueComboBox7
            // 
            this.cueComboBox7.CueText = "C.P. 2";
            this.cueComboBox7.FormattingEnabled = true;
            this.cueComboBox7.Location = new System.Drawing.Point(638, 84);
            this.cueComboBox7.Name = "cueComboBox7";
            this.cueComboBox7.Size = new System.Drawing.Size(121, 21);
            this.cueComboBox7.TabIndex = 26;
            // 
            // WarehouseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.tabControl1);
            this.Name = "WarehouseView";
            this.Text = "Almacen";
            this.tabControl1.ResumeLayout(false);
            this.Proveedores.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4_Pre.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.Productos.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Proveedores;
        private System.Windows.Forms.TabPage Productos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel4_Pre;
        private System.Windows.Forms.Button btnImprimir_Pre;
        private System.Windows.Forms.Button btnPresupuestor_Pre;
        private System.Windows.Forms.Button btnProforma_Pre;
        private System.Windows.Forms.Button btnFactura_Pre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Views.CueComboBox cueComboBoxCIF;
        private Views.CueComboBox cueComboBoxNombre;
        private Views.CueComboBox cueComboBoxLocalidad;
        private Views.CueComboBox cueComboBoxDireccion;
        private Views.CueComboBox cueComboBoxProvincia;
        private Views.CueComboBox cueComboBoxCP;
        private Views.CueComboBox cueComboBoxMovil;
        private Views.CueComboBox cueComboBoxTelefono;
        private Views.CueComboBox cueComboBoxFax;
        private Views.CueComboBox cueComboBoxEmail;
        private Views.CueComboBox cueComboBox1;
        private Views.CueComboBox cueComboBox2;
        private Views.CueTextBox cueTextBox1;
        private Views.CueComboBox cueComboBox3;
        private Views.CueComboBox cueComboBox4;
        private Views.CueComboBox cueComboBox5;
        private Views.CueComboBox cueComboBox6;
        private Views.CueComboBox cueComboBox7;
    }
}