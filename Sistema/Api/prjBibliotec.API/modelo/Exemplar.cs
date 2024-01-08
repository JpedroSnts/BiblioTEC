using System.Collections.Generic;

namespace prjListaLivros.modelo
{
    internal class Exemplar
    {
        public int Codigo { get; set; }
        public bool Fixo { get; set; }
        public string RfId { get; set; }
        public bool Emprestado { get; set; }
        public Localizacao Localizacao { get; set; }
        public List<Livro> Livros { get; set; }

        public Exemplar(int codigo, bool fixo, string rfId, Localizacao localizacao, List<Livro> livros)
        {
            Codigo = codigo;
            Fixo = fixo;
            RfId = rfId;
            Localizacao = localizacao;
            Livros = livros;
        }
    }

}
