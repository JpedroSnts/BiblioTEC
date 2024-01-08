using MySql.Data.MySqlClient;
using prjListaLivros.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjListaLivros.logica
{
    internal class CategoriaLogica
    {
        private Banco Banco = null;

        public CategoriaLogica()
        {
            Banco = new Banco();
        }

        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            Banco.Conectar();
            MySqlDataReader dados = Banco.Consultar("SELECT * FROM categoria;");

            while (dados.Read())
            {
                lista.Add(new Categoria(int.Parse(dados[0].ToString()), dados[1].ToString()));
            }

            if (!dados.IsClosed) dados.Close();
            Banco.Desconectar();
            return lista;
        }

        public Categoria ListarPorCodigo(string codigo)
        {
            Banco.Conectar();
            MySqlDataReader dados = Banco.Consultar("SELECT * FROM categoria WHERE cd_categoria = " + codigo);

            if (dados.Read())
            {
                Categoria categoria = new Categoria(int.Parse(dados[0].ToString()), dados[1].ToString());
                if (!dados.IsClosed) dados.Close();
                Banco.Desconectar();
                return categoria;
            }

            if (!dados.IsClosed) dados.Close();
            Banco.Desconectar();
            return null;
        }

    }
}
