
namespace CrudDesafio.View
{
    partial class ListarCliente
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
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimparFiltro = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridClientes
            // 
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Location = new System.Drawing.Point(185, 213);
            this.gridClientes.Margin = new System.Windows.Forms.Padding(2);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.RowHeadersWidth = 51;
            this.gridClientes.RowTemplate.Height = 24;
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Size = new System.Drawing.Size(565, 283);
            this.gridClientes.TabIndex = 0;
            this.gridClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Clientes";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(353, 119);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(105, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(469, 113);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 27);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFiltro.Location = new System.Drawing.Point(575, 113);
            this.btnLimparFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(118, 27);
            this.btnLimparFiltro.TabIndex = 4;
            this.btnLimparFiltro.Text = "Limpar Filtro";
            this.btnLimparFiltro.UseVisualStyleBackColor = true;
            this.btnLimparFiltro.Click += new System.EventHandler(this.btnLimparFiltro_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(416, 176);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 32);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // ListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 666);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnLimparFiltro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridClientes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListarCliente";
            this.Text = "ListarCliente";
            this.Load += new System.EventHandler(this.ListarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimparFiltro;
        private System.Windows.Forms.Button btnAtualizar;
    }
}