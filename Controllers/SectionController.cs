using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AbetMvc.Data;
using AbetMvc.Models;
using AbetMvc.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace AbetMvc.Controllers;

public class SectionController : Controller
{
    private readonly ILogger<SectionController> _logger;
    private readonly AbetMvcDbContext _dbContext;

    private readonly UserManager<Instructor> _instructorManager;

    public SectionController(ILogger<SectionController> logger, AbetMvcDbContext dbContext,
            UserManager<Instructor> instructorManager)
    {
        _logger = logger;
        _dbContext = dbContext;
        _instructorManager = instructorManager;
    }

    public async Task<IActionResult> Index()
    {
        var instructorId = _instructorManager.GetUserId(User);

        var sections = await _dbContext.Sections.Where(s => s.Instructor!.Id == instructorId)
                        .Include(s => s.Course).Include(s => s.Instructor).ToListAsync();

        List<SectionViewModel> sectionViews = new();

        foreach (var section in sections)
        {
            SectionViewModel viewModel = new(section);
            sectionViews.Add(viewModel);
        }

        return View(sectionViews);
    }
}