// AssessmentId, INt Primary Key
// SectionId, foreign key into Section
// OutcomeId, foreign key into Outcome
// Major, Enum
// Assessment Description, TEXT
// Weight, INT

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbetMvc.Models;
public class Assessment
{
    public int Id { get; set; }

    public Section? Section { get; set; }

    public Outcome? Outcome { get; set; }

    public Major Major { get; set; }

    public string? Description { get; set; }

    public int Weight { get; set; }

}