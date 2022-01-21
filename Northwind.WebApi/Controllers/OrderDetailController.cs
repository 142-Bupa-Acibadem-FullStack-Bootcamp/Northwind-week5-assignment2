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
    public class OrderDetailController : ApiBaseController<IOrderDetailService, OrderDetail, DtoOrderDetail>
    {
        public readonly IOrderDetailService _orderDetailService;

        public OrderDetailController(IOrderDetailService service) : base(service)
        {
            _orderDetailService = service;
        }
    }
}