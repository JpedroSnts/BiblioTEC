using MySql.Data.MySqlClient;
using prjListaLivros.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjListaLivros.logica
{
    internal class EmprestimoLogica
    {
        private Banco Banco = null;

        public EmprestimoLogica()
        {
            Banco = new Banco();
        }

        public List<Emprestimo> Listar(String filtro)
        {
            List<Emprestimo> lista = new List<Emprestimo>();
            UsuarioLogica usuarioLogica = new UsuarioLogica();
            ExemplarLogica exemplarLogica = new ExemplarLogica();
            LivroLogica livroLogica = new LivroLogica();

            Banco.Conectar();
            MySqlDataReader dados = Banco.Consultar(
                @"SELECT l.cd_livro, e.*, te.nm_tipo_emprestimo FROM emprestimo e
                  JOIN livro l ON l.cd_livro = e.cd_livro JOIN tipo_emprestimo te ON te.cd_tipo_emprestimo = e.cd_tipo_emprestimo
                  WHERE e.nm_login = '" + filtro + "'");

            while (dados.Read())
            {
                string dataHora = dados["dt_emprestimo"].ToString().Split(' ')[0] + " " + dados["hr_emprestimo"].ToString();
                Emprestimo emprestimo = new Emprestimo(
                    usuarioLogica.Listar(dados["nm_login"].ToString())[0],
                    exemplarLogica.BuscarPorCodigo(int.Parse(dados["cd_exemplar"].ToString())),
                    livroLogica.Buscar(int.Parse(dados["cd_livro"].ToString())),
                    DateTime.Parse(dataHora),
                    DateTime.Parse(dados["dt_devolucao_estimada"].ToString()),
                    new TipoEmprestimo(int.Parse(dados["cd_tipo_emprestimo"].ToString()), dados["nm_tipo_emprestimo"].ToString())
                );

                if (!String.IsNullOrEmpty(dados["dt_devolucao"].ToString()))
                {
                    emprestimo.Devolucao = DateTime.Parse(dados["dt_devolucao"].ToString());
                }

                lista.Add(emprestimo);
            }

            if (!dados.IsClosed) dados.Close();
            Banco.Desconectar();
            return lista;
        }

        public void Devolver(Emprestimo emprestimo)
        {
            Banco.Conectar();
            string sql = @"UPDATE emprestimo SET dt_devolucao = CURDATE() WHERE nm_login = '" + emprestimo.Usuario.Login + "' AND cd_exemplar = " + emprestimo.Exemplar.Codigo + " AND cd_livro = " + emprestimo.Livro.Codigo + " AND dt_emprestimo = '" + emprestimo.DataHora.ToString("yyyy-MM-dd") + "';";
            Banco.Executar(sql);
            Banco.Desconectar();
        }

        public void Emprestar(List<Exemplar> exemplares, List<Livro> livros, Usuario usuario)
        {
            int qtEmprestados = 0;
            List<Emprestimo> emprestimos = this.Listar(usuario.Login);
            foreach (Emprestimo emprestimo in emprestimos)
            {
                if (emprestimo.Devolucao.ToString() == "01/01/0001 00:00:00")
                {
                    qtEmprestados++;
                }
            }
            if (qtEmprestados == 3)
            {
                throw new Exception("Quantidade máxima de lívros excedida!");
            }
            if (qtEmprestados == 2 && livros.Count > 1)
            {
                throw new Exception("Quantidade máxima de lívros excedida! Retire " + (livros.Count - 1).ToString() + " Livro(s)");
            }
            if (qtEmprestados == 1 && livros.Count > 2)
            {
                throw new Exception("Quantidade máxima de lívros excedida! Retire " + (livros.Count - 1).ToString() + " Livro(s)");
            }
            Banco.Conectar();
            for (int i = 0; i < livros.Count; i++)
            {
                int tipoEmprestimo = exemplares[i].Fixo ? 1 : 2;
                Banco.Executar(@"INSERT INTO emprestimo VALUES ('" + usuario.Login + "', " + exemplares[i].Codigo + ", " + livros[i].Codigo + ", CURDATE(), CURTIME(), CURDATE() + INTERVAL 14 DAY, NULL, " + tipoEmprestimo + ");");
            }
            Banco.Desconectar();
        }
    }
}
