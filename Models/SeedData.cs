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
            Section gwSection1 = CreateSectionIfNotExist(context,
                    georgeWashington, algorithmAnalysis, Semester.Spring, 2019);
            Section gwSection2 = CreateSectionIfNotExist(context,
                    georgeWashington, algorithmAnalysis, Semester.Fall, 2019);
            Section gwSection3 = CreateSectionIfNotExist(context,
                    georgeWashington, systemsProgramming, Semester.Spring,
                    2020);
            Section gwSection4 = CreateSectionIfNotExist(context,
                    georgeWashington, csDesignPracticum, Semester.Spring, 2020);

            // Benjamin Franklin Sections
            Section bfSection1 = CreateSectionIfNotExist(context,
                    benjaminFranklin, algorithmAnalysis, Semester.Spring, 2018);
            Section bfSection2 = CreateSectionIfNotExist(context,
                    benjaminFranklin, softwareEngineering, Semester.Spring, 2019);
            Section bfSection3 = CreateSectionIfNotExist(context,
                    benjaminFranklin, systemsProgramming, Semester.Spring, 2020);
            Section bfSection4 = CreateSectionIfNotExist(context,
                    benjaminFranklin, csDesignPracticum, Semester.Spring, 2019);

            // John Adams User
            Section jaSection1 = CreateSectionIfNotExist(context,
                    johnAdams, softwareEngineering, Semester.Spring, 2019);
            Section jaSection2 = CreateSectionIfNotExist(context,
                    johnAdams, systemsProgramming, Semester.Spring, 2019);
            Section jaSection3 = CreateSectionIfNotExist(context,
                    johnAdams, systemsProgramming, Semester.Fall, 2019);
            Section jaSection4 = CreateSectionIfNotExist(context,
                    johnAdams, csJuniorSeminar, Semester.Fall, 2020);

            // Thomas Jefferson User
            Section tjSection1 = CreateSectionIfNotExist(context,
                    thomasJefferson, introLogicDesign, Semester.Spring, 2019);
            Section tjSection2 = CreateSectionIfNotExist(context,
                    thomasJefferson, computerInterfaces, Semester.Spring, 2019);
            Section tjSection3 = CreateSectionIfNotExist(context,
                    thomasJefferson, electronicDevices, Semester.Fall, 2019);
            Section tjSection4 = CreateSectionIfNotExist(context,
                    thomasJefferson, fundamentalsCommunications, Semester.Fall, 2020);
            Section tjSection5 = CreateSectionIfNotExist(context,
                    thomasJefferson, digitalSystemsDesign, Semester.Spring, 2020);

            // Samuel Adams User
            Section saSection1 = CreateSectionIfNotExist(context,
                    samuelAdams, signalsAndSystems, Semester.Spring, 2019);
            Section saSection2 = CreateSectionIfNotExist(context,
                    samuelAdams, signalsAndSystems, Semester.Fall, 2019);
            Section saSection3 = CreateSectionIfNotExist(context,
                    samuelAdams, electricEnergy, Semester.Spring, 2020);
            Section saSection4 = CreateSectionIfNotExist(context,
                    samuelAdams, fundamentalsCommunications, Semester.Spring, 2020);
            Section saSection5 = CreateSectionIfNotExist(context,
                    samuelAdams, eceDesignPracticum, Semester.Fall, 2020);
            Section saSection6 = CreateSectionIfNotExist(context,
                    samuelAdams, eceJuniorSeminar, Semester.Fall, 2020);

            // Henry Knox User
            Section hkSection1 = CreateSectionIfNotExist(context,
                    henryKnox, introLogicDesign, Semester.Fall, 2019);
            Section hkSection2 = CreateSectionIfNotExist(context,
                    henryKnox, introLogicDesign, Semester.Fall, 2020);
            Section hkSection3 = CreateSectionIfNotExist(context,
                    henryKnox, computerInterfaces, Semester.Fall, 2020);
            Section hkSection4 = CreateSectionIfNotExist(context,
                    henryKnox, electronicDevices, Semester.Spring, 2019);
            Section hkSection5 = CreateSectionIfNotExist(context,
                    henryKnox, fundamentalsCommunications, Semester.Spring, 2020);
            Section hkSection6 = CreateSectionIfNotExist(context,
                    henryKnox, digitalSystemsDesign, Semester.Fall, 2019);

            // CS Outcomes
            Outcome csOutcome1 = CreateOutcomeIfNotExist(context, 1, Major.CS,
                "Analyze a complex computing problem and to apply principles of computing " +
                "and other relevant disciplines to identify solutions");
            Outcome csOutcome2 = CreateOutcomeIfNotExist(context, 2, Major.CS,
                "Design, implement, and evaluate a computing-based solution to meet a " +
                "given set of computing requirements in the context of the program\'s " +
                "discipline");
            Outcome csOutcome3 = CreateOutcomeIfNotExist(context, 3, Major.CS,
                "Communicate effectively in a variety of professional contexts");
            Outcome csOutcome4 = CreateOutcomeIfNotExist(context, 4, Major.CS,
                "Recognize professional responsibilities and make informed judgements in " +
                "computing practice based on legal and ethical principles");
            Outcome csOutcome5 = CreateOutcomeIfNotExist(context, 5, Major.CS,
                "Function effectively as a member or leader of a team engaged in " +
                "activities appropriate to the program's discipline");
            Outcome csOutcome6 = CreateOutcomeIfNotExist(context, 6, Major.CS,
                "Apply computer science theory and software development fundamentals to " +
                "produce computing-based solutions");

            // EE Outcomes
            Outcome eeOutcome1 = CreateOutcomeIfNotExist(context, 1, Major.EE,
                "An ability to identify, formulate, and solve complex engineering problems " +
                "by applying principles of engineering, science, and mathematics");
            Outcome eeOutcome2 = CreateOutcomeIfNotExist(context, 2, Major.EE,
                "An ability to apply engineering design to produce solutions that meet " +
                "specified needs with consideration of public health, safety, and welfare, " +
                "as well as global, cultural, social, environmental, and economic factors");
            Outcome eeOutcome3 = CreateOutcomeIfNotExist(context, 3, Major.EE, 
                "An ability to communicate effectively with a range of audiences");
            Outcome eeOutcome4 = CreateOutcomeIfNotExist(context, 4, Major.EE, 
                "An ability to recognize ethical and professional responsibilities in " +
                "engineering situations and make informed judgements, which must consider " +
                "the impact of engineering solutions in global, economic, environmental, " +
                "and societal contexts" );
            Outcome eeOutcome5 = CreateOutcomeIfNotExist(context, 5, Major.EE, 
                "An ability to function effectively on a team whose members together " +
                "provide leadership, create a collaborative and inclusive environment, " +
                "establish goals, plan tasks, and meet objectives");
            Outcome eeOutcome6 = CreateOutcomeIfNotExist(context, 6, Major.EE,
                "An ability to develop and conduct appropriate experimentation, analyze " +
                "and interpret data, and use engineering judgement to draw conclusions");
            Outcome eeOutcome7 = CreateOutcomeIfNotExist(context, 7, Major.EE,
                "An ability to acquire and apply new knowledge as needed, using appropriate " +
                "learning strategies");

            // CpE Outcomes
            Outcome cpeOutcome1 = CreateOutcomeIfNotExist(context, 1, Major.CpE,
                "An ability to identify, formulate, and solve complex engineering problems " +
                "by applying principles of engineering, science, and mathematics");
            Outcome cpeOutcome2 = CreateOutcomeIfNotExist(context, 2, Major.CpE,
                "An ability to apply engineering design to produce solutions that meet " +
                "specified needs with consideration of public health, safety, and welfare, " +
                "as well as global, cultural, social, environmental, and economic factors");
            Outcome cpeOutcome3 = CreateOutcomeIfNotExist(context, 3, Major.CpE,
                "An ability to communicate effectively with a range of audiences");
            Outcome cpeOutcome4 = CreateOutcomeIfNotExist(context, 4, Major.CpE,
                "An ability to recognize ethical and professional responsibilities in " +
                "engineering situations and make informed judgements, which must consider " +
                "the impact of engineering solutions in global, economic, environmental, " +
                "and societal contexts");
            Outcome cpeOutcome5 = CreateOutcomeIfNotExist(context, 5, Major.CpE,
                "An ability to function effectively on a team whose members together " +
                "provide leadership, create a collaborative and inclusive environment, " +
                "establish goals, plan tasks, and meet objectives");
            Outcome cpeOutcome6 = CreateOutcomeIfNotExist(context, 6, Major.CpE,
                "An ability to develop and conduct appropriate experimentation, analyze " +
                "and interpret data, and use engineering judgement to draw conclusions");
            Outcome cpeOutcome7 = CreateOutcomeIfNotExist(context, 7, Major.CpE,
                "An ability to acquire and apply new knowledge as needed, using appropriate " +
                "learning strategies");

            // Outcome Results for CS, George Washington's First Section
            CreateOutcomeResultIfNotExist(context, gwSection1, csOutcome1, Major.CS,
                PerformanceLevel.NotMeetsExpectations, 10);
            CreateOutcomeResultIfNotExist(context, gwSection1, csOutcome1, Major.CS,
                PerformanceLevel.MeetsExpectations, 30);
            CreateOutcomeResultIfNotExist(context, gwSection1, csOutcome1, Major.CS,
                PerformanceLevel.ExceedsExpectations, 40);
            CreateOutcomeResultIfNotExist(context, gwSection1, csOutcome2, Major.CS,
                PerformanceLevel.NotMeetsExpectations, 40);
            CreateOutcomeResultIfNotExist(context, gwSection1, csOutcome2, Major.CS,
                PerformanceLevel.MeetsExpectations, 30);
            CreateOutcomeResultIfNotExist(context, gwSection1, csOutcome2, Major.CS,
                PerformanceLevel.ExceedsExpectations, 10);
            CreateOutcomeResultIfNotExist(context, gwSection1, csOutcome3, Major.CS,
                PerformanceLevel.NotMeetsExpectations, 16);
            CreateOutcomeResultIfNotExist(context, gwSection1, csOutcome3, Major.CS,
                PerformanceLevel.MeetsExpectations, 54);
            CreateOutcomeResultIfNotExist(context, gwSection1, csOutcome3, Major.CS,
                PerformanceLevel.ExceedsExpectations, 10);
   
            // Outcome Results for CS, George Washington's Second Section 
            CreateOutcomeResultIfNotExist(context, gwSection2, csOutcome1, Major.CS,
                PerformanceLevel.NotMeetsExpectations, 10);
            CreateOutcomeResultIfNotExist(context, gwSection2, csOutcome1, Major.CS,
                PerformanceLevel.MeetsExpectations, 20);
            CreateOutcomeResultIfNotExist(context, gwSection2, csOutcome1, Major.CS,
                PerformanceLevel.ExceedsExpectations, 30);
            CreateOutcomeResultIfNotExist(context, gwSection2, csOutcome2, Major.CS,
                PerformanceLevel.NotMeetsExpectations, 20);
            CreateOutcomeResultIfNotExist(context, gwSection2, csOutcome2, Major.CS,
                PerformanceLevel.MeetsExpectations, 30);
            CreateOutcomeResultIfNotExist(context, gwSection2, csOutcome2, Major.CS,
                PerformanceLevel.ExceedsExpectations, 10);

            // Outcome Results for CS, George Washington's Third Section
            CreateOutcomeResultIfNotExist(context, gwSection3, csOutcome2, Major.CS,
                PerformanceLevel.NotMeetsExpectations, 80);
            CreateOutcomeResultIfNotExist(context, gwSection3, csOutcome2, Major.CS,
                PerformanceLevel.MeetsExpectations, 30);
            CreateOutcomeResultIfNotExist(context, gwSection3, csOutcome2, Major.CS,
                PerformanceLevel.ExceedsExpectations, 60);

            // Outcome Results for CS, George Washington's Fourth Section
            CreateOutcomeResultIfNotExist(context, gwSection4, csOutcome1, Major.CS,
                PerformanceLevel.NotMeetsExpectations, 20);
            CreateOutcomeResultIfNotExist(context, gwSection4, csOutcome1, Major.CS,
                PerformanceLevel.MeetsExpectations, 50);
            CreateOutcomeResultIfNotExist(context, gwSection4, csOutcome1, Major.CS,
                PerformanceLevel.ExceedsExpectations, 70);
            CreateOutcomeResultIfNotExist(context, gwSection4, csOutcome2, Major.CS,
                PerformanceLevel.NotMeetsExpectations, 30);
            CreateOutcomeResultIfNotExist(context, gwSection4, csOutcome2, Major.CS,
                PerformanceLevel.MeetsExpectations, 60);
            CreateOutcomeResultIfNotExist(context, gwSection4, csOutcome2, Major.CS,
                PerformanceLevel.ExceedsExpectations, 50);
            CreateOutcomeResultIfNotExist(context, gwSection4, csOutcome3, Major.CS,
                PerformanceLevel.NotMeetsExpectations, 10);
            CreateOutcomeResultIfNotExist(context, gwSection4, csOutcome3, Major.CS,
                PerformanceLevel.MeetsExpectations, 80);
            CreateOutcomeResultIfNotExist(context, gwSection4, csOutcome3, Major.CS,
                PerformanceLevel.ExceedsExpectations, 50);

            // Outcome Results for CS, Benjamin Franklin's First Section
            CreateOutcomeResultIfNotExist(context, bfSection1, csOutcome1, Major.CS,
                PerformanceLevel.NotMeetsExpectations, 20);
            CreateOutcomeResultIfNotExist(context, bfSection1, csOutcome1, Major.CS,
                PerformanceLevel.MeetsExpectations, 40);
            CreateOutcomeResultIfNotExist(context, bfSection1, csOutcome1, Major.CS,
                PerformanceLevel.ExceedsExpectations, 30);
            CreateOutcomeResultIfNotExist(context, bfSection1, csOutcome2, Major.CS,
                PerformanceLevel.NotMeetsExpectations, 30);
            CreateOutcomeResultIfNotExist(context, bfSection1, csOutcome2, Major.CS,
                PerformanceLevel.MeetsExpectations, 40);
            CreateOutcomeResultIfNotExist(context, bfSection1, csOutcome2, Major.CS,
                PerformanceLevel.ExceedsExpectations, 20);
            CreateOutcomeResultIfNotExist(context, bfSection1, csOutcome3, Major.CS,
                PerformanceLevel.NotMeetsExpectations, 5);
            CreateOutcomeResultIfNotExist(context, bfSection1, csOutcome3, Major.CS,
                PerformanceLevel.MeetsExpectations, 55);
            CreateOutcomeResultIfNotExist(context, bfSection1, csOutcome3, Major.CS,
                PerformanceLevel.ExceedsExpectations, 30);

            // Outcome Results for CpE, Benjamin Franklin's Second Section
            CreateOutcomeResultIfNotExist(context, bfSection2, cpeOutcome1, Major.CpE,
                PerformanceLevel.NotMeetsExpectations, 20);
            CreateOutcomeResultIfNotExist(context, bfSection2, cpeOutcome1, Major.CpE,
                PerformanceLevel.MeetsExpectations, 10);
            CreateOutcomeResultIfNotExist(context, bfSection2, cpeOutcome1, Major.CpE,
                PerformanceLevel.ExceedsExpectations, 60);
            CreateOutcomeResultIfNotExist(context, bfSection2, cpeOutcome2, Major.CpE,
                PerformanceLevel.NotMeetsExpectations, 25);
            CreateOutcomeResultIfNotExist(context, bfSection2, cpeOutcome2, Major.CpE,
                PerformanceLevel.MeetsExpectations, 55);
            CreateOutcomeResultIfNotExist(context, bfSection2, cpeOutcome2, Major.CpE,
                PerformanceLevel.ExceedsExpectations, 10);

            // Outcome Results for EE, Sam Adam's First Section
            CreateOutcomeResultIfNotExist(context, saSection1, cpeOutcome1, Major.EE,
                PerformanceLevel.NotMeetsExpectations, 20);
            CreateOutcomeResultIfNotExist(context, saSection1, cpeOutcome1, Major.EE,
                PerformanceLevel.MeetsExpectations, 10);
            CreateOutcomeResultIfNotExist(context, saSection1, cpeOutcome1, Major.EE,
                PerformanceLevel.ExceedsExpectations, 60);
            CreateOutcomeResultIfNotExist(context, saSection1, eeOutcome2, Major.EE,
                PerformanceLevel.NotMeetsExpectations, 25);
            CreateOutcomeResultIfNotExist(context, saSection1, eeOutcome2, Major.EE,
                PerformanceLevel.MeetsExpectations, 55);
            CreateOutcomeResultIfNotExist(context, saSection1, eeOutcome2, Major.EE,
                PerformanceLevel.ExceedsExpectations, 10);

            // Outcome Results for John Adam's First Section
            CreateOutcomeResultIfNotExist(context, jaSection1, csOutcome1, Major.CS,
                PerformanceLevel.NotMeetsExpectations, 10);
            CreateOutcomeResultIfNotExist(context, jaSection1, csOutcome1, Major.CS,
                PerformanceLevel.MeetsExpectations, 40);
            CreateOutcomeResultIfNotExist(context, jaSection1, csOutcome1, Major.CS,
                PerformanceLevel.ExceedsExpectations, 80);

            // ** START Seed CourseOutcomeMapping **//
            CreateCourseOutcomeMappingIfNotExist(context, algorithmAnalysis, csOutcome6, Major.CS, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, algorithmAnalysis, csOutcome6, Major.CS, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, algorithmAnalysis, csOutcome6, Major.CS, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, algorithmAnalysis, csOutcome6, Major.CS, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, algorithmAnalysis, csOutcome6, Major.CS, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, algorithmAnalysis, csOutcome6, Major.CS, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, algorithmAnalysis, csOutcome6, Major.CS, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome2, Major.CS, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome2, Major.CS, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome2, Major.CS, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome2, Major.CS, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome2, Major.CS, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome2, Major.CS, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome2, Major.CS, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome3, Major.CS, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome3, Major.CS, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome3, Major.CS, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome3, Major.CS, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome3, Major.CS, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome3, Major.CS, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome3, Major.CS, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome5, Major.CS, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome5, Major.CS, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome5, Major.CS, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome5, Major.CS, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome5, Major.CS, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome5, Major.CS, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome5, Major.CS, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome6, Major.CS, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome6, Major.CS, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome6, Major.CS, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome6, Major.CS, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome6, Major.CS, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome6, Major.CS, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, softwareEngineering, csOutcome6, Major.CS, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, systemsProgramming, csOutcome1, Major.CS, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, systemsProgramming, csOutcome1, Major.CS, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, systemsProgramming, csOutcome1, Major.CS, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, systemsProgramming, csOutcome1, Major.CS, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, systemsProgramming, csOutcome1, Major.CS, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, systemsProgramming, csOutcome1, Major.CS, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, systemsProgramming, csOutcome1, Major.CS, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, programmingLanguages, csOutcome1, Major.CS, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, programmingLanguages, csOutcome1, Major.CS, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, programmingLanguages, csOutcome1, Major.CS, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, programmingLanguages, csOutcome1, Major.CS, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, programmingLanguages, csOutcome1, Major.CS, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, programmingLanguages, csOutcome1, Major.CS, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, programmingLanguages, csOutcome1, Major.CS, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, csJuniorSeminar, csOutcome4, Major.CS, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, csJuniorSeminar, csOutcome4, Major.CS, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, csJuniorSeminar, csOutcome4, Major.CS, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, csJuniorSeminar, csOutcome4, Major.CS, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, csJuniorSeminar, csOutcome4, Major.CS, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, csJuniorSeminar, csOutcome4, Major.CS, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, csJuniorSeminar, csOutcome4, Major.CS, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome2, Major.CS, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome2, Major.CS, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome2, Major.CS, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome2, Major.CS, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome2, Major.CS, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome2, Major.CS, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome2, Major.CS, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome3, Major.CS, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome3, Major.CS, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome3, Major.CS, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome3, Major.CS, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome3, Major.CS, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome3, Major.CS, Semester.Fall, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome3, Major.CS, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome4, Major.CS, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome4, Major.CS, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome4, Major.CS, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome4, Major.CS, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome4, Major.CS, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome4, Major.CS, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome4, Major.CS, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome5, Major.CS, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome5, Major.CS, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome5, Major.CS, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome5, Major.CS, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome5, Major.CS, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome5, Major.CS, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, csDesignPracticum, csOutcome5, Major.CS, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, introLogicDesign, cpeOutcome6, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, introLogicDesign, cpeOutcome6, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, introLogicDesign, cpeOutcome6, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, introLogicDesign, cpeOutcome6, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, introLogicDesign, cpeOutcome6, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, introLogicDesign, cpeOutcome6, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, introLogicDesign, cpeOutcome6, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, cpeOutcome1, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, cpeOutcome1, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, cpeOutcome1, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, cpeOutcome1, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, cpeOutcome1, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, cpeOutcome1, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, cpeOutcome1, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, cpeOutcome6, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, cpeOutcome6, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, cpeOutcome6, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, cpeOutcome6, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, cpeOutcome6, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, cpeOutcome6, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, cpeOutcome6, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, cpeOutcome1, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, cpeOutcome1, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, cpeOutcome1, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, cpeOutcome1, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, cpeOutcome1, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, cpeOutcome1, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, cpeOutcome1, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, cpeOutcome3, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, cpeOutcome3, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, cpeOutcome3, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, cpeOutcome3, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, cpeOutcome3, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, cpeOutcome3, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, cpeOutcome3, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome1, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome1, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome1, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome1, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome1, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome1, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome1, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome2, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome2, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome2, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome2, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome2, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome2, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome2, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome6, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome6, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome6, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome6, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome6, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome6, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, cpeOutcome6, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, cpeOutcome1, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, cpeOutcome1, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, cpeOutcome1, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, cpeOutcome1, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, cpeOutcome1, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, cpeOutcome1, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, cpeOutcome1, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, cpeOutcome3, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, cpeOutcome3, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, cpeOutcome3, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, cpeOutcome3, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, cpeOutcome3, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, cpeOutcome3, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, cpeOutcome3, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome1, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome1, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome1, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome1, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome1, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome1, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome1, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome2, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome2, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome2, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome2, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome2, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome2, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome2, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome5, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome5, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome5, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome5, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome5, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome5, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome5, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome6, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome6, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome6, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome6, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome6, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome6, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, digitalSystemsDesign, cpeOutcome6, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome1, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome1, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome1, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome1, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome1, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome1, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome1, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome4, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome4, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome4, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome4, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome4, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome4, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome4, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome7, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome7, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome7, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome7, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome7, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome7, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, cpeOutcome7, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome2, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome2, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome2, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome2, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome2, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome2, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome2, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome3, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome3, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome3, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome3, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome3, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome3, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome3, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome4, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome4, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome4, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome4, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome4, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome4, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome4, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome5, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome5, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome5, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome5, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome5, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome5, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome5, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome7, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome7, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome7, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome7, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome7, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome7, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, cpeOutcome7, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, systemsProgramming, cpeOutcome1, Major.CpE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, systemsProgramming, cpeOutcome1, Major.CpE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, systemsProgramming, cpeOutcome1, Major.CpE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, systemsProgramming, cpeOutcome1, Major.CpE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, systemsProgramming, cpeOutcome1, Major.CpE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, systemsProgramming, cpeOutcome1, Major.CpE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, systemsProgramming, cpeOutcome1, Major.CpE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, introLogicDesign, eeOutcome2, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, introLogicDesign, eeOutcome2, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, introLogicDesign, eeOutcome2, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, introLogicDesign, eeOutcome2, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, introLogicDesign, eeOutcome2, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, introLogicDesign, eeOutcome2, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, introLogicDesign, eeOutcome2, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, eeOutcome1, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, eeOutcome1, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, eeOutcome1, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, eeOutcome1, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, eeOutcome1, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, eeOutcome1, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, eeOutcome1, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, eeOutcome6, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, eeOutcome6, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, eeOutcome6, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, eeOutcome6, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, eeOutcome6, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, eeOutcome6, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, computerInterfaces, eeOutcome6, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, eeOutcome1, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, eeOutcome1, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, eeOutcome1, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, eeOutcome1, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, eeOutcome1, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, eeOutcome1, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, eeOutcome1, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, eeOutcome3, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, eeOutcome3, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, eeOutcome3, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, eeOutcome3, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, eeOutcome3, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, eeOutcome3, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, signalsAndSystems, eeOutcome3, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome2, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome2, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome2, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome2, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome2, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome2, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome2, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome5, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome5, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome5, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome5, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome5, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome5, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome5, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome6, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome6, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome6, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome6, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome6, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome6, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, electricEnergy, eeOutcome6, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome1, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome1, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome1, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome1, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome1, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome1, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome1, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome2, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome2, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome2, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome2, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome2, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome2, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome2, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome6, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome6, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome6, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome6, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome6, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome6, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, electronicDevices, eeOutcome6, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, eeOutcome1, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, eeOutcome1, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, eeOutcome1, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, eeOutcome1, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, eeOutcome1, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, eeOutcome1, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, eeOutcome1, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, eeOutcome3, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, eeOutcome3, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, eeOutcome3, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, eeOutcome3, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, eeOutcome3, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, eeOutcome3, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, fundamentalsCommunications, eeOutcome3, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, eeOutcome4, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, eeOutcome4, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, eeOutcome4, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, eeOutcome4, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, eeOutcome4, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, eeOutcome4, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, eeOutcome4, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, eeOutcome7, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, eeOutcome7, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, eeOutcome7, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, eeOutcome7, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, eeOutcome7, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, eeOutcome7, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceJuniorSeminar, eeOutcome7, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome2, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome2, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome2, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome2, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome2, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome2, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome2, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome3, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome3, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome3, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome3, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome3, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome3, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome3, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome4, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome4, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome4, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome4, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome4, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome4, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome4, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome5, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome5, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome5, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome5, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome5, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome5, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome5, Major.EE, Semester.Spring, 2021);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome7, Major.EE, Semester.Spring, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome7, Major.EE, Semester.Fall, 2018);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome7, Major.EE, Semester.Spring, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome7, Major.EE, Semester.Fall, 2019);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome7, Major.EE, Semester.Spring, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome7, Major.EE, Semester.Fall, 2020);
            CreateCourseOutcomeMappingIfNotExist(context, eceDesignPracticum, eeOutcome7, Major.EE, Semester.Spring, 2021);
            // ** END   Seed CourseOutcomeMapping **//

            CreateAssessmentIfNotExist(context, gwSection2, csOutcome1, Major.CS, "Homeworks 1, 3 and 10", 20);
            CreateAssessmentIfNotExist(context, gwSection2, csOutcome1, Major.CS, "Midterm questions on functional languages", 80);
            CreateAssessmentIfNotExist(context, gwSection3, csOutcome2, Major.CS, "Homeworks 1, 2, and 3", 15);
            CreateAssessmentIfNotExist(context, gwSection3, csOutcome2, Major.CS, "Exam #1", 10);
            CreateAssessmentIfNotExist(context, gwSection3, csOutcome2, Major.CS, "Labs 1 and 6", 60);
            CreateAssessmentIfNotExist(context, gwSection3, csOutcome2, Major.CS, "Project", 15);
            CreateAssessmentIfNotExist(context, gwSection4, csOutcome1, Major.CS, "Finals", 30);
            CreateAssessmentIfNotExist(context, gwSection4, csOutcome1, Major.CS, "Midterm 1 question", 10);
            CreateAssessmentIfNotExist(context, bfSection1, csOutcome1, Major.CS, "Homework assignments 1 - 6", 10);
            CreateAssessmentIfNotExist(context, bfSection1, csOutcome1, Major.CS, "Midterm 1", 30);
            CreateAssessmentIfNotExist(context, bfSection2, cpeOutcome2, Major.CpE, "Final design document", 70);
            CreateAssessmentIfNotExist(context, bfSection2, cpeOutcome2, Major.CpE, "Initial design document", 30);
            CreateAssessmentIfNotExist(context, bfSection2, cpeOutcome1, Major.CpE, "Project Description", 50);
            CreateAssessmentIfNotExist(context, bfSection2, cpeOutcome2, Major.CpE, "Project Implementation", 50);
            CreateAssessmentIfNotExist(context, bfSection3, eeOutcome2, Major.EE, "Design of a circuit", 100);
            CreateAssessmentIfNotExist(context, bfSection3, eeOutcome1, Major.EE, "midterm1", 20);
            CreateAssessmentIfNotExist(context, bfSection3, eeOutcome1, Major.EE, "midterm3", 20);
            CreateAssessmentIfNotExist(context, bfSection3, eeOutcome1, Major.EE, "midterm4", 30);
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

    public static Section CreateSectionIfNotExist(AbetMvcDbContext dbContext,
            Instructor instructor, Course course, Semester semester, int year)
    {
        IEnumerable<Section> sectionQuery = dbContext.Sections.Where(
                s => ( (s.Instructor == instructor) &&
                (s.Course == course) && (s.Semester == semester)) );

        if (sectionQuery.Any())
        {
            return sectionQuery.First();
        }

        Section section = new Section{Instructor=instructor,Course=course,Semester=semester,Year=year};
        dbContext.Sections.Add(section);
        dbContext.SaveChanges();

        return section;
    }

    public static Outcome CreateOutcomeIfNotExist(AbetMvcDbContext dbContext,
            int outcomeNumber, Major outcomeMajor, string outcomeDescription)
    {
        IEnumerable<Outcome> outcomeQuery =  dbContext.Outcomes.Where(
            o => ( ( o.Number == outcomeNumber)
            && ( o.Major == outcomeMajor ) ) );

        if (outcomeQuery.Any())
        {
            return outcomeQuery.First();
        }

        Outcome outcome = new Outcome{Number=outcomeNumber,Major=outcomeMajor,Description=outcomeDescription};
        dbContext.Outcomes.Add(outcome);
        dbContext.SaveChanges();

        return outcome;
    }

    public static void CreateOutcomeResultIfNotExist(AbetMvcDbContext dbContext, Section section,
            Outcome outcome, Major major, PerformanceLevel performanceLevel, short numberOfStudents)
    {
        if (dbContext.OutcomeResults.Where( or => ( ( or.SectionId == section.Id &&
                or.OutcomeId == outcome.Id && or.Major == major &&
                or.PerformanceLevel == performanceLevel && or.NumberOfStudents == numberOfStudents))).Any())
        {
            return;
        }

        OutcomeResult outcomeResult = new OutcomeResult{Section=section,Outcome=outcome,
                Major=major,PerformanceLevel=performanceLevel,
                NumberOfStudents=numberOfStudents};
        dbContext.OutcomeResults.Add(outcomeResult);
        dbContext.SaveChanges();
    }

    public static void CreateCourseOutcomeMappingIfNotExist(AbetMvcDbContext dbContext,
        Course course, Outcome outcome, Major major, Semester semester, int year)
    {
        if (dbContext.CourseOutcomeMappings.Where( com => ( ( com.Course.Id == course.Id &&
            com.Outcome.Id == outcome.Id && com.Major == major && com.Semester == semester &&
            com.Year == year))).Any())
        {
            return;
        }

        CourseOutcomeMapping com = new CourseOutcomeMapping{
            Course=course,Outcome=outcome,Major=major,Semester=semester,Year=year
        };

        dbContext.CourseOutcomeMappings.Add(com);
        dbContext.SaveChanges();
    }

    public static void CreateAssessmentIfNotExist(AbetMvcDbContext dbContext, Section section, Outcome outcome,
        Major major, string description, int weight)
    {
        if (dbContext.Assessments.Where( a => ( ( a.Section.Id == section.Id &&
            a.Outcome.Id == outcome.Id && a.Major == major && a.Description == description ))).Any())
        {
                return;
        }

        Assessment assessment = new Assessment{
            Section=section,Outcome=outcome,Major=major,Description=description,Weight=weight
        };

        dbContext.Assessments.Add(assessment);
        dbContext.SaveChanges();
    }
}