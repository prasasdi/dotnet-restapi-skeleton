using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Service.Contracts.Manager;
using Shared.DataTransferableObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSkeleton.Presentation.Controllers
{
    [Route("api/pemesan/{pemesanId}/pesanan")]
    public class PesananController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public PesananController(IServiceManager serviceManager) 
        {
            _serviceManager = serviceManager;
        }
        [HttpGet]
        public IActionResult GetAllPesananByPemesanId(Guid pemesanId)
        {
            var pesanans = _serviceManager.PesananService.GetAllPesananByPemesanId(pemesanId, trackChanges: false);
            return Ok(pesanans);
        }

        [HttpGet("{pesananId:guid}", Name = "GetPesananForPemesan")]
        public IActionResult GetPesananForPemesan(Guid pemesananId, Guid pesananId)
        {
            var pesanan = _serviceManager.PesananService.GetPesananForPemesan(pemesananId, pesananId, trackChanges: false);
            return Ok(pesanan);
        }

        [HttpPost]
        public IActionResult CreatePesanan(Guid pemesanId, [FromBody] PesananForCreationDto pesanan)
        {
            if (pesanan is null) return BadRequest("PesananForCreationDto object is null.");

            var createdPesanan = _serviceManager.PesananService.CreatePesanan(pemesanId, pesanan);
            return CreatedAtRoute("GetPesananForPemesan", new { pemesanId = pemesanId, pesananId = createdPesanan.Id }, createdPesanan);
        }
    }
}
