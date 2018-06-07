using AbcMovies.Dtos;
using AbcMovies.Models;
using AutoMapper;

namespace AbcMovies.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to Dto
            CreateMap<Customer, CustomerDto>();
            CreateMap<Movie, MovieDto>();
            CreateMap<MembershipTypeDto, MembershipType>();

            //Dto to Domain
            CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());

        }
    }
}