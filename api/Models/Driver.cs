using System.ComponentModel.DataAnnotations;

namespace api.Models
{
public class Driver : Staff
{
    public string? LicenseNumber { get; set; }
    public ICollection<Transport> Transports { get; set; }  = new List<Transport>(); 
}
}