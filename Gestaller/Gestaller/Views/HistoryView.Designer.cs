
namespace Gestaller
{
    partial class HistoryView
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
            this.tabControl1Historial = new System.Windows.Forms.TabControl();
            this.tabPageHistContable = new System.Windows.Forms.TabPage();
            this.tableHist_Contable = new System.Windows.Forms.TableLayoutPanel();
            this.label1Hist_Contable_Titulo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1Hist_Contable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1Hist_Contable_FechaInicio = new System.Windows.Forms.Panel();
            this.label2Hist_Contable_FechaInicio = new System.Windows.Forms.Label();
            this.dateTimePicker1Hist_Contable_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.panel2Hist_Contable_FechaFin = new System.Windows.Forms.Panel();
            this.label3Hist_Contable_FechaFin = new System.Windows.Forms.Label();
            this.dateTimePicker2Hist_Contable_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.panel1Hist_Contable = new System.Windows.Forms.Panel();
            this.button1Hist_Contable_Ver = new System.Windows.Forms.Button();
            this.dataGridView1Hist_Contable = new System.Windows.Forms.DataGridView();
            this.panel2Hist_Contable = new System.Windows.Forms.Panel();
            this.cueTextBox1 = new Gestaller.Views.CueTextBox();
            this.tabPageHistFacturas = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1Hist_Facturas = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cueTextBox2 = new Gestaller.Views.CueTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cueComboBox1 = new Gestaller.Views.CueComboBox();
            this.cueComboBox2 = new Gestaller.Views.CueComboBox();
            this.cueComboBox3 = new Gestaller.Views.CueComboBox();
            this.cueComboBox4 = new Gestaller.Views.CueComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageHistDeposito = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1Hist_Depositos = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cueComboBox5 = new Gestaller.Views.CueComboBox();
            this.cueComboBox6 = new Gestaller.Views.CueComboBox();
            this.cueComboBox7 = new Gestaller.Views.CueComboBox();
            this.cueComboBox8 = new Gestaller.Views.CueComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1Historial.SuspendLayout();
            this.tabPageHistContable.SuspendLayout();
            this.tableHist_Contable.SuspendLayout();
            this.flowLayoutPanel1Hist_Contable.SuspendLayout();
            this.panel1Hist_Contable_FechaInicio.SuspendLayout();
            this.panel2Hist_Contable_FechaFin.SuspendLayout();
            this.panel1Hist_Contable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Hist_Contable)).BeginInit();
            this.panel2Hist_Contable.SuspendLayout();
            this.tabPageHistFacturas.SuspendLayout();
            this.tableLayoutPanel1Hist_Facturas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPageHistDeposito.SuspendLayout();
            this.tableLayoutPanel1Hist_Depositos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1Historial
            // 
            this.tabControl1Historial.Controls.Add(this.tabPageHistContable);
            this.tabControl1Historial.Controls.Add(this.tabPageHistFacturas);
            this.tabControl1Historial.Controls.Add(this.tabPageHistDeposito);
            this.tabControl1Historial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1Historial.Location = new System.Drawing.Point(0, 0);
            this.tabControl1Historial.Name = "tabControl1Historial";
            this.tabControl1Historial.SelectedIndex = 0;
            this.tabControl1Historial.Size = new System.Drawing.Size(800, 450);
            this.tabControl1Historial.TabIndex = 2;
            // 
            // tabPageHistContable
            // 
            this.tabPageHistContable.Controls.Add(this.tableHist_Contable);
            this.tabPageHistContable.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistContable.Name = "tabPageHistContable";
            this.tabPageHistContable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistContable.Size = new System.Drawing.Size(792, 424);
            this.tabPageHistContable.TabIndex = 0;
            this.tabPageHistContable.Text = "Historial Contable";
            this.tabPageHistContable.UseVisualStyleBackColor = true;
            // 
            // tableHist_Contable
            // 
            this.tableHist_Contable.ColumnCount = 1;
            this.tableHist_Contable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableHist_Contable.Controls.Add(this.label1Hist_Contable_Titulo, 0, 0);
            this.tableHist_Contable.Controls.Add(this.flowLayoutPanel1Hist_Contable, 0, 1);
            this.tableHist_Contable.Controls.Add(this.panel1Hist_Contable, 0, 2);
            this.tableHist_Contable.Controls.Add(this.dataGridView1Hist_Contable, 0, 3);
            this.tableHist_Contable.Controls.Add(this.panel2Hist_Contable, 0, 4);
            this.tableHist_Contable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableHist_Contable.Location = new System.Drawing.Point(3, 3);
            this.tableHist_Contable.Name = "tableHist_Contable";
            this.tableHist_Contable.RowCount = 5;
            this.tableHist_Contable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableHist_Contable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableHist_Contable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableHist_Contable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableHist_Contable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableHist_Contable.Size = new System.Drawing.Size(786, 418);
            this.tableHist_Contable.TabIndex = 0;
            // 
            // label1Hist_Contable_Titulo
            // 
            this.label1Hist_Contable_Titulo.AutoSize = true;
            this.label1Hist_Contable_Titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1Hist_Contable_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1Hist_Contable_Titulo.Location = new System.Drawing.Point(3, 0);
            this.label1Hist_Contable_Titulo.Name = "label1Hist_Contable_Titulo";
            this.label1Hist_Contable_Titulo.Size = new System.Drawing.Size(780, 20);
            this.label1Hist_Contable_Titulo.TabIndex = 0;
            this.label1Hist_Contable_Titulo.Text = "CONTABILIDAD POR FECHAS";
            // 
            // flowLayoutPanel1Hist_Contable
            // 
            this.flowLayoutPanel1Hist_Contable.Controls.Add(this.panel1Hist_Contable_FechaInicio);
            this.flowLayoutPanel1Hist_Contable.Controls.Add(this.panel2Hist_Contable_FechaFin);
            this.flowLayoutPanel1Hist_Contable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1Hist_Contable.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel1Hist_Contable.Name = "flowLayoutPanel1Hist_Contable";
            this.flowLayoutPanel1Hist_Contable.Size = new System.Drawing.Size(780, 58);
            this.flowLayoutPanel1Hist_Contable.TabIndex = 1;
            // 
            // panel1Hist_Contable_FechaInicio
            // 
            this.panel1Hist_Contable_FechaInicio.Controls.Add(this.label2Hist_Contable_FechaInicio);
            this.panel1Hist_Contable_FechaInicio.Controls.Add(this.dateTimePicker1Hist_Contable_FechaInicio);
            this.panel1Hist_Contable_FechaInicio.Location = new System.Drawing.Point(3, 3);
            this.panel1Hist_Contable_FechaInicio.Name = "panel1Hist_Contable_FechaInicio";
            this.panel1Hist_Contable_FechaInicio.Size = new System.Drawing.Size(248, 26);
            this.panel1Hist_Contable_FechaInicio.TabIndex = 0;
            // 
            // label2Hist_Contable_FechaInicio
            // 
            this.label2Hist_Contable_FechaInicio.AutoSize = true;
            this.label2Hist_Contable_FechaInicio.Location = new System.Drawing.Point(3, 6);
            this.label2Hist_Contable_FechaInicio.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label2Hist_Contable_FechaInicio.Name = "label2Hist_Contable_FechaInicio";
            this.label2Hist_Contable_FechaInicio.Size = new System.Drawing.Size(65, 13);
            this.label2Hist_Contable_FechaInicio.TabIndex = 0;
            this.label2Hist_Contable_FechaInicio.Text = "Fecha Inicio";
            // 
            // dateTimePicker1Hist_Contable_FechaInicio
            // 
            this.dateTimePicker1Hist_Contable_FechaInicio.CustomFormat = "";
            this.dateTimePicker1Hist_Contable_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1Hist_Contable_FechaInicio.Location = new System.Drawing.Point(124, 3);
            this.dateTimePicker1Hist_Contable_FechaInicio.Name = "dateTimePicker1Hist_Contable_FechaInicio";
            this.dateTimePicker1Hist_Contable_FechaInicio.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1Hist_Contable_FechaInicio.TabIndex = 0;
            // 
            // panel2Hist_Contable_FechaFin
            // 
            this.panel2Hist_Contable_FechaFin.Controls.Add(this.label3Hist_Contable_FechaFin);
            this.panel2Hist_Contable_FechaFin.Controls.Add(this.dateTimePicker2Hist_Contable_FechaFin);
            this.panel2Hist_Contable_FechaFin.Location = new System.Drawing.Point(257, 3);
            this.panel2Hist_Contable_FechaFin.Name = "panel2Hist_Contable_FechaFin";
            this.panel2Hist_Contable_FechaFin.Size = new System.Drawing.Size(248, 26);
            this.panel2Hist_Contable_FechaFin.TabIndex = 1;
            // 
            // label3Hist_Contable_FechaFin
            // 
            this.label3Hist_Contable_FechaFin.AutoSize = true;
            this.label3Hist_Contable_FechaFin.Location = new System.Drawing.Point(3, 6);
            this.label3Hist_Contable_FechaFin.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label3Hist_Contable_FechaFin.Name = "label3Hist_Contable_FechaFin";
            this.label3Hist_Contable_FechaFin.Size = new System.Drawing.Size(54, 13);
            this.label3Hist_Contable_FechaFin.TabIndex = 0;
            this.label3Hist_Contable_FechaFin.Text = "Fecha Fin";
            // 
            // dateTimePicker2Hist_Contable_FechaFin
            // 
            this.dateTimePicker2Hist_Contable_FechaFin.CustomFormat = "";
            this.dateTimePicker2Hist_Contable_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2Hist_Contable_FechaFin.Location = new System.Drawing.Point(124, 3);
            this.dateTimePicker2Hist_Contable_FechaFin.Name = "dateTimePicker2Hist_Contable_FechaFin";
            this.dateTimePicker2Hist_Contable_FechaFin.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker2Hist_Contable_FechaFin.TabIndex = 1;
            // 
            // panel1Hist_Contable
            // 
            this.panel1Hist_Contable.Controls.Add(this.button1Hist_Contable_Ver);
            this.panel1Hist_Contable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1Hist_Contable.Location = new System.Drawing.Point(0, 84);
            this.panel1Hist_Contable.Margin = new System.Windows.Forms.Padding(0);
            this.panel1Hist_Contable.Name = "panel1Hist_Contable";
            this.panel1Hist_Contable.Size = new System.Drawing.Size(786, 23);
            this.panel1Hist_Contable.TabIndex = 2;
            // 
            // button1Hist_Contable_Ver
            // 
            this.button1Hist_Contable_Ver.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1Hist_Contable_Ver.Location = new System.Drawing.Point(711, 0);
            this.button1Hist_Contable_Ver.Name = "button1Hist_Contable_Ver";
            this.button1Hist_Contable_Ver.Size = new System.Drawing.Size(75, 23);
            this.button1Hist_Contable_Ver.TabIndex = 0;
            this.button1Hist_Contable_Ver.Text = "Ver";
            this.button1Hist_Contable_Ver.UseVisualStyleBackColor = true;
            this.button1Hist_Contable_Ver.Click += new System.EventHandler(this.button1Hist_Contable_Ver_Click);
            // 
            // dataGridView1Hist_Contable
            // 
            this.dataGridView1Hist_Contable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1Hist_Contable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Hist_Contable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1Hist_Contable.Location = new System.Drawing.Point(3, 110);
            this.dataGridView1Hist_Contable.Name = "dataGridView1Hist_Contable";
            this.dataGridView1Hist_Contable.Size = new System.Drawing.Size(780, 282);
            this.dataGridView1Hist_Contable.TabIndex = 3;
            // 
            // panel2Hist_Contable
            // 
            this.panel2Hist_Contable.Controls.Add(this.cueTextBox1);
            this.panel2Hist_Contable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2Hist_Contable.Location = new System.Drawing.Point(3, 395);
            this.panel2Hist_Contable.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel2Hist_Contable.Name = "panel2Hist_Contable";
            this.panel2Hist_Contable.Size = new System.Drawing.Size(783, 23);
            this.panel2Hist_Contable.TabIndex = 4;
            // 
            // cueTextBox1
            // 
            this.cueTextBox1.CueText = "Total €";
            this.cueTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.cueTextBox1.Location = new System.Drawing.Point(0, 0);
            this.cueTextBox1.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.cueTextBox1.Name = "cueTextBox1";
            this.cueTextBox1.Size = new System.Drawing.Size(121, 20);
            this.cueTextBox1.TabIndex = 0;
            // 
            // tabPageHistFacturas
            // 
            this.tabPageHistFacturas.Controls.Add(this.tableLayoutPanel1Hist_Facturas);
            this.tabPageHistFacturas.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistFacturas.Name = "tabPageHistFacturas";
            this.tabPageHistFacturas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistFacturas.Size = new System.Drawing.Size(792, 424);
            this.tabPageHistFacturas.TabIndex = 1;
            this.tabPageHistFacturas.Text = "Historial Facturas";
            this.tabPageHistFacturas.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1Hist_Facturas
            // 
            this.tableLayoutPanel1Hist_Facturas.ColumnCount = 1;
            this.tableLayoutPanel1Hist_Facturas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1Hist_Facturas.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1Hist_Facturas.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1Hist_Facturas.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1Hist_Facturas.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1Hist_Facturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1Hist_Facturas.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1Hist_Facturas.Name = "tableLayoutPanel1Hist_Facturas";
            this.tableLayoutPanel1Hist_Facturas.RowCount = 4;
            this.tableLayoutPanel1Hist_Facturas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1Hist_Facturas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1Hist_Facturas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1Hist_Facturas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1Hist_Facturas.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel1Hist_Facturas.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cueTextBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 395);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 23);
            this.panel1.TabIndex = 5;
            // 
            // cueTextBox2
            // 
            this.cueTextBox2.CueText = "Total € sin I.V.A.";
            this.cueTextBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.cueTextBox2.Location = new System.Drawing.Point(0, 0);
            this.cueTextBox2.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.cueTextBox2.Name = "cueTextBox2";
            this.cueTextBox2.Size = new System.Drawing.Size(121, 20);
            this.cueTextBox2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 302);
            this.dataGridView1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cueComboBox1);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBox2);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBox3);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBox4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 26);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(780, 58);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // cueComboBox1
            // 
            this.cueComboBox1.CueText = "Matrícula";
            this.cueComboBox1.FormattingEnabled = true;
            this.cueComboBox1.Location = new System.Drawing.Point(3, 3);
            this.cueComboBox1.Name = "cueComboBox1";
            this.cueComboBox1.Size = new System.Drawing.Size(121, 21);
            this.cueComboBox1.TabIndex = 0;
            // 
            // cueComboBox2
            // 
            this.cueComboBox2.CueText = "Cliente";
            this.cueComboBox2.FormattingEnabled = true;
            this.cueComboBox2.Location = new System.Drawing.Point(130, 3);
            this.cueComboBox2.Name = "cueComboBox2";
            this.cueComboBox2.Size = new System.Drawing.Size(121, 21);
            this.cueComboBox2.TabIndex = 1;
            // 
            // cueComboBox3
            // 
            this.cueComboBox3.CueText = "Marca";
            this.cueComboBox3.FormattingEnabled = true;
            this.cueComboBox3.Location = new System.Drawing.Point(257, 3);
            this.cueComboBox3.Name = "cueComboBox3";
            this.cueComboBox3.Size = new System.Drawing.Size(121, 21);
            this.cueComboBox3.TabIndex = 2;
            // 
            // cueComboBox4
            // 
            this.cueComboBox4.CueText = "Modelo";
            this.cueComboBox4.FormattingEnabled = true;
            this.cueComboBox4.Location = new System.Drawing.Point(384, 3);
            this.cueComboBox4.Name = "cueComboBox4";
            this.cueComboBox4.Size = new System.Drawing.Size(121, 21);
            this.cueComboBox4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "HISTORIAL DE FACTURAS";
            // 
            // tabPageHistDeposito
            // 
            this.tabPageHistDeposito.Controls.Add(this.tableLayoutPanel1Hist_Depositos);
            this.tabPageHistDeposito.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistDeposito.Name = "tabPageHistDeposito";
            this.tabPageHistDeposito.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistDeposito.Size = new System.Drawing.Size(792, 424);
            this.tabPageHistDeposito.TabIndex = 2;
            this.tabPageHistDeposito.Text = "Historial Depósitos";
            this.tabPageHistDeposito.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1Hist_Depositos
            // 
            this.tableLayoutPanel1Hist_Depositos.ColumnCount = 1;
            this.tableLayoutPanel1Hist_Depositos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1Hist_Depositos.Controls.Add(this.dataGridView2, 0, 2);
            this.tableLayoutPanel1Hist_Depositos.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1Hist_Depositos.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1Hist_Depositos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1Hist_Depositos.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1Hist_Depositos.Name = "tableLayoutPanel1Hist_Depositos";
            this.tableLayoutPanel1Hist_Depositos.RowCount = 3;
            this.tableLayoutPanel1Hist_Depositos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1Hist_Depositos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1Hist_Depositos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1Hist_Depositos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1Hist_Depositos.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel1Hist_Depositos.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 90);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(780, 325);
            this.dataGridView2.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.cueComboBox5);
            this.flowLayoutPanel2.Controls.Add(this.cueComboBox6);
            this.flowLayoutPanel2.Controls.Add(this.cueComboBox7);
            this.flowLayoutPanel2.Controls.Add(this.cueComboBox8);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 26);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(780, 58);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // cueComboBox5
            // 
            this.cueComboBox5.CueText = "Matrícula";
            this.cueComboBox5.FormattingEnabled = true;
            this.cueComboBox5.Location = new System.Drawing.Point(3, 3);
            this.cueComboBox5.Name = "cueComboBox5";
            this.cueComboBox5.Size = new System.Drawing.Size(121, 21);
            this.cueComboBox5.TabIndex = 0;
            // 
            // cueComboBox6
            // 
            this.cueComboBox6.CueText = "Cliente";
            this.cueComboBox6.FormattingEnabled = true;
            this.cueComboBox6.Location = new System.Drawing.Point(130, 3);
            this.cueComboBox6.Name = "cueComboBox6";
            this.cueComboBox6.Size = new System.Drawing.Size(121, 21);
            this.cueComboBox6.TabIndex = 1;
            // 
            // cueComboBox7
            // 
            this.cueComboBox7.CueText = "Marca";
            this.cueComboBox7.FormattingEnabled = true;
            this.cueComboBox7.Location = new System.Drawing.Point(257, 3);
            this.cueComboBox7.Name = "cueComboBox7";
            this.cueComboBox7.Size = new System.Drawing.Size(121, 21);
            this.cueComboBox7.TabIndex = 2;
            // 
            // cueComboBox8
            // 
            this.cueComboBox8.CueText = "Modelo";
            this.cueComboBox8.FormattingEnabled = true;
            this.cueComboBox8.Location = new System.Drawing.Point(384, 3);
            this.cueComboBox8.Name = "cueComboBox8";
            this.cueComboBox8.Size = new System.Drawing.Size(121, 21);
            this.cueComboBox8.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(780, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "HISTORIAL DE DEPÓSITOS";
            // 
            // HistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1Historial);
            this.Name = "HistoryView";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.HistoryView_Load);
            this.tabControl1Historial.ResumeLayout(false);
            this.tabPageHistContable.ResumeLayout(false);
            this.tableHist_Contable.ResumeLayout(false);
            this.tableHist_Contable.PerformLayout();
            this.flowLayoutPanel1Hist_Contable.ResumeLayout(false);
            this.panel1Hist_Contable_FechaInicio.ResumeLayout(false);
            this.panel1Hist_Contable_FechaInicio.PerformLayout();
            this.panel2Hist_Contable_FechaFin.ResumeLayout(false);
            this.panel2Hist_Contable_FechaFin.PerformLayout();
            this.panel1Hist_Contable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Hist_Contable)).EndInit();
            this.panel2Hist_Contable.ResumeLayout(false);
            this.panel2Hist_Contable.PerformLayout();
            this.tabPageHistFacturas.ResumeLayout(false);
            this.tableLayoutPanel1Hist_Facturas.ResumeLayout(false);
            this.tableLayoutPanel1Hist_Facturas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPageHistDeposito.ResumeLayout(false);
            this.tableLayoutPanel1Hist_Depositos.ResumeLayout(false);
            this.tableLayoutPanel1Hist_Depositos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1Historial;
        private System.Windows.Forms.TabPage tabPageHistContable;
        private System.Windows.Forms.TabPage tabPageHistFacturas;
        private System.Windows.Forms.TabPage tabPageHistDeposito;
        private System.Windows.Forms.TableLayoutPanel tableHist_Contable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1Hist_Facturas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1Hist_Depositos;
        private System.Windows.Forms.Label label1Hist_Contable_Titulo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1Hist_Contable;
        private System.Windows.Forms.Panel panel1Hist_Contable_FechaInicio;
        private System.Windows.Forms.Label label2Hist_Contable_FechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1Hist_Contable_FechaInicio;
        private System.Windows.Forms.Panel panel2Hist_Contable_FechaFin;
        private System.Windows.Forms.Label label3Hist_Contable_FechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePicker2Hist_Contable_FechaFin;
        private System.Windows.Forms.Panel panel1Hist_Contable;
        private System.Windows.Forms.Button button1Hist_Contable_Ver;
        private System.Windows.Forms.DataGridView dataGridView1Hist_Contable;
        private System.Windows.Forms.Panel panel2Hist_Contable;
        private Views.CueTextBox cueTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private Views.CueComboBox cueComboBox1;
        private Views.CueComboBox cueComboBox2;
        private Views.CueComboBox cueComboBox3;
        private Views.CueComboBox cueComboBox4;
        private System.Windows.Forms.Panel panel1;
        private Views.CueTextBox cueTextBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Views.CueComboBox cueComboBox5;
        private Views.CueComboBox cueComboBox6;
        private Views.CueComboBox cueComboBox7;
        private Views.CueComboBox cueComboBox8;
        private System.Windows.Forms.Label label2;
    }
}