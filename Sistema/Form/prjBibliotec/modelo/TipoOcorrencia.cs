namespace prjListaLivros.modelo
{
    internal class TipoOcorrencia
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public TipoOcorrencia(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
    }
}
