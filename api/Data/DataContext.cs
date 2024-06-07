using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Assignment> Assignment { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<Fee> Fee { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Hostel> Hostel { get; set; }
        public DbSet<Library> Library { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Transport> Transport { get; set; }

    }
}
