using CountryStateManager.BussinessLayer.Interface;
using CountryStateManager.DataAccessLayer.Mappings;
using CountryStateManager.DataAccessLayer.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<IStateRepository, StateRepository>();
builder.Services.AddAutoMapper(typeof(CountryProfile));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
