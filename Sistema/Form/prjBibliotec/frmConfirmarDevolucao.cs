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
    public partial class frmConfirmarDevolucao : Form
    {
        public frmConfirmarDevolucao()
        {
            InitializeComponent();
        }

        private void frmConfirmarDevolucao_Load(object sender, EventArgs e)
        {
            TipoOcorrenciaLogica tipoOcorrenciaLogica = new TipoOcorrenciaLogica();
            List<TipoOcorrencia> tipoOcorrencias = tipoOcorrenciaLogica.Listar();
            foreach(var to in tipoOcorrencias)
            {
                cmbTipoOcorrencia.Items.Add(to.Nome);
                cmbTipoOcorrenciaCd.Items.Add(to.Codigo);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (rdbSim.Checked)
            {
                if (cmbTipoOcorrencia.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione um tipo de ocorrência!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                UsuarioLogica usuarioLogica = new UsuarioLogica();
                OcorrenciaLogica ocorrenciaLogica = new OcorrenciaLogica();

                int index = cmbTipoOcorrencia.SelectedIndex;
                int codigo = int.Parse(cmbTipoOcorrenciaCd.Items[index].ToString());
                string nome = cmbTipoOcorrencia.Items[index].ToString();
                ocorrenciaLogica.Registrar(Dados.emprestimo, new TipoOcorrencia(codigo, nome), txtDescricao.Text);

                usuarioLogica.Bloquear(Dados.usuario);
            }
            EmprestimoLogica emprestimoLogica = new EmprestimoLogica();
            emprestimoLogica.Devolver(Dados.emprestimo);
            MessageBox.Show("Livro devolvido!");
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            grbControles.Enabled = true;
        }

        private void rdbNao_CheckedChanged(object sender, EventArgs e)
        {
            grbControles.Enabled = false;
        }
    }
}
