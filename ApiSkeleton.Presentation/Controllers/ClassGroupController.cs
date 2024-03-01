using Microsoft.AspNetCore.Mvc;
using Service.Contracts.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ApiSkeleton.Presentation.Controllers
{
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
            var classGroups = _service.GroupClassService.GetAllClassGroups(trackChanges: false);
            return Ok(classGroups);
        }

        [HttpPost("printIni")]
        public IActionResult PrintThis(string Ini)
        {
            Console.WriteLine(Ini);
            return Ok();
        }

        [HttpGet("{classGroupId:guid}")]
        public IActionResult GetClassGroup(Guid classGroupId)
        {
            var classGroup = _service.GroupClassService.GetClassGroupById(classGroupId, trackChanges: false);
            return Ok(classGroup);
        }
    }
}
