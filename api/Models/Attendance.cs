using System.ComponentModel.DataAnnotations;

namespace api.Models
{
public class Attendance
{
    public int AttendanceId { get; set; }
    public int StudentId { get; set; }
    public DateTime? Date { get; set; }
    public bool IsPresent { get; set; }

    // Navigation property
    public Student? Student { get; set; }
}

}