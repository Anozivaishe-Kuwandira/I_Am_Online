using System.ComponentModel.DataAnnotations;

namespace api.Models
{
public class Transport
{
    public int TransportId { get; set; }
    public string? RouteName { get; set; }
    public string? BusNumber { get; set; }
    public int DriverId { get; set; }

    // Navigation property
    public Driver? Driver { get; set; }
}

}