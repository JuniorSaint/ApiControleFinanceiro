using Api.Data.Repository;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace Api.Data.Implementations
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> _dataset;

        public UserImplementation(MyContext contex) : base(contex)
        {
            _dataset = contex.Set<UserEntity>();
        }

        public async Task<UserEntity> FindByLogin(string email, string password)
        {
            return await _dataset.FirstOrDefaultAsync(u => u.Email.Equals(email) && u.Password.Equals(password));
        }

        public Task<UserEntity> GetByEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<UserEntity>> SearchByEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<UserEntity>> SearchByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}




