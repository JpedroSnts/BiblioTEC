using prjListaLivros.logica;
using prjListaLivros.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjListaLivros
{
    public partial class frmMochila : Form
    {
        private int livroSelecionado;

        internal frmMochila()
        {
            InitializeComponent();
        }

        private void frmMochila_Load(object sender, EventArgs e)
        {
            tblResultado.Rows.Clear();
            List<Livro> livros = Dados.mochila.livros;
            List<Exemplar> exemplares = Dados.mochila.exemplares;
            for (int i = 0; i < livros.Count; i++)
            {
                tblResultado.Rows.Add(livros[i].Codigo, livros[i].ISBN, livros[i].Titulo, livros[i].Editora.Nome, livros[i].Ano, exemplares[i].Codigo, exemplares[i].Fixo ? "Sim" : "Não");
            }
            btnConcluirReserva.Enabled = Dados.mochila.quantidade != 0;
            if (Dados.usuario != null && Dados.usuario.Login != null)
            {
                lblRm.Text = Dados.usuario.Login;
                lblNome.Text = Dados.usuario.Nome;
                lblTipoCliente.Text = Dados.usuario.TipoUsuario.Nome;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                Dados.mochila.remover(livroSelecionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.frmMochila_Load(sender, e);
            atualizarBotao();
        }

        private void tblResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            livroSelecionado = e.RowIndex;
            atualizarBotao();
        }

        private void atualizarBotao()
        {
            if (Dados.mochila.quantidade == 0 || livroSelecionado == -1)
            {
                btnRemover.Enabled = false;
            } else
            {
                btnRemover.Enabled = true;
            }
        }

        private void btnConcluirReserva_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja concluir a reserva?", "Reservar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                EmprestimoLogica emprestimoLogica = new EmprestimoLogica();
                try
                {
                    emprestimoLogica.Emprestar(Dados.mochila.exemplares, Dados.mochila.livros, Dados.usuario);
                } 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Dados.mochila = new Mochila();
                Dados.usuario = null;
                MessageBox.Show("Livro(s) Reservados!", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
