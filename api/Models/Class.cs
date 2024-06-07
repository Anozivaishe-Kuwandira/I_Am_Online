using System.ComponentModel.DataAnnotations;

namespace api.Models
{
public class Class
{
    public int ClassId { get; set; }
    public string? ClassName { get; set; }
    public int? GradeLevel { get; set; }
    public int TeacherId { get; set; }

    // Navigation property
    public Teacher? Teacher { get; set; }
    public ICollection<Student> Students { get; set; }  = new List<Student>(); 
    public ICollection<Subject> Subjects { get; set; }  = new List<Subject>(); 
}


}