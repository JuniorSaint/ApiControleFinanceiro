using System;
using Api.Domain.Dtos.Category;
using Api.Domain.Dtos.EntriesAmount;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            #region User
            CreateMap<UserDto, UserEntity>().ReverseMap();
            CreateMap<UserDtoCreateResult, UserEntity>().ReverseMap();
            CreateMap<UserDtoUpdateResult, UserEntity>().ReverseMap();
            #endregion

            #region Category
            CreateMap<CategoryDto, CategoryEntity>().ReverseMap();
            CreateMap<CategoryDtoCreateResult, CategoryEntity>().ReverseMap();
            CreateMap<CategoryDtoUpdateResult, CategoryEntity>().ReverseMap();
            #endregion

            #region EntriesAmount
            CreateMap<EntriesAmountDto, EntriesAmountEntity>().ReverseMap();
            CreateMap<EntriesAmountDtoCreateResult, EntriesAmountEntity>().ReverseMap();
            CreateMap<EntriesAmountUpdateResult, EntriesAmountEntity>().ReverseMap();
            #endregion

        }
    }
}
