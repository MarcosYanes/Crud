
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
            this.txtBuscaPorCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridRelatorioProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRelatorioProdutos
            // 
            this.gridRelatorioProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRelatorioProdutos.Location = new System.Drawing.Point(43, 129);
            this.gridRelatorioProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridRelatorioProdutos.Name = "gridRelatorioProdutos";
            this.gridRelatorioProdutos.RowHeadersWidth = 51;
            this.gridRelatorioProdutos.RowTemplate.Height = 24;
            this.gridRelatorioProdutos.Size = new System.Drawing.Size(974, 330);
            this.gridRelatorioProdutos.TabIndex = 0;
            this.gridRelatorioProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtBuscarPorProduto
            // 
            this.txtBuscarPorProduto.Location = new System.Drawing.Point(1138, 213);
            this.txtBuscarPorProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarPorProduto.Name = "txtBuscarPorProduto";
            this.txtBuscarPorProduto.Size = new System.Drawing.Size(170, 22);
            this.txtBuscarPorProduto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1044, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produto";
            // 
            // txtBuscaPorCliente
            // 
            this.txtBuscaPorCliente.Location = new System.Drawing.Point(1138, 270);
            this.txtBuscaPorCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscaPorCliente.Name = "txtBuscaPorCliente";
            this.txtBuscaPorCliente.Size = new System.Drawing.Size(170, 22);
            this.txtBuscaPorCliente.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1044, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cliente ";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(1138, 129);
            this.dtpDataInicial.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(170, 22);
            this.dtpDataInicial.TabIndex = 6;
            this.dtpDataInicial.Value = new System.DateTime(2021, 12, 1, 0, 0, 0, 0);
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(1138, 159);
            this.dtpDataFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(170, 22);
            this.dtpDataFinal.TabIndex = 7;
            // 
            // btnBuscarData
            // 
            this.btnBuscarData.Location = new System.Drawing.Point(1144, 404);
            this.btnBuscarData.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarData.Name = "btnBuscarData";
            this.btnBuscarData.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarData.TabIndex = 3;
            this.btnBuscarData.Text = "Filtrar";
            this.btnBuscarData.UseVisualStyleBackColor = true;
            this.btnBuscarData.Click += new System.EventHandler(this.btnBuscarPorProduto_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1044, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(43, 489);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(132, 22);
            this.txtQuantidade.TabIndex = 10;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(1327, 267);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(70, 28);
            this.btnProcurar.TabIndex = 11;
            this.btnProcurar.Text = "Buscar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1044, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data";
            // 
            // RelatorioProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 554);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscaPorCliente);
            this.Controls.Add(this.btnBuscarData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarPorProduto);
            this.Controls.Add(this.gridRelatorioProdutos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox txtBuscaPorCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Button btnBuscarData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label label4;
    }
}