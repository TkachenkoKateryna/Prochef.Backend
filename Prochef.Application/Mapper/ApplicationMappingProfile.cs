using AutoMapper;
using Microsoft.OpenApi.Extensions;
using Prochef.Application.Dtos;
using Prochef.Core.Dtos.Request.Chains;
using Prochef.Core.Dtos.Request.Products;
using Prochef.Core.Dtos.Request.Upsert;
using Prochef.Core.Dtos.Response;

using Prochef.Core.Entities;

namespace Prochef.Application.Mapper
{
    public class ApplicationMappingProfile : Profile
    {
        public ApplicationMappingProfile()
        {
            CreateMap<UpsertExpenseRequest, Expenses>().ReverseMap();
            CreateMap<UpsertChainRequest, Chain>()
                .ForMember(m => m.Restaurants, opt => opt.Ignore())
                .ForMember(m => m.Id, opt => opt.Ignore())
                .ForMember(m => m.Id, opt => opt.UseDestinationValue());
            CreateMap<UpsertRestaurantRequest, Restaurant>()
                .ForMember(m => m.Employees, opt => opt.Ignore())
                .ForMember(m => m.Id, opt => opt.Ignore())
                .ForMember(m => m.Id, opt => opt.UseDestinationValue());
            CreateMap<UpsertProductRequest, Product>()
                .ForMember(m => m.Id, opt => opt.UseDestinationValue())
                .ForMember(m => m.Ingredients, opt => opt.Ignore());




            CreateMap<Restaurant, RestaurantResponse>();
            CreateMap<Chain, ChainResponse>();
            CreateMap<Product, ProductResponse>()
                .ForMember(m => m.Category, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(m => m.Place, opt => opt.MapFrom(src => src.Place.Name))
                .ForMember(m => m.State, opt => opt.MapFrom(src => src.State.GetDisplayName()));
            CreateMap<Ingredient, IngredientResponse>()
                .ForMember(m => m.Name, opt => opt.MapFrom(src => src.Product.Name))
                .ForMember(m => m.Weight, opt => opt.MapFrom(src => src.Weight));

            CreateMap<MenuItem, MenuItemResponse>()
                .ForMember(m => m.Price, opt => opt.MapFrom(src => src.GetFullPrice()))
                .ForMember(m => m.Section, opt => opt.MapFrom(src => src.Section.Name))
                .ForMember(m => m.TimeOfTheDay, opt => opt.MapFrom(src => src.TimeOfTheDay.GetDisplayName()));
        }
    }
}
