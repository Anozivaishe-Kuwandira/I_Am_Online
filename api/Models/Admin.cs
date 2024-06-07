using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Admin : Staff
{
    public string? Department { get; set; }
    // Other specific properties for administrative staff
}
}