
namespace CrudDesafio.View
{
    partial class ConsultarPedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtIdColaborador = new System.Windows.Forms.TextBox();
            this.gridPedidos = new System.Windows.Forms.DataGridView();
            this.txtTotalLiquido = new System.Windows.Forms.TextBox();
            this.txtTotalDesconto = new System.Windows.Forms.TextBox();
            this.txtTotalBruto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdPedido = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtNomeColaborador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLucro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInativar = new System.Windows.Forms.Button();
            this.txtFormaPagamento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdCliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "IdColaborador";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(134, 53);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(24, 20);
            this.txtIdCliente.TabIndex = 1;
            // 
            // txtIdColaborador
            // 
            this.txtIdColaborador.Location = new System.Drawing.Point(134, 85);
            this.txtIdColaborador.Name = "txtIdColaborador";
            this.txtIdColaborador.ReadOnly = true;
            this.txtIdColaborador.Size = new System.Drawing.Size(100, 20);
            this.txtIdColaborador.TabIndex = 1;
            // 
            // gridPedidos
            // 
            this.gridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPedidos.Location = new System.Drawing.Point(32, 161);
            this.gridPedidos.Name = "gridPedidos";
            this.gridPedidos.RowHeadersWidth = 51;
            this.gridPedidos.Size = new System.Drawing.Size(442, 167);
            this.gridPedidos.TabIndex = 2;
            // 
            // txtTotalLiquido
            // 
            this.txtTotalLiquido.Location = new System.Drawing.Point(650, 240);
            this.txtTotalLiquido.Name = "txtTotalLiquido";
            this.txtTotalLiquido.ReadOnly = true;
            this.txtTotalLiquido.Size = new System.Drawing.Size(120, 20);
            this.txtTotalLiquido.TabIndex = 27;
            // 
            // txtTotalDesconto
            // 
            this.txtTotalDesconto.Location = new System.Drawing.Point(650, 215);
            this.txtTotalDesconto.Name = "txtTotalDesconto";
            this.txtTotalDesconto.ReadOnly = true;
            this.txtTotalDesconto.Size = new System.Drawing.Size(120, 20);
            this.txtTotalDesconto.TabIndex = 28;
            // 
            // txtTotalBruto
            // 
            this.txtTotalBruto.Location = new System.Drawing.Point(650, 191);
            this.txtTotalBruto.Name = "txtTotalBruto";
            this.txtTotalBruto.ReadOnly = true;
            this.txtTotalBruto.Size = new System.Drawing.Size(120, 20);
            this.txtTotalBruto.TabIndex = 29;
            this.txtTotalBruto.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(520, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Total Liquido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(520, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Total De Desconto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(520, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Total Bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(520, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "FormaPagamento";
            // 
            // IdPedido
            // 
            this.IdPedido.AutoSize = true;
            this.IdPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdPedido.Location = new System.Drawing.Point(31, 20);
            this.IdPedido.Name = "IdPedido";
            this.IdPedido.Size = new System.Drawing.Size(63, 17);
            this.IdPedido.TabIndex = 0;
            this.IdPedido.Text = "IdPedido";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Location = new System.Drawing.Point(134, 19);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.ReadOnly = true;
            this.txtIdPedido.Size = new System.Drawing.Size(24, 20);
            this.txtIdPedido.TabIndex = 1;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(162)))), ((int)(((byte)(230)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(32, 362);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 31);
            this.btnAlterar.TabIndex = 31;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(398, 53);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCliente.TabIndex = 32;
            // 
            // txtNomeColaborador
            // 
            this.txtNomeColaborador.Location = new System.Drawing.Point(398, 84);
            this.txtNomeColaborador.Name = "txtNomeColaborador";
            this.txtNomeColaborador.ReadOnly = true;
            this.txtNomeColaborador.Size = new System.Drawing.Size(100, 20);
            this.txtNomeColaborador.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nome Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(268, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nome Colaborador";
            // 
            // txtLucro
            // 
            this.txtLucro.Location = new System.Drawing.Point(650, 262);
            this.txtLucro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.ReadOnly = true;
            this.txtLucro.Size = new System.Drawing.Size(120, 20);
            this.txtLucro.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(520, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Lucro";
            // 
            // btnInativar
            // 
            this.btnInativar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnInativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInativar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInativar.Location = new System.Drawing.Point(146, 362);
            this.btnInativar.Name = "btnInativar";
            this.btnInativar.Size = new System.Drawing.Size(92, 30);
            this.btnInativar.TabIndex = 36;
            this.btnInativar.Text = "Inativar";
            this.btnInativar.UseVisualStyleBackColor = false;
            this.btnInativar.Click += new System.EventHandler(this.btnInativar_Click);
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.Location = new System.Drawing.Point(650, 161);
            this.txtFormaPagamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.ReadOnly = true;
            this.txtFormaPagamento.Size = new System.Drawing.Size(120, 20);
            this.txtFormaPagamento.TabIndex = 37;
            // 
            // ConsultarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFormaPagamento);
            this.Controls.Add(this.btnInativar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLucro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeColaborador);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtTotalLiquido);
            this.Controls.Add(this.txtTotalDesconto);
            this.Controls.Add(this.txtTotalBruto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridPedidos);
            this.Controls.Add(this.txtIdColaborador);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdPedido);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarPedido";
            this.Text = "ConsultarPedido";
            this.Load += new System.EventHandler(this.ConsultarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtIdColaborador;
        private System.Windows.Forms.DataGridView gridPedidos;
        private System.Windows.Forms.TextBox txtTotalLiquido;
        private System.Windows.Forms.TextBox txtTotalDesconto;
        private System.Windows.Forms.TextBox txtTotalBruto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IdPedido;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtNomeColaborador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLucro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInativar;
        private System.Windows.Forms.TextBox txtFormaPagamento;
    }
}