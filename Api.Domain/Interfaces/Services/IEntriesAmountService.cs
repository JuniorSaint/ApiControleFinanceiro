
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.EntriesAmount;

namespace Api.Domain.Interfaces.Services
{
    public interface IEntriesAmountService
    {
        Task<EntriesAmountDto> Get(Guid id);
        Task<IEnumerable<EntriesAmountDto>> GetAll();
        Task<EntriesAmountDtoCreateResult> Post(EntriesAmountDtoCreate entries);
        Task<EntriesAmountUpdateResult> Put(EntriesAmountUpdate entries);
        Task<bool> Delete(Guid id);
    }
}