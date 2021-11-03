
namespace CrudDesafio.View
{
    partial class ListarColaborador
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
            this.gridColaborador = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimparFiltro = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridColaborador)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColaborador
            // 
            this.gridColaborador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridColaborador.Location = new System.Drawing.Point(75, 214);
            this.gridColaborador.Margin = new System.Windows.Forms.Padding(2);
            this.gridColaborador.Name = "gridColaborador";
            this.gridColaborador.ReadOnly = true;
            this.gridColaborador.RowHeadersWidth = 51;
            this.gridColaborador.RowTemplate.Height = 24;
            this.gridColaborador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridColaborador.Size = new System.Drawing.Size(742, 306);
            this.gridColaborador.TabIndex = 13;
            this.gridColaborador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridColaborador_CellContentClick);
            this.gridColaborador.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridColaborador_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lista de Colaboradores";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(364, 120);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(92, 20);
            this.txtBuscar.TabIndex = 15;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(470, 116);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(68, 26);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFiltro.Location = new System.Drawing.Point(555, 116);
            this.btnLimparFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(152, 26);
            this.btnLimparFiltro.TabIndex = 17;
            this.btnLimparFiltro.Text = "Limpar Filtro";
            this.btnLimparFiltro.UseVisualStyleBackColor = true;
            this.btnLimparFiltro.Click += new System.EventHandler(this.btnLimparFiltro_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(413, 177);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 32);
            this.btnAtualizar.TabIndex = 18;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // ListarColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 666);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnLimparFiltro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridColaborador);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListarColaborador";
            this.Text = "ListarColaborador";
            this.Load += new System.EventHandler(this.ListarColaborador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridColaborador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridColaborador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimparFiltro;
        private System.Windows.Forms.Button btnAtualizar;
    }
}