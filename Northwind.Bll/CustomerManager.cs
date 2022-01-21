using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Base;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class CustomerManager : BllBase<Customer, DtoCustomer>, ICustomerService
    {
        public readonly ICustomerRepository customerRepository;

        public CustomerManager(IServiceProvider service) : base(service)
        {
            customerRepository = service.GetService<ICustomerRepository>();
        }

        public IQueryable CustomerReport()
        {
            return customerRepository.CustomerReport();
        }

        public IResponse<Customer> GetInclude(string str)
        {
            var customer = customerRepository.Get(str);
            if(customer != null)
            {
               
                

                return new Response<Customer>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = ObjectMapper.Mapper.Map<Customer>(customer)

                };

            } 
            else 
            {

                return new Response<Customer>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = "id bulunamadı",
                    Data = null
                };

            }
        }
    }
}
