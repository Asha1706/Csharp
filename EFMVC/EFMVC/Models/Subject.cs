using System.ComponentModel.DataAnnotations;

namespace EFMVC.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        [Required]
        public string SubjectName { get; set; }
        public List<Teacher> SubjectTeacher { get; set; }= new List<Teacher>();

    }
}
