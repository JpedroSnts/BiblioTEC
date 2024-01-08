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
        public int CodigoLivro { get; set; }


        public Exemplar(int codigo, bool fixo, string rfId, Localizacao localizacao, int codigoLivro)
        {
            Codigo = codigo;
            Fixo = fixo;
            RfId = rfId;
            Localizacao = localizacao;
            CodigoLivro = codigoLivro;
        }

        public Exemplar()
        {
        }
    }

}
