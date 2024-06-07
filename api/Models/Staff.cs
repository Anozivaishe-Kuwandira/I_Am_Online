
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
public class Staff
{
    public int StaffId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Position { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Gender { get; set; }
}

}