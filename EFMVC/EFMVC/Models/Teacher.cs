using System.ComponentModel.DataAnnotations;

namespace EFMVC.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [Required]
        public string TeacherName { get; set; }
        public int TeacherAge { get; set;}
        [Required]
        public string TeacherAddress { get; set; }
        public List<Subject> TeacherSubject { get; set; }=new List<Subject>();
    }
}
