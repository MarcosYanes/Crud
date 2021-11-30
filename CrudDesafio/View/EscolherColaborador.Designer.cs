
namespace CrudDesafio.View
{
    partial class EscolherColaborador
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
            this.btnAdicionarColaborador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridColaborador)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColaborador
            // 
            this.gridColaborador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridColaborador.Location = new System.Drawing.Point(63, 78);
            this.gridColaborador.Name = "gridColaborador";
            this.gridColaborador.ReadOnly = true;
            this.gridColaborador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridColaborador.Size = new System.Drawing.Size(673, 257);
            this.gridColaborador.TabIndex = 0;
            // 
            // btnAdicionarColaborador
            // 
            this.btnAdicionarColaborador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(162)))), ((int)(((byte)(230)))));
            this.btnAdicionarColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarColaborador.Location = new System.Drawing.Point(358, 377);
            this.btnAdicionarColaborador.Name = "btnAdicionarColaborador";
            this.btnAdicionarColaborador.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarColaborador.TabIndex = 1;
            this.btnAdicionarColaborador.Text = "Adicionar";
            this.btnAdicionarColaborador.UseVisualStyleBackColor = false;
            this.btnAdicionarColaborador.Click += new System.EventHandler(this.btnAdicionarColaborador_Click);
            // 
            // EscolherColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdicionarColaborador);
            this.Controls.Add(this.gridColaborador);
            this.Name = "EscolherColaborador";
            this.Text = "EscolherColaborador";
            this.Load += new System.EventHandler(this.EscolherColaborador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridColaborador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridColaborador;
        private System.Windows.Forms.Button btnAdicionarColaborador;
    }
}