using System.ComponentModel.DataAnnotations;

namespace Annotations
{
    public class Data
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Name { get; set; }

    }
}
