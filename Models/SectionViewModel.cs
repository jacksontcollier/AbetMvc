using AbetMvc.Areas.Identity.Data;

namespace AbetMvc.Models;

public class SectionViewModel
{
    public Course? Course { get; set; }
    public Instructor? Instructor { get; set; }
    public Section? Section { get; set; }
    public string SemesterString { get; set; }

    public SectionViewModel(Section section)
    {
        this.Section = section;
        this.Course = section.Course;
        this.Instructor = section.Instructor;

        if (section.Semester == Semester.Fall)
        {
            SemesterString = "Fall";
        }
        else if (section.Semester == Semester.Spring)
        {
            SemesterString = "Spring";
        }
        else
        {
            SemesterString = "Summer";
        }
    }
}