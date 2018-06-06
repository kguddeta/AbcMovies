using AbcMovies.Dtos;
using AbcMovies.Models;
using AutoMapper;

namespace AbcMovies.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
        }
    }
}