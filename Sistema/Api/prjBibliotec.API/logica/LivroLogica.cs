using MySql.Data.MySqlClient;
using prjBibliotec.API;
using prjListaLivros.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjListaLivros.logica
{
    internal class LivroLogica
    {
        private Banco Banco = null;

        public LivroLogica()
        {
            Banco = new Banco();
        }

        public List<Livro> Listar(string filtro, int inicio, int quantidade)
        {
            ExemplarLogica exemplarLogica = new ExemplarLogica();
            List<Livro> lista = new List<Livro>();
            Banco.Conectar();
            MySqlDataReader dados = Banco.Consultar(
                @"SELECT 
                        l.*,
                        e.nm_editora,
                        GROUP_CONCAT(DISTINCT (a.cd_autor))     	as cd_autores,
                        GROUP_CONCAT(DISTINCT (a.nm_autor))     	as nm_autores,
                        GROUP_CONCAT(DISTINCT (c.cd_categoria)) 	as cd_categorias,
                        GROUP_CONCAT(DISTINCT (c.nm_categoria)) 	as nm_categorias
                FROM livro l
                        JOIN editora e 			ON e.cd_editora = l.cd_editora
                        JOIN livro_autor la 	ON la.cd_livro = l.cd_livro
                        JOIN autor a 			ON a.cd_autor = la.cd_autor
                        JOIN livro_categoria lc ON lc.cd_livro = l.cd_livro
                        JOIN categoria c 		ON c.cd_categoria = lc.cd_categoria" +
                " WHERE l.cd_livro = '" + filtro + "' OR l.cd_ISBN = '" + filtro + "' OR l.nm_livro LIKE '" + filtro + "%'" +
                " GROUP BY l.cd_livro LIMIT " + quantidade + " OFFSET " + inicio);

            while (dados.Read())
            {
                List<Autor> autores = BuscarAutores(dados);
                List<Categoria> categorias = BuscarCategorias(dados);

                Editora editora = new Editora(int.Parse(dados[5].ToString()), dados[7].ToString());

                string capa = BuscarCapa(dados);

                lista.Add(new Livro(
                    int.Parse(dados[0].ToString()),
                    dados[1].ToString(),
                    dados[2].ToString(),
                    int.Parse(dados[3].ToString()),
                    dados[4].ToString(),
                    editora, autores, categorias,
                    exemplarLogica.ListarPorCodigoLivro(int.Parse(dados[0].ToString())),
                    capa
                ));
            }

            if (!dados.IsClosed) dados.Close();
            Banco.Desconectar();
            return lista;
        }

        public List<Livro> Listar(int categoria, int inicio, int quantidade)
        {
            ExemplarLogica exemplarLogica = new ExemplarLogica();
            List<Livro> lista = new List<Livro>();
            Banco.Conectar();
            MySqlDataReader dados = Banco.Consultar(
                @"SELECT 
                        l.*,
                        e.nm_editora,
                        GROUP_CONCAT(DISTINCT (a.cd_autor))     	as cd_autores,
                        GROUP_CONCAT(DISTINCT (a.nm_autor))     	as nm_autores,
                        GROUP_CONCAT(DISTINCT (c.cd_categoria)) 	as cd_categorias,
                        GROUP_CONCAT(DISTINCT (c.nm_categoria)) 	as nm_categorias
                FROM livro l
                        JOIN editora e 			ON e.cd_editora = l.cd_editora
                        JOIN livro_autor la 	ON la.cd_livro = l.cd_livro
                        JOIN autor a 			ON a.cd_autor = la.cd_autor
                        JOIN livro_categoria lc ON lc.cd_livro = l.cd_livro
                        JOIN categoria c 		ON c.cd_categoria = lc.cd_categoria" +
                " WHERE lc.cd_categoria = "+ categoria +
                " GROUP BY l.cd_livro LIMIT " + quantidade + " OFFSET " + inicio);

            while (dados.Read())
            {
                List<Autor> autores = BuscarAutores(dados);
                List<Categoria> categorias = BuscarCategorias(dados);

                Editora editora = new Editora(int.Parse(dados[5].ToString()), dados[7].ToString());

                string capa = BuscarCapa(dados);

                lista.Add(new Livro(
                    int.Parse(dados[0].ToString()),
                    dados[1].ToString(),
                    dados[2].ToString(),
                    int.Parse(dados[3].ToString()),
                    dados[4].ToString(),
                    editora, autores, categorias,
                    exemplarLogica.ListarPorCodigoLivro(int.Parse(dados[0].ToString())),
                    capa
                ));
            }

            if (!dados.IsClosed) dados.Close();
            Banco.Desconectar();
            return lista;
        }

        public List<Livro> ListarMaisReservados(int inicio, int quantidade)
        {
            ExemplarLogica exemplarLogica = new ExemplarLogica();
            List<Livro> lista = new List<Livro>();
            Banco.Conectar();
            MySqlDataReader dados = Banco.Consultar(
                @"SELECT * FROM(SELECT 
                        l.*,
                        e.nm_editora,
                        GROUP_CONCAT(DISTINCT (a.cd_autor))     	as cd_autores,
                        GROUP_CONCAT(DISTINCT (a.nm_autor))     	as nm_autores,
                        GROUP_CONCAT(DISTINCT (c.cd_categoria)) 	as cd_categorias,
                        GROUP_CONCAT(DISTINCT (c.nm_categoria)) 	as nm_categorias,
                        (SELECT COUNT(*) FROM emprestimo WHERE cd_Livro = l.cd_livro) as qt_emprestimos
                FROM livro l
                        JOIN editora e 			ON e.cd_editora = l.cd_editora
                        JOIN livro_autor la 	ON la.cd_livro = l.cd_livro
                        JOIN autor a 			ON a.cd_autor = la.cd_autor
                        JOIN livro_categoria lc ON lc.cd_livro = l.cd_livro
                        JOIN categoria c 		ON c.cd_categoria = lc.cd_categoria 
                GROUP BY l.cd_livro ORDER BY qt_emprestimos DESC LIMIT " + quantidade + " OFFSET " + inicio + ") t WHERE t.qt_emprestimos <> 0;");

            while (dados.Read())
            {
                List<Autor> autores = BuscarAutores(dados);
                List<Categoria> categorias = BuscarCategorias(dados);

                Editora editora = new Editora(int.Parse(dados[5].ToString()), dados[7].ToString());

                string capa = BuscarCapa(dados);

                lista.Add(new Livro(
                    int.Parse(dados[0].ToString()),
                    dados[1].ToString(),
                    dados[2].ToString(),
                    int.Parse(dados[3].ToString()),
                    dados[4].ToString(),
                    editora, autores, categorias,
                    exemplarLogica.ListarPorCodigoLivro(int.Parse(dados[0].ToString())),
                    capa
                ));
            }

            if (!dados.IsClosed) dados.Close();
            Banco.Desconectar();
            return lista;
        }

        private List<Autor> BuscarAutores(MySqlDataReader dados)
        {
            List<Autor> autores = new List<Autor>();
            string[] cdAutores = dados[8].ToString().Split(',');
            string[] nmAutores = dados[9].ToString().Split(',');
            for (int i = 0; i < cdAutores.Length; i++)
            {
                autores.Add(new Autor(int.Parse(cdAutores[i]), nmAutores[i]));
            }

            return autores;
        }

        private List<Categoria> BuscarCategorias(MySqlDataReader dados)
        {
            List<Categoria> categorias = new List<Categoria>();
            string[] cdCategorias = dados[10].ToString().Split(',');
            string[] nmCategorias = dados[11].ToString().Split(',');
            for (int i = 0; i < cdCategorias.Length; i++)
            {
                categorias.Add(new Categoria(int.Parse(cdCategorias[i]), nmCategorias[i]));
            }

            return categorias;
        }

        private string BuscarCapa(MySqlDataReader dados)
        {
            if (!String.IsNullOrEmpty(dados[6].ToString()))
            {
                byte[] bytes = (byte[])dados[6];
                return Convert.ToBase64String(bytes);
            }
            return null;
        }
    }
}
