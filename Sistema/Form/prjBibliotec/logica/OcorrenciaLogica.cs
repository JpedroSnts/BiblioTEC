using MySql.Data.MySqlClient;
using prjListaLivros.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjListaLivros.logica
{
    internal class OcorrenciaLogica
    {
        private Banco Banco = null;

        public OcorrenciaLogica()
        {
            Banco = new Banco();
        }

        public void Registrar(Emprestimo emprestimo, TipoOcorrencia tipoOcorrencia, string descricao)
        {
            Banco.Conectar();
            string sql = String.Format("INSERT INTO ocorrencia VALUES ('{0}', {1}, {2}, '{3}', {4}, '{5}');", emprestimo.Usuario.Login,emprestimo.Exemplar.Codigo,emprestimo.Livro.Codigo,emprestimo.DataHora.ToString("yyyy-MM-dd"),tipoOcorrencia.Codigo,descricao);
            Banco.Executar(sql);
            Banco.Desconectar();
        }

    }
}
