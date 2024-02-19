using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbetMvc.Areas.Identity.Data;
using AbetMvc.Data;
using System;
using System.Linq;

namespace AbetMvc.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new AbetMvcDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<AbetMvcDbContext>>()
        ))
        {
            // George Washington User
            Instructor georgeWashington = 
            CreateInstructorIfNotExist(
                context,
                "George", "Washington", "gwashington", "GWASHINGTON",
                "gwashington@fakemail.com", "GWASHINGTON@FAKEMAIL.COM",
                "georgeP@$$123"
            );

            // Benjamin Franklin User
            Instructor benjaminFranklin = 
            CreateInstructorIfNotExist(
                context,
                "Benjamin", "Franklin", "bfranklin", "BFRANKLIN",
                "bfranklin@fakemail.com", "BFRANKLIN@FAKEMAIL.COM",
                "benjaminP@$$123"
            ) ;

            // John Adams User
            Instructor johnAdams = 
            CreateInstructorIfNotExist(
                context,
                "John", "Adams", "jadams", "JADAMS",
                "jadams@fakemail.com", "JADAMS@FAKEMAIL.COM",
                "johnP@$$123"
            );

            // Thomas Jefferson User
            Instructor thomasJefferson = 
            CreateInstructorIfNotExist(
                context,
                "Thomas", "Jefferson", "tjefferson", "TJEFFERSON",
                "tjefferson@fakemail.com", "TJEFFERSON@FAKEMAIL.COM",
                "thomasP@$$123"
            );

            // Samuel Adams User
            Instructor samuelAdams = 
            CreateInstructorIfNotExist(
                context,
                "Samuel", "Adams", "sadams", "SADAMS",
                "sadams@fakemail.com", "SADAMS@FAKEMAIL.COM",
                "samuelP@$$123"
            );

            // Henry Knox User
            Instructor henryKnox = 
            CreateInstructorIfNotExist(
                context,
                "Henry", "Knox", "hknox", "HKNOX",
                "hknox@fakemail.com", "HKNOX@FAKEMAIL.COM",
                "henryP@$$123"
            );

            // Create Courses
            Course algorithmAnalysis = 
            CreateCourseIfNotExist(context, "COSC 312", "Algorithm Analysis and Automata");

            Course softwareEngineering = 
            CreateCourseIfNotExist(context, "COSC 340", "Software Engineering");

            Course systemsProgramming = 
            CreateCourseIfNotExist(context, "COSC 360", "Systems Programming");

            Course programmingLanguages = 
            CreateCourseIfNotExist(context, "COSC 365", "Programming Languages and Systems");

            Course csJuniorSeminar = 
            CreateCourseIfNotExist(context, "COSC 395", "Junior Seminar");

            Course csDesignPracticum = 
            CreateCourseIfNotExist(context, "COSC 402", "Senior Design Practicum");

            Course introLogicDesign = 
            CreateCourseIfNotExist(context, "ECE 255", "Introduction to Logic Design of Digital Systems");

            Course computerInterfaces = 
            CreateCourseIfNotExist(context, "ECE 256", "Computer System Interfaces");

            Course signalsAndSystems = 
            CreateCourseIfNotExist(context, "ECE 315", "Signals and Systems 1");

            Course electricEnergy =
            CreateCourseIfNotExist(context, "ECE 325", "Electric Energy System Components");

            Course electronicDevices = 
            CreateCourseIfNotExist(context, "ECE 335", "Electronic Devices");

            Course fundamentalsCommunications = 
            CreateCourseIfNotExist(context, "ECE 342", "Fundamentals of Communications");

            Course digitalSystemsDesign = 
            CreateCourseIfNotExist(context, "ECE 351", "Digital Systems Design");

            Course eceJuniorSeminar =
            CreateCourseIfNotExist(context, "ECE 395", "Junior Seminar");

            Course eceDesignPracticum = 
            CreateCourseIfNotExist(context, "ECE 402", "Senior Design Practicum");


            // George Washington Sections
            CreateSectionIfNotExist(context, georgeWashington, algorithmAnalysis, Semester.Spring, 2019);
            CreateSectionIfNotExist(context, georgeWashington, algorithmAnalysis, Semester.Fall, 2019);
            CreateSectionIfNotExist(context, georgeWashington, systemsProgramming, Semester.Spring, 2020);
            CreateSectionIfNotExist(context, georgeWashington, csDesignPracticum, Semester.Spring, 2020);

            // Benjamin Franklin Sections
            CreateSectionIfNotExist(context, benjaminFranklin, algorithmAnalysis, Semester.Spring, 2018);
            CreateSectionIfNotExist(context, benjaminFranklin, softwareEngineering, Semester.Spring, 2019);
            CreateSectionIfNotExist(context, benjaminFranklin, systemsProgramming, Semester.Spring, 2020);
            CreateSectionIfNotExist(context, benjaminFranklin, csDesignPracticum, Semester.Spring, 2019);

            // John Adams User
            CreateSectionIfNotExist(context, johnAdams , softwareEngineering, Semester.Spring, 2019);
            CreateSectionIfNotExist(context, johnAdams , systemsProgramming, Semester.Spring, 2019);
            CreateSectionIfNotExist(context, johnAdams , systemsProgramming, Semester.Fall, 2019);
            CreateSectionIfNotExist(context, johnAdams , csJuniorSeminar, Semester.Fall, 2020);

            // Thomas Jefferson User
            CreateSectionIfNotExist(context,  thomasJefferson, introLogicDesign, Semester.Spring, 2019);
            CreateSectionIfNotExist(context,  thomasJefferson, computerInterfaces, Semester.Spring, 2019);
            CreateSectionIfNotExist(context,  thomasJefferson, electronicDevices, Semester.Fall, 2019);
            CreateSectionIfNotExist(context,  thomasJefferson, fundamentalsCommunications, Semester.Fall, 2020);
            CreateSectionIfNotExist(context,  thomasJefferson, digitalSystemsDesign, Semester.Spring, 2020);

            // Samuel Adams User
            CreateSectionIfNotExist(context, samuelAdams, signalsAndSystems, Semester.Spring, 2019);
            CreateSectionIfNotExist(context, samuelAdams, signalsAndSystems, Semester.Fall, 2019);
            CreateSectionIfNotExist(context, samuelAdams, electricEnergy, Semester.Spring, 2020);
            CreateSectionIfNotExist(context, samuelAdams, fundamentalsCommunications, Semester.Spring, 2020);
            CreateSectionIfNotExist(context, samuelAdams, eceDesignPracticum, Semester.Fall, 2020);
            CreateSectionIfNotExist(context, samuelAdams, eceJuniorSeminar, Semester.Fall, 2020);

            // Henry Knox User
            CreateSectionIfNotExist(context, henryKnox, introLogicDesign, Semester.Fall, 2019);
            CreateSectionIfNotExist(context, henryKnox, introLogicDesign, Semester.Fall, 2020);
            CreateSectionIfNotExist(context, henryKnox, computerInterfaces, Semester.Fall, 2020);
            CreateSectionIfNotExist(context, henryKnox, electronicDevices, Semester.Spring, 2019);
            CreateSectionIfNotExist(context, henryKnox, fundamentalsCommunications, Semester.Spring, 2020);
            CreateSectionIfNotExist(context, henryKnox, digitalSystemsDesign, Semester.Fall, 2019);

            // CS Outcomes
            CreateOutcomeIfNotExist(context, 1, Major.CS,
                "Analyze a complex computing problem and to apply principles of computing " +
                "and other relevant disciplines to identify solutions");
            CreateOutcomeIfNotExist(context, 2, Major.CS,
                "Design, implement, and evaluate a computing-based solution to meet a " +
                "given set of computing requirements in the context of the program\'s " +
                "discipline");
            CreateOutcomeIfNotExist(context, 3, Major.CS,
                "Communicate effectively in a variety of professional contexts");
            CreateOutcomeIfNotExist(context, 4, Major.CS,
                "Recognize professional responsibilities and make informed judgements in " +
                "computing practice based on legal and ethical principles");
            CreateOutcomeIfNotExist(context, 5, Major.CS,
                "Function effectively as a member or leader of a team engaged in " +
                "activities appropriate to the program's discipline");
            CreateOutcomeIfNotExist(context, 6, Major.CS,
                "Apply computer science theory and software development fundamentals to " +
                "produce computing-based solutions");

            // EE Outcomes
            CreateOutcomeIfNotExist(context, 1, Major.EE,
                "An ability to identify, formulate, and solve complex engineering problems " +
                "by applying principles of engineering, science, and mathematics");
            CreateOutcomeIfNotExist(context, 2, Major.EE,
                "An ability to apply engineering design to produce solutions that meet " +
                "specified needs with consideration of public health, safety, and welfare, " +
                "as well as global, cultural, social, environmental, and economic factors");
            CreateOutcomeIfNotExist(context, 3, Major.EE, 
                "An ability to communicate effectively with a range of audiences");
            CreateOutcomeIfNotExist(context, 4, Major.EE, 
                "An ability to recognize ethical and professional responsibilities in " +
                "engineering situations and make informed judgements, which must consider " +
                "the impact of engineering solutions in global, economic, environmental, " +
                "and societal contexts" );
            CreateOutcomeIfNotExist(context, 5, Major.EE, 
                "An ability to function effectively on a team whose members together " +
                "provide leadership, create a collaborative and inclusive environment, " +
                "establish goals, plan tasks, and meet objectives");
            CreateOutcomeIfNotExist(context, 6, Major.EE,
                "An ability to develop and conduct appropriate experimentation, analyze " +
                "and interpret data, and use engineering judgement to draw conclusions");
            CreateOutcomeIfNotExist(context, 7, Major.EE,
                "An ability to acquire and apply new knowledge as needed, using appropriate " +
                "learning strategies");

            // CpE Outcomes
            CreateOutcomeIfNotExist(context, 1, Major.CpE,
                "An ability to identify, formulate, and solve complex engineering problems " +
                "by applying principles of engineering, science, and mathematics");
            CreateOutcomeIfNotExist(context, 2, Major.CpE,
                "An ability to apply engineering design to produce solutions that meet " +
                "specified needs with consideration of public health, safety, and welfare, " +
                "as well as global, cultural, social, environmental, and economic factors");
            CreateOutcomeIfNotExist(context, 3, Major.CpE,
                "An ability to communicate effectively with a range of audiences");
            CreateOutcomeIfNotExist(context, 4, Major.CpE,
                "An ability to recognize ethical and professional responsibilities in " +
                "engineering situations and make informed judgements, which must consider " +
                "the impact of engineering solutions in global, economic, environmental, " +
                "and societal contexts");
            CreateOutcomeIfNotExist(context, 5, Major.CpE,
                "An ability to function effectively on a team whose members together " +
                "provide leadership, create a collaborative and inclusive environment, " +
                "establish goals, plan tasks, and meet objectives");
            CreateOutcomeIfNotExist(context, 6, Major.CpE,
                "An ability to develop and conduct appropriate experimentation, analyze " +
                "and interpret data, and use engineering judgement to draw conclusions");
            CreateOutcomeIfNotExist(context, 7, Major.CpE,
                "An ability to acquire and apply new knowledge as needed, using appropriate " +
                "learning strategies");
        }
    }

    public static Instructor CreateInstructorIfNotExist(AbetMvcDbContext dbContext,
        string firstName, string lastName, string userName,
        string normalizedUserName, string email, string normalizedEmail,
        string password)
    {
        IEnumerable<Instructor> instructorQuery = dbContext.Users.Where(u => u.UserName == userName);

        // Don't create the user if they already exist in the database
        if (instructorQuery.Any())
        {
            return instructorQuery.First();
        }

        IUserStore<Instructor> userStore;

        userStore = new UserStore<Instructor>(dbContext);

        var instructor = Activator.CreateInstance<Instructor>();
        instructor.FirstName = firstName;
        instructor.LastName = lastName;
        instructor.UserName = userName;
        instructor.NormalizedUserName = normalizedUserName;
        instructor.Email = email;
        instructor.NormalizedEmail = normalizedEmail;
        
        PasswordHasher<Instructor> hasher = new PasswordHasher<Instructor>();
        instructor.PasswordHash = hasher.HashPassword(
            instructor,
            password
        );
        
        var result = userStore.CreateAsync(instructor, CancellationToken.None);
        result.Wait();

        return instructor;
    }

    public static Course CreateCourseIfNotExist(AbetMvcDbContext dbContext,
            string courseId, string courseTitle)
    {
        IEnumerable<Course> courseQuery = dbContext.Courses.Where(c => c.Id == courseId);

        // Don't create the course if it already exists in the database
        if (courseQuery.Any())
        {
            return courseQuery.First();
        }

        Course course = new Course{Id=courseId, Title=courseTitle};
        dbContext.Courses.Add(course); 
        dbContext.SaveChanges();

        return course;
    }

    public static void CreateSectionIfNotExist(AbetMvcDbContext dbContext,
            Instructor instructor, Course course, Semester semester, int year)
    {
        if (dbContext.Sections.Where(s => ( (s.Instructor == instructor) &&
            (s.Course == course) && (s.Semester == semester)) ).Any())
        {
            return;
        }

        Section section = new Section{Instructor=instructor,Course=course,Semester=semester,Year=year};
        dbContext.Sections.Add(section);
        dbContext.SaveChanges();
    }

    public static void CreateOutcomeIfNotExist(AbetMvcDbContext dbContext, int outcomeNumber, Major outcomeMajor,
            string outcomeDescription)
    {
        if (dbContext.Outcomes.Where(o => ( ( o.Number == outcomeNumber)
            && ( o.Major == outcomeMajor ) ) ).Any() )
        {
            return;
        }

        Outcome outcome = new Outcome{Number=outcomeNumber,Major=outcomeMajor,Description=outcomeDescription};
        dbContext.Outcomes.Add(outcome);
        dbContext.SaveChanges();
    }
}