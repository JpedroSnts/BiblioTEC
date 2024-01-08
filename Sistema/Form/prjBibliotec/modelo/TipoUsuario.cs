namespace prjListaLivros.modelo
{
    internal class TipoUsuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public TipoUsuario(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public TipoUsuario()
        {
        }
    }
}
