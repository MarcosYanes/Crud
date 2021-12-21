
namespace CrudDesafio.View
{
    partial class EscolherCliente
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
            this.gridCliente = new System.Windows.Forms.DataGridView();
            this.txtAdicionar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCliente
            // 
            this.gridCliente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCliente.Location = new System.Drawing.Point(62, 122);
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.ReadOnly = true;
            this.gridCliente.RowHeadersWidth = 51;
            this.gridCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCliente.Size = new System.Drawing.Size(673, 236);
            this.gridCliente.TabIndex = 0;
            // 
            // txtAdicionar
            // 
            this.txtAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtAdicionar.Location = new System.Drawing.Point(360, 364);
            this.txtAdicionar.Name = "txtAdicionar";
            this.txtAdicionar.Size = new System.Drawing.Size(75, 23);
            this.txtAdicionar.TabIndex = 1;
            this.txtAdicionar.Text = "Adicionar";
            this.txtAdicionar.UseVisualStyleBackColor = false;
            this.txtAdicionar.Click += new System.EventHandler(this.txtAdicionar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(62, 86);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(162)))), ((int)(((byte)(230)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(168, 84);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // EscolherCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtAdicionar);
            this.Controls.Add(this.gridCliente);
            this.Name = "EscolherCliente";
            this.Text = "EscolherCliente";
            this.Load += new System.EventHandler(this.EscolherCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCliente;
        private System.Windows.Forms.Button txtAdicionar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}