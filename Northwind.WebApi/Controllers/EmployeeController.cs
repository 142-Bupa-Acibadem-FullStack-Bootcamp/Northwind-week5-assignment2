﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ApiBaseController<IEmployeeService, Employee, DtoEmployee>
    {
        public readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService service) : base(service)
        {
            _employeeService = service;
        }
    }
}
