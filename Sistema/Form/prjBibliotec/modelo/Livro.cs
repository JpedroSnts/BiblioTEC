using System.Collections.Generic;

namespace prjListaLivros.modelo
{
    internal class Livro
    {
        public int Codigo { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public string Sinopse { get; set; }
        public Editora Editora { get; set; }
        public string Capa { get; set; }

        public List<Autor> Autores { get; set; }
        public List<Categoria> Categorias { get; set; }
        public List<Exemplar> Exemplares { get; set; }

        public Livro(int codigo, string isbn, string titulo, int ano, string sinopse, Editora editora, List<Autor> autores, List<Categoria> categorias, List<Exemplar> exemplares, string capa)
        {
            Codigo = codigo;
            ISBN = isbn;
            Titulo = titulo;
            Ano = ano;
            Sinopse = sinopse;
            Editora = editora;
            Autores = autores;
            Categorias = categorias;
            Exemplares = exemplares;
            Capa = capa;
        }

        public Livro()
        {
        }
    }
}
