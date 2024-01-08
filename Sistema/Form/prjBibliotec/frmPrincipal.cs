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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void buscarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarLivros frmListarLivros = new frmListarLivros();
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == typeof(frmListarLivros))
                {
                    filho.Focus();
                    return;
                }
            }
            frmListarLivros.MdiParent = this;
            frmListarLivros.Show();
        }

        private void devolverLívroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIdentificarCliente frmIdentificarCliente = new frmIdentificarCliente();
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == typeof(frmIdentificarCliente))
                {
                    filho.Focus();
                    return;
                }
            }
            frmIdentificarCliente.MdiParent = this;
            frmIdentificarCliente.Show();
        }
    }
}
