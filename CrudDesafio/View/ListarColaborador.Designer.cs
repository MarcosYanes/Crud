
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
            ((System.ComponentModel.ISupportInitialize)(this.gridColaborador)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColaborador
            // 
            this.gridColaborador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridColaborador.Location = new System.Drawing.Point(12, 94);
            this.gridColaborador.Name = "gridColaborador";
            this.gridColaborador.RowHeadersWidth = 51;
            this.gridColaborador.RowTemplate.Height = 24;
            this.gridColaborador.Size = new System.Drawing.Size(1169, 584);
            this.gridColaborador.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lista de Colaboradores";
            // 
            // ListarColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 820);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridColaborador);
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
    }
}