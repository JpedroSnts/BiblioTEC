namespace prjListaLivros.modelo
{
    internal class Autor
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Autor(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
    }
}
