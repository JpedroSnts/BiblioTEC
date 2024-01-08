using System;

namespace prjListaLivros.modelo
{
    internal class Emprestimo
    {
        public Usuario Usuario { get; set; }
        public Exemplar Exemplar { get; set; }
        public Livro Livro { get; set; }
        public DateTime DataHora { get; set; }
        public DateTime DevolucaoEstimada { get; set; }
        public DateTime Devolucao { get; set; }
        public TipoEmprestimo TipoEmprestimo { get; set; }

        public Emprestimo(Usuario usuario, Exemplar exemplar, Livro livro, DateTime dataHora, DateTime devolucaoEstimada, DateTime devolucao, TipoEmprestimo tipoEmprestimo)
        {
            Usuario = usuario;
            Exemplar = exemplar;
            Livro = livro;
            DataHora = dataHora;
            DevolucaoEstimada = devolucaoEstimada;
            Devolucao = devolucao;
            TipoEmprestimo = tipoEmprestimo;
        }

        public Emprestimo(Usuario usuario, Exemplar exemplar, Livro livro, DateTime dataHora, DateTime devolucaoEstimada, TipoEmprestimo tipoEmprestimo)
        {
            Usuario = usuario;
            Exemplar = exemplar;
            Livro = livro;
            DataHora = dataHora;
            DevolucaoEstimada = devolucaoEstimada;
            TipoEmprestimo = tipoEmprestimo;
        }

        public Emprestimo()
        {
            Exemplar = new Exemplar();
            Livro = new Livro();
            Usuario = new Usuario();
        }
    }
}
