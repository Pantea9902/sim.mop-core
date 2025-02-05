using sim.mop.Models;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.Extensions.Options;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSession(options =>
{
	options.IdleTimeout = TimeSpan.FromMinutes(30); // Set session timeout as needed  
	options.Cookie.HttpOnly = true; // Set to true for security  
	options.Cookie.IsEssential = true; // Required for session to work  
});
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddMvc();
builder.Services.AddSession();
builder.Services.AddMemoryCache();

builder.Services.AddDbContext<MopContext>(options =>

    options.UseSqlServer("Server=.;Database=Mop;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true"));

var app = builder.Build();

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
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
	  //pattern: "{controller=Home}/{action=Index}/{id?}");
	  pattern: "{controller=Users}/{action=Login}/{id?}");

app.Run();
