using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DostawyMaterialow.Models
{
    public class DostawaRepository : IDostawcaRepository
    {
        private readonly AppDbContext _appDbContext;
        public DostawaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Dostawa PobierzDostaweOId(int dostawaId)
        {
            return _appDbContext.Dostawy.FirstOrDefault(s => s.Id == dostawaId);
        }

        public IEnumerable<Dostawa> PobierzWszystkieDostawy()
        {
            return _appDbContext.Dostawy;
        }
    }
}
