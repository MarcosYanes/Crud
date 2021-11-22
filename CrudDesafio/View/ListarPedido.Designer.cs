
namespace CrudDesafio.View
{
    partial class ListarPedido
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
            this.gridPedidos = new System.Windows.Forms.DataGridView();
            this.txtConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPedidos
            // 
            this.gridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPedidos.Location = new System.Drawing.Point(119, 89);
            this.gridPedidos.Name = "gridPedidos";
            this.gridPedidos.ReadOnly = true;
            this.gridPedidos.RowHeadersWidth = 51;
            this.gridPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPedidos.Size = new System.Drawing.Size(546, 280);
            this.gridPedidos.TabIndex = 0;
            this.gridPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPedidos_CellDoubleClick);
            // 
            // txtConsultar
            // 
            this.txtConsultar.Location = new System.Drawing.Point(349, 393);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(75, 23);
            this.txtConsultar.TabIndex = 1;
            this.txtConsultar.Text = "Consultar";
            this.txtConsultar.UseVisualStyleBackColor = true;
            this.txtConsultar.Click += new System.EventHandler(this.txtConsultar_Click);
            // 
            // ListarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.gridPedidos);
            this.Name = "ListarPedido";
            this.Text = "ListarPedido";
            this.Load += new System.EventHandler(this.ListarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPedidos;
        private System.Windows.Forms.Button txtConsultar;
    }
}