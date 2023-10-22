using ICT_profile.Data;
using ICT_profile.Manegers;
using ICT_profile.Repos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//runtime view.
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
//sql connection
builder.Services.AddDbContext<ICTcontext>
    (options => options.UseSqlServer("Server=.; Database=ICTdb; Trusted_Connection=true; Encrypt=false;"));

builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IUserManeger, UserManeger>();

builder.Services.AddScoped<IEdueRepo, EdueRepo>();
builder.Services.AddScoped<IEdueManeger, EdueManeger>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
