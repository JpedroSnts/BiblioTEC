using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace prjListaLivros.logica
{
    internal class Banco
    {
        private string LinhaConexao { get; set; }
        private MySqlConnection Conexao = null;
        private MySqlCommand Cmd = null;

        public Banco(string server, string user, string password, string database)
        {
            LinhaConexao = "SERVER=" + server + ";UID=" + user + ";PASSWORD=" + password + ";DATABASE=" + database; 
        }

        public Banco()
        {
            LinhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=bibliotec";
        }

        public void Conectar()
        {
            Conexao = new MySqlConnection(LinhaConexao);
            try
            {
                Conexao.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel se conectar ao banco de dados!", ex);
            }
        }

        public void Desconectar()
        {
            if (Conexao != null && Conexao.State == System.Data.ConnectionState.Open)
                Conexao.Close();
        }

        public MySqlDataReader Consultar(string sql)
        {
            try
            {
                Cmd = new MySqlCommand(sql, Conexao);
                return Cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro na consulta!", ex);
            }
        }
    }
}
