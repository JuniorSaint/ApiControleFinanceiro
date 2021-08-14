using System;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Api.Data.Implementation
{
    public class EntriesAmountImplementation : BaseRepository<EntriesAmountEntity>, IEntriesAmountRepository
    {
        private DbSet<EntriesAmountEntity> _dataset;

        public EntriesAmountImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<EntriesAmountEntity>();
        }

 
    }
}
