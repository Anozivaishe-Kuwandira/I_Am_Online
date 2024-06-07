using System.ComponentModel.DataAnnotations;

namespace api.Models
{
public class Library
{
    public int LibraryId { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? ISBN { get; set; }
    public bool IsAvailable { get; set; }
}

}