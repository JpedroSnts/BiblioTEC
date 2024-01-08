using System.Collections.Generic;

namespace prjListaLivros.modelo
{
    internal class Localizacao
    {
        public int Codigo { get; set; }
        public string Local { get; set; }

        public List<Exemplar> Exemplares { get; set; }

        public Localizacao(int codigo, string local, List<Exemplar> exemplares)
        {
            Codigo = codigo;
            Local = local;
            Exemplares = exemplares;
        }
    }
}