using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskTrackerApp.Models
{
    public class Status
    {
        public int StatusId { get; set; }

        [Required(ErrorMessage = "Status name is required.")]
        [MaxLength(50, ErrorMessage = "Status name cannot exceed 50 characters.")]
        [Display(Name = "Status")]
        [Column(TypeName = "TEXT")]
        public string StatusName { get; set; } = "";

        public ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}