using Ambev.DeveloperEvaluation.Application.Sale.CreateSale;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings;

public class CreateSaleRequestProfile : Profile
{
    public CreateSaleRequestProfile()
    {
        CreateMap<CreateSaleRequest, CreateSaleCommand>();
    }
}