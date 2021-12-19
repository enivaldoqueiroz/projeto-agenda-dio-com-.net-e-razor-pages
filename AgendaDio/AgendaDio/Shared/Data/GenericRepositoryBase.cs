using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AgendaDio.Shared.Data
{
    public abstract class GenericRepositoryBase
    {
        private readonly DbContext _dbContext;

        public async ValueTask DisposeAsync();
    }
}