using System.Collections.Generic;

namespace Books
{
    public interface ICatalogo
    {
        List<Livro> GetLivros();
    }
}