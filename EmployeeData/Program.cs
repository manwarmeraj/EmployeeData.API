using AutoMapper.Extensions.ExpressionMapping;
using Employee.Business.Business;
using Employee.Business.Contract;
using Employee.Entity.Models;
using Employee.Repository.Common;
using Employee.Repository.Contract;
using Employee.Repository.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration; //Added to get Configuration from appsettings.json

// Add services to the container.
builder.Services.AddScoped<DbContext, TestDbContext>();
builder.Services.AddScoped<IEmployeeBusiness, EmployeeBusiness>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//To use connectionString for Db connections (EF).
builder.Services.AddDbContext<TestDbContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("TestDbConnectionString"));
});

//To use Automapper.
builder.Services.AddAutoMapper(c =>
{
    c.AddExpressionMapping();
}, typeof(AutoMapperProfiles).Assembly);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
