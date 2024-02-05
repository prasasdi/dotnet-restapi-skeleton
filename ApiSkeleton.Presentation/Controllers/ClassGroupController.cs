using Microsoft.AspNetCore.Mvc;
using Service.Contracts.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSkeleton.Presentation.Controllers
{
    //Contoh route URL
    //[Route("api/[controller]")]

    [Route("api/kelas")]
    [ApiController]
    public class ClassGroupController : ControllerBase
    {
        private readonly IServiceManager _service;

        public ClassGroupController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetClassGroups()
        {
            try
            {
                var classGroups = _service.GroupClassService.GetAllClassGroups(trackChanges: false);

                return Ok(classGroups);
            }
            catch (Exception ex)
            {
                /**
                 * Hayoloooh, bukan cuman asal OK aja
                 * harus tau tujuan dari tiap respon code 
                 * 
                 * Jangan asal jeplah 500 doang ya
                 */
                return StatusCode(500, "Internal server error");
                throw;
            }
        }
    }
}
