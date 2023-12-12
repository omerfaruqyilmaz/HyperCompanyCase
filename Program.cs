using HyperCompanyCase.Business.Abstract.Command;
using HyperCompanyCase.Business.Abstract.Query;
using HyperCompanyCase.Business.Abstract.Service;
using HyperCompanyCase.Business.Concrete.Command;
using HyperCompanyCase.Business.Concrete.Query;
using HyperCompanyCase.Business.Concrete.Service;
using HyperCompanyCase.DataAccess.Concrete;
using HyperCompanyCase.DataAccess.SeedData;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<IBoatService, BoatService>();
builder.Services.AddScoped<IBusService, BusService>();
builder.Services.AddScoped<IColorService, ColorService>();
builder.Services.AddScoped<IDynamicCommandRepository, DynamicCommandRepository>();
builder.Services.AddScoped<IDynamicQuery, DynamicQuery>();


builder.Services.AddDbContext<ProjectDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["Database:ConnectionString"]);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

Seed.Init(app);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
