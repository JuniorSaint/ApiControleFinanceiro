using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.EntriesAmount;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repositories;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class EntriesAmountService : IEntriesAmountService
    {
        private IRepository<EntriesAmountEntity> _repository;
        private readonly IMapper _mapper;

        public EntriesAmountService(IRepository<EntriesAmountEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<EntriesAmountDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<EntriesAmountDto>(entity);
        }

        public async Task<IEnumerable<EntriesAmountDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<EntriesAmountDto>>(listEntity);
        }

        public async Task<EntriesAmountDtoCreateResult> Post(EntriesAmountDtoCreate entries)
        {
            var model = _mapper.Map<EntriesAmountModel>(entries);
            var entity = _mapper.Map<EntriesAmountEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<EntriesAmountDtoCreateResult>(result);
        }

        public async Task<EntriesAmountUpdateResult> Put(EntriesAmountUpdate entries)
        {
            var model = _mapper.Map<EntriesAmountModel>(entries);
            var entity = _mapper.Map<EntriesAmountEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<EntriesAmountUpdateResult>(result);
        }
    }
}
