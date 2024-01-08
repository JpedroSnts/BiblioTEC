using MySql.Data.MySqlClient;
using prjListaLivros.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjListaLivros.logica
{
    internal class TipoOcorrenciaLogica
    {
        private Banco Banco = null;

        public TipoOcorrenciaLogica()
        {
            Banco = new Banco();
        }

        public List<TipoOcorrencia> Listar()
        {
            List<TipoOcorrencia> lista = new List<TipoOcorrencia>();

            Banco.Conectar();
            MySqlDataReader dados = Banco.Consultar("SELECT * FROM tipo_ocorrencia;");

            while (dados.Read())
            {
               lista.Add(new TipoOcorrencia(int.Parse(dados[0].ToString()), dados[1].ToString()));
            }

            if (!dados.IsClosed) dados.Close();
            Banco.Desconectar();
            return lista;
        }
    }
}
