namespace prjListaLivros.modelo
{
    internal class Editora
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Editora(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
    }
}
