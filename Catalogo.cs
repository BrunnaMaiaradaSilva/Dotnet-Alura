using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books
{
    public class Catalogo : ICatalogo
    {
        public List<Livro> GetLivros()
        {
            var livros = new List<Livro>();
            livros.Add(new Livro("001", "Hamlet", 19.87m));
            livros.Add(new Livro("002", "Fique rico com TI", 34.99m));
            livros.Add(new Livro("003", "Eh mentira", 9.99m));

            return livros;
        }
    }
}
