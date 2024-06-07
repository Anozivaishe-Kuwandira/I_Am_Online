using System.ComponentModel.DataAnnotations;

namespace api.Models
{
public class Assignment
{
    public int AssignmentId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime? DueDate { get; set; }
    public int ClassId { get; set; }

    // Navigation property
    public Class? Class { get; set; }
}


}