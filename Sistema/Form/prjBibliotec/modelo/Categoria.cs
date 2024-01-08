namespace prjListaLivros.modelo
{
    internal class Categoria
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Categoria(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
    }
}
