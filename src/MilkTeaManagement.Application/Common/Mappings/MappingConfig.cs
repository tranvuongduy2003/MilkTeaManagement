using AutoMapper;
using MilkTeaManagement.Application.Common.Models.Chat;
using MilkTeaManagement.Domain.Entities;

namespace MilkTeaManagement.Application.Common.Mappings
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Message, MessageDto>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
