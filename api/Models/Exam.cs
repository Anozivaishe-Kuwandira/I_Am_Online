
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
public class Exam
{
    public int ExamId { get; set; }
    public string? ExamType { get; set; }
    public DateTime? Date { get; set; }
    public int ClassId { get; set; }

    // Navigation property
    public Class? Class { get; set; }
}

}