using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Category;

namespace Api.Domain.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<CategoryDto> Get(Guid id);
        Task<IEnumerable<CategoryDto>> GetAll();
        Task<CategoryDtoCreateResult> Post(CategoryDtoCreate category);
        Task<CategoryDtoUpdateResult> Put(CategoryDtoUpdate category);
        Task<bool> Delete(Guid id);
    }
}