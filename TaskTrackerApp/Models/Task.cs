using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace TaskTrackerApp.Models
{
    public class Task
    {
        public int TaskId { get; set; }

        private string _title = "";
        [Required(ErrorMessage = "Title is required.")]
        [MaxLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        [Display(Name = "Task Title")]
        public string Title
        {
            get => _title;
            set => _title = value?.Trim() ?? "";
        }

        private string _description = "";
        [Required(ErrorMessage = "Description is required.")]
        [MaxLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        [Display(Name = "Task Description")]
        public string Description
        {
            get => _description;
            set => _description = value?.Trim() ?? "";
        }

        [Required(ErrorMessage = "Due Date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Due Date")]
        [FutureDate(ErrorMessage = "Due Date must be in the future.")]
        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Priority is required.")]
        [Range(1, 5, ErrorMessage = "Priority must be between 1 (low) and 5 (high).")]
        public int Priority { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        [Display(Name = "Task Status")]
        public int StatusId { get; set; }

        public Status? Status { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [NotMapped]
        public string Slug => Regex.Replace(Title.ToLower().Trim(), @"[^a-z0-9]+", "-").Trim('-');
    }

    // Custom validation attribute to ensure DueDate is in the future
    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is DateTime dateValue)
            {
                return dateValue.Date > DateTime.Now.Date;
            }
            return false;
        }
    }
}
