using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ClassMember
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Class member name is required field")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 Characters")]
        public string? Name { get; set; }

        [ForeignKey(nameof(ClassGroup))]
        public Guid ClassGroupId { get; set; }

        public ClassGroup? ClassGroup { get; set; }
    }
}
