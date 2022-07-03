using CannyFox.Api.Interfaces.Services;
using CannyFox.Api.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CannyFox.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly ITestService service;

        public TestsController(ITestService _service)
        {
            this.service = _service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
            => Ok(await service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(Guid id)
            => Ok(await service.GetAsync(id));

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] TestCreationViewModel testCreationViewModel)
            => Ok(await service.CreateAsync(testCreationViewModel));

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] TestCreationViewModel testCreationViewModel)
            => Ok(await service.UpdateAsync(id, testCreationViewModel));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
            => Ok(await service.DeleteAsync(id));

        
    }
}
