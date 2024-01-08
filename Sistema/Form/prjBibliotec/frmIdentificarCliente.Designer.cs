namespace prjListaLivros
{
    partial class frmIdentificarCliente
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblCliente = new System.Windows.Forms.DataGridView();
            this.RM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ic_valido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.tblEmprestimoAtual = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevolucaoEstimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cd_exemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcbUsuarioBloqueado = new System.Windows.Forms.PictureBox();
            this.pcbImgUsuario = new System.Windows.Forms.PictureBox();
            this.btnIdentificar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblRm = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmprestimoAtual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuarioBloqueado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(229, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 22);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(11, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(212, 20);
            this.txtPesquisa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RM / Nome";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(-21, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(874, 3);
            this.label4.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-39, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Foto:";
            // 
            // tblCliente
            // 
            this.tblCliente.AllowUserToAddRows = false;
            this.tblCliente.AllowUserToDeleteRows = false;
            this.tblCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RM,
            this.Nome,
            this.Tipo,
            this.Status,
            this.ic_valido});
            this.tblCliente.Location = new System.Drawing.Point(11, 58);
            this.tblCliente.Name = "tblCliente";
            this.tblCliente.ReadOnly = true;
            this.tblCliente.Size = new System.Drawing.Size(574, 150);
            this.tblCliente.TabIndex = 2;
            this.tblCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblCliente_CellClick);
            // 
            // RM
            // 
            this.RM.HeaderText = "RM";
            this.RM.Name = "RM";
            this.RM.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ic_valido
            // 
            this.ic_valido.HeaderText = "ic_valido";
            this.ic_valido.Name = "ic_valido";
            this.ic_valido.ReadOnly = true;
            this.ic_valido.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Empréstimo Atual:";
            // 
            // tblEmprestimoAtual
            // 
            this.tblEmprestimoAtual.AllowUserToAddRows = false;
            this.tblEmprestimoAtual.AllowUserToDeleteRows = false;
            this.tblEmprestimoAtual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEmprestimoAtual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.DevolucaoEstimada,
            this.Column1,
            this.cd_exemplar,
            this.cd_livro,
            this.dt_emprestimo});
            this.tblEmprestimoAtual.Location = new System.Drawing.Point(11, 277);
            this.tblEmprestimoAtual.Name = "tblEmprestimoAtual";
            this.tblEmprestimoAtual.ReadOnly = true;
            this.tblEmprestimoAtual.Size = new System.Drawing.Size(739, 104);
            this.tblEmprestimoAtual.TabIndex = 3;
            this.tblEmprestimoAtual.TabStop = false;
            this.tblEmprestimoAtual.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblEmprestimoAtual_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 57;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Título";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Exemplar";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // DevolucaoEstimada
            // 
            this.DevolucaoEstimada.HeaderText = "Devolução Estimada";
            this.DevolucaoEstimada.Name = "DevolucaoEstimada";
            this.DevolucaoEstimada.ReadOnly = true;
            this.DevolucaoEstimada.Width = 130;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // cd_exemplar
            // 
            this.cd_exemplar.HeaderText = "cd_exemplar";
            this.cd_exemplar.Name = "cd_exemplar";
            this.cd_exemplar.ReadOnly = true;
            this.cd_exemplar.Visible = false;
            // 
            // cd_livro
            // 
            this.cd_livro.HeaderText = "cd_livro";
            this.cd_livro.Name = "cd_livro";
            this.cd_livro.ReadOnly = true;
            this.cd_livro.Visible = false;
            // 
            // dt_emprestimo
            // 
            this.dt_emprestimo.HeaderText = "dt_emprestimo";
            this.dt_emprestimo.Name = "dt_emprestimo";
            this.dt_emprestimo.ReadOnly = true;
            this.dt_emprestimo.Visible = false;
            // 
            // pcbUsuarioBloqueado
            // 
            this.pcbUsuarioBloqueado.BackgroundImage = global::prjListaLivros.Properties.Resources.block;
            this.pcbUsuarioBloqueado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbUsuarioBloqueado.Location = new System.Drawing.Point(707, 165);
            this.pcbUsuarioBloqueado.Name = "pcbUsuarioBloqueado";
            this.pcbUsuarioBloqueado.Size = new System.Drawing.Size(40, 40);
            this.pcbUsuarioBloqueado.TabIndex = 52;
            this.pcbUsuarioBloqueado.TabStop = false;
            this.pcbUsuarioBloqueado.Visible = false;
            // 
            // pcbImgUsuario
            // 
            this.pcbImgUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbImgUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbImgUsuario.Location = new System.Drawing.Point(601, 31);
            this.pcbImgUsuario.Name = "pcbImgUsuario";
            this.pcbImgUsuario.Size = new System.Drawing.Size(149, 177);
            this.pcbImgUsuario.TabIndex = 34;
            this.pcbImgUsuario.TabStop = false;
            // 
            // btnIdentificar
            // 
            this.btnIdentificar.Location = new System.Drawing.Point(11, 222);
            this.btnIdentificar.Name = "btnIdentificar";
            this.btnIdentificar.Size = new System.Drawing.Size(75, 23);
            this.btnIdentificar.TabIndex = 53;
            this.btnIdentificar.Text = "Identificar";
            this.btnIdentificar.UseVisualStyleBackColor = true;
            this.btnIdentificar.Click += new System.EventHandler(this.btnIdentificar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(120, 227);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 55;
            this.label15.Text = "RM";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(264, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Nome";
            // 
            // lblRm
            // 
            this.lblRm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRm.Location = new System.Drawing.Point(152, 223);
            this.lblRm.Name = "lblRm";
            this.lblRm.Size = new System.Drawing.Size(106, 20);
            this.lblRm.TabIndex = 56;
            this.lblRm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNome
            // 
            this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNome.Location = new System.Drawing.Point(309, 223);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(275, 20);
            this.lblNome.TabIndex = 57;
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmIdentificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 390);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblRm);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnIdentificar);
            this.Controls.Add(this.pcbUsuarioBloqueado);
            this.Controls.Add(this.tblEmprestimoAtual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcbImgUsuario);
            this.Controls.Add(this.tblCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmIdentificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identificar Usuário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIdentificarCliente_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tblCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmprestimoAtual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuarioBloqueado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImgUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbImgUsuario;
        private System.Windows.Forms.DataGridView tblCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView tblEmprestimoAtual;
        private System.Windows.Forms.PictureBox pcbUsuarioBloqueado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevolucaoEstimada;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_exemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_emprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ic_valido;
        private System.Windows.Forms.Button btnIdentificar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblRm;
        private System.Windows.Forms.Label lblNome;
    }
}