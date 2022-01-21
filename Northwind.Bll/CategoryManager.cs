using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;

namespace Northwind.Bll
{
    public class CategoryManager : BllBase<Category, DtoCategory>, ICategoryService
    {
        public readonly ICategoryRepository categoryRepository;

        public CategoryManager(IServiceProvider service) : base(service)
        {
            categoryRepository = service.GetService<ICategoryRepository>();
        }
    }
}
