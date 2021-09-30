
namespace Gestaller
{
    partial class Opciones
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
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.tabIVA = new System.Windows.Forms.TabPage();
            this.tabEmpresa = new System.Windows.Forms.TabPage();
            this.tabServidor = new System.Windows.Forms.TabPage();
            this.layoutIVAForm = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTipo = new System.Windows.Forms.Panel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.boxTipo = new System.Windows.Forms.TextBox();
            this.panelValor = new System.Windows.Forms.Panel();
            this.boxValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IVAgridView = new System.Windows.Forms.DataGridView();
            this.tabOptions.SuspendLayout();
            this.tabIVA.SuspendLayout();
            this.layoutIVAForm.SuspendLayout();
            this.panelTipo.SuspendLayout();
            this.panelValor.SuspendLayout();
            this.btnLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IVAgridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.tabIVA);
            this.tabOptions.Controls.Add(this.tabEmpresa);
            this.tabOptions.Controls.Add(this.tabServidor);
            this.tabOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOptions.Location = new System.Drawing.Point(0, 0);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(1000, 562);
            this.tabOptions.TabIndex = 0;
            // 
            // tabIVA
            // 
            this.tabIVA.Controls.Add(this.panel1);
            this.tabIVA.Controls.Add(this.btnLayout);
            this.tabIVA.Controls.Add(this.layoutIVAForm);
            this.tabIVA.Location = new System.Drawing.Point(4, 29);
            this.tabIVA.Name = "tabIVA";
            this.tabIVA.Padding = new System.Windows.Forms.Padding(3);
            this.tabIVA.Size = new System.Drawing.Size(992, 529);
            this.tabIVA.TabIndex = 0;
            this.tabIVA.Text = "IVA";
            this.tabIVA.UseVisualStyleBackColor = true;
            // 
            // tabEmpresa
            // 
            this.tabEmpresa.Location = new System.Drawing.Point(4, 29);
            this.tabEmpresa.Name = "tabEmpresa";
            this.tabEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpresa.Size = new System.Drawing.Size(992, 529);
            this.tabEmpresa.TabIndex = 1;
            this.tabEmpresa.Text = "Datos de empresa";
            this.tabEmpresa.UseVisualStyleBackColor = true;
            // 
            // tabServidor
            // 
            this.tabServidor.Location = new System.Drawing.Point(4, 29);
            this.tabServidor.Name = "tabServidor";
            this.tabServidor.Padding = new System.Windows.Forms.Padding(3);
            this.tabServidor.Size = new System.Drawing.Size(992, 529);
            this.tabServidor.TabIndex = 2;
            this.tabServidor.Text = "Servidor";
            this.tabServidor.UseVisualStyleBackColor = true;
            // 
            // layoutIVAForm
            // 
            this.layoutIVAForm.Controls.Add(this.panelTipo);
            this.layoutIVAForm.Controls.Add(this.panelValor);
            this.layoutIVAForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutIVAForm.Location = new System.Drawing.Point(3, 3);
            this.layoutIVAForm.Name = "layoutIVAForm";
            this.layoutIVAForm.Size = new System.Drawing.Size(986, 57);
            this.layoutIVAForm.TabIndex = 0;
            // 
            // panelTipo
            // 
            this.panelTipo.AutoSize = true;
            this.panelTipo.Controls.Add(this.boxTipo);
            this.panelTipo.Controls.Add(this.lblTipo);
            this.panelTipo.Location = new System.Drawing.Point(75, 20);
            this.panelTipo.Margin = new System.Windows.Forms.Padding(75, 20, 3, 3);
            this.panelTipo.Name = "panelTipo";
            this.panelTipo.Size = new System.Drawing.Size(155, 33);
            this.panelTipo.TabIndex = 0;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(4, 4);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(41, 20);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            // 
            // boxTipo
            // 
            this.boxTipo.Location = new System.Drawing.Point(52, 4);
            this.boxTipo.Name = "boxTipo";
            this.boxTipo.Size = new System.Drawing.Size(100, 26);
            this.boxTipo.TabIndex = 1;
            // 
            // panelValor
            // 
            this.panelValor.AutoSize = true;
            this.panelValor.Controls.Add(this.boxValor);
            this.panelValor.Controls.Add(this.lblValor);
            this.panelValor.Location = new System.Drawing.Point(236, 20);
            this.panelValor.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.panelValor.Name = "panelValor";
            this.panelValor.Size = new System.Drawing.Size(155, 33);
            this.panelValor.TabIndex = 1;
            // 
            // boxValor
            // 
            this.boxValor.Location = new System.Drawing.Point(52, 4);
            this.boxValor.Name = "boxValor";
            this.boxValor.Size = new System.Drawing.Size(100, 26);
            this.boxValor.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(4, 4);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(48, 20);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            // 
            // btnLayout
            // 
            this.btnLayout.Controls.Add(this.btnAplicar);
            this.btnLayout.Controls.Add(this.btnDelete);
            this.btnLayout.Controls.Add(this.btnCancel);
            this.btnLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLayout.Location = new System.Drawing.Point(3, 60);
            this.btnLayout.Name = "btnLayout";
            this.btnLayout.Size = new System.Drawing.Size(986, 100);
            this.btnLayout.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(364, 25);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(50, 25, 50, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 35);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(207, 25);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0, 25, 0, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 35);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(50, 25);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(50, 25, 50, 3);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(107, 35);
            this.btnAplicar.TabIndex = 2;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IVAgridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 366);
            this.panel1.TabIndex = 2;
            // 
            // IVAgridView
            // 
            this.IVAgridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IVAgridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IVAgridView.Location = new System.Drawing.Point(0, 0);
            this.IVAgridView.Name = "IVAgridView";
            this.IVAgridView.RowHeadersWidth = 51;
            this.IVAgridView.RowTemplate.Height = 24;
            this.IVAgridView.Size = new System.Drawing.Size(986, 366);
            this.IVAgridView.TabIndex = 0;
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.tabOptions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Opciones";
            this.Text = "Opciones";
            this.tabOptions.ResumeLayout(false);
            this.tabIVA.ResumeLayout(false);
            this.layoutIVAForm.ResumeLayout(false);
            this.layoutIVAForm.PerformLayout();
            this.panelTipo.ResumeLayout(false);
            this.panelTipo.PerformLayout();
            this.panelValor.ResumeLayout(false);
            this.panelValor.PerformLayout();
            this.btnLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IVAgridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.TabPage tabIVA;
        private System.Windows.Forms.TabPage tabEmpresa;
        private System.Windows.Forms.TabPage tabServidor;
        private System.Windows.Forms.FlowLayoutPanel layoutIVAForm;
        private System.Windows.Forms.FlowLayoutPanel btnLayout;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelTipo;
        private System.Windows.Forms.TextBox boxTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Panel panelValor;
        private System.Windows.Forms.TextBox boxValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView IVAgridView;
    }
}