using Lanches_Mac.Models;
using System.Collections.Generic;

namespace Lanches_Mac.Repositories
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchePreferidos { get; }
        Lanche GetLancheById(int lancheId);
    }
}
