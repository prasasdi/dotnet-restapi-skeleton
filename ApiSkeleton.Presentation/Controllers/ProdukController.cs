using Microsoft.AspNetCore.Mvc;
using Service.Contracts.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSkeleton.Presentation.Controllers
{
    [Route("api/produk")]
    [ApiController]
    public class ProdukController : ControllerBase
    {
        private readonly IServiceManager _service;
        public ProdukController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllProduks()
        {
            var produks = _service.ProdukService.GetAllProduks(false);
            return Ok(produks);
        }

        [HttpGet("id:guid")]
        public IActionResult GetProdukById(Guid id)
        {
            var produk = _service.ProdukService.GetProductById(id, false);
            return Ok(produk);
        }
    }
}
