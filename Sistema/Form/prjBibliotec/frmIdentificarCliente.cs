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
    public partial class frmIdentificarCliente : Form
    {
        frmListarLivros formPai;

        internal frmIdentificarCliente(frmListarLivros parent)
        {
            formPai = parent;
            InitializeComponent();
            btnIdentificar.Enabled = false;
        }

        internal frmIdentificarCliente()
        {
            InitializeComponent();
            btnIdentificar.Enabled = false;
        }

        private List<Usuario> usuarios;
        private String buscaUsuario;
        private int userSelecionado;

        private void tblCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarDados(e.RowIndex);
        }

        private void AlterarDados(int index)
        {
            if (index != -1)
            {
                userSelecionado = index;
                Dados.mochila = new Mochila();
                pcbUsuarioBloqueado.Visible = bool.Parse(tblCliente.Rows[index].Cells["ic_valido"].Value.ToString());
                String rm = tblCliente.Rows[index].Cells["RM"].Value.ToString();
                foreach (Usuario u in usuarios)
                {
                    if (u.Login == rm) Dados.usuario = u;
                }
                lblRm.Text = rm;
                lblNome.Text = Dados.usuario.Nome;
                btnIdentificar.Enabled = formPai != null;
            }
            ListarEmprestimos();
        }

        private void tblEmprestimoAtual_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                Emprestimo emprestimo = new Emprestimo();
                emprestimo.Exemplar.Codigo = int.Parse(tblEmprestimoAtual.Rows[e.RowIndex].Cells["cd_exemplar"].Value.ToString());
                emprestimo.Livro.Codigo = int.Parse(tblEmprestimoAtual.Rows[e.RowIndex].Cells["cd_livro"].Value.ToString());
                emprestimo.DataHora = DateTime.Parse(tblEmprestimoAtual.Rows[e.RowIndex].Cells["dt_emprestimo"].Value.ToString());
                emprestimo.Usuario.Login = Dados.usuario.Login;
                Dados.emprestimo = emprestimo;
                frmConfirmarDevolucao frmConfirmarDevolucao = new frmConfirmarDevolucao();
                frmConfirmarDevolucao.ShowDialog();
                tblEmprestimoAtual.Rows.Clear();
                ListarEmprestimos();

                tblCliente.Rows.Clear();
                UsuarioLogica usuarioLogica = new UsuarioLogica();
                usuarios = usuarioLogica.Listar(buscaUsuario);
                foreach (Usuario usuario in usuarios)
                {
                    tblCliente.Rows.Add(usuario.Login, usuario.Nome, usuario.TipoUsuario.Nome, usuario.Bloqueado ? "Restrito" : "Sem Restrição", usuario.Bloqueado, usuario.Login);
                }
                if (usuarios.Count == 1)
                {
                    AlterarDados(0);
                }
                else
                {
                    AlterarDados(userSelecionado);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "")
            {
                tblEmprestimoAtual.Rows.Clear();
                buscaUsuario = txtPesquisa.Text;
                tblCliente.Rows.Clear();
                UsuarioLogica usuarioLogica = new UsuarioLogica();
                usuarios = usuarioLogica.Listar(txtPesquisa.Text);
                foreach (Usuario usuario in usuarios)
                {
                    tblCliente.Rows.Add(usuario.Login, usuario.Nome, usuario.TipoUsuario.Nome, usuario.Bloqueado ? "Restrito" : "Sem Restrição", usuario.Bloqueado, usuario.Login);
                }
                if (usuarios.Count == 1)
                {
                    AlterarDados(0);
                }
                txtPesquisa.Clear();
                return;
            }
            MessageBox.Show("Digite um cliente (Nome / RM)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ListarEmprestimos()
        {
            if (Dados.usuario != null && Dados.usuario.Login != null)
            {
                EmprestimoLogica emprestimoLogica = new EmprestimoLogica();
                List<Emprestimo> emprestimos = emprestimoLogica.Listar(Dados.usuario.Login);
                tblEmprestimoAtual.Rows.Clear();
                foreach (Emprestimo emprestimo in emprestimos)
                {
                    if (emprestimo.Devolucao.ToString() == "01/01/0001 00:00:00")
                    {
                        tblEmprestimoAtual.Rows.Add(emprestimo.Livro.ISBN, emprestimo.Livro.Titulo, emprestimo.Exemplar.Codigo, emprestimo.DevolucaoEstimada.ToString().Split(' ')[0], "Devolver", emprestimo.Exemplar.Codigo, emprestimo.Livro.Codigo, emprestimo.DataHora);
                    }
                }
            }
        }

        private void frmIdentificarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            tblEmprestimoAtual.Rows.Clear();
            Dados.emprestimo = null;
            if (formPai != null) formPai.exibirNomeRm();
        } 

        private void btnIdentificar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
