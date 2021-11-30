
namespace CrudDesafio.View
{
    partial class PedidoAlterar
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
            this.TotalBruto = new System.Windows.Forms.Label();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.txtDesconto = new System.Windows.Forms.NumericUpDown();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtTotalBrutoProduto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFormaPagamento = new System.Windows.Forms.ComboBox();
            this.txtTotalLiquido = new System.Windows.Forms.TextBox();
            this.txtTotalDesconto = new System.Windows.Forms.TextBox();
            this.txtTotalBruto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridCarrinho = new System.Windows.Forms.DataGridView();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtNomeColaborador = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdColaborador = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelecionarColaborador = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelecionarCliente = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalBruto
            // 
            this.TotalBruto.AutoSize = true;
            this.TotalBruto.Location = new System.Drawing.Point(48, 458);
            this.TotalBruto.Name = "TotalBruto";
            this.TotalBruto.Size = new System.Drawing.Size(59, 13);
            this.TotalBruto.TabIndex = 74;
            this.TotalBruto.Text = "Total Bruto";
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Location = new System.Drawing.Point(481, 419);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverProduto.TabIndex = 73;
            this.btnRemoverProduto.Text = "Remover";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(115, 425);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(120, 20);
            this.txtDesconto.TabIndex = 72;
            this.txtDesconto.ValueChanged += new System.EventHandler(this.txtDesconto_ValueChanged);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(116, 390);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(120, 20);
            this.txtQuantidade.TabIndex = 71;
            this.txtQuantidade.ValueChanged += new System.EventHandler(this.txtQuantidade_ValueChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(51, 525);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 70;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtTotalBrutoProduto
            // 
            this.txtTotalBrutoProduto.Location = new System.Drawing.Point(113, 455);
            this.txtTotalBrutoProduto.Name = "txtTotalBrutoProduto";
            this.txtTotalBrutoProduto.Size = new System.Drawing.Size(73, 20);
            this.txtTotalBrutoProduto.TabIndex = 68;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(85, 487);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(73, 20);
            this.txtTotal.TabIndex = 69;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(48, 491);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 67;
            this.label16.Text = "Total";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 427);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "Desconto";
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.FormattingEnabled = true;
            this.txtFormaPagamento.Items.AddRange(new object[] {
            "A vista",
            "Cartão de Crédito",
            "Cartão de Débito"});
            this.txtFormaPagamento.Location = new System.Drawing.Point(971, 253);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(97, 21);
            this.txtFormaPagamento.TabIndex = 65;
            // 
            // txtTotalLiquido
            // 
            this.txtTotalLiquido.Location = new System.Drawing.Point(968, 344);
            this.txtTotalLiquido.Name = "txtTotalLiquido";
            this.txtTotalLiquido.Size = new System.Drawing.Size(100, 20);
            this.txtTotalLiquido.TabIndex = 64;
            // 
            // txtTotalDesconto
            // 
            this.txtTotalDesconto.Location = new System.Drawing.Point(968, 311);
            this.txtTotalDesconto.Name = "txtTotalDesconto";
            this.txtTotalDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDesconto.TabIndex = 63;
            // 
            // txtTotalBruto
            // 
            this.txtTotalBruto.Location = new System.Drawing.Point(971, 281);
            this.txtTotalBruto.Name = "txtTotalBruto";
            this.txtTotalBruto.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBruto.TabIndex = 62;
            this.txtTotalBruto.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(872, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Total Liquido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(872, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Total De Desconto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(875, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Total Bruto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(875, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "FormaPagamento";
            // 
            // gridCarrinho
            // 
            this.gridCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarrinho.Location = new System.Drawing.Point(481, 253);
            this.gridCarrinho.Name = "gridCarrinho";
            this.gridCarrinho.ReadOnly = true;
            this.gridCarrinho.RowHeadersWidth = 51;
            this.gridCarrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCarrinho.Size = new System.Drawing.Size(359, 150);
            this.gridCarrinho.TabIndex = 57;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(89, 312);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(100, 20);
            this.txtNomeProduto.TabIndex = 56;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(136, 352);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(52, 20);
            this.txtPrecoVenda.TabIndex = 53;
            // 
            // txtNomeColaborador
            // 
            this.txtNomeColaborador.Location = new System.Drawing.Point(99, 90);
            this.txtNomeColaborador.Name = "txtNomeColaborador";
            this.txtNomeColaborador.Size = new System.Drawing.Size(100, 20);
            this.txtNomeColaborador.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(48, 392);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "Quantidade";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(89, 280);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(35, 20);
            this.txtIdProduto.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Nome";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "Preço de Venda";
            // 
            // txtIdColaborador
            // 
            this.txtIdColaborador.Location = new System.Drawing.Point(99, 59);
            this.txtIdColaborador.Name = "txtIdColaborador";
            this.txtIdColaborador.Size = new System.Drawing.Size(35, 20);
            this.txtIdColaborador.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Id";
            // 
            // btnSelecionarColaborador
            // 
            this.btnSelecionarColaborador.Location = new System.Drawing.Point(169, 23);
            this.btnSelecionarColaborador.Name = "btnSelecionarColaborador";
            this.btnSelecionarColaborador.Size = new System.Drawing.Size(56, 23);
            this.btnSelecionarColaborador.TabIndex = 45;
            this.btnSelecionarColaborador.Text = "Buscar";
            this.btnSelecionarColaborador.UseVisualStyleBackColor = true;
            this.btnSelecionarColaborador.Click += new System.EventHandler(this.BtnSelecionarColaborador_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "SelecionarColaborador";
            // 
            // btnSelecionarCliente
            // 
            this.btnSelecionarCliente.Location = new System.Drawing.Point(557, 24);
            this.btnSelecionarCliente.Name = "btnSelecionarCliente";
            this.btnSelecionarCliente.Size = new System.Drawing.Size(61, 23);
            this.btnSelecionarCliente.TabIndex = 43;
            this.btnSelecionarCliente.Text = "Buscar";
            this.btnSelecionarCliente.UseVisualStyleBackColor = true;
            this.btnSelecionarCliente.Click += new System.EventHandler(this.BtnSelecionarCliente_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(491, 88);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(87, 20);
            this.txtNomeCliente.TabIndex = 42;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(449, 91);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 41;
            this.Nome.Text = "Nome";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(491, 57);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(31, 20);
            this.txtIdCliente.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Id";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(144, 253);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 21);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Selecionar Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Escolher Produto";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(915, 507);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 75;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // PedidoAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 566);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.TotalBruto);
            this.Controls.Add(this.btnRemoverProduto);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtTotalBrutoProduto);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtFormaPagamento);
            this.Controls.Add(this.txtTotalLiquido);
            this.Controls.Add(this.txtTotalDesconto);
            this.Controls.Add(this.txtTotalBruto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridCarrinho);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.txtNomeColaborador);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtIdColaborador);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSelecionarColaborador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSelecionarCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "PedidoAlterar";
            this.Text = "PedidoAlterar";
            this.Load += new System.EventHandler(this.PedidoAlterar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TotalBruto;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.NumericUpDown txtDesconto;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtTotalBrutoProduto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox txtFormaPagamento;
        private System.Windows.Forms.TextBox txtTotalLiquido;
        private System.Windows.Forms.TextBox txtTotalDesconto;
        private System.Windows.Forms.TextBox txtTotalBruto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridCarrinho;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.TextBox txtNomeColaborador;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIdColaborador;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelecionarColaborador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelecionarCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterar;
    }
}