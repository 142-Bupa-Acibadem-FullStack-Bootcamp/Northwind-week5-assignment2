using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Base;
using Northwind.Entity.IBase;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Northwind.WebApi.Base
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes =JwtBearerDefaults.AuthenticationScheme)]
    public class ApiBaseController<TInterface, T, TDto> : ControllerBase where TInterface : IGenericServise<T, TDto> where T:EntityBase where TDto : DtoBase
    {
        private readonly TInterface service;

        public ApiBaseController(TInterface service)
        {
            this.service = service;
        }

        [HttpGet("Find")]
        public IResponse<TDto> Find(int id)
        {
            try
            {
                var entity = service.Find(id);

                return entity;
            }
            catch (Exception ex)
            {
                return new Response<TDto>
                {
                    Message = $"Error:{ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }

        [HttpGet("GetAll")]
        public IResponse<List<TDto>> GetAll()
        {
            try
            {
                return service.GetAll();
            }
            catch (Exception ex)
            {
                return new Response<List<TDto>>
                {
                    Message = $"Error:{ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
           
        }

        [HttpPost]
        public IResponse<TDto> Add(TDto item)
        {
            try
            {

                var result = service.Add(item);
                return result;

            }
            catch (Exception ex)
            {
                return new Response<TDto>
                {
                    Message = $"Error:{ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }



        [HttpDelete]
        public IResponse<bool> DeleteById(int id)
        {
            try
            {
                return service.DeleteById(id);
            }
            catch (Exception ex)
            {
                return new Response<bool>
                {
                    Message = $"Error:{ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = false
                };
            }
        }


    }
}
