using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class ClassGroup
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Group class name is required field")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 Characters")]
        public string? Name { get; set; }

        public ICollection<ClassMember> ClassMembers { get; set; }
    }
}
