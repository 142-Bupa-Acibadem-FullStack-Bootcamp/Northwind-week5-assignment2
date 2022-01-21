using AutoMapper;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, DtoCustomer>().ReverseMap();
            CreateMap<Order, DtoOrder>().ReverseMap();
            CreateMap<User, DtoUser>().ReverseMap();
            CreateMap<User, DtoLoginUser>().ReverseMap();
            CreateMap<Category, DtoCategory>().ReverseMap();
            CreateMap<OrderDetail, DtoOrderDetail>().ReverseMap();
            CreateMap<Supplier, DtoSupplier>().ReverseMap();
            CreateMap<Employee, DtoEmployee>().ReverseMap();

            CreateMap<Region, DtoRegion>().ReverseMap();         
            CreateMap<Territory, DtoTerritory>().ReverseMap();
            CreateMap<Product, DtoProduct>().ReverseMap();
            CreateMap<Shipper, DtoShipper>().ReverseMap();



        }
    }
}
