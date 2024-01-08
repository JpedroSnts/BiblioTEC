namespace prjListaLivros.modelo
{
    internal class Ocorrencia
    {
        public Usuario Usuario { get; set; }
        public Exemplar Exemplar { get; set; }
        public Livro Livro { get; set; }
        public Emprestimo Emprestimo { get; set; }
        public TipoOcorrencia TipoOcorrencia { get; set; }
        public string Descricao { get; set; }

        public Ocorrencia(Usuario usuario, Exemplar exemplar, Livro livro, Emprestimo emprestimo, TipoOcorrencia tipoOcorrencia, string descricao)
        {
            Usuario = usuario;
            Exemplar = exemplar;
            Livro = livro;
            Emprestimo = emprestimo;
            TipoOcorrencia = tipoOcorrencia;
            Descricao = descricao;
        }
    }
}
