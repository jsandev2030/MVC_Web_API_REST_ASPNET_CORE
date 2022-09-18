using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCWatches.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MVCWatchesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MVCWatchesContext") ?? throw new InvalidOperationException("Connection string 'MVCWatchesContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Watches/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Watches}/{action=Index}/{id?}");

app.Run();
