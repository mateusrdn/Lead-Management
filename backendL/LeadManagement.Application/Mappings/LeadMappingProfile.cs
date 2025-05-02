using AutoMapper;
using LeadManagement.Application.DTOs;
using LeadManagement.Domain.Entities;

namespace LeadManagement.Application.Mappings
{
    public class LeadMappingProfile : Profile
    {
        public LeadMappingProfile() 
        {
            CreateMap<Lead, ReadLeadDto>();
        }

    }
}
