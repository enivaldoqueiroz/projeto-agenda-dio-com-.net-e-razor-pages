using AgendaDio.Areas.Contatos.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaDio.Shared.Data
{
    public class AgendaDbContext : DbContext
    {
        public AgendaDbContext(DbContextOptions<AgendaDbContext> options) : base(options)
        {
        }

        public DbSet<Contato> Contatos { get; set; }

    }
}
