using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using LibraryDAL.Model;
using LibraryBLL.Dto;

namespace LibraryBLL.Infrastructure
{
    class MapperConfigurator: Profile
    {
        public MapperConfigurator(IMapperConfigurationExpression configExpression)
        {
            configExpression.CreateMap<User, UserViewModel>()
            .ForMember(destination => destination.Name,
                option => option.MapFrom(source => source.Name))
             .ForMember(destination => destination.Id,
                option => option.MapFrom(s => s.Id))
            .ForMember(destination => destination.Email,
                option => option.MapFrom(s => s.Email ?? ""))
            .ReverseMap();

            _ = configExpression.CreateMap<Title, TitleViewModel>()
            .ForMember(destination => destination.Name,
                option => option.MapFrom(source => source.Name))
             .ForMember(destination => destination.Id,
                option => option.MapFrom(s => s.Id))
            .ForMember(destination => destination.Series,
                option => option.MapFrom(s => s.Series ?? 0))
            .ForMember(destination => destination.Year,
                option => option.MapFrom(s => s.Year ?? 0))
            .ReverseMap();
        }
    }
}
