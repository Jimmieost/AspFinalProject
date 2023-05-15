using Microsoft.EntityFrameworkCore;
using AspFinalProject.Models.Contexts;
using Microsoft.AspNetCore.Identity;
using AspFinalProject.Models.Entities;
using AspFinalProject.Repositories;
using AspFinalProject.Services;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("SqlLocalDb")));

// Dependency Injection
builder.Services.AddTransient<ProductRepository>();

//Services
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<SignInManager<AccountEntity>>();

// Add and configure Identity
builder.Services.AddIdentity<AccountEntity, IdentityRole>(x =>
{
    x.SignIn.RequireConfirmedAccount = false;
    x.User.RequireUniqueEmail = true;
    x.Password.RequireUppercase = false;
    x.Password.RequireNonAlphanumeric = false;
    x.Password.RequireDigit = false;
    x.Password.RequiredLength = 6;
}).AddEntityFrameworkStores<AppDbContext>();







//Den här ska ligga sist i listan för att undvika error.
var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
