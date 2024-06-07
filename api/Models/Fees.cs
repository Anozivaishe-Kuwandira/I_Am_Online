using System.ComponentModel.DataAnnotations;

namespace api.Models
{
public class Fee
{
    public int FeeId { get; set; }
    public int? StudentId { get; set; }
    public decimal? Amount { get; set; }
    public DateTime DatePaid { get; set; }

    // Navigation property
    public Student? Student { get; set; }
}


}