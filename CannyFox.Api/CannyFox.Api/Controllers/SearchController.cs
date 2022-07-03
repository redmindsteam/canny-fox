﻿using CannyFox.Api.Interfaces.Services;
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

        [HttpGet("{search}")]
        public async Task<IActionResult> FindAsync(string search)
            => Ok(await service.FindAsync(search));
    }
}