using System;
using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
            modelBuilder.Entity<EntriesAmountEntity>(new EntriesAmountMap().Configure);
            modelBuilder.Entity<CategoryEntity>(new CategoryMap().Configure);


            modelBuilder.Entity<UserEntity>().HasData( //criar um usuário assim que a tabela for criada
                new UserEntity
                {
                    Id = Guid.NewGuid(),
                    UserName = "Administrador",
                    Email = "junior.saint@gmail.com",
                    PassWord = "123456",
                    Active = true,
                    UserType = "Administrador",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );
        }
    }
}
