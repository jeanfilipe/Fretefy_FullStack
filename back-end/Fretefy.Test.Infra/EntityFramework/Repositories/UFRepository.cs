using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class UFRepository : IUFRepository
    {
        private readonly AppDbContext _appDbContext;

        public UFRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<UF> GetAll()
        {
            return _appDbContext.UFs.OrderBy(x => x.Nome).ToList();
        }
    }
}
