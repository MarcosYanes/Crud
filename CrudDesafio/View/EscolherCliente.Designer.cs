
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
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCliente
            // 
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCliente.Location = new System.Drawing.Point(63, 81);
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCliente.Size = new System.Drawing.Size(673, 236);
            this.gridCliente.TabIndex = 0;
            // 
            // txtAdicionar
            // 
            this.txtAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(162)))), ((int)(((byte)(230)))));
            this.txtAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtAdicionar.Location = new System.Drawing.Point(360, 364);
            this.txtAdicionar.Name = "txtAdicionar";
            this.txtAdicionar.Size = new System.Drawing.Size(75, 23);
            this.txtAdicionar.TabIndex = 1;
            this.txtAdicionar.Text = "Adicionar";
            this.txtAdicionar.UseVisualStyleBackColor = false;
            this.txtAdicionar.Click += new System.EventHandler(this.txtAdicionar_Click);
            // 
            // EscolherCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAdicionar);
            this.Controls.Add(this.gridCliente);
            this.Name = "EscolherCliente";
            this.Text = "EscolherCliente";
            this.Load += new System.EventHandler(this.EscolherCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCliente;
        private System.Windows.Forms.Button txtAdicionar;
    }
}