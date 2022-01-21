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
    public class ShipperController : ApiBaseController<IShipperService, Shipper, DtoShipper>
    {
        public readonly IShipperService _shipperService;

        public ShipperController(IShipperService service) : base(service)
        {
            _shipperService = service;
        }
    }
}