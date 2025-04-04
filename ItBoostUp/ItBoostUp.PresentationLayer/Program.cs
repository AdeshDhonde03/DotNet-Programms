using ItBoostUp.BuisnessLayer.Interface;
using ItBoostUp.DataAccessLayer.Repository;
using ItBoostUp.PresentationLayer.Filters;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

//Global level filter registration
builder.Services.AddControllersWithViews( options =>
{
    //1st way to add filter
    //options.Filters.Add(new CustomActionFilter());
    //2nd / standard way to add filter
    //options.Filters.Add<CustomExceptionFilter>();
    //options.Filters.Add<CustomResultFilter>();
    //options.Filters.Add<CustomActionFilter>();
});


builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<CustomActionFilter>();
builder.Services.AddScoped<CustomExceptionFilter>();
builder.Services.AddScoped<CustomResultFilter>();
builder.Services.AddScoped<CustomAuthorizationFilter>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
