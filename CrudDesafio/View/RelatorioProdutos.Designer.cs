
namespace CrudDesafio.View
{
    partial class RelatorioProdutos
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
            this.gridRelatorioProdutos = new System.Windows.Forms.DataGridView();
            this.txtBuscarPorProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarPorProduto = new System.Windows.Forms.Button();
            this.txtBuscaPorCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarPorCliente = new System.Windows.Forms.Button();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimparFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridRelatorioProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRelatorioProdutos
            // 
            this.gridRelatorioProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRelatorioProdutos.Location = new System.Drawing.Point(32, 197);
            this.gridRelatorioProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.gridRelatorioProdutos.Name = "gridRelatorioProdutos";
            this.gridRelatorioProdutos.RowHeadersWidth = 51;
            this.gridRelatorioProdutos.RowTemplate.Height = 24;
            this.gridRelatorioProdutos.Size = new System.Drawing.Size(736, 209);
            this.gridRelatorioProdutos.TabIndex = 0;
            this.gridRelatorioProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtBuscarPorProduto
            // 
            this.txtBuscarPorProduto.Location = new System.Drawing.Point(100, 18);
            this.txtBuscarPorProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarPorProduto.Name = "txtBuscarPorProduto";
            this.txtBuscarPorProduto.Size = new System.Drawing.Size(206, 20);
            this.txtBuscarPorProduto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produto";
            // 
            // btnBuscarPorProduto
            // 
            this.btnBuscarPorProduto.Location = new System.Drawing.Point(326, 15);
            this.btnBuscarPorProduto.Name = "btnBuscarPorProduto";
            this.btnBuscarPorProduto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorProduto.TabIndex = 3;
            this.btnBuscarPorProduto.Text = "Buscar";
            this.btnBuscarPorProduto.UseVisualStyleBackColor = true;
            this.btnBuscarPorProduto.Click += new System.EventHandler(this.btnBuscarPorProduto_Click_1);
            // 
            // txtBuscaPorCliente
            // 
            this.txtBuscaPorCliente.Location = new System.Drawing.Point(100, 64);
            this.txtBuscaPorCliente.Name = "txtBuscaPorCliente";
            this.txtBuscaPorCliente.Size = new System.Drawing.Size(206, 20);
            this.txtBuscaPorCliente.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cliente ";
            // 
            // txtBuscarPorCliente
            // 
            this.txtBuscarPorCliente.Location = new System.Drawing.Point(326, 62);
            this.txtBuscarPorCliente.Name = "txtBuscarPorCliente";
            this.txtBuscarPorCliente.Size = new System.Drawing.Size(75, 23);
            this.txtBuscarPorCliente.TabIndex = 3;
            this.txtBuscarPorCliente.Text = "Buscar";
            this.txtBuscarPorCliente.UseVisualStyleBackColor = true;
            this.txtBuscarPorCliente.Click += new System.EventHandler(this.btnBuscarPorProduto_Click_1);
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(100, 113);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(94, 20);
            this.dtpDataInicial.TabIndex = 6;
            this.dtpDataInicial.Value = new System.DateTime(2021, 12, 1, 0, 0, 0, 0);
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(212, 113);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(94, 20);
            this.dtpDataFinal.TabIndex = 7;
            // 
            // btnBuscarData
            // 
            this.btnBuscarData.Location = new System.Drawing.Point(326, 114);
            this.btnBuscarData.Name = "btnBuscarData";
            this.btnBuscarData.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarData.TabIndex = 3;
            this.btnBuscarData.Text = "Buscar";
            this.btnBuscarData.UseVisualStyleBackColor = true;
            this.btnBuscarData.Click += new System.EventHandler(this.btnBuscarPorProduto_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data";
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.Location = new System.Drawing.Point(355, 169);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(95, 23);
            this.btnLimparFiltro.TabIndex = 9;
            this.btnLimparFiltro.Text = "Limpar Filtros";
            this.btnLimparFiltro.UseVisualStyleBackColor = true;
            this.btnLimparFiltro.Click += new System.EventHandler(this.btnLimparFiltro_Click);
            // 
            // RelatorioProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimparFiltro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscaPorCliente);
            this.Controls.Add(this.btnBuscarData);
            this.Controls.Add(this.txtBuscarPorCliente);
            this.Controls.Add(this.btnBuscarPorProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarPorProduto);
            this.Controls.Add(this.gridRelatorioProdutos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RelatorioProdutos";
            this.Text = "RelatorioProdutos";
            this.Load += new System.EventHandler(this.RelatorioProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRelatorioProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridRelatorioProdutos;
        private System.Windows.Forms.TextBox txtBuscarPorProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarPorProduto;
        private System.Windows.Forms.TextBox txtBuscaPorCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtBuscarPorCliente;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Button btnBuscarData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimparFiltro;
    }
}