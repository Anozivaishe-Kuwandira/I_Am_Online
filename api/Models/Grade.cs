using System.ComponentModel.DataAnnotations;

namespace api.Models
{
public class Grade
{
    public int GradeId { get; set; }
    public int StudentId { get; set; }
    public int SubjectId { get; set; }
    public double? Score { get; set; }

    // Navigation property
    public Student? Student { get; set; }
    public Subject? Subject { get; set; }
}


}