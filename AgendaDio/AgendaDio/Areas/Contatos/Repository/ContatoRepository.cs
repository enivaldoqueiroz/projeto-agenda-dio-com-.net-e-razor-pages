﻿using AgendaDio.Areas.Contatos.Models;
using AgendaDio.Shared.Data;
using Microsoft.EntityFrameworkCore;

namespace AgendaDio.Areas.Contatos.Repository
{
    public class ContatoRepository : GenericRepository<Contato>
    {
        public ContatoRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
