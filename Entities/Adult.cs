using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Serializable]
    public class Adult : Person
    {   
        // [ForeignKey("JobFK")]
        public Job JobTitle { get; set; }
    }
}