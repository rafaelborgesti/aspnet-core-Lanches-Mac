using Lanches_Mac.Models;
using System.Collections.Generic;

namespace Lanches_Mac.Repositories
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
