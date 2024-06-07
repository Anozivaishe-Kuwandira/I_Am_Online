using System.ComponentModel.DataAnnotations;

namespace api.Models
{
public class Teacher : Staff
{
    public string? Subject { get; set; }

    // Navigation property

        public ICollection<Class> Classes { get; set; } = new List<Class>();  // Initialize with empty collection
        public ICollection<Course> Courses { get; set; } = new List<Course>();  // Initialize with empty collection
}

}