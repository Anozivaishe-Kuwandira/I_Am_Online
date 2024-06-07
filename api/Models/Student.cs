using System.ComponentModel.DataAnnotations;

namespace api.Models
{
public class Student
{
    public int StudentId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Gender { get; set; }
    public int ClassId { get; set; }

    // Navigation property
    public Class? Class { get; set; }
    public ICollection<Grade> Grades { get; set; }  = new List<Grade>(); 
    public ICollection<Attendance> Attendances { get; set; }  = new List<Attendance>(); 
    public ICollection<Fee> Fees { get; set; }  = new List<Fee>(); 
}


}
