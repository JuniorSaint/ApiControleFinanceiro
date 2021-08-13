using System;
using Api.Data.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Api.Domain.Interfaces.Repositories;
using Api.Data.Repository;
using Api.Data.Implementations;
using Api.Data.Implementation;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {

            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();
            serviceCollection.AddScoped<ICategoryRepository, CategoryImplementation>();
            serviceCollection.AddScoped<IEntriesAmountRepository, EntriesAmountImplementation>();          


            serviceCollection.AddDbContext<MyContext>(
                 options => options.UseNpgsql("Server=localhost; Port=5432; Database=ControleFinanceiro; Uid=Junior; Pwd=123456")
                 );
        }
    }
}
