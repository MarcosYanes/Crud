
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
            this.gridCliente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCliente.Location = new System.Drawing.Point(84, 100);
            this.gridCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.ReadOnly = true;
            this.gridCliente.RowHeadersWidth = 51;
            this.gridCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCliente.Size = new System.Drawing.Size(897, 290);
            this.gridCliente.TabIndex = 0;
            // 
            // txtAdicionar
            // 
            this.txtAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtAdicionar.Location = new System.Drawing.Point(480, 448);
            this.txtAdicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdicionar.Name = "txtAdicionar";
            this.txtAdicionar.Size = new System.Drawing.Size(100, 28);
            this.txtAdicionar.TabIndex = 1;
            this.txtAdicionar.Text = "Adicionar";
            this.txtAdicionar.UseVisualStyleBackColor = false;
            this.txtAdicionar.Click += new System.EventHandler(this.txtAdicionar_Click);
            // 
            // EscolherCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtAdicionar);
            this.Controls.Add(this.gridCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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