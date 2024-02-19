using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbetMvc.Models;

public class CourseOutcomeMapping
{
    public int Id { get; set; }

    public Course? Course { get; set; }

    public Outcome? Outcome { get; set; }

    public Major? Major { get; set; }

    public Semester? Semester { get; set; }

    public int? Year { get; set; }

}