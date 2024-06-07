using System.ComponentModel.DataAnnotations;

namespace api.Models
{
public class Course
{
    public int CourseId { get; set; }
    public string? CourseName { get; set; }
    public string? Description { get; set; }
    public int TeacherId { get; set; }

    // Navigation property
    public Teacher? Teacher { get; set; }
    public ICollection<Subject> Subjects { get; set; }  = new List<Subject>(); 
}

}