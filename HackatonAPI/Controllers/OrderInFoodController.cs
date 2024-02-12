using Hackaton.Service.DTOs;
using Hackaton.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HackatonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderInFoodController : ControllerBase
    {
        private readonly IOrderInFoodService service;
        public OrderInFoodController(IOrderInFoodService service)
        {
            this.service = service;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(OrderInFoodDto dto)
            => Ok(await service.CreateAsync(dto));



        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
            => Ok(service.GetAll(p => p.Id != 0));



        [HttpPut("{id}")]
        public async ValueTask<IActionResult> UpdateAsync([FromRoute] int id, OrderInFoodDto dto)
            => Ok(service.Update(id, dto));




        [HttpGet("{id}")]
        public async ValueTask<IActionResult> GetAsync([FromRoute] int id)
            => Ok(await service.GetAsync(u => u.Id == id));




        [HttpDelete("{id}")]
        public async ValueTask<IActionResult> DeleteAsync([FromRoute] int id)
            => Ok(await service.DeleteAsync(p => p.Id == id));
    }
}
