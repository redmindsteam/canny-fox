using CannyFox.Api.Interfaces.Services;
using CannyFox.Api.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CannyFox.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ITestService service;

        public SearchController(ITestService _service)
        {
            this.service = _service;
        }

        [HttpPost]
        public async Task<IActionResult> FindAsync([FromBody] FindableViewModel findableViewModel)
            => Ok(await service.FindAsync(findableViewModel.Search));
    }
}
