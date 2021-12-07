
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
            ((System.ComponentModel.ISupportInitialize)(this.gridRelatorioClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRelatorioClientes
            // 
            this.gridRelatorioClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRelatorioClientes.Location = new System.Drawing.Point(61, 159);
            this.gridRelatorioClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridRelatorioClientes.Name = "gridRelatorioClientes";
            this.gridRelatorioClientes.RowHeadersWidth = 51;
            this.gridRelatorioClientes.RowTemplate.Height = 24;
            this.gridRelatorioClientes.Size = new System.Drawing.Size(693, 267);
            this.gridRelatorioClientes.TabIndex = 0;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(72, 26);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(182, 20);
            this.txtBuscarCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome ";
            // 
            // dtpDataInical
            // 
            this.dtpDataInical.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInical.Location = new System.Drawing.Point(72, 71);
            this.dtpDataInical.Name = "dtpDataInical";
            this.dtpDataInical.Size = new System.Drawing.Size(82, 20);
            this.dtpDataInical.TabIndex = 4;
            this.dtpDataInical.Value = new System.DateTime(2021, 12, 1, 13, 37, 0, 0);
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(173, 71);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(82, 20);
            this.dtpDataFinal.TabIndex = 5;
            // 
            // btnBuscarPorData
            // 
            this.btnBuscarPorData.Location = new System.Drawing.Point(679, 26);
            this.btnBuscarPorData.Name = "btnBuscarPorData";
            this.btnBuscarPorData.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorData.TabIndex = 3;
            this.btnBuscarPorData.Text = "Buscar";
            this.btnBuscarPorData.UseVisualStyleBackColor = true;
            this.btnBuscarPorData.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data";
            // 
            // cbOrdenarPor
            // 
            this.cbOrdenarPor.FormattingEnabled = true;
            this.cbOrdenarPor.Items.AddRange(new object[] {
            "Quantidade",
            "Total Bruto",
            "Total De Desconto",
            "Total Liquido"});
            this.cbOrdenarPor.Location = new System.Drawing.Point(351, 26);
            this.cbOrdenarPor.Name = "cbOrdenarPor";
            this.cbOrdenarPor.Size = new System.Drawing.Size(121, 21);
            this.cbOrdenarPor.TabIndex = 7;
            // 
            // cbCrescente
            // 
            this.cbCrescente.FormattingEnabled = true;
            this.cbCrescente.Items.AddRange(new object[] {
            "Crescente",
            "Decrescente"});
            this.cbCrescente.Location = new System.Drawing.Point(493, 26);
            this.cbCrescente.Name = "cbCrescente";
            this.cbCrescente.Size = new System.Drawing.Size(121, 21);
            this.cbCrescente.TabIndex = 8;
            // 
            // txtTop
            // 
            this.txtTop.Location = new System.Drawing.Point(351, 75);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(121, 20);
            this.txtTop.TabIndex = 9;
            // 
            // Ordenar
            // 
            this.Ordenar.AutoSize = true;
            this.Ordenar.Location = new System.Drawing.Point(291, 29);
            this.Ordenar.Name = "Ordenar";
            this.Ordenar.Size = new System.Drawing.Size(45, 13);
            this.Ordenar.TabIndex = 10;
            this.Ordenar.Text = "Ordenar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Top";
            // 
            // RelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ordenar);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.cbCrescente);
            this.Controls.Add(this.cbOrdenarPor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpDataInical);
            this.Controls.Add(this.btnBuscarPorData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.gridRelatorioClientes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RelatorioCliente";
            this.Text = "RelatorioCliente";
            this.Load += new System.EventHandler(this.RelatorioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRelatorioClientes)).EndInit();
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
    }
}