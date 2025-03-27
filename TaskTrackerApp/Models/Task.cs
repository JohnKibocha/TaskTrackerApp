namespace TaskTrackerApp.Models;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Task
{
    public int TaskId { get; set; }

    [Required]
    [Column(TypeName = "TEXT")]
    public string Title { get; set; } = "";

    [Required]
    [Column(TypeName = "TEXT")]
    public string Description { get; set; } = "";

    [Required]
    [DataType(DataType.Date)]
    [Display(Name = "Due Date")]
    public DateTime DueDate { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Priority must be greater than zero.")]
    public int Priority { get; set; }

    [Required]
    public int StatusId { get; set; }

    public Status? Status { get; set; }

    public DateTime DateCreated { get; set; } = DateTime.Now;

    [NotMapped]
    public string Slug => Title.Replace(" ", "-").ToLower();
}