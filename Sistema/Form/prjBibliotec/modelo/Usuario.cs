using System;

namespace prjListaLivros.modelo
{
    internal class Usuario
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Bloqueado { get; set; }
        public DateTime DataBloqueio { get; set; }
        public TipoUsuario TipoUsuario { get; set; }

        public Usuario(string nome, string login, string senha, bool bloqueado, TipoUsuario tipoUsuario)
        {
            Nome = nome;
            Login = login;
            Senha = senha;
            Bloqueado = bloqueado;
            TipoUsuario = tipoUsuario;
        }

        public Usuario()
        {
        }
    }
}
