
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalBruto = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecoDeCusto = new System.Windows.Forms.TextBox();
            this.txtPrecoLiquido = new System.Windows.Forms.TextBox();
            this.txtLucro = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProcurarProduto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridRelatorioProdutos)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridRelatorioProdutos
            // 
            this.gridRelatorioProdutos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridRelatorioProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRelatorioProdutos.Location = new System.Drawing.Point(43, 111);
            this.gridRelatorioProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridRelatorioProdutos.Name = "gridRelatorioProdutos";
            this.gridRelatorioProdutos.ReadOnly = true;
            this.gridRelatorioProdutos.RowHeadersWidth = 51;
            this.gridRelatorioProdutos.RowTemplate.Height = 24;
            this.gridRelatorioProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRelatorioProdutos.Size = new System.Drawing.Size(973, 329);
            this.gridRelatorioProdutos.TabIndex = 0;
            // 
            // txtBuscarPorProduto
            // 
            this.txtBuscarPorProduto.Location = new System.Drawing.Point(91, 20);
            this.txtBuscarPorProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarPorProduto.Name = "txtBuscarPorProduto";
            this.txtBuscarPorProduto.Size = new System.Drawing.Size(196, 22);
            this.txtBuscarPorProduto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produto";
            // 
            // txtBuscaPorCliente
            // 
            this.txtBuscaPorCliente.Location = new System.Drawing.Point(91, 16);
            this.txtBuscaPorCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscaPorCliente.Multiline = true;
            this.txtBuscaPorCliente.Name = "txtBuscaPorCliente";
            this.txtBuscaPorCliente.Size = new System.Drawing.Size(196, 25);
            this.txtBuscaPorCliente.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cliente ";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(91, 15);
            this.dtpDataInicial.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(232, 22);
            this.dtpDataInicial.TabIndex = 6;
            this.dtpDataInicial.Value = new System.DateTime(2021, 12, 1, 0, 0, 0, 0);
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(91, 44);
            this.dtpDataFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(232, 22);
            this.dtpDataFinal.TabIndex = 7;
            // 
            // btnBuscarData
            // 
            this.btnBuscarData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(254)))), ((int)(((byte)(154)))));
            this.btnBuscarData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarData.Location = new System.Drawing.Point(133, 489);
            this.btnBuscarData.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarData.Name = "btnBuscarData";
            this.btnBuscarData.Size = new System.Drawing.Size(132, 42);
            this.btnBuscarData.TabIndex = 3;
            this.btnBuscarData.Text = "Filtrar";
            this.btnBuscarData.UseVisualStyleBackColor = false;
            this.btnBuscarData.Click += new System.EventHandler(this.btnBuscarPorProduto_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Inicial";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(156, 459);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ReadOnly = true;
            this.txtQuantidade.Size = new System.Drawing.Size(132, 22);
            this.txtQuantidade.TabIndex = 10;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(285, 16);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(39, 26);
            this.btnProcurar.TabIndex = 11;
            this.btnProcurar.Text = "🔍";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(8, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 460);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(341, 458);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total";
            // 
            // txtTotalBruto
            // 
            this.txtTotalBruto.Location = new System.Drawing.Point(476, 457);
            this.txtTotalBruto.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalBruto.Name = "txtTotalBruto";
            this.txtTotalBruto.ReadOnly = true;
            this.txtTotalBruto.Size = new System.Drawing.Size(132, 22);
            this.txtTotalBruto.TabIndex = 14;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(156, 491);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.ReadOnly = true;
            this.txtDesconto.Size = new System.Drawing.Size(132, 22);
            this.txtDesconto.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 491);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Desconto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(341, 495);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Preço Liquido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(665, 458);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Preço de Custo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(665, 498);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Lucro";
            // 
            // txtPrecoDeCusto
            // 
            this.txtPrecoDeCusto.Location = new System.Drawing.Point(813, 457);
            this.txtPrecoDeCusto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoDeCusto.Name = "txtPrecoDeCusto";
            this.txtPrecoDeCusto.ReadOnly = true;
            this.txtPrecoDeCusto.Size = new System.Drawing.Size(132, 22);
            this.txtPrecoDeCusto.TabIndex = 20;
            // 
            // txtPrecoLiquido
            // 
            this.txtPrecoLiquido.Location = new System.Drawing.Point(476, 491);
            this.txtPrecoLiquido.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoLiquido.Name = "txtPrecoLiquido";
            this.txtPrecoLiquido.ReadOnly = true;
            this.txtPrecoLiquido.Size = new System.Drawing.Size(132, 22);
            this.txtPrecoLiquido.TabIndex = 21;
            // 
            // txtLucro
            // 
            this.txtLucro.Location = new System.Drawing.Point(813, 494);
            this.txtLucro.Margin = new System.Windows.Forms.Padding(4);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.ReadOnly = true;
            this.txtLucro.Size = new System.Drawing.Size(132, 22);
            this.txtLucro.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnBuscarData);
            this.panel1.Location = new System.Drawing.Point(1023, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 565);
            this.panel1.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnProcurar);
            this.groupBox3.Controls.Add(this.txtBuscaPorCliente);
            this.groupBox3.Location = new System.Drawing.Point(25, 234);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(341, 59);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnProcurarProduto);
            this.groupBox2.Controls.Add(this.txtBuscarPorProduto);
            this.groupBox2.Location = new System.Drawing.Point(25, 162);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(341, 64);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // btnProcurarProduto
            // 
            this.btnProcurarProduto.Location = new System.Drawing.Point(285, 20);
            this.btnProcurarProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProcurarProduto.Name = "btnProcurarProduto";
            this.btnProcurarProduto.Size = new System.Drawing.Size(38, 22);
            this.btnProcurarProduto.TabIndex = 11;
            this.btnProcurarProduto.Text = "🔍";
            this.btnProcurarProduto.UseVisualStyleBackColor = true;
            this.btnProcurarProduto.Click += new System.EventHandler(this.btnProcurarProduto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDataFinal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDataInicial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(25, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(341, 82);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(148, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 36);
            this.label11.TabIndex = 8;
            this.label11.Text = "Filtros";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(365, 38);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(305, 36);
            this.label12.TabIndex = 24;
            this.label12.Text = "Relatório de Produtos";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(254)))), ((int)(((byte)(154)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Location = new System.Drawing.Point(43, 541);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(127, 30);
            this.btnExportar.TabIndex = 25;
            this.btnExportar.Text = "Exportar Excel";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.ExportarExcel_Click);
            // 
            // RelatorioProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1405, 583);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtLucro);
            this.Controls.Add(this.txtPrecoLiquido);
            this.Controls.Add(this.txtPrecoDeCusto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtTotalBruto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.gridRelatorioProdutos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RelatorioProdutos";
            this.Text = "RelatorioProdutos";
            this.Load += new System.EventHandler(this.RelatorioProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRelatorioProdutos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalBruto;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecoDeCusto;
        private System.Windows.Forms.TextBox txtPrecoLiquido;
        private System.Windows.Forms.TextBox txtLucro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProcurarProduto;
        private System.Windows.Forms.Button btnExportar;
        // private System.Windows.Forms.Button ExportarExcel;
    }
}