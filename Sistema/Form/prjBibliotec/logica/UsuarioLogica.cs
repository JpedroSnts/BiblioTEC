using MySql.Data.MySqlClient;
using prjListaLivros.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjListaLivros.logica
{
    internal class UsuarioLogica
    {
        private Banco Banco = null;

        public UsuarioLogica()
        {
            Banco = new Banco();
        }

        public List<Usuario> Listar(string filtro)
        {
            List<Usuario> lista = new List<Usuario>();
            Banco.Conectar();
            MySqlDataReader dados = Banco.Consultar(@"
                SELECT u.*, tu.nm_tipo_usuario
                FROM usuario u 
                JOIN tipo_usuario tu ON u.cd_tipo_usuario = tu.cd_tipo_usuario
                WHERE u.nm_login = '" + filtro + "' OR u.nm_usuario LIKE '" + filtro + "%'");

            while (dados.Read())
            {
                Usuario usuario = new Usuario(
                    dados[1].ToString(),
                    dados[0].ToString(),
                    dados[2].ToString(),
                    bool.Parse(dados[3].ToString()),
                    new TipoUsuario(int.Parse(dados[5].ToString()), dados[6].ToString())
                );

                if (!String.IsNullOrEmpty(dados[4].ToString()))
                {
                    usuario.DataBloqueio = DateTime.Parse(dados[4].ToString());
                }

                lista.Add(usuario);
            }

            if (!dados.IsClosed) dados.Close();
            Banco.Desconectar();
            return lista;
        }
        public void Bloquear(Usuario usuario)
        {
            Banco.Conectar();
            string sql = String.Format("UPDATE usuario SET ic_bloqueado = TRUE WHERE nm_login = '{0}';", usuario.Login);
            Banco.Executar(sql);
            Banco.Desconectar();
        }

        public void Desbloquear(Usuario usuario)
        {
            Banco.Conectar();
            string sql = String.Format("UPDATE usuario SET ic_bloqueado = FALSE WHERE nm_login = '{0}';", usuario.Login);
            Banco.Executar(sql);
            Banco.Desconectar();
        }
    }
}
