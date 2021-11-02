
namespace Gestaller
{
    partial class OrdersView
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1SearchBudget = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cueComboBoxNombre = new Gestaller.Views.CueComboBox();
            this.cueComboBoxMatricula = new Gestaller.Views.CueComboBox();
            this.cueComboBoxMarca = new Gestaller.Views.CueComboBox();
            this.cueComboBoxModelo = new Gestaller.Views.CueComboBox();
            this.cueTextBoxKMS = new Gestaller.Views.CueTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Presupuesto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Proforma";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Factura";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.label1.Text = "CLIENTE";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1SearchBudget);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 23);
            this.panel1.TabIndex = 1;
            // 
            // button1SearchBudget
            // 
            this.button1SearchBudget.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1SearchBudget.Location = new System.Drawing.Point(711, 0);
            this.button1SearchBudget.Name = "button1SearchBudget";
            this.button1SearchBudget.Size = new System.Drawing.Size(75, 23);
            this.button1SearchBudget.TabIndex = 0;
            this.button1SearchBudget.Text = "Buscar";
            this.button1SearchBudget.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.cueComboBoxNombre);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBoxMatricula);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBoxMarca);
            this.flowLayoutPanel1.Controls.Add(this.cueComboBoxModelo);
            this.flowLayoutPanel1.Controls.Add(this.cueTextBoxKMS);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(780, 74);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(780, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRESUPUESTO";
            // 
            // cueComboBoxNombre
            // 
            this.cueComboBoxNombre.CueText = "Cliente";
            this.cueComboBoxNombre.FormattingEnabled = true;
            this.cueComboBoxNombre.Location = new System.Drawing.Point(3, 3);
            this.cueComboBoxNombre.Name = "cueComboBoxNombre";
            this.cueComboBoxNombre.Size = new System.Drawing.Size(248, 21);
            this.cueComboBoxNombre.TabIndex = 4;
            // 
            // cueComboBoxMatricula
            // 
            this.cueComboBoxMatricula.CueText = "Matrícula";
            this.cueComboBoxMatricula.FormattingEnabled = true;
            this.cueComboBoxMatricula.Location = new System.Drawing.Point(257, 3);
            this.cueComboBoxMatricula.Name = "cueComboBoxMatricula";
            this.cueComboBoxMatricula.Size = new System.Drawing.Size(121, 21);
            this.cueComboBoxMatricula.TabIndex = 6;
            // 
            // cueComboBoxMarca
            // 
            this.cueComboBoxMarca.CueText = "Marca";
            this.cueComboBoxMarca.FormattingEnabled = true;
            this.cueComboBoxMarca.Location = new System.Drawing.Point(384, 3);
            this.cueComboBoxMarca.Name = "cueComboBoxMarca";
            this.cueComboBoxMarca.Size = new System.Drawing.Size(121, 21);
            this.cueComboBoxMarca.TabIndex = 8;
            // 
            // cueComboBoxModelo
            // 
            this.cueComboBoxModelo.CueText = "Modelo";
            this.cueComboBoxModelo.FormattingEnabled = true;
            this.cueComboBoxModelo.Location = new System.Drawing.Point(511, 3);
            this.cueComboBoxModelo.Name = "cueComboBoxModelo";
            this.cueComboBoxModelo.Size = new System.Drawing.Size(248, 21);
            this.cueComboBoxModelo.TabIndex = 9;
            // 
            // cueTextBoxKMS
            // 
            this.cueTextBoxKMS.CueText = "Kmts.";
            this.cueTextBoxKMS.Location = new System.Drawing.Point(3, 30);
            this.cueTextBoxKMS.Name = "cueTextBoxKMS";
            this.cueTextBoxKMS.Size = new System.Drawing.Size(121, 20);
            this.cueTextBoxKMS.TabIndex = 7;
            // 
            // OrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "OrdersView";
            this.Text = "Ordenes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1SearchBudget;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private Views.CueComboBox cueComboBoxNombre;
        private Views.CueComboBox cueComboBoxMatricula;
        private Views.CueComboBox cueComboBoxMarca;
        private Views.CueComboBox cueComboBoxModelo;
        private Views.CueTextBox cueTextBoxKMS;
    }
}