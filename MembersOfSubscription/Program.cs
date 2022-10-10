using MembersOfSubscription.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContextM>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("MConnection")));
builder.Services.AddDbContext<ApplicationDbContextF>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("FConnection")));
builder.Services.AddDbContext<ApplicationDbContextO>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("OConnection")));

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
