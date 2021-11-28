using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Serializable]
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Range(1, 1000000, ErrorMessage = "Salary must be atleast 1")]
        public int Salary { get; set; }
    }
}