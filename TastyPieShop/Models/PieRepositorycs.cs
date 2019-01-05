using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TastyPieShop.Models
{
    public class PieRepositorycs:IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieRepositorycs(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _appDbContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _appDbContext.Pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
