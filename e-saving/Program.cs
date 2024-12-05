using Microsoft.EntityFrameworkCore;
using e_saving.Models;

var builder = WebApplication.CreateBuilder(args);

// adciona o serviço de contexto do nosso db
builder.Services.AddDbContext<Contexto>(opcoes=>opcoes.UseSqlite(builder.Configuration.GetConnectionString("ConexaoSQLite")));
// Add services to the container.
builder.Services.AddControllersWithViews();

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
