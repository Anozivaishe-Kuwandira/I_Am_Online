using System.ComponentModel.DataAnnotations;

namespace api.Models
{
public class Subject
{
    public int SubjectId { get; set; }
    public string? SubjectName { get; set; }
    public int CourseId { get; set; }
    public int ClassId { get; set; }

    // Navigation property
    public Course? Course { get; set; }
    public Class? Class { get; set; }
    public ICollection<Grade> Grades { get; set; }  = new List<Grade>(); 
}

}
