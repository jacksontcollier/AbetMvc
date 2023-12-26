using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AbetMvc.Data;
using AbetMvc.Areas.Identity.Data;
using AbetMvc.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AbetMvcIdentityDbContextConnection") ?? throw new InvalidOperationException("Connection string 'AbetMvcIdentityDbContextConnection' not found.");

builder.Services.AddDbContext<AbetMvcDbContext>(options => options.UseSqlite(connectionString));

builder.Services.AddDefaultIdentity<Instructor>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<AbetMvcDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        SeedData.Initialize(services);
    }
}
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
