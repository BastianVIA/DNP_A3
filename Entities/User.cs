using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    [Serializable]
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public int SecurityLevel { get; set; } 
        [Required]
        public string Password { get; set; }
    }
}