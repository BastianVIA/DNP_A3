using System;
using System.ComponentModel.DataAnnotations;

namespace Entities {
    [Serializable]
public class Person {
    [Key]
    public int Id { get; set; }
    [Required, MaxLength(50)]
    public string FirstName { get; set; }
    [Required, MaxLength(50)]
    public string LastName { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    [Range(1,99, ErrorMessage = "The age must be between 1 and 99")]
    public int Age { get; set; }
    public float Weight { get; set; }
    public int Height { get; set; }
    public string Sex { get; set; }
}


}