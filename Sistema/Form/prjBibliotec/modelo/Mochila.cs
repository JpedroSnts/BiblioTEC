using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjListaLivros.modelo
{
    internal class Mochila
    {
        public int quantidade { get; set; }
        public List<Livro> livros { get; set; }
        public List<Exemplar> exemplares { get; set; }

        public Mochila()
        {
            this.quantidade = 0;
            this.livros = new List<Livro>();
            this.exemplares = new List<Exemplar>();
        }

        public void adicionar(Livro livro, Exemplar exemplar)
        {
            if (livro == null)
            {
                throw new Exception("Selecione um lívro!");
            }
            if (exemplar == null)
            {
                throw new Exception("Selecione um exemplar!");
            }
            if (quantidade > 3)
            {
                throw new Exception("A quantidade máxima é de apenas 3 livro!");
            }
            if(livroJaExiste(livro))
            {
                throw new Exception("Este Lívro já foi adicionado à mochila!");
            }
            livros.Add(livro);
            exemplares.Add(exemplar);
            quantidade++;
        }

        public void remover(int index)
        {
            if (index == -1)
            {
                throw new Exception("Nenhum lívro selecionado!");
            }
            exemplares.RemoveAt(index);
            livros.RemoveAt(index);
            quantidade--;
        }

        private bool livroJaExiste(Livro livro)
        {
            foreach (Livro l in livros)
            {
                if (l.Codigo == livro.Codigo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
