using Microsoft.EntityFrameworkCore;
using TimelyApp.Facade;
using TimelyApp.Facade.impl;
using TimelyApp.Repository;
using TimelyApp.Service;
using TimelyApp.Service.impl;
using TimelyApp.Mapper;
using TimelyApp.Mapper.impl;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProjectDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("TimelyDbContext")));
builder.Services.AddScoped<IProjectFacade, ProjectFacade>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IProjectDtoMapper, ProjectDtoMapper>();
builder.Services.AddScoped<IProjectFormMapper, ProjectFormMapper>();
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
