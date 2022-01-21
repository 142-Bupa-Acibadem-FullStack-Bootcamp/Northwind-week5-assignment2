using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerritoryController : ApiBaseController<ITerritoryService, Territory, DtoTerritory>
    {
        public readonly ITerritoryService _territoryService;

        public TerritoryController(ITerritoryService service) : base(service)
        {
            _territoryService = service;
        }
    }
}