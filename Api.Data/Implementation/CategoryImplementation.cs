using System;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementation
{
    public class CategoryImplementation : BaseRepository<CategoryEntity>, ICategoryRepository
    {

        private DbSet<CategoryEntity> _dataset;

        public CategoryImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<CategoryEntity>();

        }
    }
}
