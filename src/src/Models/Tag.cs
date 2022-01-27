using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebCourseRepo.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Tag : Entity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string? Description { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue(0)]
        public int Popularity { get; set; }

        public Status? Status { get; set; }
    }
}
