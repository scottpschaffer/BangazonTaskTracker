using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BangazonTaskTracker.Models
{
    public class Task1
    {
        [Key]
        public virtual int Id { get; set; }
        [Required]
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        [Required]
        public virtual TaskStatus Status { get; set; }
        public virtual DateTime? CompletedOn { get; set; }
    }
    public enum TaskStatus
    {
        ToDo,
        InProgress,
        Complete
    };
}