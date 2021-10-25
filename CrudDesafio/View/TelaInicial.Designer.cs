﻿
namespace CrudDesafio.View
{
    partial class TelaInicial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.alterarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.colaboradorToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // colaboradorToolStripMenuItem
            // 
            this.colaboradorToolStripMenuItem.Name = "colaboradorToolStripMenuItem";
            this.colaboradorToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.colaboradorToolStripMenuItem.Text = "Colaborador";
            this.colaboradorToolStripMenuItem.Click += new System.EventHandler(this.colaboradorToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.colaboradorToolStripMenuItem1});
            this.listarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(72, 32);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(209, 32);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // colaboradorToolStripMenuItem1
            // 
            this.colaboradorToolStripMenuItem1.Name = "colaboradorToolStripMenuItem1";
            this.colaboradorToolStripMenuItem1.Size = new System.Drawing.Size(209, 32);
            this.colaboradorToolStripMenuItem1.Text = "Colaborador";
            this.colaboradorToolStripMenuItem1.Click += new System.EventHandler(this.colaboradorToolStripMenuItem1_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem2,
            this.colaboradorToolStripMenuItem2});
            this.alterarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(149, 32);
            this.alterarToolStripMenuItem.Text = "Alterar/Excluir";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem2
            // 
            this.clienteToolStripMenuItem2.Name = "clienteToolStripMenuItem2";
            this.clienteToolStripMenuItem2.Size = new System.Drawing.Size(209, 32);
            this.clienteToolStripMenuItem2.Text = "Cliente";
            this.clienteToolStripMenuItem2.Click += new System.EventHandler(this.clienteToolStripMenuItem2_Click);
            // 
            // colaboradorToolStripMenuItem2
            // 
            this.colaboradorToolStripMenuItem2.Name = "colaboradorToolStripMenuItem2";
            this.colaboradorToolStripMenuItem2.Size = new System.Drawing.Size(209, 32);
            this.colaboradorToolStripMenuItem2.Text = "Colaborador";
            this.colaboradorToolStripMenuItem2.Click += new System.EventHandler(this.colaboradorToolStripMenuItem2_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colaboradorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem colaboradorToolStripMenuItem2;
    }
}