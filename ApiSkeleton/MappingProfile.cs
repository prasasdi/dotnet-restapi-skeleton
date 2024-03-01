using AutoMapper;
using Entities.Models;
using Shared.DataTransferableObject;

namespace ApiSkeleton
{
    public class MappingProfile : Profile
    {
        // Tambah profile mapping untuk menyederhanakan
        public MappingProfile() 
        {
            // contoh 1 on 1, gada yang dikasih perintah tambahan jadi begini aja
            CreateMap<ClassGroup, ClassGroupDto>();
            CreateMap<ClassMember, ClassMemberDto>();
        }
    }
}
