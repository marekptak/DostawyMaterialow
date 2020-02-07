using System.Collections.Generic;

namespace DostawyMaterialow.Models
{
    public interface IDostawcaRepository
    {
        IEnumerable<Dostawa> PobierzWszystkieDostawy();
        Dostawa PobierzDostaweOId(int dostawaId);
    }
}
