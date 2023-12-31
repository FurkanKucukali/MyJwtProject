using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MyJwtProject.Core.Application.Interfaces;
using MyJwtProject.Core.Application.Mappings;
using MyJwtProject.Persistance.Context;
using MyJwtProject.Persistance.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<UdemyJwtContext>(opt =>
{
	opt.UseSqlServer(builder.Configuration.GetConnectionString("Local"));
});
builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(opt =>
{
	opt.AddProfiles(new List<Profile>() { 
		new ProductProfile(),
		new CategoryProfile()
	});
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
