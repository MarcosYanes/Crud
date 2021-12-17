
namespace CrudDesafio.View
{
    partial class EscolherProduto
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
            this.GridProduto = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // GridProduto
            // 
            this.GridProduto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProduto.Location = new System.Drawing.Point(56, 110);
            this.GridProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridProduto.Name = "GridProduto";
            this.GridProduto.ReadOnly = true;
            this.GridProduto.RowHeadersWidth = 51;
            this.GridProduto.RowTemplate.Height = 24;
            this.GridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProduto.Size = new System.Drawing.Size(764, 225);
            this.GridProduto.TabIndex = 0;
            this.GridProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProduto_CellDoubleClick);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(376, 372);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(96, 28);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // EscolherProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.GridProduto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EscolherProduto";
            this.Text = "EscolherProduto";
            this.Load += new System.EventHandler(this.EscolherProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridProduto;
        private System.Windows.Forms.Button btnAdicionar;
    }
}