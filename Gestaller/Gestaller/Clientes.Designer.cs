
namespace Gestaller
{
    partial class Clientes
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
            this.tab_datos_bancarios = new System.Windows.Forms.TabPage();
            this.tab_otras_direcciones = new System.Windows.Forms.TabPage();
            this.tabControl_Clientes.SuspendLayout();
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
            this.tabControl_Clientes.Size = new System.Drawing.Size(800, 450);
            this.tabControl_Clientes.TabIndex = 0;
            // 
            // tab_clientes_vehiculos
            // 
            this.tab_clientes_vehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_clientes_vehiculos.Location = new System.Drawing.Point(4, 22);
            this.tab_clientes_vehiculos.Margin = new System.Windows.Forms.Padding(0);
            this.tab_clientes_vehiculos.Name = "tab_clientes_vehiculos";
            this.tab_clientes_vehiculos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_clientes_vehiculos.Size = new System.Drawing.Size(792, 424);
            this.tab_clientes_vehiculos.TabIndex = 0;
            this.tab_clientes_vehiculos.Text = "Clientes-Vehiculos";
            this.tab_clientes_vehiculos.UseVisualStyleBackColor = true;
            // 
            // tab_datos_bancarios
            // 
            this.tab_datos_bancarios.Location = new System.Drawing.Point(4, 22);
            this.tab_datos_bancarios.Margin = new System.Windows.Forms.Padding(0);
            this.tab_datos_bancarios.Name = "tab_datos_bancarios";
            this.tab_datos_bancarios.Padding = new System.Windows.Forms.Padding(3);
            this.tab_datos_bancarios.Size = new System.Drawing.Size(792, 424);
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
            this.tab_otras_direcciones.Size = new System.Drawing.Size(792, 424);
            this.tab_otras_direcciones.TabIndex = 2;
            this.tab_otras_direcciones.Text = "Otras Direcciones";
            this.tab_otras_direcciones.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl_Clientes);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.tabControl_Clientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Clientes;
        private System.Windows.Forms.TabPage tab_clientes_vehiculos;
        private System.Windows.Forms.TabPage tab_datos_bancarios;
        private System.Windows.Forms.TabPage tab_otras_direcciones;
    }
}