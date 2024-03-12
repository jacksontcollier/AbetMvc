using AbetMvc.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using AbetMvc.Models;

namespace AbetMvc.Data;

public class AbetMvcDbContext : IdentityDbContext<Instructor>
{
    public AbetMvcDbContext(DbContextOptions<AbetMvcDbContext> options)
        : base(options)
    {
    }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Section> Sections { get; set; }

    public DbSet<Outcome> Outcomes { get; set; }

    public DbSet<OutcomeResult> OutcomeResults { get; set; }

    public DbSet<CourseOutcomeMapping> CourseOutcomeMappings { get; set; }

    public DbSet<Assessment> Assessments { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        this.SeedUsers(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    private void SeedUsers(ModelBuilder builder)
    {
        Instructor instructor = new Instructor()
        {
            UserName = "gwashington",
            Email = "gwashington@fakemail.com",
            LockoutEnabled = false,
            PhoneNumber = "1234567890"
        };

        PasswordHasher<Instructor> passwordHasher = new PasswordHasher<Instructor>();
        passwordHasher.HashPassword(instructor, "gwashpass");
        builder.Entity<Instructor>().HasData(instructor);
    }
}
