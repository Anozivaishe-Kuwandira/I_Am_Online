using System.ComponentModel.DataAnnotations;

namespace api.Models
{
public class Event
{
    public int EventId { get; set; }
    public string? EventName { get; set; }
    public DateTime? Date { get; set; }
    public string? Description { get; set; }
}

}