using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbetMvc.Models;

public enum PerformanceLevel
{
    NotMeetsExpectations,
    MeetsExpectations,
    ExceedsExpectations
}

[Index(nameof(SectionId), nameof(OutcomeId), nameof(PerformanceLevel), nameof(Major), IsUnique=true)]
public class OutcomeResult
{
    public int Id { get; set; }

    public Section? Section { get; set; }

    [ForeignKey(nameof(Section))]
    public int? SectionId { get; set; }

    public Outcome? Outcome { get; set; }

    [ForeignKey(nameof(Outcome))]
    public int? OutcomeId { get; set; }

    public Major Major { get; set; }

    public PerformanceLevel PerformanceLevel { get; set; }

    public Int16 NumberOfStudents { get; set; }

}