using AutoMapper;
using Supermarket.API.Domain.Models;
using Supermarket.API.Resources;

public class ResourceToModelProfile : Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveCategoryResource, Category>();
    }
}
