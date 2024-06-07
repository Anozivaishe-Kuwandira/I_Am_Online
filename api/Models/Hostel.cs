using System.ComponentModel.DataAnnotations;

namespace api.Models
{
public class Hostel
{
    public int HostelId { get; set; }
    public string? HostelName { get; set; }
    public int? Capacity { get; set; }
    public ICollection<Student> Students { get; set; }  = new List<Student>(); 
}


}