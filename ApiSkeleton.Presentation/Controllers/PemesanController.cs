using Microsoft.AspNetCore.Mvc;
using Service.Contracts.Manager;
using Shared.DataTransferableObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSkeleton.Presentation.Controllers
{
    [Route("api/pemesan")]
    [ApiController]
    public class PemesanController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public PemesanController(IServiceManager serviceManager) 
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public IActionResult GetAllPemesan()
        {
            var pemesans = _serviceManager.PemesanService.GetAllPemesan(trackChanges: false);
            return Ok(pemesans);
        }

        [HttpGet("{id:guid}", Name = "GetPemesan")]
        public IActionResult GetPemesan(Guid id)
        {
            var pemesan = _serviceManager.PemesanService.GetPemesan(id, trackChanges: false);
            return Ok(pemesan);
        }

        [HttpPost]
        public IActionResult CreatePemesan([FromBody] PemesanForCreationDto pemesan)
        {
            if (pemesan is null) return BadRequest($"PemesanForCreationDto object is null");
            var createdPemesan = _serviceManager.PemesanService.CreatePemesan(pemesan);
            return CreatedAtRoute("GetPemesan", new { id = createdPemesan.Id}, createdPemesan);
        }
    }
}
