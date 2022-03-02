using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice_1.Models.DTO;
using Practice_1.Models.Request.RealEstate;
using Practice_1.Services.Abstractions;
using Practice_1.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstateManagement.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RealEstateController : ControllerBase
    {
        private readonly IRealEstateService _service;

        public RealEstateController(IRealEstateService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result.Adapt<List<RealEstate>>());
        }

        [HttpGet("{identifier}")]
        public async Task<IActionResult> Get(string identifier)
        {
            var result = await _service.GetAsync(identifier);
            return Ok(result.Adapt<RealEstate>());
        }

        [HttpPost]

        public async Task<IActionResult> Insert(CreateRealEstateRequest request)
        {
            var result = request.Adapt<RealEstateModel>();
            var id = await _service.CreateAsync(result);
            return Ok(id);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateRealEstateRequest request)
        {
            var result = request.Adapt<RealEstateModel>();
            await _service.UpdateAsync(result);
            return Ok("Updated Successfully");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok("Deleted Successfully");
        }
    }
}
