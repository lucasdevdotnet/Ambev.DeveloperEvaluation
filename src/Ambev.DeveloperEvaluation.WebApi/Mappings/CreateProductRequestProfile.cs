﻿using Ambev.DeveloperEvaluation.Application.Products.CreateProduct;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings;

public class CreateProductRequestProfile : Profile
{
    public CreateProductRequestProfile()
    {
        CreateMap<CreateProductRequest, CreateProductCommand>();
    }
}