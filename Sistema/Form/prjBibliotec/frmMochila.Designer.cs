using System;

namespace prjListaLivros
{
    partial class frmMochila
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
            this.tblResultado = new System.Windows.Forms.DataGridView();
            this.cd_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fixo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnConcluirReserva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRm = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // tblResultado
            // 
            this.tblResultado.AllowUserToAddRows = false;
            this.tblResultado.AllowUserToDeleteRows = false;
            this.tblResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cd_livro,
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Fixo});
            this.tblResultado.Location = new System.Drawing.Point(12, 64);
            this.tblResultado.Name = "tblResultado";
            this.tblResultado.ReadOnly = true;
            this.tblResultado.Size = new System.Drawing.Size(776, 84);
            this.tblResultado.TabIndex = 0;
            this.tblResultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblResultado_CellClick);
            // 
            // cd_livro
            // 
            this.cd_livro.HeaderText = "cd_livro";
            this.cd_livro.Name = "cd_livro";
            this.cd_livro.ReadOnly = true;
            this.cd_livro.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ISBN";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Título";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Editora";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ano da Edição";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Exemplar";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Fixo
            // 
            this.Fixo.HeaderText = "Fixo";
            this.Fixo.Name = "Fixo";
            this.Fixo.ReadOnly = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Enabled = false;
            this.btnRemover.Location = new System.Drawing.Point(12, 154);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnConcluirReserva
            // 
            this.btnConcluirReserva.Location = new System.Drawing.Point(681, 154);
            this.btnConcluirReserva.Name = "btnConcluirReserva";
            this.btnConcluirReserva.Size = new System.Drawing.Size(107, 22);
            this.btnConcluirReserva.TabIndex = 3;
            this.btnConcluirReserva.Text = "Concluir Reserva";
            this.btnConcluirReserva.UseVisualStyleBackColor = true;
            this.btnConcluirReserva.Click += new System.EventHandler(this.btnConcluirReserva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            // 
            // lblNome
            // 
            this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNome.Location = new System.Drawing.Point(169, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(407, 20);
            this.lblNome.TabIndex = 10;
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTipoCliente.Location = new System.Drawing.Point(582, 28);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(204, 20);
            this.lblTipoCliente.TabIndex = 14;
            this.lblTipoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tipo do Cliente: ";
            // 
            // lblRm
            // 
            this.lblRm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRm.Location = new System.Drawing.Point(12, 28);
            this.lblRm.Name = "lblRm";
            this.lblRm.Size = new System.Drawing.Size(151, 20);
            this.lblRm.TabIndex = 16;
            this.lblRm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "RM: ";
            // 
            // frmMochila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 184);
            this.Controls.Add(this.lblRm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTipoCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConcluirReserva);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.tblResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMochila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mochila";
            this.Load += new System.EventHandler(this.frmMochila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblResultado;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnConcluirReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fixo;
    }
}