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
    [Route("api/produk/{produkId}/komentar")]
    [ApiController]
    public class KomentarController : ControllerBase
    {
        private readonly IServiceManager _service;
        public KomentarController(IServiceManager service)
        {
            _service = service;
        }
        [HttpGet("{id:guid}", Name = "GetKomentarForProduk")]
        public IActionResult GetKomentarForProduk(Guid produkId, Guid id)
        {
            var komentar = _service.KomentarService.GetKomentarForProduk(produkId, id, false);
            return Ok(komentar);
        }
        [HttpGet]
        public IActionResult GetAllKomentarByProdukId(Guid produkId)
        {
            var komentars = _service.KomentarService.GetAllKomentarByProdukId(produkId, trackChanges: false);
            return Ok(komentars);
        }
        [HttpPost]
        public IActionResult CreateNewKomentar(Guid produkId, [FromBody] KomentarForCreationDto komentar)
        {
            if (komentar is null) return BadRequest("KomentarForCreationDto object is null");

            var komentarToReturn = _service.KomentarService.CreateKomentar(produkId, komentar, trackChanges: false);

            return CreatedAtRoute("GetKomentarForProduk", new { produkId, id = komentarToReturn.Id }, komentarToReturn);
        }
    }
}
