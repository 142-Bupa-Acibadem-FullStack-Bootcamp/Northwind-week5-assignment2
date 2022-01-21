using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class CategoryContoller : ApiBaseController<ICategoryService, Category, DtoCategory>
    {
        public readonly ICategoryService _categoryService;

        public CategoryContoller(ICategoryService service) : base(service)
        {
            _categoryService = service;
        }
    }
}
