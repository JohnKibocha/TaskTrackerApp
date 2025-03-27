namespace TaskTrackerApp.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Status
{
    public int StatusId { get; set; }

    [Required]
    [Column(TypeName = "TEXT")]
    public string StatusName { get; set; } = "";

    public ICollection<Task>? Tasks { get; set; }
}