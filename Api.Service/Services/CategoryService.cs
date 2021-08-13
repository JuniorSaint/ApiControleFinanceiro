using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Category;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repositories;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class CategoryService : ICategoryService
    {

        private IRepository<CategoryEntity> _repository;
        private readonly IMapper _mapper;

        public CategoryService(IRepository<CategoryEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<CategoryDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<CategoryDto>(entity);
        }

        public async Task<IEnumerable<CategoryDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<CategoryDto>>(listEntity);
        }

        public async Task<CategoryDtoCreateResult> Post(CategoryDtoCreate cat)
        {
            var model = _mapper.Map<CategoryModel>(cat);
            var entity = _mapper.Map<CategoryEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<CategoryDtoCreateResult>(result);
        }

        public async Task<CategoryDtoUpdateResult> Put(CategoryDtoUpdate cat)
        {
            var model = _mapper.Map<CategoryModel>(cat);
            var entity = _mapper.Map<CategoryEntity>(model);

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<CategoryDtoUpdateResult>(result);
        }
    }
}
