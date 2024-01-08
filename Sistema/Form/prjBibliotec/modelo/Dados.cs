using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjListaLivros.modelo
{
    internal class Dados
    {
        public static Usuario usuario;
        public static Mochila mochila = new Mochila();
        public static Emprestimo emprestimo = new Emprestimo();

        public static void limpar()
        {
            mochila = null;
            usuario = new Usuario();
            emprestimo = null;
        }
    }
}
