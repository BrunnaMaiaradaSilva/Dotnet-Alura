using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Books
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}