using AbetMvc.Areas.Identity.Data;

namespace AbetMvc.Models;

public enum Semester
{
    Fall, Spring, Summer
}

public class Section
{
    public int Id { get; set; }

    public Instructor? Instructor { get; set; }

    public Course? Course { get; set; }

    public Semester? Semester { get; set; }

    public int? Year { get; set; }
}