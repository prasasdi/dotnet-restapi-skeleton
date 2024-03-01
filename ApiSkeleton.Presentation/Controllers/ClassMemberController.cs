using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Service.Contracts.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSkeleton.Presentation.Controllers
{
    [Route("api/kelas/{classGroupId}/anggota")]
    [ApiController]
    public class ClassMemberController  : ControllerBase
    {
        private readonly IServiceManager _service;
        public ClassMemberController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetClassMembersForClassGroup(Guid classGroupId)
        {
            var classMembers = _service.ClassMemberService.GetClassMembers(classGroupId, false);
            return Ok(classMembers);
        }

        [HttpGet("{classMemberId:guid}")]
        public IActionResult GetClassMemberForClassGroup(Guid classGroupId, Guid classMemberId)
        {
            var classMember = _service.ClassMemberService.GetClassMember(classGroupId, classMemberId, false);
            return Ok(classMember);
        }
    }
}
