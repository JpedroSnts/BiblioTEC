namespace prjListaLivros
{
    partial class frmListarLivros
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAnoEdicao = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lsbExemplares = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExibirLocalizacao = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lsbCategorias = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lsbAutores = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblQuantidadeLivros = new System.Windows.Forms.Label();
            this.lblSinopse = new System.Windows.Forms.Label();
            this.tblResultado = new System.Windows.Forms.DataGridView();
            this.cd_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnMochila = new System.Windows.Forms.Button();
            this.pcbImgLivro = new System.Windows.Forms.PictureBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblRmCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImgLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(12, 50);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(157, 20);
            this.txtFiltro.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(175, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome / ISBN / Código do lívro: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Foto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Título: ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Location = new System.Drawing.Point(262, 312);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(501, 20);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblISBN
            // 
            this.lblISBN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblISBN.Location = new System.Drawing.Point(262, 357);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(246, 20);
            this.lblISBN.TabIndex = 9;
            this.lblISBN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ISBN: ";
            // 
            // lblAnoEdicao
            // 
            this.lblAnoEdicao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnoEdicao.Location = new System.Drawing.Point(262, 402);
            this.lblAnoEdicao.Name = "lblAnoEdicao";
            this.lblAnoEdicao.Size = new System.Drawing.Size(120, 20);
            this.lblAnoEdicao.TabIndex = 13;
            this.lblAnoEdicao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ano da edição: ";
            // 
            // lblEditora
            // 
            this.lblEditora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEditora.Location = new System.Drawing.Point(517, 357);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(246, 20);
            this.lblEditora.TabIndex = 11;
            this.lblEditora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Editora: ";
            // 
            // lsbExemplares
            // 
            this.lsbExemplares.FormattingEnabled = true;
            this.lsbExemplares.Location = new System.Drawing.Point(769, 293);
            this.lsbExemplares.Name = "lsbExemplares";
            this.lsbExemplares.Size = new System.Drawing.Size(120, 264);
            this.lsbExemplares.TabIndex = 5;
            this.lsbExemplares.SelectedIndexChanged += new System.EventHandler(this.lsbExemplares_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(766, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Exemplares: ";
            // 
            // btnExibirLocalizacao
            // 
            this.btnExibirLocalizacao.Enabled = false;
            this.btnExibirLocalizacao.Location = new System.Drawing.Point(769, 561);
            this.btnExibirLocalizacao.Name = "btnExibirLocalizacao";
            this.btnExibirLocalizacao.Size = new System.Drawing.Size(120, 23);
            this.btnExibirLocalizacao.TabIndex = 6;
            this.btnExibirLocalizacao.Text = "Localização";
            this.btnExibirLocalizacao.UseVisualStyleBackColor = true;
            this.btnExibirLocalizacao.Click += new System.EventHandler(this.btnExibirLocalizacao_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(391, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Sinopse: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Categorias:";
            // 
            // lsbCategorias
            // 
            this.lsbCategorias.FormattingEnabled = true;
            this.lsbCategorias.Location = new System.Drawing.Point(262, 447);
            this.lsbCategorias.Name = "lsbCategorias";
            this.lsbCategorias.Size = new System.Drawing.Size(120, 56);
            this.lsbCategorias.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 509);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Autores:";
            // 
            // lsbAutores
            // 
            this.lsbAutores.FormattingEnabled = true;
            this.lsbAutores.Location = new System.Drawing.Point(262, 528);
            this.lsbAutores.Name = "lsbAutores";
            this.lsbAutores.Size = new System.Drawing.Size(120, 56);
            this.lsbAutores.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Location = new System.Drawing.Point(15, 589);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(238, 23);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar à mochila";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(-6, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(915, 3);
            this.label4.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(761, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Identificar: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(830, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Mochila: ";
            // 
            // lblQuantidadeLivros
            // 
            this.lblQuantidadeLivros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuantidadeLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeLivros.Location = new System.Drawing.Point(870, 67);
            this.lblQuantidadeLivros.Name = "lblQuantidadeLivros";
            this.lblQuantidadeLivros.Size = new System.Drawing.Size(21, 22);
            this.lblQuantidadeLivros.TabIndex = 29;
            this.lblQuantidadeLivros.Text = "0";
            this.lblQuantidadeLivros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSinopse
            // 
            this.lblSinopse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSinopse.Location = new System.Drawing.Point(394, 402);
            this.lblSinopse.Name = "lblSinopse";
            this.lblSinopse.Size = new System.Drawing.Size(369, 182);
            this.lblSinopse.TabIndex = 32;
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
            this.Column4});
            this.tblResultado.Location = new System.Drawing.Point(12, 103);
            this.tblResultado.Name = "tblResultado";
            this.tblResultado.ReadOnly = true;
            this.tblResultado.Size = new System.Drawing.Size(877, 150);
            this.tblResultado.TabIndex = 2;
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
            // btnUsuario
            // 
            this.btnUsuario.BackgroundImage = global::prjListaLivros.Properties.Resources.usuario_buscar;
            this.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUsuario.Location = new System.Drawing.Point(764, 29);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(60, 60);
            this.btnUsuario.TabIndex = 9;
            this.btnUsuario.TabStop = false;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnMochila
            // 
            this.btnMochila.BackgroundImage = global::prjListaLivros.Properties.Resources.mochila;
            this.btnMochila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMochila.Enabled = false;
            this.btnMochila.Location = new System.Drawing.Point(831, 29);
            this.btnMochila.Name = "btnMochila";
            this.btnMochila.Size = new System.Drawing.Size(60, 60);
            this.btnMochila.TabIndex = 10;
            this.btnMochila.TabStop = false;
            this.btnMochila.UseVisualStyleBackColor = true;
            this.btnMochila.Click += new System.EventHandler(this.btnMochila_Click);
            // 
            // pcbImgLivro
            // 
            this.pcbImgLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbImgLivro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbImgLivro.Location = new System.Drawing.Point(15, 293);
            this.pcbImgLivro.Name = "pcbImgLivro";
            this.pcbImgLivro.Size = new System.Drawing.Size(238, 291);
            this.pcbImgLivro.TabIndex = 4;
            this.pcbImgLivro.TabStop = false;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.Location = new System.Drawing.Point(609, 73);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(149, 13);
            this.lblNomeCliente.TabIndex = 33;
            this.lblNomeCliente.Text = "-";
            this.lblNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(719, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Nome";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(732, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "RM";
            // 
            // lblRmCliente
            // 
            this.lblRmCliente.Location = new System.Drawing.Point(609, 42);
            this.lblRmCliente.Name = "lblRmCliente";
            this.lblRmCliente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRmCliente.Size = new System.Drawing.Size(149, 13);
            this.lblRmCliente.TabIndex = 35;
            this.lblRmCliente.Text = "-";
            // 
            // frmListarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 624);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblRmCliente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblSinopse);
            this.Controls.Add(this.lblQuantidadeLivros);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnMochila);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lsbAutores);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lsbCategorias);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnExibirLocalizacao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lsbExemplares);
            this.Controls.Add(this.lblAnoEdicao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcbImgLivro);
            this.Controls.Add(this.tblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListarLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Lívros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListarLivros_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tblResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImgLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbImgLivro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAnoEdicao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lsbExemplares;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExibirLocalizacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lsbCategorias;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lsbAutores;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMochila;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblQuantidadeLivros;
        private System.Windows.Forms.Label lblSinopse;
        private System.Windows.Forms.DataGridView tblResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblRmCliente;
    }
}

