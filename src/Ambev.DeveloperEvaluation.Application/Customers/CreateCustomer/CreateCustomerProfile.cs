using Ambev.DeveloperEvaluation.Application.Customers.CreateCustomer;
using Ambev.DeveloperEvaluation.Application.Products.CreateProduct;
using Ambev.DeveloperEvaluation.Application.Sale.CreateSale;
using Ambev.DeveloperEvaluation.Application.SalesItems.CreateSaleItem;
using Ambev.DeveloperEvaluation.Application.Users.CreateUser;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Customers.CreateCustomer;

/// <summary>
/// Profile for mapping between Customer entity and CreateCustomerResponse
/// </summary>
public class CreateCustomerProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateCustomer operation
    /// </summary>
    public CreateCustomerProfile()
    {
        CreateMap<CreateCustomerCommand, Customer>();
        CreateMap<Customer, CreateCustomerResult>();
    }
}
