using AutoMapper;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Application.DTOs;

namespace CleanArchMvc.Application.Mapper
{
    public class DomainToDTOMapperProfile : Profile
    {
        public DomainToDTOMapperProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
        }
    }
}
