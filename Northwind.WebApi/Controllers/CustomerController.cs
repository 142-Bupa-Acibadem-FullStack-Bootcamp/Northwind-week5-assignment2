using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Base;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class CustomerController : ApiBaseController<ICustomerService, Customer, DtoCustomer>
    {
        public readonly ICustomerService _customerService;

        public CustomerController(ICustomerService service) : base(service)
        {
            _customerService = service;
        }

        [HttpGet]
        public IResponse<Customer> GetSearch(string str)
        {
            
                var customer = _customerService.GetInclude(str);
                return customer;   

        }
    }


}



