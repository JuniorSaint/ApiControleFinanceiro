using Api.Domain.Dtos.Category;
using Api.Domain.Dtos.EntriesAmount;
using Api.Domain.Dtos.User;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            #region User
            CreateMap<UserModel, UserDto>().ReverseMap();
            CreateMap<UserModel, UserDtoCreate>().ReverseMap();
            CreateMap<UserModel, UserDtoUpdate>().ReverseMap();
            #endregion


            #region Category
            CreateMap<CategoryModel, CategoryDto>().ReverseMap();
            CreateMap<CategoryModel, CategoryDtoCreate>().ReverseMap();
            CreateMap<CategoryModel, CategoryDtoUpdate>().ReverseMap();
            #endregion

            #region EntriesAmount
            CreateMap<EntriesAmountModel, EntriesAmountDto>().ReverseMap();
            CreateMap<EntriesAmountModel, EntriesAmountDtoCreate>().ReverseMap();
            CreateMap<EntriesAmountModel, EntriesAmountUpdate>().ReverseMap();
            #endregion
        }
    }
}
