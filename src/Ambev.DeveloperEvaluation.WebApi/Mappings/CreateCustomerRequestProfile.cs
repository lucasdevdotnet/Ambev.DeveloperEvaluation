using Ambev.DeveloperEvaluation.Application.Customers.CreateCustomer;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings;

public class CreateCustomerRequestProfile : Profile
{
    public CreateCustomerRequestProfile()
    {
        CreateMap<CreateCustomerRequest, CreateCustomerCommand>();
    }
}