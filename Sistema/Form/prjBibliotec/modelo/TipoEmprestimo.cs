namespace prjListaLivros.modelo
{
    internal class TipoEmprestimo
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public TipoEmprestimo(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public TipoEmprestimo()
        {
        }
    }
}
