using prjListaLivros.logica;
using prjListaLivros.modelo;
using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace prjListaLivros
{
    public partial class frmListarLivros : Form
    {
        private Livro livroSelecionado = null;
        private Exemplar exemplarSelecionado = null;

        internal frmListarLivros()
        {
            InitializeComponent();
            Dados.mochila = new Mochila();
            Dados.usuario = null;
        }

        private void LimparCampos()
        {
            lsbAutores.Items.Clear();
            lsbCategorias.Items.Clear();
            lsbExemplares.Items.Clear();
            lblAnoEdicao.Text = "";
            lblEditora.Text = "";
            lblISBN.Text = "";
            lblSinopse.Text = "";
            lblTitulo.Text = "";
            livroSelecionado = null;
            exemplarSelecionado = null;
            pcbImgLivro.BackgroundImage = null;
            btnExibirLocalizacao.Enabled = false;
            btnAdicionar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tblResultado.Rows.Clear();
            LimparCampos();

            if (txtFiltro.Text != "")
            {
                LivroLogica livroLogica = new LivroLogica();
                ExemplarLogica exemplarLogica = new ExemplarLogica();
                Exemplar exemplar = exemplarLogica.BuscarPorRfid(txtFiltro.Text);
                if (exemplar != null)
                {
                    Livro livro = livroLogica.Buscar(exemplar.CodigoLivro);
                    tblResultado.Rows.Add(livro.Codigo, livro.ISBN, livro.Titulo, livro.Editora.Nome, livro.Ano);
                    preencherLivro(0);
                    for (int i = 0; i < lsbExemplares.Items.Count; i++)
                    {
                        if (lsbExemplares.Items[i].ToString() == exemplar.Codigo.ToString())
                        {
                            lsbExemplares.SelectedIndex = i;
                        }
                    }
                    return;
                }

                List<Livro> livros = livroLogica.Listar(txtFiltro.Text);
                for (int i = 0; i < livros.Count; i++)
                {
                    tblResultado.Rows.Add(livros[i].Codigo, livros[i].ISBN, livros[i].Titulo, livros[i].Editora.Nome, livros[i].Ano);
                }
                if (livros.Count == 1)
                {
                    preencherLivro(0);
                }
                txtFiltro.Clear();
                return;
            }
            MessageBox.Show("Digite um lívro (Nome / ISBN / Código do lívro)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tblResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            preencherLivro(e.RowIndex);
        }

        private void preencherLivro(int index)
        {
            LimparCampos();
            if (index != -1)
            {
                int CodigoLivro = int.Parse(tblResultado.Rows[index].Cells["cd_livro"].Value.ToString());
                LivroLogica livroLogica = new LivroLogica();
                livroSelecionado = livroLogica.Buscar(CodigoLivro);
                lblTitulo.Text = livroSelecionado.Titulo;
                lblISBN.Text = livroSelecionado.ISBN;
                lblEditora.Text = livroSelecionado.Editora.Nome;
                lblAnoEdicao.Text = livroSelecionado.Ano.ToString();
                lblSinopse.Text = livroSelecionado.Sinopse;
                pcbImgLivro.Image = null;
                foreach (Exemplar exemplar in livroSelecionado.Exemplares)
                    if (!exemplar.Emprestado)
                        lsbExemplares.Items.Add(exemplar.Codigo);
                foreach (Autor autor in livroSelecionado.Autores)
                    lsbAutores.Items.Add(autor.Nome);
                foreach (Categoria categoria in livroSelecionado.Categorias)
                    lsbCategorias.Items.Add(categoria.Nome);
                btnAdicionar.Enabled = true;


                if (!String.IsNullOrEmpty(livroSelecionado.Capa))
                {
                    byte[] bytes = Convert.FromBase64String(livroSelecionado.Capa);
                    using (var ms = new MemoryStream(bytes, 0, bytes.Length))
                    {
                        pcbImgLivro.BackgroundImage = Image.FromStream(ms, true);
                    }
                }
            }
        }

        private void lsbExemplares_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbExemplares.SelectedIndex != -1)
            {
                ExemplarLogica exemplarLogica = new ExemplarLogica();
                exemplarSelecionado = exemplarLogica.BuscarPorCodigo(int.Parse(lsbExemplares.Items[lsbExemplares.SelectedIndex].ToString()));
                btnExibirLocalizacao.Enabled = true;
            }
        }

        private void btnExibirLocalizacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show(exemplarSelecionado.Localizacao.Local, "Localização do Lívro");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (Dados.usuario == null)
            {
                frmIdentificarCliente frmIdentificarCliente = new frmIdentificarCliente(this);
                frmIdentificarCliente.ShowDialog();
            }
            if (Dados.usuario == null)
            {
                return;
            }
            if (Dados.usuario.Bloqueado)
            {
                return;
            }
            try
            {
                Dados.mochila.adicionar(livroSelecionado, exemplarSelecionado);
                lblQuantidadeLivros.Text = Dados.mochila.quantidade.ToString();
                LimparCampos();
                tblResultado.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnMochila_Click(object sender, EventArgs e)
        {
            frmMochila frmMochila = new frmMochila();
            frmMochila.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            var form = new frmIdentificarCliente(this);
            form.ShowDialog();
        }

        public void exibirNomeRm()
        {
            lblQuantidadeLivros.Text = Dados.mochila.quantidade.ToString();
            if (Dados.usuario == null || Dados.usuario.Login == null)
            {
                btnUsuario.BackgroundImage = Properties.Resources.usuario_buscar;
                lblRmCliente.Text = "-";
                lblNomeCliente.Text = "-";
            }
            else
            {
                lblRmCliente.Text = Dados.usuario.Login;
                lblNomeCliente.Text = Dados.usuario.Nome.Split(' ')[0];

                if (Dados.usuario.Bloqueado)
                {
                    btnUsuario.BackgroundImage = Properties.Resources.usuario_bloqueado;
                    btnMochila.Enabled = false;
                    btnAdicionar.Enabled = false;
                }
                else
                {
                    btnUsuario.BackgroundImage = Properties.Resources.usuario_correto;
                    btnMochila.Enabled = true;
                    btnAdicionar.Enabled = true;
                }
            }
        }

        private void frmListarLivros_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dados.limpar();
        }

    }
}
