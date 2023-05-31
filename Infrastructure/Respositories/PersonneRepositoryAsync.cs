using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Respositories
{
    public class PersonneRepositoryAsync : GenericRepositoryAsync<Personne>, IPersonneRepositoryAsync
    {
        private readonly DbSet<Personne> _personne;

        public PersonneRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _personne = dbContext.Set<Personne>();
        }
    }
}
