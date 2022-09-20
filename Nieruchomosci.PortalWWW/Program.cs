using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Nieruchomosci.Data.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<NieruchomosciContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("NieruchomosciContext") ?? throw new InvalidOperationException("Connection string 'NieruchomosciContext' not found.")));


// Add services to the container.
builder.Services.AddControllersWithViews();
//START
builder.Services.AddSession(options =>
{
    // Set a short timeout for easy testing.
    options.IdleTimeout = TimeSpan.FromSeconds(40);
    options.Cookie.HttpOnly = true;
    // Make the session cookie essential
    options.Cookie.IsEssential = true;
});
//STOP

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

//START
app.UseSession();
//STOP

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
