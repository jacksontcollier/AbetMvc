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
            Instructor samAdams = 
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
}