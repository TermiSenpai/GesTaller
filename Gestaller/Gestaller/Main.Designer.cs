
namespace Gestaller
{
    partial class MainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsMenu = new System.Windows.Forms.Panel();
            this.btnOpciones = new System.Windows.Forms.Button();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnDepositos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.ChildPanel = new System.Windows.Forms.Panel();
            this.btnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsMenu
            // 
            this.btnsMenu.AutoScroll = true;
            this.btnsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsMenu.Controls.Add(this.btnOpciones);
            this.btnsMenu.Controls.Add(this.btnAlmacen);
            this.btnsMenu.Controls.Add(this.btnHistorial);
            this.btnsMenu.Controls.Add(this.btnOrdenes);
            this.btnsMenu.Controls.Add(this.btnDepositos);
            this.btnsMenu.Controls.Add(this.btnClientes);
            this.btnsMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnsMenu.Location = new System.Drawing.Point(0, 0);
            this.btnsMenu.Name = "btnsMenu";
            this.btnsMenu.Size = new System.Drawing.Size(200, 562);
            this.btnsMenu.TabIndex = 0;
            // 
            // btnOpciones
            // 
            this.btnOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpciones.FlatAppearance.BorderSize = 0;
            this.btnOpciones.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnOpciones.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpciones.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnOpciones.Location = new System.Drawing.Point(0, 275);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(200, 55);
            this.btnOpciones.TabIndex = 5;
            this.btnOpciones.Text = "Opciones";
            this.btnOpciones.UseVisualStyleBackColor = true;
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlmacen.FlatAppearance.BorderSize = 0;
            this.btnAlmacen.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAlmacen.Location = new System.Drawing.Point(0, 220);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(200, 55);
            this.btnAlmacen.TabIndex = 4;
            this.btnAlmacen.Text = "Almacén";
            this.btnAlmacen.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnHistorial.Location = new System.Drawing.Point(0, 165);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(200, 55);
            this.btnHistorial.TabIndex = 3;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdenes.FlatAppearance.BorderSize = 0;
            this.btnOrdenes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnOrdenes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenes.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnOrdenes.Location = new System.Drawing.Point(0, 110);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(200, 55);
            this.btnOrdenes.TabIndex = 2;
            this.btnOrdenes.Text = "Órdenes";
            this.btnOrdenes.UseVisualStyleBackColor = true;
            // 
            // btnDepositos
            // 
            this.btnDepositos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepositos.FlatAppearance.BorderSize = 0;
            this.btnDepositos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDepositos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDepositos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDepositos.Location = new System.Drawing.Point(0, 55);
            this.btnDepositos.Name = "btnDepositos";
            this.btnDepositos.Size = new System.Drawing.Size(200, 55);
            this.btnDepositos.TabIndex = 1;
            this.btnDepositos.Text = "Depósitos";
            this.btnDepositos.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnClientes.Location = new System.Drawing.Point(0, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(200, 55);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // ChildPanel
            // 
            this.ChildPanel.AutoScroll = true;
            this.ChildPanel.BackgroundImage = global::Gestaller.Properties.Resources.car;
            this.ChildPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ChildPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildPanel.Location = new System.Drawing.Point(200, 0);
            this.ChildPanel.Name = "ChildPanel";
            this.ChildPanel.Size = new System.Drawing.Size(800, 562);
            this.ChildPanel.TabIndex = 1;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.ChildPanel);
            this.Controls.Add(this.btnsMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainMenu";
            this.Text = "GesTaller";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.btnsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnsMenu;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnOpciones;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Button btnDepositos;
        private System.Windows.Forms.Panel ChildPanel;
    }
}

