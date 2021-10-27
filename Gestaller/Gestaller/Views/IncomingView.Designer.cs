
namespace Gestaller
{
    partial class IncomingView
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
            this.table1Recepciones_Main_Container = new System.Windows.Forms.TableLayoutPanel();
            this.table1Recepciones_Down_Side = new System.Windows.Forms.TableLayoutPanel();
            this.table1Recepciones_Grids = new System.Windows.Forms.TableLayoutPanel();
            this.table1Recepciones_Vehicle = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewVehicles = new System.Windows.Forms.DataGridView();
            this.flowIncoming_Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.button1Create = new System.Windows.Forms.Button();
            this.button2Modificar = new System.Windows.Forms.Button();
            this.button3Buscar = new System.Windows.Forms.Button();
            this.button4Borrar = new System.Windows.Forms.Button();
            this.button5Presupuesto = new System.Windows.Forms.Button();
            this.button6Entregar = new System.Windows.Forms.Button();
            this.dataGridViewDepositos = new System.Windows.Forms.DataGridView();
            this.tableDatosV = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowDatos_Vehiculos = new System.Windows.Forms.FlowLayoutPanel();
            this.cueComboBoxMatricula = new Gestaller.Views.CueComboBox();
            this.cueTextBoxKMS = new Gestaller.Views.CueTextBox();
            this.cueComboBoxBastidor = new Gestaller.Views.CueComboBox();
            this.cueComboBoxCliente = new Gestaller.Views.CueComboBox();
            this.cueComboBoxMarca = new Gestaller.Views.CueComboBox();
            this.cueComboBoxModelo = new Gestaller.Views.CueComboBox();
            this.cueComboBoxTipoMotor = new Gestaller.Views.CueComboBox();
            this.table1Recepciones_Main_Container.SuspendLayout();
            this.table1Recepciones_Down_Side.SuspendLayout();
            this.table1Recepciones_Grids.SuspendLayout();
            this.table1Recepciones_Vehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).BeginInit();
            this.flowIncoming_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepositos)).BeginInit();
            this.tableDatosV.SuspendLayout();
            this.flowDatos_Vehiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // table1Recepciones_Main_Container
            // 
            this.table1Recepciones_Main_Container.ColumnCount = 1;
            this.table1Recepciones_Main_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table1Recepciones_Main_Container.Controls.Add(this.table1Recepciones_Down_Side, 0, 1);
            this.table1Recepciones_Main_Container.Controls.Add(this.tableDatosV, 0, 0);
            this.table1Recepciones_Main_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table1Recepciones_Main_Container.Location = new System.Drawing.Point(0, 0);
            this.table1Recepciones_Main_Container.Name = "table1Recepciones_Main_Container";
            this.table1Recepciones_Main_Container.RowCount = 2;
            this.table1Recepciones_Main_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table1Recepciones_Main_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table1Recepciones_Main_Container.Size = new System.Drawing.Size(800, 450);
            this.table1Recepciones_Main_Container.TabIndex = 0;
            // 
            // table1Recepciones_Down_Side
            // 
            this.table1Recepciones_Down_Side.ColumnCount = 1;
            this.table1Recepciones_Down_Side.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table1Recepciones_Down_Side.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table1Recepciones_Down_Side.Controls.Add(this.table1Recepciones_Grids, 0, 0);
            this.table1Recepciones_Down_Side.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table1Recepciones_Down_Side.Location = new System.Drawing.Point(3, 228);
            this.table1Recepciones_Down_Side.Name = "table1Recepciones_Down_Side";
            this.table1Recepciones_Down_Side.RowCount = 1;
            this.table1Recepciones_Down_Side.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table1Recepciones_Down_Side.Size = new System.Drawing.Size(794, 219);
            this.table1Recepciones_Down_Side.TabIndex = 0;
            // 
            // table1Recepciones_Grids
            // 
            this.table1Recepciones_Grids.ColumnCount = 1;
            this.table1Recepciones_Grids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table1Recepciones_Grids.Controls.Add(this.table1Recepciones_Vehicle, 0, 0);
            this.table1Recepciones_Grids.Controls.Add(this.dataGridViewDepositos, 0, 1);
            this.table1Recepciones_Grids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table1Recepciones_Grids.Location = new System.Drawing.Point(3, 3);
            this.table1Recepciones_Grids.Name = "table1Recepciones_Grids";
            this.table1Recepciones_Grids.RowCount = 2;
            this.table1Recepciones_Grids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table1Recepciones_Grids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table1Recepciones_Grids.Size = new System.Drawing.Size(788, 213);
            this.table1Recepciones_Grids.TabIndex = 0;
            // 
            // table1Recepciones_Vehicle
            // 
            this.table1Recepciones_Vehicle.ColumnCount = 2;
            this.table1Recepciones_Vehicle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table1Recepciones_Vehicle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table1Recepciones_Vehicle.Controls.Add(this.dataGridViewVehicles, 0, 0);
            this.table1Recepciones_Vehicle.Controls.Add(this.flowIncoming_Buttons, 1, 0);
            this.table1Recepciones_Vehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table1Recepciones_Vehicle.Location = new System.Drawing.Point(3, 3);
            this.table1Recepciones_Vehicle.Name = "table1Recepciones_Vehicle";
            this.table1Recepciones_Vehicle.RowCount = 1;
            this.table1Recepciones_Vehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table1Recepciones_Vehicle.Size = new System.Drawing.Size(782, 100);
            this.table1Recepciones_Vehicle.TabIndex = 0;
            // 
            // dataGridViewVehicles
            // 
            this.dataGridViewVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVehicles.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewVehicles.Name = "dataGridViewVehicles";
            this.dataGridViewVehicles.Size = new System.Drawing.Size(385, 94);
            this.dataGridViewVehicles.TabIndex = 0;
            // 
            // flowIncoming_Buttons
            // 
            this.flowIncoming_Buttons.Controls.Add(this.button1Create);
            this.flowIncoming_Buttons.Controls.Add(this.button2Modificar);
            this.flowIncoming_Buttons.Controls.Add(this.button3Buscar);
            this.flowIncoming_Buttons.Controls.Add(this.button4Borrar);
            this.flowIncoming_Buttons.Controls.Add(this.button5Presupuesto);
            this.flowIncoming_Buttons.Controls.Add(this.button6Entregar);
            this.flowIncoming_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowIncoming_Buttons.Location = new System.Drawing.Point(394, 3);
            this.flowIncoming_Buttons.Name = "flowIncoming_Buttons";
            this.flowIncoming_Buttons.Size = new System.Drawing.Size(385, 94);
            this.flowIncoming_Buttons.TabIndex = 1;
            // 
            // button1Create
            // 
            this.button1Create.Location = new System.Drawing.Point(3, 3);
            this.button1Create.Name = "button1Create";
            this.button1Create.Size = new System.Drawing.Size(75, 23);
            this.button1Create.TabIndex = 0;
            this.button1Create.Text = "Crear";
            this.button1Create.UseVisualStyleBackColor = true;
            // 
            // button2Modificar
            // 
            this.button2Modificar.Location = new System.Drawing.Point(84, 3);
            this.button2Modificar.Name = "button2Modificar";
            this.button2Modificar.Size = new System.Drawing.Size(75, 23);
            this.button2Modificar.TabIndex = 1;
            this.button2Modificar.Text = "Modificar";
            this.button2Modificar.UseVisualStyleBackColor = true;
            // 
            // button3Buscar
            // 
            this.button3Buscar.Location = new System.Drawing.Point(165, 3);
            this.button3Buscar.Name = "button3Buscar";
            this.button3Buscar.Size = new System.Drawing.Size(75, 23);
            this.button3Buscar.TabIndex = 2;
            this.button3Buscar.Text = "Buscar";
            this.button3Buscar.UseVisualStyleBackColor = true;
            // 
            // button4Borrar
            // 
            this.button4Borrar.Location = new System.Drawing.Point(246, 3);
            this.button4Borrar.Name = "button4Borrar";
            this.button4Borrar.Size = new System.Drawing.Size(75, 23);
            this.button4Borrar.TabIndex = 3;
            this.button4Borrar.Text = "Borrar";
            this.button4Borrar.UseVisualStyleBackColor = true;
            // 
            // button5Presupuesto
            // 
            this.button5Presupuesto.Location = new System.Drawing.Point(3, 32);
            this.button5Presupuesto.Name = "button5Presupuesto";
            this.button5Presupuesto.Size = new System.Drawing.Size(75, 23);
            this.button5Presupuesto.TabIndex = 4;
            this.button5Presupuesto.Text = "Presupuesto";
            this.button5Presupuesto.UseVisualStyleBackColor = true;
            // 
            // button6Entregar
            // 
            this.button6Entregar.Location = new System.Drawing.Point(84, 32);
            this.button6Entregar.Name = "button6Entregar";
            this.button6Entregar.Size = new System.Drawing.Size(75, 23);
            this.button6Entregar.TabIndex = 5;
            this.button6Entregar.Text = "Entregar";
            this.button6Entregar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDepositos
            // 
            this.dataGridViewDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepositos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDepositos.Location = new System.Drawing.Point(3, 109);
            this.dataGridViewDepositos.Name = "dataGridViewDepositos";
            this.dataGridViewDepositos.Size = new System.Drawing.Size(782, 101);
            this.dataGridViewDepositos.TabIndex = 1;
            // 
            // tableDatosV
            // 
            this.tableDatosV.ColumnCount = 1;
            this.tableDatosV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDatosV.Controls.Add(this.label1, 0, 0);
            this.tableDatosV.Controls.Add(this.flowDatos_Vehiculos, 0, 1);
            this.tableDatosV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDatosV.Location = new System.Drawing.Point(3, 3);
            this.tableDatosV.Name = "tableDatosV";
            this.tableDatosV.RowCount = 2;
            this.tableDatosV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableDatosV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableDatosV.Size = new System.Drawing.Size(794, 219);
            this.tableDatosV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DATOS DE LOS VEHÍCULOS";
            // 
            // flowDatos_Vehiculos
            // 
            this.flowDatos_Vehiculos.Controls.Add(this.cueComboBoxMatricula);
            this.flowDatos_Vehiculos.Controls.Add(this.cueTextBoxKMS);
            this.flowDatos_Vehiculos.Controls.Add(this.cueComboBoxBastidor);
            this.flowDatos_Vehiculos.Controls.Add(this.cueComboBoxCliente);
            this.flowDatos_Vehiculos.Controls.Add(this.cueComboBoxMarca);
            this.flowDatos_Vehiculos.Controls.Add(this.cueComboBoxModelo);
            this.flowDatos_Vehiculos.Controls.Add(this.cueComboBoxTipoMotor);
            this.flowDatos_Vehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowDatos_Vehiculos.Location = new System.Drawing.Point(3, 24);
            this.flowDatos_Vehiculos.Name = "flowDatos_Vehiculos";
            this.flowDatos_Vehiculos.Size = new System.Drawing.Size(788, 192);
            this.flowDatos_Vehiculos.TabIndex = 1;
            // 
            // cueComboBoxMatricula
            // 
            this.cueComboBoxMatricula.CueText = "Matrícula";
            this.cueComboBoxMatricula.FormattingEnabled = true;
            this.cueComboBoxMatricula.Location = new System.Drawing.Point(3, 3);
            this.cueComboBoxMatricula.Name = "cueComboBoxMatricula";
            this.cueComboBoxMatricula.Size = new System.Drawing.Size(121, 21);
            this.cueComboBoxMatricula.TabIndex = 0;
            // 
            // cueTextBoxKMS
            // 
            this.cueTextBoxKMS.CueText = "Kmts.";
            this.cueTextBoxKMS.Location = new System.Drawing.Point(130, 3);
            this.cueTextBoxKMS.Name = "cueTextBoxKMS";
            this.cueTextBoxKMS.Size = new System.Drawing.Size(100, 20);
            this.cueTextBoxKMS.TabIndex = 1;
            // 
            // cueComboBoxBastidor
            // 
            this.cueComboBoxBastidor.CueText = "Bastidor";
            this.cueComboBoxBastidor.FormattingEnabled = true;
            this.cueComboBoxBastidor.Location = new System.Drawing.Point(236, 3);
            this.cueComboBoxBastidor.Name = "cueComboBoxBastidor";
            this.cueComboBoxBastidor.Size = new System.Drawing.Size(121, 21);
            this.cueComboBoxBastidor.TabIndex = 2;
            // 
            // cueComboBoxCliente
            // 
            this.cueComboBoxCliente.CueText = "Cliente";
            this.cueComboBoxCliente.FormattingEnabled = true;
            this.cueComboBoxCliente.Location = new System.Drawing.Point(363, 3);
            this.cueComboBoxCliente.Name = "cueComboBoxCliente";
            this.cueComboBoxCliente.Size = new System.Drawing.Size(121, 21);
            this.cueComboBoxCliente.TabIndex = 3;
            // 
            // cueComboBoxMarca
            // 
            this.cueComboBoxMarca.CueText = "Marca";
            this.cueComboBoxMarca.FormattingEnabled = true;
            this.cueComboBoxMarca.Location = new System.Drawing.Point(490, 3);
            this.cueComboBoxMarca.Name = "cueComboBoxMarca";
            this.cueComboBoxMarca.Size = new System.Drawing.Size(121, 21);
            this.cueComboBoxMarca.TabIndex = 4;
            // 
            // cueComboBoxModelo
            // 
            this.cueComboBoxModelo.CueText = "Modelo";
            this.cueComboBoxModelo.FormattingEnabled = true;
            this.cueComboBoxModelo.Location = new System.Drawing.Point(617, 3);
            this.cueComboBoxModelo.Name = "cueComboBoxModelo";
            this.cueComboBoxModelo.Size = new System.Drawing.Size(121, 21);
            this.cueComboBoxModelo.TabIndex = 5;
            // 
            // cueComboBoxTipoMotor
            // 
            this.cueComboBoxTipoMotor.CueText = "Tipo de Motor";
            this.cueComboBoxTipoMotor.FormattingEnabled = true;
            this.cueComboBoxTipoMotor.Location = new System.Drawing.Point(3, 30);
            this.cueComboBoxTipoMotor.Name = "cueComboBoxTipoMotor";
            this.cueComboBoxTipoMotor.Size = new System.Drawing.Size(121, 21);
            this.cueComboBoxTipoMotor.TabIndex = 6;
            // 
            // IncomingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.table1Recepciones_Main_Container);
            this.Name = "IncomingView";
            this.Text = "Informe_Recepciones";
            this.Load += new System.EventHandler(this.IncomingView_Load);
            this.table1Recepciones_Main_Container.ResumeLayout(false);
            this.table1Recepciones_Down_Side.ResumeLayout(false);
            this.table1Recepciones_Grids.ResumeLayout(false);
            this.table1Recepciones_Vehicle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).EndInit();
            this.flowIncoming_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepositos)).EndInit();
            this.tableDatosV.ResumeLayout(false);
            this.tableDatosV.PerformLayout();
            this.flowDatos_Vehiculos.ResumeLayout(false);
            this.flowDatos_Vehiculos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel table1Recepciones_Main_Container;
        private System.Windows.Forms.TableLayoutPanel table1Recepciones_Down_Side;
        private System.Windows.Forms.TableLayoutPanel table1Recepciones_Grids;
        private System.Windows.Forms.TableLayoutPanel table1Recepciones_Vehicle;
        private System.Windows.Forms.FlowLayoutPanel flowDatos_Vehiculos;
        private System.Windows.Forms.DataGridView dataGridViewVehicles;
        private System.Windows.Forms.FlowLayoutPanel flowIncoming_Buttons;
        private System.Windows.Forms.Button button1Create;
        private System.Windows.Forms.Button button2Modificar;
        private System.Windows.Forms.Button button3Buscar;
        private System.Windows.Forms.Button button4Borrar;
        private System.Windows.Forms.Button button5Presupuesto;
        private System.Windows.Forms.Button button6Entregar;
        private System.Windows.Forms.DataGridView dataGridViewDepositos;
        private Views.CueComboBox cueComboBoxMatricula;
        private Views.CueTextBox cueTextBoxKMS;
        private Views.CueComboBox cueComboBoxBastidor;
        private Views.CueComboBox cueComboBoxCliente;
        private Views.CueComboBox cueComboBoxMarca;
        private Views.CueComboBox cueComboBoxModelo;
        private Views.CueComboBox cueComboBoxTipoMotor;
        private System.Windows.Forms.TableLayoutPanel tableDatosV;
        private System.Windows.Forms.Label label1;
    }
}