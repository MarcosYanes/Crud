
namespace CrudDesafio.View
{
    partial class RelatorioCliente
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
            this.gridRelatorioClientes = new System.Windows.Forms.DataGridView();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataInical = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarPorData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOrdenarPor = new System.Windows.Forms.ComboBox();
            this.cbCrescente = new System.Windows.Forms.ComboBox();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.Ordenar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaiorQue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridRelatorioClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridRelatorioClientes
            // 
            this.gridRelatorioClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRelatorioClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridRelatorioClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRelatorioClientes.Location = new System.Drawing.Point(18, 95);
            this.gridRelatorioClientes.Margin = new System.Windows.Forms.Padding(2);
            this.gridRelatorioClientes.Name = "gridRelatorioClientes";
            this.gridRelatorioClientes.ReadOnly = true;
            this.gridRelatorioClientes.RowHeadersWidth = 51;
            this.gridRelatorioClientes.RowTemplate.Height = 24;
            this.gridRelatorioClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRelatorioClientes.Size = new System.Drawing.Size(716, 332);
            this.gridRelatorioClientes.TabIndex = 0;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(89, 138);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(111, 20);
            this.txtBuscarCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(25, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome ";
            // 
            // dtpDataInical
            // 
            this.dtpDataInical.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInical.Location = new System.Drawing.Point(121, 72);
            this.dtpDataInical.Name = "dtpDataInical";
            this.dtpDataInical.Size = new System.Drawing.Size(79, 20);
            this.dtpDataInical.TabIndex = 4;
            this.dtpDataInical.Value = new System.DateTime(2021, 12, 1, 13, 37, 0, 0);
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(121, 98);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(79, 20);
            this.dtpDataFinal.TabIndex = 5;
            // 
            // btnBuscarPorData
            // 
            this.btnBuscarPorData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(254)))), ((int)(((byte)(154)))));
            this.btnBuscarPorData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPorData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarPorData.Location = new System.Drawing.Point(70, 335);
            this.btnBuscarPorData.Name = "btnBuscarPorData";
            this.btnBuscarPorData.Size = new System.Drawing.Size(97, 33);
            this.btnBuscarPorData.TabIndex = 3;
            this.btnBuscarPorData.Text = "Filtrar";
            this.btnBuscarPorData.UseVisualStyleBackColor = false;
            this.btnBuscarPorData.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data";
            // 
            // cbOrdenarPor
            // 
            this.cbOrdenarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrdenarPor.FormattingEnabled = true;
            this.cbOrdenarPor.Items.AddRange(new object[] {
            "Quantidade",
            "Total Bruto",
            "Total De Desconto",
            "Total Liquido"});
            this.cbOrdenarPor.Location = new System.Drawing.Point(89, 179);
            this.cbOrdenarPor.Name = "cbOrdenarPor";
            this.cbOrdenarPor.Size = new System.Drawing.Size(111, 21);
            this.cbOrdenarPor.TabIndex = 7;
            // 
            // cbCrescente
            // 
            this.cbCrescente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCrescente.FormattingEnabled = true;
            this.cbCrescente.Items.AddRange(new object[] {
            "Crescente",
            "Decrescente"});
            this.cbCrescente.Location = new System.Drawing.Point(89, 208);
            this.cbCrescente.Name = "cbCrescente";
            this.cbCrescente.Size = new System.Drawing.Size(111, 21);
            this.cbCrescente.TabIndex = 8;
            // 
            // txtTop
            // 
            this.txtTop.Location = new System.Drawing.Point(89, 281);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(111, 20);
            this.txtTop.TabIndex = 9;
            // 
            // Ordenar
            // 
            this.Ordenar.AutoSize = true;
            this.Ordenar.ForeColor = System.Drawing.SystemColors.Control;
            this.Ordenar.Location = new System.Drawing.Point(27, 179);
            this.Ordenar.Name = "Ordenar";
            this.Ordenar.Size = new System.Drawing.Size(45, 13);
            this.Ordenar.TabIndex = 10;
            this.Ordenar.Text = "Ordenar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(25, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Top";
            // 
            // txtMaiorQue
            // 
            this.txtMaiorQue.Location = new System.Drawing.Point(89, 255);
            this.txtMaiorQue.Name = "txtMaiorQue";
            this.txtMaiorQue.Size = new System.Drawing.Size(111, 20);
            this.txtMaiorQue.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(27, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Maior Que";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(81, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Inicial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(86, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Final";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(266, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Relatório de Clientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.txtBuscarCliente);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMaiorQue);
            this.panel1.Controls.Add(this.btnBuscarPorData);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpDataInical);
            this.panel1.Controls.Add(this.Ordenar);
            this.panel1.Controls.Add(this.dtpDataFinal);
            this.panel1.Controls.Add(this.txtTop);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbCrescente);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbOrdenarPor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(750, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 450);
            this.panel1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(84, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Filtros";
            // 
            // RelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gridRelatorioClientes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RelatorioCliente";
            this.Text = "RelatorioCliente";
            this.Load += new System.EventHandler(this.RelatorioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRelatorioClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridRelatorioClientes;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataInical;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Button btnBuscarPorData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOrdenarPor;
        private System.Windows.Forms.ComboBox cbCrescente;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.Label Ordenar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaiorQue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}