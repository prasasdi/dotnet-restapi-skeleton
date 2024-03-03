using Microsoft.AspNetCore.Mvc;
using Service.Contracts.Manager;
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
        public IActionResult GetAllKomentarByProdukId(Guid produkId)
        {
            var komentars = _service.KomentarService.GetAllKomentarByProductId(produkId, false);
            return Ok(komentars);
        }
    }
}
