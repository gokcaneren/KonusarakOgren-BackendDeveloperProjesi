using KonusarakOgren.Core.Models;
using KonusarakOgren.Core.Repositories;
using KonusarakOgren.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt => {
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));
});

builder.Services.AddIdentity<ApiUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();
// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddHttpClient("MyWebAPI", client =>
{
    client.BaseAddress = new Uri("https://localhost:44313/");
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
