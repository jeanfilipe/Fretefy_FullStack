using Fretefy.Test.Domain.Entities;
using System.Collections.Generic;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IUFRepository
    {
        List<UF> GetAll();
    }
}
